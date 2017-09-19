using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motor_Insurance_Calculator
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
     
        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Occupation", typeof(string));
            table.Columns.Add("Date of Birth", typeof(DateTime));
            table.Columns.Add("Age", typeof(string));
            //table.Columns.Add("Claims", typeof(int));

            dataGridView1.DataSource = table;
            
        }
        

        
        public void button1_Click(object sender, EventArgs e)
        {
            
                if (policyStartDate.Value < DateTime.Today)
                {
                    MessageBox.Show("Start Date of Policy before current date", "Policy Date Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (table.Rows.Count < driversOnPolicy.Value)
            {
                TimeSpan age = DateTime.Now - driverDob.Value;
                int years = DateTime.Now.Year - driverDob.Value.Year;
                if (driverDob.Value.AddYears(years) > DateTime.Now) years--;
                bool ageParameters = true;
                if (years < 21)
                {
                    MessageBox.Show("Age of Youngest Driver: " + textBoxName.Text, "Driver Age",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ageParameters = false;
                }
                else if (years > 75)
                {
                    MessageBox.Show("Age of Oldest Driver: " + textBoxName.Text, "Driver Age",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ageParameters = false;
                }


                if (ageParameters == true) 
                {
                    if (comboBoxJob.Text == "Chauffeur")
                    {
                        GlobalVariables.premium += GlobalVariables.premium * 0.1;
                    }
                    else if (comboBoxJob.Text == "Accountant")
                    {
                        GlobalVariables.premium -= GlobalVariables.premium * 0.1;
                    }
                    else if (years >= 21 && years <= 25)
                    {
                        GlobalVariables.premium += GlobalVariables.premium * 0.2;
                    }
                    if (years >= 26 && years <= 75)
                    {
                        GlobalVariables.premium -= GlobalVariables.premium * 0.2;
                    }
                    table.Rows.Add(textBoxName.Text, comboBoxJob.Text, driverDob.Text, textBoxAge.Text = years.ToString());
                    totalPremiumBox.Text = GlobalVariables.premium.ToString("N2");
                }
            }
        }
    }
}
