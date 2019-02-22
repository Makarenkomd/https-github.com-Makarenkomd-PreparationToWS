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
        int currentIndexImg = 0;

        void showPicture()
        {
            pictureBox1.Image = Image.FromFile(img[currentIndexImg]);
            pictureBox2.Image = Image.FromFile(img[(currentIndexImg+1)%img.Count()]);
            pictureBox3.Image = Image.FromFile(img[(currentIndexImg+2)%img.Count()]);
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
            currentIndexImg = (currentIndexImg+3) % img.Count();
            showPicture();

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            currentIndexImg = (currentIndexImg - 3 +img.Count()) % img.Count();
            showPicture();
        }
    }
}
