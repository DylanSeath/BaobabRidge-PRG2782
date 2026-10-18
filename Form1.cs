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
            //  Add search logic
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
