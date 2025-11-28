using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace InsertNameHere
{
    public partial class Form1 : Form
    {
        User thisUser = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            thisUser.FirstName = FullNameInputBox.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
