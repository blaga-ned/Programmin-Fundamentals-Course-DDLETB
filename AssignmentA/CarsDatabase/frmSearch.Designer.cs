namespace CarsDatabase
{
    partial class frmSearch
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblField = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvCarsDataView = new System.Windows.Forms.DataGridView();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.lblValue);
            this.grbSearch.Controls.Add(this.lblOperator);
            this.grbSearch.Controls.Add(this.lblField);
            this.grbSearch.Controls.Add(this.txtValue);
            this.grbSearch.Controls.Add(this.cboOperator);
            this.grbSearch.Controls.Add(this.cboField);
            this.grbSearch.Location = new System.Drawing.Point(49, 56);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(477, 82);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "Make",
            "EngineSize",
            "RentalPerDay",
            "Available"});
            this.cboField.Location = new System.Drawing.Point(18, 41);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(139, 21);
            this.cboField.TabIndex = 0;
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">=  "});
            this.cboOperator.Location = new System.Drawing.Point(207, 41);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(72, 21);
            this.cboOperator.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(325, 42);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(121, 20);
            this.txtValue.TabIndex = 2;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.Location = new System.Drawing.Point(15, 22);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(38, 16);
            this.lblField.TabIndex = 3;
            this.lblField.Text = "Field";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(204, 22);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(61, 16);
            this.lblOperator.TabIndex = 4;
            this.lblOperator.Text = "Operator";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(322, 22);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(43, 16);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Value";
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Location = new System.Drawing.Point(564, 70);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(87, 28);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(564, 104);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvCarsDataView
            // 
            this.dgvCarsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarsDataView.Location = new System.Drawing.Point(49, 201);
            this.dgvCarsDataView.Name = "dgvCarsDataView";
            this.dgvCarsDataView.Size = new System.Drawing.Size(477, 164);
            this.dgvCarsDataView.TabIndex = 3;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCarsDataView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.grbSearch);
            this.Name = "frmSearch";
            this.Text = "Blaga Nedyalkova 02/11/2022";
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCarsDataView;
    }
}