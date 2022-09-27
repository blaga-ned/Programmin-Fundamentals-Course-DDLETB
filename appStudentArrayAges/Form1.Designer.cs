namespace appStudentArrayAges
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
            this.btnGetStudentAge = new System.Windows.Forms.Button();
            this.btnShowStudentAge = new System.Windows.Forms.Button();
            this.txtStudentDetails = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetStudentAge
            // 
            this.btnGetStudentAge.Location = new System.Drawing.Point(55, 23);
            this.btnGetStudentAge.Name = "btnGetStudentAge";
            this.btnGetStudentAge.Size = new System.Drawing.Size(180, 81);
            this.btnGetStudentAge.TabIndex = 0;
            this.btnGetStudentAge.Text = "Enter Student Ages";
            this.btnGetStudentAge.UseVisualStyleBackColor = true;
            this.btnGetStudentAge.Click += new System.EventHandler(this.btnGetStudentAge_Click);
            // 
            // btnShowStudentAge
            // 
            this.btnShowStudentAge.Location = new System.Drawing.Point(55, 110);
            this.btnShowStudentAge.Name = "btnShowStudentAge";
            this.btnShowStudentAge.Size = new System.Drawing.Size(180, 81);
            this.btnShowStudentAge.TabIndex = 1;
            this.btnShowStudentAge.Text = "Show Student Age";
            this.btnShowStudentAge.UseVisualStyleBackColor = true;
            this.btnShowStudentAge.Click += new System.EventHandler(this.btnShowStudentAge_Click);
            // 
            // txtStudentDetails
            // 
            this.txtStudentDetails.Location = new System.Drawing.Point(203, 279);
            this.txtStudentDetails.Multiline = true;
            this.txtStudentDetails.Name = "txtStudentDetails";
            this.txtStudentDetails.ReadOnly = true;
            this.txtStudentDetails.Size = new System.Drawing.Size(348, 122);
            this.txtStudentDetails.TabIndex = 3;
            this.txtStudentDetails.TextChanged += new System.EventHandler(this.txtStudentDetails_TextChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(55, 197);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(180, 81);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 75);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtStudentDetails);
            this.Controls.Add(this.btnShowStudentAge);
            this.Controls.Add(this.btnGetStudentAge);
            this.Name = "frmMain";
            this.Text = "Get and display student age";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetStudentAge;
        private Button btnShowStudentAge;
        private TextBox txtStudentDetails;
        private Button btnDisplay;
        private Button btnSave;
    }
}