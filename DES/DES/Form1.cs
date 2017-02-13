using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DES
{
    public partial class mainInterfaceDes : Form
    {
        public mainInterfaceDes()
        {
            InitializeComponent();
        }     

        private void mainInterfaceDes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {                
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Submit.Enabled = false;
            }
            else
            {
                Submit.Enabled = true;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
