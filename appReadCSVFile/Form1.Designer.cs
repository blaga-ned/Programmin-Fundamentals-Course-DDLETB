namespace appReadCSVFile
{
    partial class frmMain
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.txtStudentPosition = new System.Windows.Forms.TextBox();
            this.lblStudentPosition = new System.Windows.Forms.Label();
            this.lblFirstNameDisplay = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastNameDisplay = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAgeDisplay = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStudentFullDetailsDisplayed = new System.Windows.Forms.Label();
            this.lblFullDetails = new System.Windows.Forms.Label();
            this.lblNumberOfStudentsDisplay = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtIntroduction = new System.Windows.Forms.TextBox();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.btnDisplayIntroduction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(268, 26);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(134, 44);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read Student File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 15;
            this.lstStudents.Location = new System.Drawing.Point(268, 94);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(171, 169);
            this.lstStudents.TabIndex = 2;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // txtStudentPosition
            // 
            this.txtStudentPosition.Location = new System.Drawing.Point(565, 94);
            this.txtStudentPosition.Name = "txtStudentPosition";
            this.txtStudentPosition.Size = new System.Drawing.Size(95, 23);
            this.txtStudentPosition.TabIndex = 3;
            this.txtStudentPosition.TextChanged += new System.EventHandler(this.txtStudentPosition_TextChanged);
            // 
            // lblStudentPosition
            // 
            this.lblStudentPosition.AutoSize = true;
            this.lblStudentPosition.Location = new System.Drawing.Point(565, 76);
            this.lblStudentPosition.Name = "lblStudentPosition";
            this.lblStudentPosition.Size = new System.Drawing.Size(95, 15);
            this.lblStudentPosition.TabIndex = 4;
            this.lblStudentPosition.Text = "Enter Student ID:";
            // 
            // lblFirstNameDisplay
            // 
            this.lblFirstNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstNameDisplay.Location = new System.Drawing.Point(534, 281);
            this.lblFirstNameDisplay.Name = "lblFirstNameDisplay";
            this.lblFirstNameDisplay.Size = new System.Drawing.Size(128, 23);
            this.lblFirstNameDisplay.TabIndex = 6;
            this.lblFirstNameDisplay.Click += new System.EventHandler(this.lblFirstNameDisplay_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(681, 289);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblLastNameDisplay
            // 
            this.lblLastNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastNameDisplay.Location = new System.Drawing.Point(534, 328);
            this.lblLastNameDisplay.Name = "lblLastNameDisplay";
            this.lblLastNameDisplay.Size = new System.Drawing.Size(128, 23);
            this.lblLastNameDisplay.TabIndex = 8;
            this.lblLastNameDisplay.Click += new System.EventHandler(this.lblLastNameDisplay_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(681, 336);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAgeDisplay
            // 
            this.lblAgeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgeDisplay.Location = new System.Drawing.Point(534, 376);
            this.lblAgeDisplay.Name = "lblAgeDisplay";
            this.lblAgeDisplay.Size = new System.Drawing.Size(128, 22);
            this.lblAgeDisplay.TabIndex = 10;
            this.lblAgeDisplay.Click += new System.EventHandler(this.lblAgeDisplay_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(681, 377);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(34, 15);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age: ";
            // 
            // lblStudentFullDetailsDisplayed
            // 
            this.lblStudentFullDetailsDisplayed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentFullDetailsDisplayed.Location = new System.Drawing.Point(534, 240);
            this.lblStudentFullDetailsDisplayed.Name = "lblStudentFullDetailsDisplayed";
            this.lblStudentFullDetailsDisplayed.Size = new System.Drawing.Size(254, 23);
            this.lblStudentFullDetailsDisplayed.TabIndex = 13;
            this.lblStudentFullDetailsDisplayed.Click += new System.EventHandler(this.lblStudentFullDetailsDisplayed_Click);
            // 
            // lblFullDetails
            // 
            this.lblFullDetails.AutoSize = true;
            this.lblFullDetails.Location = new System.Drawing.Point(534, 210);
            this.lblFullDetails.Name = "lblFullDetails";
            this.lblFullDetails.Size = new System.Drawing.Size(165, 15);
            this.lblFullDetails.TabIndex = 14;
            this.lblFullDetails.Text = "Student Full Details Displayed:";
            // 
            // lblNumberOfStudentsDisplay
            // 
            this.lblNumberOfStudentsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfStudentsDisplay.Location = new System.Drawing.Point(268, 276);
            this.lblNumberOfStudentsDisplay.Name = "lblNumberOfStudentsDisplay";
            this.lblNumberOfStudentsDisplay.Size = new System.Drawing.Size(166, 28);
            this.lblNumberOfStudentsDisplay.TabIndex = 15;
            this.lblNumberOfStudentsDisplay.Click += new System.EventHandler(this.lblNumberOfStudentsDisplay_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(268, 318);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(73, 37);
            this.btnSort.TabIndex = 16;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.Location = new System.Drawing.Point(25, 27);
            this.txtIntroduction.Multiline = true;
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.Size = new System.Drawing.Size(178, 411);
            this.txtIntroduction.TabIndex = 17;
            this.txtIntroduction.TextChanged += new System.EventHandler(this.txtIntroduction_TextChanged);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(25, 9);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(105, 15);
            this.lblIntroduction.TabIndex = 18;
            this.lblIntroduction.Text = "Make Introduction";
            this.lblIntroduction.Click += new System.EventHandler(this.lblIntroduction_Click);
            // 
            // btnDisplayIntroduction
            // 
            this.btnDisplayIntroduction.Location = new System.Drawing.Point(209, 396);
            this.btnDisplayIntroduction.Name = "btnDisplayIntroduction";
            this.btnDisplayIntroduction.Size = new System.Drawing.Size(107, 42);
            this.btnDisplayIntroduction.TabIndex = 19;
            this.btnDisplayIntroduction.Text = "Display";
            this.btnDisplayIntroduction.UseVisualStyleBackColor = true;
            this.btnDisplayIntroduction.Click += new System.EventHandler(this.btnDisplayIntroduction_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayIntroduction);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.txtIntroduction);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblNumberOfStudentsDisplay);
            this.Controls.Add(this.lblFullDetails);
            this.Controls.Add(this.lblStudentFullDetailsDisplayed);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAgeDisplay);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLastNameDisplay);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblFirstNameDisplay);
            this.Controls.Add(this.lblStudentPosition);
            this.Controls.Add(this.txtStudentPosition);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnRead);
            this.Name = "frmMain";
            this.Text = "Read Data from CSV File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRead;
        private ListBox lstStudents;
        private TextBox txtStudentPosition;
        private Label lblStudentPosition;
        private Label lblFirstNameDisplay;
        private Label lblFirstName;
        private Label lblLastNameDisplay;
        private Label lblLastName;
        private Label lblAgeDisplay;
        private Label lblAge;
        private Label lblStudentFullDetailsDisplayed;
        private Label lblFullDetails;
        private Label lblNumberOfStudentsDisplay;
        private Button btnSort;
        private TextBox txtIntroduction;
        private Label lblIntroduction;
        private Button btnDisplayIntroduction;
    }
}