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
add validator class
remove textboxes for rm values
add GetDisplayText
display data in multi-line text box instead of listbox
use Product Maintenance example for File I/O
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
            cboMovement.Items.Add("Back Squat");
            cboMovement.Items.Add("Shoulder Press");
            cboMovement.Items.Add("Deadlift");
            cboMovement.Items.Add("Clean");
            cboMovement.Items.Add("Snatch");
            //RM checkbox
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
            //set textbox values to 0
            txt1RM.Text = "0";
            txt2RM.Text = "0";
            txt3RM.Text = "0";
            txt4RM.Text = "0";
            txt5RM.Text = "0";
            txt6RM.Text = "0";
            txt7RM.Text = "0";
            txt8RM.Text = "0";
            txt9RM.Text = "0";
            txt10RM.Text = "0";
            txt15RM.Text = "0";
            txt20RM.Text = "0";
        }


        decimal weight;//weight in lbs or kg no conversion needed
        //string unit;//lbs or kg
        decimal reps;//repetitions completed
        decimal oneRM;


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //calculate RM from 1RM
                    //create a calculate object to find RM values
                    Calculator c = new Calculator(
                        Convert.ToDecimal(txt1RM.Text),
                        Convert.ToDecimal(txt2RM.Text),
                        Convert.ToDecimal(txt3RM.Text),
                        Convert.ToDecimal(txt4RM.Text),
                        Convert.ToDecimal(txt5RM.Text),
                        Convert.ToDecimal(txt6RM.Text),
                        Convert.ToDecimal(txt7RM.Text),
                        Convert.ToDecimal(txt8RM.Text),
                        Convert.ToDecimal(txt9RM.Text),
                        Convert.ToDecimal(txt10RM.Text),
                        Convert.ToDecimal(txt15RM.Text),
                        Convert.ToDecimal(txt20RM.Text)
                    );

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
                    //use for lstRM listbox
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
                    txt1RM.Text = oneRM.ToString("N0");
                    txt2RM.Text = rmArray[0].ToString("N0");//2
                    txt3RM.Text = rmArray[1].ToString("N0");//3
                    txt4RM.Text = rmArray[2].ToString("N0");//4
                    txt5RM.Text = rmArray[3].ToString("N0");//5
                    txt6RM.Text = rmArray[4].ToString("N0");//6
                    txt7RM.Text = rmArray[5].ToString("N0");//7
                    txt8RM.Text = rmArray[6].ToString("N0");//8
                    txt9RM.Text = rmArray[7].ToString("N0");//9
                    txt10RM.Text = rmArray[8].ToString("N0");//10
                    txt15RM.Text = rmArray[9].ToString("N0");//15
                    txt20RM.Text = rmArray[10].ToString("N0");//20
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
            cboMovement.Text = "";
            txtWeight.Text = "";
            txtReps.Text = "";
            cboRM.Text = "";
            //can remove
            txt1RM.Text = "0";
            txt2RM.Text = "0";
            txt2RM.Text = "0";
            txt3RM.Text = "0";
            txt4RM.Text = "0";
            txt5RM.Text = "0";
            txt6RM.Text = "0";
            txt7RM.Text = "0";
            txt8RM.Text = "0";
            txt9RM.Text = "0";
            txt10RM.Text = "0";
            txt15RM.Text = "0";
            txt20RM.Text = "0";
            lstRM.Items.Clear();
            lstPercent.Items.Clear();
            txtPercent.Text = "";
        }

        //if weight is changed line 240 in designer
        //could add if reps is changed
        private void ClearValues(object sender, EventArgs e)
        {
            cboRM.Text = "";
            txt1RM.Text = "0";
            txt2RM.Text = "0";
            txt3RM.Text = "0";
            txt4RM.Text = "0";
            txt5RM.Text = "0";
            txt6RM.Text = "0";
            txt7RM.Text = "0";
            txt8RM.Text = "0";
            txt9RM.Text = "0";
            txt10RM.Text = "0";
            txt15RM.Text = "0";
            txt20RM.Text = "0";
            lstRM.Items.Clear();
            lstPercent.Items.Clear();
            txtPercent.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to fill percentages listbox
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
                    rm = Convert.ToDecimal(txt1RM.Text);
                }
                else if (cboRM.Text == "2RM")
                {
                    rm = Convert.ToDecimal(txt2RM.Text);
                }
                else if (cboRM.Text == "3RM")
                {
                    rm = Convert.ToDecimal(txt3RM.Text);
                }
                else if (cboRM.Text == "4RM")
                {
                    rm = Convert.ToDecimal(txt4RM.Text);
                }
                else if (cboRM.Text == "5RM")
                {
                    rm = Convert.ToDecimal(txt5RM.Text);
                }
                else if (cboRM.Text == "6RM")
                {
                    rm = Convert.ToDecimal(txt6RM.Text);
                }
                else if (cboRM.Text == "7RM")
                {
                    rm = Convert.ToDecimal(txt7RM.Text);
                }
                else if (cboRM.Text == "8RM")
                {
                    rm = Convert.ToDecimal(txt8RM.Text);
                }
                else if (cboRM.Text == "9RM")
                {
                    rm = Convert.ToDecimal(txt9RM.Text);
                }
                else if (cboRM.Text == "10RM")
                {
                    rm = Convert.ToDecimal(txt10RM.Text);
                }
                else if (cboRM.Text == "15RM")
                {
                    rm = Convert.ToDecimal(txt15RM.Text);
                }
                else if (cboRM.Text == "20RM")
                {
                    rm = Convert.ToDecimal(txt20RM.Text);
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
