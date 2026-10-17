namespace BaobaRidge
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void btnGenerateSummary_Click(object sender, System.EventArgs e)
        {

            System.Windows.Forms.MessageBox.Show("Summary generation started.", "Generate Summary", 
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }


    }
}
