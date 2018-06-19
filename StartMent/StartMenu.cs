using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Trial1;

namespace StartMent
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }


        Form1 form1 = new Form1();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            form1.LoadOrNot++;
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
