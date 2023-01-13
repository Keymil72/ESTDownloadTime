using ESTDownloadTime.logic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ESTDownloadTime
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal speed = Speed.Value;
            int speedUnti = SpeedUnit.SelectedIndex;
            decimal toDownload = Size.Value;
            int downloadUnit = DownloadUnit.SelectedIndex;
            App app = new App();
            Time.Text = app.init(speed, speedUnti, toDownload, downloadUnit);

        }



    }
}