using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial1
{
    public partial class Map : Form
    {
        public Map()
        {
            /*
            Image myImage = new Bitmap(@"C:\Users\SDE-03062\source\repos\Trial1\Trial1\Images\BackgroundImage.bmp");

            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = myImage;
            */
            
           
            
            InitializeComponent();
        }



        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
