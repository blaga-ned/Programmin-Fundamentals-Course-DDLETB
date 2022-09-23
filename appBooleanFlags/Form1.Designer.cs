namespace appBooleanFlags
{
    partial class formMain
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEqualsFlag = new System.Windows.Forms.Label();
            this.lblGreaterThanFlag = new System.Windows.Forms.Label();
            this.lblLessThanFlag = new System.Windows.Forms.Label();
            this.lblGreaterOrEqualsFlag = new System.Windows.Forms.Label();
            this.lblLessOrEqualsFlag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(153, 60);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(126, 23);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(332, 60);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(129, 23);
            this.txtNumber2.TabIndex = 1;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(495, 56);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(119, 28);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "&Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number 1 equals Number 2:";
            // 
            // lblEqualsFlag
            // 
            this.lblEqualsFlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEqualsFlag.Location = new System.Drawing.Point(332, 112);
            this.lblEqualsFlag.Name = "lblEqualsFlag";
            this.lblEqualsFlag.Size = new System.Drawing.Size(127, 23);
            this.lblEqualsFlag.TabIndex = 4;
            this.lblEqualsFlag.Click += new System.EventHandler(this.lblEqualsFlag_Click);
            // 
            // lblGreaterThanFlag
            // 
            this.lblGreaterThanFlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGreaterThanFlag.Location = new System.Drawing.Point(331, 160);
            this.lblGreaterThanFlag.Name = "lblGreaterThanFlag";
            this.lblGreaterThanFlag.Size = new System.Drawing.Size(127, 23);
            this.lblGreaterThanFlag.TabIndex = 5;
            // 
            // lblLessThanFlag
            // 
            this.lblLessThanFlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLessThanFlag.Location = new System.Drawing.Point(331, 208);
            this.lblLessThanFlag.Name = "lblLessThanFlag";
            this.lblLessThanFlag.Size = new System.Drawing.Size(127, 23);
            this.lblLessThanFlag.TabIndex = 6;
            // 
            // lblGreaterOrEqualsFlag
            // 
            this.lblGreaterOrEqualsFlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGreaterOrEqualsFlag.Location = new System.Drawing.Point(331, 244);
            this.lblGreaterOrEqualsFlag.Name = "lblGreaterOrEqualsFlag";
            this.lblGreaterOrEqualsFlag.Size = new System.Drawing.Size(127, 23);
            this.lblGreaterOrEqualsFlag.TabIndex = 7;
            // 
            // lblLessOrEqualsFlag
            // 
            this.lblLessOrEqualsFlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLessOrEqualsFlag.Location = new System.Drawing.Point(332, 284);
            this.lblLessOrEqualsFlag.Name = "lblLessOrEqualsFlag";
            this.lblLessOrEqualsFlag.Size = new System.Drawing.Size(127, 23);
            this.lblLessOrEqualsFlag.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number 1 grater than Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number 1 less than Number2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Number 1 is greater of equal to Number 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number 1 is less or equal to Number 2:";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLessOrEqualsFlag);
            this.Controls.Add(this.lblGreaterOrEqualsFlag);
            this.Controls.Add(this.lblLessThanFlag);
            this.Controls.Add(this.lblGreaterThanFlag);
            this.Controls.Add(this.lblEqualsFlag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "formMain";
            this.Text = "Comparing Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnCompare;
        private Label label1;
        private Label lblEqualsFlag;
        private Label lblGreaterThanFlag;
        private Label lblLessThanFlag;
        private Label lblGreaterOrEqualsFlag;
        private Label lblLessOrEqualsFlag;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}