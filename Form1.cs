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
            var animals = FileHandler.LoadAnimals(out int skippedCount);

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
    }
}
