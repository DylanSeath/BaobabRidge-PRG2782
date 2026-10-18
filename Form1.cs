namespace BaobaRidge
{
    public partial class Form1 : Form
    {
        private AnimalRepo repository;
        public Form1()
        {
            InitializeComponent();
            repository = new AnimalRepo();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string id = txtAnimalId.Text.Trim().ToUpper();
            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();
            string rawAge = txtAge.Text.Trim();
            string rawScore = txtScore.Text.Trim();

            //Character Validation
            if (id.Length != 7 || !id.StartsWith("WR-"))
            {
                MessageBox.Show("Animal ID must be in the format WR- followed by 4 digits.", " ID Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnimalId.Focus();
                return;
            }

            
            string digitsPart = id.Substring(3); 
            if (!int.TryParse(digitsPart, out _))
            {
                MessageBox.Show("The characters after 'WR-' must be numbers.", " ID Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnimalId.Focus();
                return;
            }

            
            if (!repository.UniqueID(id))
            {
                MessageBox.Show("This Animal ID already exists!", "ID validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnimalId.Focus();
                return;
            }

       
            if (string.IsNullOrWhiteSpace(name) || name.Length > 30 || name.Contains("|"))
            {
                MessageBox.Show("Name is required, cannot exceed 30 characters, and cannot contain the '|' character.", "Name Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

           
            if (string.IsNullOrWhiteSpace(species) || species.Length > 30 || species.Contains("|"))
            {
                MessageBox.Show("Species is required, cannot exceed 30 characters, and cannot contain the '|' character.", "Species Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpecies.Focus();
                return;
            }

            
            if (!int.TryParse(rawAge, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Age must be a whole number between 0 and 100.", "Age Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

           
            if (!int.TryParse(rawScore, out int recoveryScore) || recoveryScore < 0 || recoveryScore > 100)
            {
                MessageBox.Show("Recovery Score must be a whole number between 0 and 100.", "Recovery Score Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtScore.Focus();
                return;
            }

            try
            {
              
                var classification = AnimalStatus.GetClassification(recoveryScore);
                string status = classification.Status;
                string housingUnit = classification.HousingUnit;

               
                string newLine = $"{id}|{name}|{species}|{age}|{recoveryScore}|{status}|{housingUnit}";
                repository.AddAnimalRecord(newLine);

                
                MessageBox.Show($"Animal added successfully!\nStatus: {status}\nHousing Unit: {housingUnit}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                txtAnimalId.Clear();
                txtName.Clear();
                txtSpecies.Clear();
                txtAge.Clear();
                txtScore.Clear();
                txtAnimalId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            //  Add update logic
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //  Add delete logic
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            //  Open summary form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Form load logic if needed
        }
    }
}
