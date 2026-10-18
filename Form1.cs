namespace BaobaRidge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // loads animals from file and displays in a grid
        public void RefreshGrid(bool showSkippedMessage = false)
        {

            List<Animal> animals;
            int skippedCount;

            try
            {
                animals = FileHandler.LoadAnimals(out skippedCount);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "Access denied. Unable to read the animal.txt.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "Unable to read the animal.txt. See if the file is accessible.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;

            //header text so grid doesn't show property names
            dgvAnimals.Columns["Id"]!.HeaderText = "Animal ID";
            dgvAnimals.Columns["Name"]!.HeaderText = "Name";
            dgvAnimals.Columns["Species"]!.HeaderText = "Species";
            dgvAnimals.Columns["Age"]!.HeaderText = "Age";
            dgvAnimals.Columns["Score"]!.HeaderText = "Recovery Score";
            dgvAnimals.Columns["Status"]!.HeaderText = "Status";
            dgvAnimals.Columns["HousingUnit"]!.HeaderText = "Housing Unit";

            // show a message if and when line are skipped
            if (showSkippedMessage && skippedCount > 0)
            {
                MessageBox.Show($"{skippedCount} lines were skipped and cannot be loaded");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            // gets the animal ID entered and removes spaces
            string searchId = txtAnimalId.Text.Trim().ToUpper();

            // checks if the user actually entered an ID
            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter an Animal ID.");
                txtAnimalId.Focus();
                return;
            }


            // checks if the animal ID has the correct format
            int animalNumber;

            if (!searchId.StartsWith("WR-") ||
                searchId.Length != 7 ||
                !int.TryParse(searchId.Substring(3), out animalNumber))
            {
                MessageBox.Show("Animal ID must be in the format WR-0001.");
                return;
            }


            try
            {
                // gets the animals that are saved in the text file
                int skippedCount;
                List<Animal> animals = FileHandler.LoadAnimals(out skippedCount);

                // starts with no animal found
                Animal? foundAnimal = null;

                // goes through the animals to find the matching ID
                foreach (Animal animal in animals)
                {
                    if (animal.Id == searchId)
                    {
                        foundAnimal = animal;
                        break; // stops the loop because we found the animal
                    }
                }

                // if no animal matches the ID, show a message
                if (foundAnimal == null)
                {
                    MessageBox.Show("Animal not found.");

                    txtName.Clear();
                    txtSpecies.Clear();
                    txtAge.Clear();
                    txtScore.Clear();

                    return;
                }

                // puts the animal's information into the textboxes
                txtAnimalId.Text = foundAnimal.Id;
                txtName.Text = foundAnimal.Name;
                txtSpecies.Text = foundAnimal.Species;
                txtAge.Text = foundAnimal.Age.ToString();
                txtScore.Text = foundAnimal.Score.ToString();

                MessageBox.Show("Animal found successfully!");
            }
            catch (IOException)
            {
                // shows an error if the file cannot be read
                MessageBox.Show("Unable to read the animals file.");
            }
            catch (UnauthorizedAccessException)
            {
                // shows an error if the program cannot access the file
                MessageBox.Show("Access denied to the animals file.");
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.ShowDialog();
        }
    }
}
