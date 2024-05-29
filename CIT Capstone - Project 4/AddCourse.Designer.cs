namespace CIT_Capstone___Project_4
{
    partial class AddCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.courseNameLbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inPersonBtn = new System.Windows.Forms.RadioButton();
            this.eCampusBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.yesNurseBtn = new System.Windows.Forms.RadioButton();
            this.noNurseBtn = new System.Windows.Forms.RadioButton();
            this.creditHrsBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.courseGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.creditHrsBox)).BeginInit();
            this.courseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Course Name:";
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.Location = new System.Drawing.Point(261, 55);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(125, 27);
            this.courseNameLbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Course Type:";
            // 
            // inPersonBtn
            // 
            this.inPersonBtn.AutoSize = true;
            this.inPersonBtn.Location = new System.Drawing.Point(261, 122);
            this.inPersonBtn.Name = "inPersonBtn";
            this.inPersonBtn.Size = new System.Drawing.Size(91, 24);
            this.inPersonBtn.TabIndex = 3;
            this.inPersonBtn.TabStop = true;
            this.inPersonBtn.Text = "In-Person";
            this.inPersonBtn.UseVisualStyleBackColor = true;
            // 
            // eCampusBtn
            // 
            this.eCampusBtn.AutoSize = true;
            this.eCampusBtn.Location = new System.Drawing.Point(358, 122);
            this.eCampusBtn.Name = "eCampusBtn";
            this.eCampusBtn.Size = new System.Drawing.Size(114, 24);
            this.eCampusBtn.TabIndex = 4;
            this.eCampusBtn.TabStop = true;
            this.eCampusBtn.Text = "TN eCampus";
            this.eCampusBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(80, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "Is your in-person course a nursing course?";
            // 
            // yesNurseBtn
            // 
            this.yesNurseBtn.AutoSize = true;
            this.yesNurseBtn.Location = new System.Drawing.Point(261, 185);
            this.yesNurseBtn.Name = "yesNurseBtn";
            this.yesNurseBtn.Size = new System.Drawing.Size(51, 24);
            this.yesNurseBtn.TabIndex = 6;
            this.yesNurseBtn.TabStop = true;
            this.yesNurseBtn.Text = "Yes";
            this.yesNurseBtn.UseVisualStyleBackColor = true;
            // 
            // noNurseBtn
            // 
            this.noNurseBtn.AutoSize = true;
            this.noNurseBtn.Location = new System.Drawing.Point(355, 185);
            this.noNurseBtn.Name = "noNurseBtn";
            this.noNurseBtn.Size = new System.Drawing.Size(50, 24);
            this.noNurseBtn.TabIndex = 7;
            this.noNurseBtn.TabStop = true;
            this.noNurseBtn.Text = "No";
            this.noNurseBtn.UseVisualStyleBackColor = true;
            // 
            // creditHrsBox
            // 
            this.creditHrsBox.Location = new System.Drawing.Point(261, 270);
            this.creditHrsBox.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.creditHrsBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.creditHrsBox.Name = "creditHrsBox";
            this.creditHrsBox.Size = new System.Drawing.Size(43, 27);
            this.creditHrsBox.TabIndex = 8;
            this.creditHrsBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "# of Credit Hours";
            // 
            // addClassBtn
            // 
            this.addClassBtn.Location = new System.Drawing.Point(109, 369);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(94, 29);
            this.addClassBtn.TabIndex = 10;
            this.addClassBtn.Text = "Add Course";
            this.addClassBtn.UseVisualStyleBackColor = true;
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.Location = new System.Drawing.Point(234, 369);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(94, 29);
            this.editCourseBtn.TabIndex = 11;
            this.editCourseBtn.Text = "Edit Course";
            this.editCourseBtn.UseVisualStyleBackColor = true;
            // 
            // deleteCourseBtn
            // 
            this.deleteCourseBtn.Location = new System.Drawing.Point(355, 369);
            this.deleteCourseBtn.Name = "deleteCourseBtn";
            this.deleteCourseBtn.Size = new System.Drawing.Size(123, 29);
            this.deleteCourseBtn.TabIndex = 12;
            this.deleteCourseBtn.Text = "Delete Course";
            this.deleteCourseBtn.UseVisualStyleBackColor = true;
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(508, 369);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(118, 29);
            this.receiptButton.TabIndex = 13;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 20;
            this.courseListBox.Location = new System.Drawing.Point(17, 19);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(150, 104);
            this.courseListBox.TabIndex = 14;
            // 
            // courseGroupBox
            // 
            this.courseGroupBox.Controls.Add(this.courseListBox);
            this.courseGroupBox.Location = new System.Drawing.Point(454, 223);
            this.courseGroupBox.Name = "courseGroupBox";
            this.courseGroupBox.Size = new System.Drawing.Size(187, 125);
            this.courseGroupBox.TabIndex = 15;
            this.courseGroupBox.TabStop = false;
            this.courseGroupBox.Text = "Enrolled Courses";
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseGroupBox);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.deleteCourseBtn);
            this.Controls.Add(this.editCourseBtn);
            this.Controls.Add(this.addClassBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creditHrsBox);
            this.Controls.Add(this.noNurseBtn);
            this.Controls.Add(this.yesNurseBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eCampusBtn);
            this.Controls.Add(this.inPersonBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseNameLbl);
            this.Controls.Add(this.label1);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            ((System.ComponentModel.ISupportInitialize)(this.creditHrsBox)).EndInit();
            this.courseGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox courseNameLbl;
        private Label label2;
        private RadioButton inPersonBtn;
        private RadioButton eCampusBtn;
        private Label label3;
        private RadioButton yesNurseBtn;
        private RadioButton noNurseBtn;
        private NumericUpDown creditHrsBox;
        private Label label4;
        private Button addClassBtn;
        private Button editCourseBtn;
        private Button deleteCourseBtn;
        private Button receiptButton;
        private ListBox courseListBox;
        private GroupBox courseGroupBox;
    }
}