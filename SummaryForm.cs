using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace BaobaRidge
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        //This method generates the summary report and also does calculations, updates the form and writes the report to a text file.
        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {

            //Load animal records from filehandler
            int skippedCount;
            List<Animal> animals = FileHandler.LoadAnimals(out skippedCount);


            //Extract the ages and recovery scores from the loaded animals

            int[] animalAges = animals.Select(a => a.Age).ToArray();
            int[] recoveryScores = animals.Select(a => a.Score).ToArray();


            int totalAnimals = animalAges.Length;

            double averageAge = totalAnimals > 0 ? animalAges.Average() : 0;
            double averageRecoveryScore = totalAnimals > 0 ? recoveryScores.Average() : 0;


            int criticalCount = recoveryScores.Count(s => s < 20);
            int seriousCount = recoveryScores.Count(s => s >= 20 && s <= 39);
            int stableCount = recoveryScores.Count(s => s >= 40 && s <= 59);
            int recoveringCount = recoveryScores.Count(s => s >= 60 && s <= 79);
            int releaseReadyCount = recoveryScores.Count(s => s >= 80 && s <= 100);


            lblCriticalValue.Text = criticalCount.ToString();
            lblSeriousValue.Text = seriousCount.ToString();
            lblStableValue.Text = stableCount.ToString();
            lblRecoveringValue.Text = recoveringCount.ToString();
            lblReleaseReadyValue.Text = releaseReadyCount.ToString();

            lblAverageAgeValue.Text = totalAnimals > 0 ? averageAge.ToString("F2", CultureInfo.InvariantCulture) : "N/A";
            lblTotalAnimalsValue.Text = totalAnimals.ToString();
            lblAverageScoreValue.Text = totalAnimals > 0 ? averageRecoveryScore.ToString("F2", CultureInfo.InvariantCulture) : "N/A";


            string generatedDate = DateTime.Now.ToString("yyy-MM-dd HH:mm");
            string formattedAge = totalAnimals > 0 ? averageAge.ToString("F2", CultureInfo.InvariantCulture) : "N/A";
            string formattedScore = totalAnimals > 0 ? averageRecoveryScore.ToString("F2", CultureInfo.InvariantCulture) : "N/A";

            string report =
                    "BOABA RIDGE WILDLIFE REHABILITATION CENTRE\n" +
                    "ANIMAL SUMMARY REPORT\n" +
                    $"Generated: {generatedDate}\n" +
                    "----------------------------------------\n" +
                    $"Total animals:           {totalAnimals}\n" +
                    $"Average age(years):      {formattedAge}\n" +
                    $"Average recovery score:  {formattedScore}\n" +
                    "----------------------------------------\n" +
                    "Animals per status: \n" +
                    $"Critical:                {criticalCount}\n" +
                    $"Serious:                 {seriousCount}\n" +
                    $"Stable:                  {stableCount}\n" +
                    $"Recovering:              {recoveringCount}\n" +
                    $"Release-Ready:           {releaseReadyCount}";

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "summary.txt");

            try
            {
                File.WriteAllText(filePath, report);

                MessageBox.Show(
                    "Summary report saved succesfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "Access denied. Cannot save the summary report.");
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to save the report. File may be in use.");
            }



        }
    }
}
