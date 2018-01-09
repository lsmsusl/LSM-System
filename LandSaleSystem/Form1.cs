using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LandSaleSystem
{
    public partial class Form1 : Form
    { 
    
        public Form1()
        {
            InitializeComponent();
           
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            if(Textbox1.Text=="kavinda" && Textbox2.Text=="1234")
                {
                    Label2.Text = "Successful Login";
                }
            else if(Textbox1.Text=="" || Textbox2.Text=="")
                {
                    Label2.Text = "Please fill all fields..!";
                }
            else
                {
                    Label2.Text = "Invalid username or password. Please try again.";
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
