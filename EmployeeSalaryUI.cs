using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        private Employee anEmployee;

        int NoOfIncrement = 0;
        private double increment = 0;
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            anEmployee = new Employee(IDtextBox1.Text, NametextBox5.Text, EmailtextBox4.Text);
            Salary aSalary = new Salary(Convert.ToDouble(BasictextBox2.Text), Convert.ToDouble(MedicaltextBox6.Text), Convert.ToDouble(ConvtextBox7.Text));
            anEmployee.ASalary = aSalary;
            MessageBox.Show(anEmployee.ID + "," + anEmployee.Name + "," + anEmployee.Email + "\n" + "u have created an account and it has \nBasic of:" + " " + anEmployee.ASalary.Basic + "\nMed:" + anEmployee.ASalary.Med + "%" + "\nConv:" + anEmployee.ASalary.Conv + "%");
        }

        private void Incrementbutton2_Click(object sender, EventArgs e)
        {
            increment = Convert.ToDouble(IncreasetextBox8.Text);
            anEmployee.ASalary.TotalSalary(increment);

        }

        private void Showbutton3_Click(object sender, EventArgs e)
        {
            int No = NoOfIncrement++;
            NoOfInctextBox3.Text = Convert.ToString(No);
            
            anEmployee.ASalary.FindConv();
            anEmployee.ASalary.FindMed();
            if (IncreasetextBox8.Text == "")
            {
                BasicSaltextBox9.Text = Convert.ToString(anEmployee.ASalary.Basic);
                MedSaltextBox10.Text = Convert.ToString(anEmployee.ASalary.FindMed());
                ConvSaltextBox11.Text = Convert.ToString(anEmployee.ASalary.FindConv());
                TotaltextBox12.Text = Convert.ToString(anEmployee.ASalary.TotalSalary(increment));
            }

            else
            {
                BasicSaltextBox9.Text = Convert.ToString(anEmployee.ASalary.Basic);
                MedSaltextBox10.Text = Convert.ToString(anEmployee.ASalary.MedAm);
                ConvSaltextBox11.Text = Convert.ToString(anEmployee.ASalary.ConvAm);
                TotaltextBox12.Text = Convert.ToString(anEmployee.ASalary.Total);
            }
        }
    }
}
