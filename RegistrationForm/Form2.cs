using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Method to set the label text
        public void setName(string text)
        {
            labelName.Text += text;
        }

        public void setRoll(string text)
        {
            labelRoll.Text += text;
        }

        public void setRegID(string text)
        {
            labelRegID.Text += text;
        }

        public void setSemester(string text)
        {
            labelSemester.Text += text;
        }

        public void setBloodGroup(string text)
        {
            labelBloodGroup.Text += text;
        }

        public void setGender(string text)
        {

            labelGender.Text += text;
        }

        public void setImage(string path)
        {
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.Image = Image.FromFile(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
