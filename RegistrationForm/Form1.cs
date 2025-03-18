using System.Xml.Linq;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        private string imagePath;
        private string gender;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxPreview.Image = Image.FromFile(imagePath);

            }
        }

        private void submitFormButton_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Set the content of Form2's label
            form2.setName(nameTextBox.Text);
            form2.setRoll(rollTextBox.Text);
            form2.setRegID(regIDtextBox.Text);
            form2.setSemester(semesterTextBox.Text);
            form2.setBloodGroup(bloodGroupTextBox.Text);

            if (radioButtonMale.Checked)
            {
                gender = radioButtonMale.Text;
            }
            else if (radioButtonFemale.Checked)
            {
                gender = radioButtonFemale.Text;
            }

            form2.setGender(gender);

            if (imagePath != null)
            {
                form2.setImage(imagePath);
            }


            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(rollTextBox.Text) || string.IsNullOrWhiteSpace(regIDtextBox.Text) || string.IsNullOrWhiteSpace(semesterTextBox.Text))
            {
                MessageBox.Show("Please fill all the required fields (Name, Roll, Reg. ID and Semester)");
                return;
            }

            // Show Form2
            form2.Show();
        }

        private void resetFormButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            rollTextBox.Clear();
            regIDtextBox.Clear();
            semesterTextBox.Clear();
            bloodGroupTextBox.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            pictureBoxPreview.Image = null;
            imagePath = "";
        }
    }
}
