using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Most current version November 2019

*/
namespace RMCalculator
{
    public partial class frmMax : Form
    {
        public frmMax()
        {
            InitializeComponent();
        }

        DateTime currentDateTime = DateTime.Now;
        private void frmMax_Load(object sender, EventArgs e)
        {
            //Movement checkbox
            cboMovement.SelectedText = "--Movement--";
            cboMovement.Items.Add("Back Squat");
            cboMovement.Items.Add("Shoulder Press");
            cboMovement.Items.Add("Deadlift");
            cboMovement.Items.Add("Clean");
            cboMovement.Items.Add("Snatch");
            //RM checkbox
            cboRM.SelectedText = "--Percent--";
            cboRM.Items.Add("1RM");
            cboRM.Items.Add("2RM");
            cboRM.Items.Add("3RM");
            cboRM.Items.Add("4RM");
            cboRM.Items.Add("5RM");
            cboRM.Items.Add("6RM");
            cboRM.Items.Add("7RM");
            cboRM.Items.Add("8RM");
            cboRM.Items.Add("9RM");
            cboRM.Items.Add("10RM");
            cboRM.Items.Add("15RM");
            cboRM.Items.Add("20RM");

            txtDateTime.Text = currentDateTime.ToString("MM dd yyyy");
        }


        decimal weight;//weight in lbs or kg no conversion needed
        //string unit;//lbs or kg
        decimal reps;//repetitions completed
        decimal oneRM, twoRM, threeRM, fourRM, fiveRM, sixRM, sevenRM, eightRM, nineRM, tenRM, fifteenRM, twentyRM;


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //inputs
                    reps = Convert.ToDecimal(txtReps.Text);
                    weight = Convert.ToDecimal(txtWeight.Text);

                    //calculate
                    oneRM = Math.Round(weight * (36 / (37 - reps)) / 5) * 5;
                    Dictionary<int, string> dict = new Dictionary<int, string>()
                    {
                        //Brzycki
                        {95,"2RM"},
                        {90,"3RM"},
                        {88,"4RM"},
                        {86,"5RM"},
                        {83,"6RM"},
                        {80,"7RM"},
                        {78,"8RM"},
                        {76,"9RM"},
                        {75,"10RM"},
                        {65,"15RM"},
                        {50,"20RM"}
                    };

                    //use for each calculation to provide values for textboxes
                    decimal calc = (weight / 100);
                    decimal[] rmArray = new decimal[dict.Count];
                    lstRM.Items.Add(currentDateTime.ToString("MMMM dd yyyy"));
                    lstRM.Items.Add(cboMovement.Text);
                    lstRM.Items.Add("1RM = " + oneRM);
                    //lstRM listbox
                    for (int i = 0; i < dict.Count; i++)
                    {
                        var p = (dict.Keys.ElementAt(i));
                        decimal repmax = (p * weight) / 100;
                        var r = (dict[dict.Keys.ElementAt(i)]);
                        lstRM.Items.Add(r + " = " + repmax.ToString("N0"));
                        rmArray[i] = repmax;
                    }

                    //can remove
                    //outputs results to text boxes from rmArray
                    //txt1RM.Text = oneRM.ToString("N0");
                    //assigns values from array to be used in percentRM
                    twoRM = rmArray[0];
                    threeRM = rmArray[1];
                    fourRM = rmArray[2];
                    fiveRM = rmArray[3];
                    sixRM = rmArray[4];
                    sevenRM = rmArray[5];
                    eightRM = rmArray[6];
                    nineRM = rmArray[7];
                    tenRM = rmArray[8];
                    fifteenRM = rmArray[9];
                    twentyRM = rmArray[10];
                }
            }
            //specific exception handling
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format. Please check all entries.",
                    "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Overflow error. Please enter smaller values.",
                    "Entry Error");
            }
            //general exception handling
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString());
            }
        }

        //data validation
        public bool IsValidData()
        {
            return
                IsPresent(txtWeight, "Weight") &&
                IsDecimal(txtWeight, "Weight") &&
                IsWithinRange(txtWeight, "Weight", 1, 1000) &&

                IsPresent(txtReps, "Reps") &&
                IsDecimal(txtReps, "Reps") &&
                IsWithinRange(txtReps, "Reps", 1, 20);
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "EntryError");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    name + " must be a decimal value.",
                    "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(
                    name + " must be between " + min + " and " + max + ".",
                    "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValues(sender, e);
            txtWeight.Text = "";
            txtReps.Text = "";
        }

        //if weight or reps are changed in designer
        private void ClearValues(object sender, EventArgs e)
        {
            cboMovement.Text = "";
            cboMovement.SelectedText = "--Movement--";
            cboRM.Text = "";
            cboRM.SelectedText = "--Percent--";
            lstRM.Items.Clear();
            lstPercent.Items.Clear();
            txtPercent.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to fill percentages listbox and textbox
        private void BtnPercentages_Click(object sender, EventArgs e)
        {
            Convert.ToString(cboRM.Text);
            decimal rm = 0;

            Dictionary<int, string> percentDict = new Dictionary<int, string>()
                    {
                        {100,"100%"},
                        {95,"95%"},
                        {90,"90%"},
                        {85,"85%"},
                        {80,"80%"},
                        {75,"75%"},
                        {70,"70%"},
                        {65,"65%"},
                        {60,"60%"},
                        {55,"55%"},
                        {50,"50%"}
                    };

            decimal[] percentArray = new decimal[percentDict.Count];
            //percent RM listbox
            lstPercent.Items.Add(currentDateTime.ToString("MMMM dd yyyy"));
            lstPercent.Items.Add(cboRM.Text + " " + cboMovement.Text);

            //percent RM textbox
            txtPercent.AppendText(currentDateTime.ToString("MMMM dd yyyy") + "\r\n");
            txtPercent.AppendText(cboRM.Text + " " + cboMovement.Text + "\r\n");
            for (int i = 0; i < percentDict.Count; i++)
            {
                if (cboRM.Text == "1RM")
                {
                    rm = oneRM;
                }
                else if (cboRM.Text == "2RM")
                {
                    rm = twoRM;
                }
                else if (cboRM.Text == "3RM")
                {
                    rm = threeRM;
                }
                else if (cboRM.Text == "4RM")
                {
                    rm = fourRM;
                }
                else if (cboRM.Text == "5RM")
                {
                    rm = fiveRM;
                }
                else if (cboRM.Text == "6RM")
                {
                    rm = sixRM;
                }
                else if (cboRM.Text == "7RM")
                {
                    rm = sevenRM;
                }
                else if (cboRM.Text == "8RM")
                {
                    rm = eightRM;
                }
                else if (cboRM.Text == "9RM")
                {
                    rm = nineRM;
                }
                else if (cboRM.Text == "10RM")
                {
                    rm = tenRM;
                }
                else if (cboRM.Text == "15RM")
                {
                    rm = fifteenRM;
                }
                else if (cboRM.Text == "20RM")
                {
                    rm = twentyRM;
                }
                else
                {
                    MessageBox.Show("RM is a required field.");
                }

                var p = (percentDict.Keys.ElementAt(i));
                decimal percentMax = (p * rm) / 100;
                var r = (percentDict[percentDict.Keys.ElementAt(i)]);
                percentArray[i] = percentMax;
                lstPercent.Items.Add(r + " = " + percentMax.ToString("N0"));
                txtPercent.AppendText(r + " = " + percentMax.ToString("N0") + "\r\n");
            }
        }  
    }
}
