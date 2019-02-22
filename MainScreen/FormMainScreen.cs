using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class FormMainScreen : Form
    {
        List<string> img = new List<string>();

        void showPicture()
        {
            pictureBox1.Image = Image.FromFile(img[0]);
            pictureBox2.Image = Image.FromFile(img[1]);
            pictureBox3.Image = Image.FromFile(img[2]);
        }
        public FormMainScreen()
        {
            InitializeComponent();
            DirectoryInfo dir = new DirectoryInfo("images");
            foreach (var file in dir.GetFiles())
                img.Add(file.FullName);
            showPicture();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {

        }
    }
}
