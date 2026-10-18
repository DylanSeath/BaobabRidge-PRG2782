namespace BaobaRidge
{
    public partial class Form1 : Form
    {
        private AnimalRepo repository;
        public Form1()
        {
            InitializeComponent();
            repository = new AnimalRepo();

            // show all saved animals when the form opens
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            // get the animals saved in the text file
            int skippedCount;
            List<Animal> animals = FileHandler.LoadAnimals(out skippedCount);

            // clear the grid before loading the animals again
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;
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


            // get the information from the textboxes
            string id = txtAnimalId.Text.Trim().ToUpper();
            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();

            // check that all the fields have information
            if (id == "" || name == "" || species == "" ||
                txtAge.Text.Trim() == "" || txtScore.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // check if the animal ID is in the correct format
            if (id.Length != 7 || !id.StartsWith("WR-"))
            {
                MessageBox.Show("Animal ID must be WR- followed by 4 numbers.");
                return;
            }

            // make sure the last 4 characters are numbers
            if (!int.TryParse(id.Substring(3), out int idNumber))
            {
                MessageBox.Show("Animal ID must contain 4 numbers.");
                return;
            }

            // check if the age is a valid number
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (age < 0 || age > 100)
            {
                MessageBox.Show("Age must be between 0 and 100.");
                return;
            }

            // check if the recovery score is a valid number
            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid recovery score.");
                return;
            }

            if (score < 0 || score > 100)
            {
                MessageBox.Show("Recovery score must be between 0 and 100.");
                return;
            }

            // calculate the status and housing unit using the score
            var classification = AnimalStatus.GetClassification(score);

            // put the updated information into an animal object
            Animal updatedAnimal = new Animal
            {
                Id = id,
                Name = name,
                Species = species,
                Age = age,
                Score = score,
                Status = classification.Status,
                HousingUnit = classification.HousingUnit
            };

            // ask the user before saving changes
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to update this animal?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            try
            {
                // send the animal to the repository to update the file
                bool updated = repository.UpdateAnimal(updatedAnimal);

                if (updated)
                {
                    MessageBox.Show("Animal updated successfully!");

                    // show the latest information in the grid
                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Animal not found. No changes were saved.");
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to update the animals file.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied. Unable to save changes.");
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {



            // get the animal ID from the textbox
            string animalId = txtAnimalId.Text.Trim().ToUpper();

            // check if the user entered an ID
            if (animalId == "")
            {
                MessageBox.Show("Please enter an Animal ID to delete.");
                return;
            }

            // check if the ID is in the correct format
            int animalNumber;

            if (!animalId.StartsWith("WR-") ||
                animalId.Length != 7 ||
                !int.TryParse(animalId.Substring(3), out animalNumber))
            {
                MessageBox.Show("Animal ID must be in the format WR-0001.");
                return;
            }

            // ask the user to confirm before deleting
            if (MessageBox.Show("Are you sure you want to delete this animal?",
                "Delete Animal", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                // delete the animal using its ID
                bool deleted = repository.DeleteAnimal(animalId);

                if (deleted)
                {
                    MessageBox.Show("Animal deleted successfully!");

                    // clear all the textboxes
                    txtAnimalId.Clear();
                    txtName.Clear();
                    txtSpecies.Clear();
                    txtAge.Clear();
                    txtScore.Clear();

                    // update the grid to show the remaining animals
                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Animal not found.");
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to delete the animal from the file.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied. Unable to delete the animal.");
            }
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
