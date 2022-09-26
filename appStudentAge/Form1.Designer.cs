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
            this.SuspendLayout();
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(137, 79);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.ShortcutsEnabled = false;
            this.txtStudentAge.Size = new System.Drawing.Size(267, 23);
            this.txtStudentAge.TabIndex = 0;
            this.txtStudentAge.TextChanged += new System.EventHandler(this.txtStudentAge_TextChanged);
            // 
            // btnIsChild
            // 
            this.btnIsChild.Location = new System.Drawing.Point(585, 114);
            this.btnIsChild.Name = "btnIsChild";
            this.btnIsChild.Size = new System.Drawing.Size(154, 90);
            this.btnIsChild.TabIndex = 1;
            this.btnIsChild.Text = "Check Type";
            this.btnIsChild.UseVisualStyleBackColor = true;
            this.btnIsChild.Click += new System.EventHandler(this.btnIsChild_Click);
            // 
            // lblStudentType
            // 
            this.lblStudentType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentType.Location = new System.Drawing.Point(137, 197);
            this.lblStudentType.Name = "lblStudentType";
            this.lblStudentType.Size = new System.Drawing.Size(267, 36);
            this.lblStudentType.TabIndex = 2;
            this.lblStudentType.Click += new System.EventHandler(this.lblStudentType_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(141, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Age";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(137, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Type";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}