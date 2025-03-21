namespace RegistrationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            rollTextBox = new TextBox();
            label2 = new Label();
            regIDtextBox = new TextBox();
            label3 = new Label();
            semesterTextBox = new TextBox();
            label4 = new Label();
            bloodGroupTextBox = new TextBox();
            label5 = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            uploadPhotoButton = new Button();
            resetFormButton = new Button();
            submitFormButton = new Button();
            pictureBoxPreview = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formLabel.Location = new Point(303, 33);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(403, 65);
            formLabel.TabIndex = 0;
            formLabel.Text = "Registration Form";
            formLabel.Click += label1_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(314, 135);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(83, 32);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            nameLabel.Click += label2_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(415, 132);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(380, 39);
            nameTextBox.TabIndex = 2;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 195);
            label1.Name = "label1";
            label1.Size = new Size(58, 32);
            label1.TabIndex = 3;
            label1.Text = "Roll:";
            label1.Click += label1_Click_1;
            // 
            // rollTextBox
            // 
            rollTextBox.Location = new Point(415, 195);
            rollTextBox.Name = "rollTextBox";
            rollTextBox.Size = new Size(380, 39);
            rollTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 257);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 5;
            label2.Text = "Reg. ID:";
            // 
            // regIDtextBox
            // 
            regIDtextBox.Location = new Point(415, 257);
            regIDtextBox.Name = "regIDtextBox";
            regIDtextBox.Size = new Size(380, 39);
            regIDtextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 322);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 7;
            label3.Text = "Semester:";
            // 
            // semesterTextBox
            // 
            semesterTextBox.Location = new Point(415, 322);
            semesterTextBox.Name = "semesterTextBox";
            semesterTextBox.Size = new Size(380, 39);
            semesterTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 379);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 9;
            label4.Text = "Blood Group:";
            // 
            // bloodGroupTextBox
            // 
            bloodGroupTextBox.Location = new Point(415, 379);
            bloodGroupTextBox.Name = "bloodGroupTextBox";
            bloodGroupTextBox.Size = new Size(380, 39);
            bloodGroupTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 441);
            label5.Name = "label5";
            label5.Size = new Size(97, 32);
            label5.TabIndex = 11;
            label5.Text = "Gender:";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(415, 441);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(98, 36);
            radioButtonMale.TabIndex = 12;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(541, 441);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(122, 36);
            radioButtonFemale.TabIndex = 13;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 515);
            label6.Name = "label6";
            label6.Size = new Size(165, 32);
            label6.TabIndex = 14;
            label6.Text = "Upload Photo:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // uploadPhotoButton
            // 
            uploadPhotoButton.Location = new Point(414, 507);
            uploadPhotoButton.Name = "uploadPhotoButton";
            uploadPhotoButton.Size = new Size(228, 49);
            uploadPhotoButton.TabIndex = 15;
            uploadPhotoButton.Text = "UPLOAD";
            uploadPhotoButton.UseVisualStyleBackColor = true;
            uploadPhotoButton.Click += button1_Click;
            // 
            // resetFormButton
            // 
            resetFormButton.Location = new Point(470, 619);
            resetFormButton.Name = "resetFormButton";
            resetFormButton.Size = new Size(150, 46);
            resetFormButton.TabIndex = 16;
            resetFormButton.Text = "RESET";
            resetFormButton.UseVisualStyleBackColor = true;
            resetFormButton.Click += resetFormButton_Click;
            // 
            // submitFormButton
            // 
            submitFormButton.Location = new Point(645, 619);
            submitFormButton.Name = "submitFormButton";
            submitFormButton.Size = new Size(150, 46);
            submitFormButton.TabIndex = 17;
            submitFormButton.Text = "SUBMIT";
            submitFormButton.UseVisualStyleBackColor = true;
            submitFormButton.Click += submitFormButton_Click;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(684, 481);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(111, 94);
            pictureBoxPreview.TabIndex = 19;
            pictureBoxPreview.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 776);
            label7.Name = "label7";
            label7.Size = new Size(358, 32);
            label7.TabIndex = 20;
            label7.Text = "© 2025 - Md. Zubaer Ahammed";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 929);
            Controls.Add(label7);
            Controls.Add(pictureBoxPreview);
            Controls.Add(submitFormButton);
            Controls.Add(resetFormButton);
            Controls.Add(uploadPhotoButton);
            Controls.Add(label6);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(label5);
            Controls.Add(bloodGroupTextBox);
            Controls.Add(label4);
            Controls.Add(semesterTextBox);
            Controls.Add(label3);
            Controls.Add(regIDtextBox);
            Controls.Add(label2);
            Controls.Add(rollTextBox);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(formLabel);
            Name = "Form1";
            Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox rollTextBox;
        private Label label2;
        private TextBox regIDtextBox;
        private Label label3;
        private TextBox semesterTextBox;
        private Label label4;
        private TextBox bloodGroupTextBox;
        private Label label5;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label label6;
        private OpenFileDialog openFileDialog1;
        private Button uploadPhotoButton;
        private Button resetFormButton;
        private Button submitFormButton;
        private PictureBox pictureBoxPreview;
        private Label label7;
    }
}
