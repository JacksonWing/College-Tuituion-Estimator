namespace CIT_Capstone___Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Course> courseList = new List<Course>(); // Creates list to store added course objects
        int costRate;                                 // Creates reference variables
        string dualEnrollment;
        string courseName;
        bool courseType; // nscc = false, eCampus = true
        bool nursing;
        int creditHours;
        int techFee;
        int regFee;
        int totalCost;
        int semesterFees = 21; // Semester fees encompasses Program Service Fee, SGA fee, and Student Activity Fee.
        int costBeforeFee;
        int nurserFee;
        int onlineAccFee;


        private void Form1_Load_1(object sender, EventArgs e) // Disables form objects for form functionality
        {
            courseNameTxt.Enabled = false;
            nsccBtn.Enabled = false;
            eCampusBtn.Enabled = false;
            yesNurseBtn.Enabled = false;
            noNurseBtn.Enabled = false;
            creditHrsBox.Enabled = false;
            addCourseBtn.Enabled = false;
            deleteCourseBtn.Enabled = false;
            receiptButton.Enabled = false;
        }
        private void confirmBtn_Click_1(object sender, EventArgs e)
        {
            // Checks to see if all user input in the student information section is not empty before continuing
            if (nameTextBox.Text != string.Empty && (inStateBtn.Checked || outStateBtn.Checked) && (yesERateBtn.Checked || noERateBtn.Checked) && (yesDeBtn.Checked || noDeBtn.Checked))
            {
                nameTextBox.Enabled = false;           // Switches form over to the course information section by
                inStateBtn.Enabled = false;            //  disabling and enabling certain form objects
                outStateBtn.Enabled = false;
                yesERateBtn.Enabled = false;
                noERateBtn.Enabled = false;
                yesDeBtn.Enabled = false;
                noDeBtn.Enabled = false;
                confirmBtn.Enabled = false;

                courseNameTxt.Enabled = true;
                nsccBtn.Enabled = true;
                eCampusBtn.Enabled = true;
                yesNurseBtn.Enabled = true;
                noNurseBtn.Enabled = true;
                creditHrsBox.Enabled = true;
                addCourseBtn.Enabled = true;
                deleteCourseBtn.Enabled = true;
                receiptButton.Enabled = true;

                if (yesERateBtn.Checked)
                {
                    yesNurseBtn.Enabled = false;
                    noNurseBtn.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Error! Missing Input.");
            }
        }

        private void addCourseBtn_Click_1(object sender, EventArgs e)
        {
            // Checks to see if all fields have input before assigning values
            if (courseNameTxt.Text != string.Empty && (nsccBtn.Checked || eCampusBtn.Checked) && (yesNurseBtn.Checked || noNurseBtn.Checked))
            {
                courseName = courseNameTxt.Text;
                if (nsccBtn.Checked)
                {
                    courseType = false;
                }
                else
                {
                    courseType = true;
                }
                if (yesNurseBtn.Checked)
                {
                    nursing = true;
                }
                else
                {
                    nursing = false;
                }
                creditHours = (int)creditHrsBox.Value;

                // Creates new instance of a Course and passes values to an all argument constructor
                Course newCourse = new Course(courseName, courseType, nursing, creditHours); 

                courseListBox.Items.Add(newCourse.CourseName); // Adds object to list and listbox
                courseList.Add(newCourse);

                courseNameTxt.Text = string.Empty; // Resets course info input
                nsccBtn.Checked = false;
                eCampusBtn.Checked = false;
                yesNurseBtn.Checked = false;
                noNurseBtn.Checked = false;
                creditHrsBox.Value = 1;

                if (yesERateBtn.Checked)
                {
                    eCampusBtn.Checked = true;
                    noNurseBtn.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Error: Missing Input.");
            }
        }

        private void deleteCourseBtn_Click_1(object sender, EventArgs e) // Deletes list element and reloads the listbox
        {
            var p = courseListBox.SelectedIndex;
            var i = courseListBox.Text;
            courseList.RemoveAt(p);
            courseListBox.Items.Remove(i);

            courseListBox.Items.Clear();
            foreach (Course elements in courseList)
            {
                courseListBox.Items.Add(elements.CourseName);
            }
        }

        private void receiptButton_Click_1(object sender, EventArgs e) // Prints the total cost
        {
            int totalCreditHours = 0;
            int totalNurseHours = 0;

            foreach (Course elements in courseList) // Loops to see total of credit hours and nursing credit hours
            {
                if (elements.Nursing == true)
                {
                    totalNurseHours += elements.CreditHours;
                }

                totalCreditHours += elements.CreditHours;
            }

            if (inStateBtn.Checked)      // Calculates receipt based on in-state values and formulas
            {
                int nurseTotal = totalNurseHours * 25;
                int techAccessFee = 10;
                int registrationFee = 31;

                costRate = 176;
                techAccessFee *= totalCreditHours;
                registrationFee += (totalCreditHours * 10) - 10;
                costBeforeFee = costRate * totalCreditHours;
                totalCost = costBeforeFee + techAccessFee;
                totalCost += nurseTotal;
                totalCost += registrationFee;
                if (noERateBtn.Checked) // If eRate is selected the code is skipped
                {
                    if (totalCreditHours >= 12) // Factors in maximum values for fees and rate changes for cost
                    {
                        totalCost = costRate * 12;
                        techAccessFee = 116;
                        registrationFee = 137;
                        int creditDiff = totalCreditHours - 12;
                        creditDiff *= 38;
                        costBeforeFee = totalCost + creditDiff;
                        totalCost += creditDiff + techAccessFee + registrationFee + nurseTotal;
                    }
                }

                if (totalCreditHours >= 12)  // Factors in maximum values for fees
                {
                    techAccessFee = 116;
                    registrationFee = 137;
                }

                techFee = techAccessFee;
                regFee = registrationFee;
                nurserFee = nurseTotal;
            }
            if (outStateBtn.Checked)     // Calculates receipt based on in-state values and formulas
            {
                int nurseTotal = totalNurseHours * 25;
                int techAccessFee = 10;
                int registrationFee = 31;

                costRate = 726;

                int count = 0;
                int numNSCC = 0;
                foreach(Course elements in courseList)  // If all course are NSCC, change the cost rate
                {
                    if(elements.CourseType == false)
                    {
                        numNSCC++;
                    }
                    count++;
                }
                if((count == numNSCC) && yesERateBtn.Checked)
                {
                    costRate = 264;
                }

                techAccessFee *= totalCreditHours;
                registrationFee += (totalCreditHours * 10) - 10;
                costBeforeFee = costRate * totalCreditHours;
                totalCost = costBeforeFee + techAccessFee;
                totalCost += registrationFee;
                totalCost += nurseTotal;
                if (noERateBtn.Checked) // If eRate is selected the code is skipped
                {
                    if (totalCreditHours >= 12)  // Factors in maximum values for fees and rate changes for cost
                    {
                        totalCost = costRate * 12;
                        techAccessFee = 116;
                        registrationFee = 137;
                        int creditDiff = totalCreditHours - 12;
                        creditDiff *= 148;
                        costBeforeFee = totalCost + creditDiff;
                        totalCost += creditDiff + techAccessFee + registrationFee + nurseTotal;
                    }
                }
                if (totalCreditHours >= 12) // Factors in maximum values for fees
                {
                    techAccessFee = 116;
                    registrationFee = 137;
                }
                techFee = techAccessFee;
                regFee = registrationFee;
                nurserFee = nurseTotal;
            }
            if (yesERateBtn.Checked)  // eRate online access fee applied
            {
                int onlineAccessFee = 70;
                onlineAccessFee *= totalCreditHours;
                totalCost += onlineAccessFee;
                onlineAccFee = onlineAccessFee;
            }
            if (noDeBtn.Checked)  // Checks for dual-enrollment and adds fees if not
            {
                dualEnrollment = "Student is not dual-enrolled.";
                totalCost += semesterFees;
            }
            if (yesDeBtn.Checked)
            {
                dualEnrollment = "Student is dual-enrolled.";
                semesterFees = 0;
            }
            MessageBox.Show("Name: " + nameTextBox.Text + // Prints receipt
                "\r\n" + dualEnrollment +
                "\r\nAmount of credits: " + totalCreditHours +
                "\r\nCost Before Fees: " + costBeforeFee.ToString("C") +
                "\r\nTechnology Access Fee: " + techFee.ToString("C") +
                "\r\nRegistration Fees: " + regFee.ToString("C") +
                "\r\nSemester Fees: " + semesterFees.ToString("C") +
                "\r\nOnline Access Fee: " + onlineAccFee.ToString("C") +
                "\r\nNursing Fees (If Applicable): " + nurserFee.ToString("C") +
                "\r\nTotal Cost including fees: " + totalCost.ToString("C"), "Receipt"); ;
        }

        private void resetButton_Click(object sender, EventArgs e) //Resets entire form
        {
            nameTextBox.Text= string.Empty;
            inStateBtn.Checked= false;
            outStateBtn.Checked= false;
            yesERateBtn.Checked= false;
            noERateBtn.Checked= false;
            yesDeBtn.Checked= false;
            noDeBtn.Checked= false;
            courseNameTxt.Text= string.Empty;
            nsccBtn.Checked= false;
            eCampusBtn.Checked= false;
            yesNurseBtn.Checked= false;
            noNurseBtn.Checked= false;
            creditHrsBox.Value = 1;
            courseList.Clear();
            courseListBox.Items.Clear();

            nameTextBox.Enabled = true;
            inStateBtn.Enabled = true;
            outStateBtn.Enabled = true;
            yesERateBtn.Enabled = true;
            noERateBtn.Enabled = true;
            yesDeBtn.Enabled = true;
            noDeBtn.Enabled = true;
            confirmBtn.Enabled = true;

            courseNameTxt.Enabled = false;
            nsccBtn.Enabled = false;
            eCampusBtn.Enabled = false;
            yesNurseBtn.Enabled = false;
            noNurseBtn.Enabled = false;
            creditHrsBox.Enabled = false;
            addCourseBtn.Enabled = false;
            deleteCourseBtn.Enabled = false;
            receiptButton.Enabled = false;

        }

        // All form event handlers below dictate input to restrict faulty user input.
        // Example: You cannot select eCampus and Yes to nursing course.

        private void nsccBtn_CheckedChanged(object sender, EventArgs e)
        {
            yesNurseBtn.Enabled = true;
            if(yesERateBtn.Checked)
            {
                yesNurseBtn.Enabled = false;
            }
        }

        private void eCampusBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            yesNurseBtn.Enabled = false;
            noNurseBtn.Checked = true;
        }

        private void yesNurseBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            nsccBtn.Checked = true;
            eCampusBtn.Enabled = false;
        }

        private void noNurseBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            eCampusBtn.Enabled = true;
        }

        private void inStateBtn_CheckedChanged(object sender, EventArgs e)
        {
            yesDeBtn.Enabled= true;
        }

        private void outStateBtn_CheckedChanged(object sender, EventArgs e)
        {
            yesDeBtn.Enabled= false;
            noDeBtn.Checked= true;
        }

        private void eRateBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void noERateBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }

}