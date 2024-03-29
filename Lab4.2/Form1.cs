﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// KATHLEEN FORGIARINI DA SILVA
//2023-02-16
// LAB 4.2 - combobox

namespace Lab4._2
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtNumberGrade.Text = cboValues.SelectedItem.ToString();
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            //decimal numberGrade = Convert.ToDecimal(cboValues.SelectedItem);
            string letterGrade = "";
            if (numberGrade >= 88) 
            { 
                letterGrade = "A"; 
            } 
            else if (numberGrade >= 80 && numberGrade <= 87) 
            { 
                letterGrade = "B"; 
            } 
            else if (numberGrade >= 68 && numberGrade <= 79) 
            { 
                letterGrade = "C"; 
            } 
            else if (numberGrade >= 60 && numberGrade <= 67) 
            { 
                letterGrade = "D"; 
            } 
            else 
            { 
                letterGrade = "F"; 
            }
            txtLetterGrade.Text = letterGrade;
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculateGrade_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                cboValues.Items.Add(i);
            }
        }

        private void cboValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumberGrade.Text = cboValues.SelectedItem.ToString();
        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value1 = Convert.ToDouble(txtNumberGrade.Text);
                cboValues.Text = txtNumberGrade.Text;
            }
            catch 
            {
                MessageBox.Show("Please enter just numbers");
            }
        }
    }
}
