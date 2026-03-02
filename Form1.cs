using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garcia_IT202NS_Lesson3Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupRowNumbers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupRowNumbers()
        {
            for (int i = 0; i <= 7; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = i.ToString();
            }
        }

        private void cmbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbProgram.Items.Add("BS Information Technology");
            cmbProgram.Items.Add("Computer Engineering");
            cmbProgram.Items.Add("BS Electrical Engineering");
            cmbProgram.Items.Add("BS Computer Science");
            cmbProgram.Items.Add("BS Mechanical Engineering");
            cmbProgram.Items.Add("BS Industrial Engineering");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommputeFees();
            CommputeUnits();
         
        }


        private void CommputeFees()
        {
            int totalLecUnits = 0, totalLabUnits = 0, tempValue;

            TextBox[] lecBoxes = { txtLecUnits1, txtLecUnits2, txtLecUnits3, txtLecUnits4, txtLecUnits5, txtLecUnits6, txtLecUnits7 };
            TextBox[] labBoxes = { txtLabUnits1, txtLabUnits2, txtLabUnits3, txtLabUnits4, txtLabUnits5, txtLabUnits6, txtLabUnits7 };

            foreach (TextBox box in lecBoxes)
                if (int.TryParse(box.Text, out tempValue)) totalLecUnits += tempValue;

            foreach (TextBox box in labBoxes)
                if (int.TryParse(box.Text, out tempValue)) totalLabUnits += tempValue;


            double lectureFee = totalLecUnits * 1500.00;
            double labFee = totalLabUnits * 2500.00;
            double comLabFee = totalLabUnits * 2500.00;
            double sapFee = 2000.00, ciscoFee = 4500.00, examFee = 450.00;

            double miscFees = labFee + comLabFee;
            double otherFees = sapFee + ciscoFee + examFee;
            double totalTuitionAndFees = lectureFee + miscFees + otherFees;



            txtMisc.Text = miscFees.ToString("N2");
            txtCLFee.Text = comLabFee.ToString("N2");
            txtSapFee.Text = sapFee.ToString("N2");
            txtCiscoLFee.Text = ciscoFee.ToString("N2");
            txtEBFee.Text = examFee.ToString("N2");
            txtTotalOthFee.Text = otherFees.ToString("N2");
            txtTotalTuitionFee.Text = totalTuitionAndFees.ToString("N2");


            double downPayment = 8000.00;
            double remaining = totalTuitionAndFees - downPayment;
            double installment = remaining / 3;

            txtDown.Text = downPayment.ToString("N2");
            txt1st.Text = installment.ToString("N2");
            txt2nd.Text = installment.ToString("N2");
            txt3rd.Text = installment.ToString("N2");

      
        }
        private void CommputeUnits()
        {
            double TotalUnits = 0;
            double tempValue = 0;

            double.TryParse(txtCredUnit1.Text, out tempValue); TotalUnits += tempValue;
            double.TryParse(txtCredUnit2.Text, out tempValue); TotalUnits += tempValue;
            double.TryParse(txtCredUnit3.Text, out tempValue); TotalUnits += tempValue;
            double.TryParse(txtCredUnit4.Text, out tempValue); TotalUnits += tempValue;
            double.TryParse(txtCredUnit5.Text, out tempValue); TotalUnits += tempValue;
            double.TryParse(txtCredUnit6.Text, out tempValue); TotalUnits += tempValue;
            double.TryParse(txtCredUnit7.Text, out tempValue); TotalUnits += tempValue;

            txtTotalCreditUnits.Text = TotalUnits.ToString();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnCLEARSTUDENTINFORMATION_Click(object sender, EventArgs e)
        {
            txtCourseCode1.Clear();
            txtSection1.Clear();
            txtDesc1.Clear();
            txtLecUnits1.Clear();
            txtLabUnits1.Clear();
            txtCredUnit1.Clear();
            txtTime1.Clear();
            txtDay1.Clear();
            txtRoom1.Clear();

            txtCourseCode2.Clear();
            txtSection2.Clear();
            txtDesc2.Clear();
            txtLecUnits2.Clear();
            txtLabUnits2.Clear();
            txtCredUnit2.Clear();
            txtTime2.Clear();
            txtDay2.Clear();
            txtRoom2.Clear();

            txtCourseCode3.Clear();
            txtSection3.Clear();
            txtDesc3.Clear();
            txtLecUnits3.Clear();
            txtLabUnits3.Clear();
            txtCredUnit3.Clear();
            txtTime3.Clear();
            txtDay3.Clear();
            txtRoom3.Clear();

            txtCourseCode4.Clear();
            txtSection4.Clear();
            txtDesc4.Clear();
            txtLecUnits4.Clear();
            txtLabUnits4.Clear();
            txtCredUnit4.Clear();
            txtTime4.Clear();
            txtDay4.Clear();
            txtRoom4.Clear();

            txtCourseCode5.Clear();
            txtSection5.Clear();
            txtDesc5.Clear();
            txtLecUnits5.Clear();
            txtLabUnits5.Clear();
            txtCredUnit5.Clear();
            txtTime5.Clear();
            txtDay5.Clear();
            txtRoom5.Clear();

            txtCourseCode6.Clear();
            txtSection6.Clear();
            txtDesc6.Clear();
            txtLecUnits6.Clear();
            txtLabUnits6.Clear();
            txtCredUnit6.Clear();
            txtTime6.Clear();
            txtDay6.Clear();
            txtRoom6.Clear();


            txtCourseCode7.Clear();
            txtSection7.Clear();
            txtDesc7.Clear();
            txtLecUnits7.Clear();
            txtLabUnits7.Clear();
            txtCredUnit7.Clear();
            txtTime7.Clear();
            txtDay7.Clear();
            txtRoom7.Clear();

            txtTotalCreditUnits.Clear();

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnCLEARSCHEDULEOFCOURSES_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentNo.Clear();
            cmbProgram.SelectedIndex = -1;
            dtpDateEnrolled.Value = DateTime.Now;
            cmbProgram2.SelectedIndex = -1;
            cmbProgram3.SelectedIndex = -1;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtLecUnits1_TextChanged(object sender, EventArgs e)
        {

        }
    } 
} 



