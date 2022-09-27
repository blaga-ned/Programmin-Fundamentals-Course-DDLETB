namespace appReadTextFile
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
            this.btnReadTextFile = new System.Windows.Forms.Button();
            this.txtTextBoxDisplay = new System.Windows.Forms.TextBox();
            this.btnWriteTextFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadTextFile
            // 
            this.btnReadTextFile.Location = new System.Drawing.Point(604, 75);
            this.btnReadTextFile.Name = "btnReadTextFile";
            this.btnReadTextFile.Size = new System.Drawing.Size(172, 69);
            this.btnReadTextFile.TabIndex = 0;
            this.btnReadTextFile.Text = "Read Text File";
            this.btnReadTextFile.UseVisualStyleBackColor = true;
            this.btnReadTextFile.Click += new System.EventHandler(this.btnReadTextFile_Click);
            // 
            // txtTextBoxDisplay
            // 
            this.txtTextBoxDisplay.Location = new System.Drawing.Point(60, 163);
            this.txtTextBoxDisplay.Multiline = true;
            this.txtTextBoxDisplay.Name = "txtTextBoxDisplay";
            this.txtTextBoxDisplay.Size = new System.Drawing.Size(716, 264);
            this.txtTextBoxDisplay.TabIndex = 1;
            this.txtTextBoxDisplay.TextChanged += new System.EventHandler(this.txtTextBoxDisplay_TextChanged);
            // 
            // btnWriteTextFile
            // 
            this.btnWriteTextFile.Location = new System.Drawing.Point(609, 458);
            this.btnWriteTextFile.Name = "btnWriteTextFile";
            this.btnWriteTextFile.Size = new System.Drawing.Size(167, 68);
            this.btnWriteTextFile.TabIndex = 2;
            this.btnWriteTextFile.Text = "Write Text File";
            this.btnWriteTextFile.UseVisualStyleBackColor = true;
            this.btnWriteTextFile.Click += new System.EventHandler(this.btnWriteTextFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.btnWriteTextFile);
            this.Controls.Add(this.txtTextBoxDisplay);
            this.Controls.Add(this.btnReadTextFile);
            this.Name = "frmMain";
            this.Text = "Display File Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReadTextFile;
        private TextBox txtTextBoxDisplay;
        private Button btnWriteTextFile;
    }
}