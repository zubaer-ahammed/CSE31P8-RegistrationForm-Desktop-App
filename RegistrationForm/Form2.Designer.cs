namespace RegistrationForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelName = new Label();
            labelRoll = new Label();
            labelRegID = new Label();
            labelSemester = new Label();
            labelBloodGroup = new Label();
            labelGender = new Label();
            pictureBoxPhoto = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 26);
            label1.Name = "label1";
            label1.Size = new Size(347, 65);
            label1.TabIndex = 0;
            label1.Text = "Student Details";
            label1.Click += label1_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(160, 168);
            labelName.Name = "labelName";
            labelName.Size = new Size(97, 32);
            labelName.TabIndex = 1;
            labelName.Text = "Name:  ";
            // 
            // labelRoll
            // 
            labelRoll.AutoSize = true;
            labelRoll.Location = new Point(185, 215);
            labelRoll.Name = "labelRoll";
            labelRoll.Size = new Size(72, 32);
            labelRoll.TabIndex = 3;
            labelRoll.Text = "Roll:  ";
            // 
            // labelRegID
            // 
            labelRegID.AutoSize = true;
            labelRegID.Location = new Point(149, 262);
            labelRegID.Name = "labelRegID";
            labelRegID.Size = new Size(108, 32);
            labelRegID.TabIndex = 4;
            labelRegID.Text = "Reg. ID:  ";
            // 
            // labelSemester
            // 
            labelSemester.AutoSize = true;
            labelSemester.Location = new Point(125, 310);
            labelSemester.Name = "labelSemester";
            labelSemester.Size = new Size(132, 32);
            labelSemester.TabIndex = 5;
            labelSemester.Text = "Semester:  ";
            labelSemester.Click += label4_Click;
            // 
            // labelBloodGroup
            // 
            labelBloodGroup.AutoSize = true;
            labelBloodGroup.Location = new Point(89, 360);
            labelBloodGroup.Name = "labelBloodGroup";
            labelBloodGroup.Size = new Size(168, 32);
            labelBloodGroup.TabIndex = 6;
            labelBloodGroup.Text = "Blood Group:  ";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(146, 416);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(111, 32);
            labelGender.TabIndex = 7;
            labelGender.Text = "Gender:  ";
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(622, 198);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(200, 200);
            pictureBoxPhoto.TabIndex = 8;
            pictureBoxPhoto.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(735, 416);
            label7.Name = "label7";
            label7.Size = new Size(77, 32);
            label7.TabIndex = 9;
            label7.Text = "Photo";
            label7.Click += label7_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 867);
            Controls.Add(label7);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(labelGender);
            Controls.Add(labelBloodGroup);
            Controls.Add(labelSemester);
            Controls.Add(labelRegID);
            Controls.Add(labelRoll);
            Controls.Add(labelName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelName;
        private Label labelRoll;
        private Label labelRegID;
        private Label labelSemester;
        private Label labelBloodGroup;
        private Label labelGender;
        private PictureBox pictureBoxPhoto;
        private Label label7;
    }
}