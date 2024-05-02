using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxkPa.Enabled = true;
            textBoxBar.Enabled = true;
            textBoxPsi.Enabled = true;
            buttonClear.Enabled = false;
            buttonCalculate.Enabled = false;    

            // Put the cursor into invisible field
            textBoxStart.Focus();
        }

        // A variable to store field used as input
        public string activeField = "";
        
        // Method for Laske button
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (activeField == "kPa")
            {
                double numerickPa = Convert.ToDouble(textBoxkPa.Text);
                double numericBar = numerickPa * 0.01d;
                double numericPsi = numerickPa * 0.145d;
                textBoxBar.Text = numericBar.ToString();
                textBoxPsi .Text = numericPsi.ToString();
            }

            if (activeField == "Bar")
            {
                double numericBar = Convert.ToDouble(textBoxBar.Text);
                double numericPsi = numericBar * 14.5d;
                double numerickPa = numericBar * 100;
                textBoxPsi.Text = numericPsi.ToString();
                textBoxkPa.Text = numericBar.ToString();
            }

            else
            {
                double numericPsi = Convert.ToDouble(textBoxPsi.Text);
                double numericBar = numericPsi / 14.5d;
                double numerickPa = numericPsi / 0.145;
                textBoxBar.Text = numericBar.ToString();
                textBoxkPa.Text = numerickPa.ToString();
              
            }

            buttonCalculate.Enabled = false;

        }

        // When user enters kPa field
        private void textBoxkPa_Enter(object sender, EventArgs e)
        {
            // Disable other fields
            textBoxBar.Enabled = false;
            textBoxPsi.Enabled = false;
            buttonClear.Enabled = true;
            activeField = "kPa";

        }

        // When user exits kPa field
        private void textBoxkPa_Leave(object sender, EventArgs e)
        {
            
            // Check if Bar value is non zero number
            double kPa;
            bool sanitykPa = double.TryParse(textBoxkPa.Text, out kPa);

            // Handle the error using messagebox
            if (kPa == 0)
            {
                string header = "Väärä paine";
                string message = "Paine kentässä kPa on virheellinen. Arvo pitää olla nollaa suurempi numero. Sallittuja merkkejä ovat numerot ja desimaalipilkku";
                DialogResult kpaError;
                kpaError = MessageBox.Show(header, message, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            else
            {
                buttonCalculate.Enabled = true;
                buttonCalculate.Focus();
            }
        }

        // When user enters kPa field
        private void textBoxBar_Enter(object sender, EventArgs e)
        {
            // Disable other fields
            textBoxkPa.Enabled = false;
            textBoxPsi.Enabled = false;
            buttonClear.Enabled = true;
            activeField = "Bar";

        }

        // When user exits kPa field
        private void textBoxBar_Leave(object sender, EventArgs e)
        {

            // Check if Bar value is non zero number
            double Bar;
            bool sanitykPa = double.TryParse(textBoxkPa.Text, out Bar);

            // Handle the error using messagebox
            if (Bar == 0)
            {
                string header = "Väärä paine";
                string message = "Paine kentässä Bar on virheellinen. Arvo pitää olla nollaa suurempi numero. Sallittuja merkkejä ovat numerot ja desimaalipilkku";
                DialogResult kpaError;
                kpaError = MessageBox.Show(header, message, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            else
            {
                buttonCalculate.Enabled = true;
                buttonCalculate.Focus();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Empty all fields
            textBoxkPa.Text = string.Empty;
            textBoxBar.Text= string.Empty;
            textBoxPsi.Text = string.Empty;

            // Activate all fields
            textBoxkPa.Enabled = true;
            textBoxBar.Enabled = true;
            textBoxPsi.Enabled = true;

            // Hide both buttons
            buttonCalculate.Enabled = false;
            buttonClear.Enabled = false;

            // Move cursot to zero field
            textBoxStart.Focus();
        }
    }
}
