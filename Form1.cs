namespace PressureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string pressureKpa = textBoxkPa.Text;
            double kiloPascals = Convert.ToDouble(pressureKpa);
            double bars = Math.Round(kiloPascals * 0.01d, 1);
            double psi = Math.Round(kiloPascals * 0.145d, 1);
            textBoxBar.Text = Convert.ToString(bars);
            textBoxPsi.Text = Convert.ToString(psi);
        }

        private void textBoxkPa_Leave(object sender, EventArgs e)
        {
            // Check if textBoxkPa contains numeric value
            double kpa;
            bool numericValue = double.TryParse(textBoxkPa.Text, out kpa);
            if (kpa <= 10)
            {
                string message = "Virheellinen painetieto, paine pitää olla yli 10 kPa, anna pelkkiä numeroita. Käytä tarvittaessa desimaalipilkkua (,)";
                string header = "Väärä paine";
                DialogResult kpaErrorMsg;
                kpaErrorMsg = MessageBox.Show(message, header, MessageBoxButtons.RetryCancel);

                // Change button state to disabled
                buttonCalculate.Enabled = false;

            }
            else
            {
                // Change button state to enabled
                buttonCalculate.Enabled = true;
                buttonCalculate.Focus();
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxkPa.Text = string.Empty;
            textBoxkPa.Focus();
            textBoxBar.Text = string.Empty;
            textBoxPsi.Text = string.Empty;
            buttonCalculate.Enabled = false;
        }

        
    }
}
