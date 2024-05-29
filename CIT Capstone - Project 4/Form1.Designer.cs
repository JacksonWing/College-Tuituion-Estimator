namespace CIT_Capstone___Project_4
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
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            yesDeBtn = new RadioButton();
            noDeBtn = new RadioButton();
            confirmBtn = new Button();
            enrollmentGB = new GroupBox();
            inStateBtn = new RadioButton();
            outStateBtn = new RadioButton();
            yesERateBtn = new RadioButton();
            courseGroupBox = new GroupBox();
            courseListBox = new ListBox();
            receiptButton = new Button();
            deleteCourseBtn = new Button();
            addCourseBtn = new Button();
            label4 = new Label();
            creditHrsBox = new NumericUpDown();
            noNurseBtn = new RadioButton();
            yesNurseBtn = new RadioButton();
            label5 = new Label();
            eCampusBtn = new RadioButton();
            nsccBtn = new RadioButton();
            label6 = new Label();
            courseNameTxt = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox6 = new GroupBox();
            noERateBtn = new RadioButton();
            label8 = new Label();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            resetButton = new Button();
            enrollmentGB.SuspendLayout();
            courseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)creditHrsBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(57, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter your name:";
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(192, 41);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(144, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(38, 88);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 2;
            label2.Text = "Type of Enrollment:";
            // 
            // label3
            // 
            label3.Location = new Point(29, 190);
            label3.Name = "label3";
            label3.Size = new Size(143, 19);
            label3.TabIndex = 6;
            label3.Text = "Are you dual-enrolled?";
            // 
            // yesDeBtn
            // 
            yesDeBtn.AutoSize = true;
            yesDeBtn.Location = new Point(18, 20);
            yesDeBtn.Margin = new Padding(3, 2, 3, 2);
            yesDeBtn.Name = "yesDeBtn";
            yesDeBtn.Size = new Size(42, 19);
            yesDeBtn.TabIndex = 7;
            yesDeBtn.TabStop = true;
            yesDeBtn.Text = "Yes";
            yesDeBtn.UseVisualStyleBackColor = true;
            // 
            // noDeBtn
            // 
            noDeBtn.AutoSize = true;
            noDeBtn.Location = new Point(74, 20);
            noDeBtn.Margin = new Padding(3, 2, 3, 2);
            noDeBtn.Name = "noDeBtn";
            noDeBtn.Size = new Size(41, 19);
            noDeBtn.TabIndex = 8;
            noDeBtn.TabStop = true;
            noDeBtn.Text = "No";
            noDeBtn.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(21, 230);
            confirmBtn.Margin = new Padding(3, 2, 3, 2);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(339, 42);
            confirmBtn.TabIndex = 9;
            confirmBtn.Text = "Confirm Information";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click_1;
            // 
            // enrollmentGB
            // 
            enrollmentGB.Controls.Add(inStateBtn);
            enrollmentGB.Controls.Add(outStateBtn);
            enrollmentGB.Location = new Point(192, 66);
            enrollmentGB.Margin = new Padding(3, 2, 3, 2);
            enrollmentGB.Name = "enrollmentGB";
            enrollmentGB.Padding = new Padding(3, 2, 3, 2);
            enrollmentGB.Size = new Size(144, 60);
            enrollmentGB.TabIndex = 21;
            enrollmentGB.TabStop = false;
            // 
            // inStateBtn
            // 
            inStateBtn.Location = new Point(16, 15);
            inStateBtn.Margin = new Padding(3, 2, 3, 2);
            inStateBtn.Name = "inStateBtn";
            inStateBtn.Size = new Size(128, 22);
            inStateBtn.TabIndex = 13;
            inStateBtn.TabStop = true;
            inStateBtn.Text = "In-State";
            inStateBtn.UseVisualStyleBackColor = true;
            inStateBtn.CheckedChanged += inStateBtn_CheckedChanged;
            // 
            // outStateBtn
            // 
            outStateBtn.Location = new Point(16, 39);
            outStateBtn.Margin = new Padding(3, 2, 3, 2);
            outStateBtn.Name = "outStateBtn";
            outStateBtn.Size = new Size(102, 18);
            outStateBtn.TabIndex = 14;
            outStateBtn.TabStop = true;
            outStateBtn.Text = "Out-of-State";
            outStateBtn.UseVisualStyleBackColor = true;
            outStateBtn.CheckedChanged += outStateBtn_CheckedChanged;
            // 
            // yesERateBtn
            // 
            yesERateBtn.Location = new Point(16, 14);
            yesERateBtn.Margin = new Padding(3, 2, 3, 2);
            yesERateBtn.Name = "yesERateBtn";
            yesERateBtn.Size = new Size(66, 18);
            yesERateBtn.TabIndex = 15;
            yesERateBtn.TabStop = true;
            yesERateBtn.Text = "Yes";
            yesERateBtn.UseVisualStyleBackColor = true;
            yesERateBtn.CheckedChanged += eRateBtn_CheckedChanged;
            // 
            // courseGroupBox
            // 
            courseGroupBox.Controls.Add(courseListBox);
            courseGroupBox.Location = new Point(361, 20);
            courseGroupBox.Margin = new Padding(3, 2, 3, 2);
            courseGroupBox.Name = "courseGroupBox";
            courseGroupBox.Padding = new Padding(3, 2, 3, 2);
            courseGroupBox.Size = new Size(156, 175);
            courseGroupBox.TabIndex = 36;
            courseGroupBox.TabStop = false;
            courseGroupBox.Text = "Enrolled Courses";
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.ItemHeight = 15;
            courseListBox.Location = new Point(15, 14);
            courseListBox.Margin = new Padding(3, 2, 3, 2);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(132, 154);
            courseListBox.TabIndex = 14;
            // 
            // receiptButton
            // 
            receiptButton.Location = new Point(376, 230);
            receiptButton.Margin = new Padding(3, 2, 3, 2);
            receiptButton.Name = "receiptButton";
            receiptButton.Size = new Size(131, 42);
            receiptButton.TabIndex = 35;
            receiptButton.Text = "Print Receipt";
            receiptButton.UseVisualStyleBackColor = true;
            receiptButton.Click += receiptButton_Click_1;
            // 
            // deleteCourseBtn
            // 
            deleteCourseBtn.Location = new Point(133, 230);
            deleteCourseBtn.Margin = new Padding(3, 2, 3, 2);
            deleteCourseBtn.Name = "deleteCourseBtn";
            deleteCourseBtn.Size = new Size(107, 42);
            deleteCourseBtn.TabIndex = 34;
            deleteCourseBtn.Text = "Delete Course";
            deleteCourseBtn.UseVisualStyleBackColor = true;
            deleteCourseBtn.Click += deleteCourseBtn_Click_1;
            // 
            // addCourseBtn
            // 
            addCourseBtn.Location = new Point(18, 230);
            addCourseBtn.Margin = new Padding(3, 2, 3, 2);
            addCourseBtn.Name = "addCourseBtn";
            addCourseBtn.Size = new Size(107, 42);
            addCourseBtn.TabIndex = 32;
            addCourseBtn.Text = "Add Course";
            addCourseBtn.UseVisualStyleBackColor = true;
            addCourseBtn.Click += addCourseBtn_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 153);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 31;
            label4.Text = "Credits:";
            // 
            // creditHrsBox
            // 
            creditHrsBox.Location = new Point(281, 170);
            creditHrsBox.Margin = new Padding(3, 2, 3, 2);
            creditHrsBox.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            creditHrsBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            creditHrsBox.Name = "creditHrsBox";
            creditHrsBox.Size = new Size(73, 23);
            creditHrsBox.TabIndex = 30;
            creditHrsBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // noNurseBtn
            // 
            noNurseBtn.AutoSize = true;
            noNurseBtn.Location = new Point(197, 16);
            noNurseBtn.Margin = new Padding(3, 2, 3, 2);
            noNurseBtn.Name = "noNurseBtn";
            noNurseBtn.Size = new Size(41, 19);
            noNurseBtn.TabIndex = 29;
            noNurseBtn.TabStop = true;
            noNurseBtn.Text = "No";
            noNurseBtn.UseVisualStyleBackColor = true;
            noNurseBtn.CheckedChanged += noNurseBtn_CheckedChanged_1;
            // 
            // yesNurseBtn
            // 
            yesNurseBtn.AutoSize = true;
            yesNurseBtn.Location = new Point(136, 16);
            yesNurseBtn.Margin = new Padding(3, 2, 3, 2);
            yesNurseBtn.Name = "yesNurseBtn";
            yesNurseBtn.Size = new Size(42, 19);
            yesNurseBtn.TabIndex = 28;
            yesNurseBtn.TabStop = true;
            yesNurseBtn.Text = "Yes";
            yesNurseBtn.UseVisualStyleBackColor = true;
            yesNurseBtn.CheckedChanged += yesNurseBtn_CheckedChanged_1;
            // 
            // label5
            // 
            label5.Location = new Point(16, 16);
            label5.Name = "label5";
            label5.Size = new Size(116, 27);
            label5.TabIndex = 27;
            label5.Text = "Nursing Course:";
            // 
            // eCampusBtn
            // 
            eCampusBtn.AutoSize = true;
            eCampusBtn.Location = new Point(197, 27);
            eCampusBtn.Margin = new Padding(3, 2, 3, 2);
            eCampusBtn.Name = "eCampusBtn";
            eCampusBtn.Size = new Size(93, 19);
            eCampusBtn.TabIndex = 26;
            eCampusBtn.TabStop = true;
            eCampusBtn.Text = "TN eCampus";
            eCampusBtn.UseVisualStyleBackColor = true;
            eCampusBtn.CheckedChanged += eCampusBtn_CheckedChanged_1;
            // 
            // nsccBtn
            // 
            nsccBtn.AutoSize = true;
            nsccBtn.Location = new Point(136, 27);
            nsccBtn.Margin = new Padding(3, 2, 3, 2);
            nsccBtn.Name = "nsccBtn";
            nsccBtn.Size = new Size(56, 19);
            nsccBtn.TabIndex = 25;
            nsccBtn.TabStop = true;
            nsccBtn.Text = "NSCC";
            nsccBtn.UseVisualStyleBackColor = true;
            nsccBtn.CheckedChanged += nsccBtn_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 28);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 24;
            label6.Text = "Select Course Type:";
            // 
            // courseNameTxt
            // 
            courseNameTxt.BorderStyle = BorderStyle.FixedSingle;
            courseNameTxt.Location = new Point(192, 56);
            courseNameTxt.Margin = new Padding(3, 2, 3, 2);
            courseNameTxt.Name = "courseNameTxt";
            courseNameTxt.Size = new Size(162, 23);
            courseNameTxt.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 56);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 22;
            label7.Text = "Enter the Course Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nsccBtn);
            groupBox1.Controls.Add(eCampusBtn);
            groupBox1.Location = new Point(18, 81);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(335, 61);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(yesNurseBtn);
            groupBox2.Controls.Add(noNurseBtn);
            groupBox2.Location = new Point(18, 146);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(254, 48);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(nameTextBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(confirmBtn);
            groupBox3.Controls.Add(enrollmentGB);
            groupBox3.Location = new Point(18, 9);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(382, 292);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Student Information";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(noERateBtn);
            groupBox6.Controls.Add(yesERateBtn);
            groupBox6.Location = new Point(192, 127);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(144, 40);
            groupBox6.TabIndex = 24;
            groupBox6.TabStop = false;
            // 
            // noERateBtn
            // 
            noERateBtn.AutoSize = true;
            noERateBtn.Location = new Point(87, 14);
            noERateBtn.Margin = new Padding(3, 2, 3, 2);
            noERateBtn.Name = "noERateBtn";
            noERateBtn.Size = new Size(41, 19);
            noERateBtn.TabIndex = 25;
            noERateBtn.TabStop = true;
            noERateBtn.Text = "No";
            noERateBtn.UseVisualStyleBackColor = true;
            noERateBtn.CheckedChanged += noERateBtn_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 141);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 23;
            label8.Text = "Are you eRate?";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(noDeBtn);
            groupBox5.Controls.Add(yesDeBtn);
            groupBox5.Location = new Point(192, 170);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(144, 48);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(resetButton);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(courseNameTxt);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Controls.Add(creditHrsBox);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(courseGroupBox);
            groupBox4.Controls.Add(addCourseBtn);
            groupBox4.Controls.Add(receiptButton);
            groupBox4.Controls.Add(deleteCourseBtn);
            groupBox4.Location = new Point(414, 9);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(529, 292);
            groupBox4.TabIndex = 40;
            groupBox4.TabStop = false;
            groupBox4.Text = "Course Information";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(247, 230);
            resetButton.Margin = new Padding(3, 2, 3, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(107, 42);
            resetButton.TabIndex = 39;
            resetButton.Text = "Reset Form";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 319);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Student Tuition Estimator";
            Load += Form1_Load_1;
            enrollmentGB.ResumeLayout(false);
            courseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)creditHrsBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private Label label3;
        private RadioButton yesDeBtn;
        private RadioButton noDeBtn;
        private Button confirmBtn;
        private GroupBox enrollmentGB;
        private RadioButton inStateBtn;
        private RadioButton outStateBtn;
        private RadioButton yesERateBtn;
        private GroupBox courseGroupBox;
        private ListBox courseListBox;
        private Button receiptButton;
        private Button deleteCourseBtn;
        private Button addCourseBtn;
        private Label label4;
        private NumericUpDown creditHrsBox;
        private RadioButton noNurseBtn;
        private RadioButton yesNurseBtn;
        private Label label5;
        private RadioButton eCampusBtn;
        private RadioButton nsccBtn;
        private Label label6;
        private TextBox courseNameTxt;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button resetButton;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private RadioButton noERateBtn;
        private Label label8;
    }
}