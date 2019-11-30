using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApplication3
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            
        }
        

        private void Form14_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        string ageGroup;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ageGroup = "9-12 yrs";
                
           }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                ageGroup = "13-15 yrs";
               
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                ageGroup = "16-18 yrs";
                
            }

        }
        string name;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
         
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
      
            Form4 f4 = new Form4(ageGroup,name);
            f4.Show();
            this.Hide();
            

        }

    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
