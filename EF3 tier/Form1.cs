using BAL;
using BAL.AccountBAL;
using ClassLibrary1.Data_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF3_tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.name =textBox1.Text;
            u.age = Int32.Parse(textBox2.Text);
            u.address =textBox3.Text;
            userBAL.AddUser(u);
            MessageBox.Show("Test");
        }
    }
}
