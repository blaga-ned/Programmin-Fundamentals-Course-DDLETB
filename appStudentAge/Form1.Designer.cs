namespace appStudenAge
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
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.btnIsChild = new System.Windows.Forms.Button();
            this.lblStudentType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInputAge = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(81, 82);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.ShortcutsEnabled = false;
            this.txtStudentAge.Size = new System.Drawing.Size(267, 23);
            this.txtStudentAge.TabIndex = 0;
            this.txtStudentAge.TextChanged += new System.EventHandler(this.txtStudentAge_TextChanged);
            // 
            // btnIsChild
            // 
            this.btnIsChild.Location = new System.Drawing.Point(81, 111);
            this.btnIsChild.Name = "btnIsChild";
            this.btnIsChild.Size = new System.Drawing.Size(154, 51);
            this.btnIsChild.TabIndex = 1;
            this.btnIsChild.Text = "Check Type";
            this.btnIsChild.UseVisualStyleBackColor = true;
            this.btnIsChild.Click += new System.EventHandler(this.btnIsChild_Click);
            // 
            // lblStudentType
            // 
            this.lblStudentType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentType.Location = new System.Drawing.Point(81, 227);
            this.lblStudentType.Name = "lblStudentType";
            this.lblStudentType.Size = new System.Drawing.Size(267, 36);
            this.lblStudentType.TabIndex = 2;
            this.lblStudentType.Click += new System.EventHandler(this.lblStudentType_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(81, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the age of the student:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(81, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Type";
            // 
            // btnInputAge
            // 
            this.btnInputAge.Location = new System.Drawing.Point(640, 82);
            this.btnInputAge.Name = "btnInputAge";
            this.btnInputAge.Size = new System.Drawing.Size(148, 51);
            this.btnInputAge.TabIndex = 5;
            this.btnInputAge.Text = "Input Box";
            this.btnInputAge.UseVisualStyleBackColor = true;
            this.btnInputAge.Click += new System.EventHandler(this.btnInputAge_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(491, 139);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ShortcutsEnabled = false;
            this.txtResults.Size = new System.Drawing.Size(297, 161);
            this.txtResults.TabIndex = 6;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnInputAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentType);
            this.Controls.Add(this.btnIsChild);
            this.Controls.Add(this.txtStudentAge);
            this.Name = "frmMain";
            this.Text = "Calculate Student Type based on Age";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtStudentAge;
        private Button btnIsChild;
        private Label lblStudentType;
        private Label label1;
        private Label label2;
        private Button btnInputAge;
        private TextBox txtResults;
    }
}