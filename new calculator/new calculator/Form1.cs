using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_calculator
{
    public partial class Form1 : Form
    {
        string HistoryMaintain = null;
        List<string> HistoryList = new List<string>();

        calculator cal = new calculator();
        int valueOne;
        int valueTwo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbm_Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbm_Choice.Text == "ADD")
             try
             {
               HistoryMaintain= txt_Answer.Text = cal.add(Convert.ToInt32(txt_ValueOne.Text), Convert.ToInt32(txt_ValueTwo.Text)).ToString();
               txt_ValueOne.Clear();
               txt_ValueTwo.Clear();
             }
            catch(Exception ee)
             {
                // lbl_error.Text = "Invalid number";
                 MessageBox.Show("Input is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
             }
            if (cbm_Choice.Text == "SUB")
                try
            {
                HistoryMaintain = txt_Answer.Text = cal.sub(Convert.ToInt32(txt_ValueOne.Text), Convert.ToInt32(txt_ValueTwo.Text)).ToString();
                txt_ValueOne.Clear();
                txt_ValueTwo.Clear();
          
                }
            catch(Exception ee)
                {
                    MessageBox.Show("Input is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            if (cbm_Choice.Text == "MUL")
                try
            {
                HistoryMaintain = txt_Answer.Text = cal.mul(Convert.ToInt32(txt_ValueOne.Text), Convert.ToInt32(txt_ValueTwo.Text)).ToString();

                txt_ValueOne.Clear();
                txt_ValueTwo.Clear();
            }

            catch(Exception ee)
                {
                    MessageBox.Show("Input is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            if (cbm_Choice.Text == "DIVID")

                try
            {
                HistoryMaintain = txt_Answer.Text = cal.divid(Convert.ToInt32(txt_ValueOne.Text), Convert.ToInt32(txt_ValueTwo.Text)).ToString();

                txt_ValueOne.Clear();
                txt_ValueTwo.Clear();
                }
            catch(Exception ee)
                {
                    MessageBox.Show("Input is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            private void error()
            {
                txt_ValueOne.Clear();
                txt_ValueTwo.Clear();
                txt_ValueOne.Focus();
                txt_Answer.Clear();
                lbl_last_Operator.Text = "Last Operator:" + HistoryMaintain;
                HistoryList.Add(HistoryMaintain);       
            }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            error();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            History myHistory = new History();
            myHistory.LoadList(HistoryList);
        }

        }



    }




