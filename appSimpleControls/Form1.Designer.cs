namespace appSimpleControls
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
            this.chkExample = new System.Windows.Forms.CheckBox();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkBread = new System.Windows.Forms.CheckBox();
            this.chkFruits = new System.Windows.Forms.CheckBox();
            this.chkSalad = new System.Windows.Forms.CheckBox();
            this.chkVeg = new System.Windows.Forms.CheckBox();
            this.txtShoppingList = new System.Windows.Forms.TextBox();
            this.btnShoppingList = new System.Windows.Forms.Button();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCard = new System.Windows.Forms.RadioButton();
            this.radVoucher = new System.Windows.Forms.RadioButton();
            this.radInPerson = new System.Windows.Forms.RadioButton();
            this.radCollect = new System.Windows.Forms.RadioButton();
            this.radHomeDelivery = new System.Windows.Forms.RadioButton();
            this.grbPayment = new System.Windows.Forms.GroupBox();
            this.btnShowPic = new System.Windows.Forms.Button();
            this.picPaymentType = new System.Windows.Forms.PictureBox();
            this.grbShoppingMethods = new System.Windows.Forms.GroupBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblShoppingMethods = new System.Windows.Forms.Label();
            this.grbPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaymentType)).BeginInit();
            this.grbShoppingMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkExample
            // 
            this.chkExample.AutoSize = true;
            this.chkExample.Location = new System.Drawing.Point(37, 37);
            this.chkExample.Name = "chkExample";
            this.chkExample.Size = new System.Drawing.Size(152, 24);
            this.chkExample.TabIndex = 0;
            this.chkExample.Text = "This is an Example";
            this.chkExample.UseVisualStyleBackColor = true;
            this.chkExample.CheckedChanged += new System.EventHandler(this.chkExample_CheckedChanged);
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(293, 37);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(159, 51);
            this.btnShowResult.TabIndex = 1;
            this.btnShowResult.Text = "Show Result";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(37, 82);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(202, 40);
            this.lblResult.TabIndex = 2;
            // 
            // chkBread
            // 
            this.chkBread.AutoSize = true;
            this.chkBread.Location = new System.Drawing.Point(19, 146);
            this.chkBread.Name = "chkBread";
            this.chkBread.Size = new System.Drawing.Size(70, 24);
            this.chkBread.TabIndex = 3;
            this.chkBread.Text = "Bread";
            this.chkBread.UseVisualStyleBackColor = true;
            this.chkBread.CheckedChanged += new System.EventHandler(this.chkBread_CheckedChanged);
            // 
            // chkFruits
            // 
            this.chkFruits.AutoSize = true;
            this.chkFruits.Location = new System.Drawing.Point(19, 176);
            this.chkFruits.Name = "chkFruits";
            this.chkFruits.Size = new System.Drawing.Size(60, 24);
            this.chkFruits.TabIndex = 4;
            this.chkFruits.Text = "Fruit";
            this.chkFruits.UseVisualStyleBackColor = true;
            this.chkFruits.CheckedChanged += new System.EventHandler(this.chkFruits_CheckedChanged);
            // 
            // chkSalad
            // 
            this.chkSalad.AutoSize = true;
            this.chkSalad.Location = new System.Drawing.Point(85, 146);
            this.chkSalad.Name = "chkSalad";
            this.chkSalad.Size = new System.Drawing.Size(68, 24);
            this.chkSalad.TabIndex = 5;
            this.chkSalad.Text = "Salad";
            this.chkSalad.UseVisualStyleBackColor = true;
            this.chkSalad.CheckedChanged += new System.EventHandler(this.chkSalad_CheckedChanged);
            // 
            // chkVeg
            // 
            this.chkVeg.AutoSize = true;
            this.chkVeg.Location = new System.Drawing.Point(85, 176);
            this.chkVeg.Name = "chkVeg";
            this.chkVeg.Size = new System.Drawing.Size(104, 24);
            this.chkVeg.TabIndex = 6;
            this.chkVeg.Text = "Vegetables";
            this.chkVeg.UseVisualStyleBackColor = true;
            this.chkVeg.CheckedChanged += new System.EventHandler(this.chkVeg_CheckedChanged);
            // 
            // txtShoppingList
            // 
            this.txtShoppingList.Location = new System.Drawing.Point(195, 125);
            this.txtShoppingList.Multiline = true;
            this.txtShoppingList.Name = "txtShoppingList";
            this.txtShoppingList.Size = new System.Drawing.Size(247, 175);
            this.txtShoppingList.TabIndex = 7;
            this.txtShoppingList.TextChanged += new System.EventHandler(this.txtShoppingList_TextChanged);
            // 
            // btnShoppingList
            // 
            this.btnShoppingList.Location = new System.Drawing.Point(234, 302);
            this.btnShoppingList.Name = "btnShoppingList";
            this.btnShoppingList.Size = new System.Drawing.Size(179, 33);
            this.btnShoppingList.TabIndex = 8;
            this.btnShoppingList.Text = "Shopping List";
            this.btnShoppingList.UseVisualStyleBackColor = true;
            this.btnShoppingList.Click += new System.EventHandler(this.btnShoppingList_Click);
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(13, 26);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(61, 24);
            this.radCash.TabIndex = 9;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            this.radCash.CheckedChanged += new System.EventHandler(this.radCash_CheckedChanged);
            // 
            // radCard
            // 
            this.radCard.AutoSize = true;
            this.radCard.Checked = true;
            this.radCard.Location = new System.Drawing.Point(13, 56);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(61, 24);
            this.radCard.TabIndex = 10;
            this.radCard.TabStop = true;
            this.radCard.Text = "Card";
            this.radCard.UseVisualStyleBackColor = true;
            this.radCard.CheckedChanged += new System.EventHandler(this.card_CheckedChanged);
            // 
            // radVoucher
            // 
            this.radVoucher.AutoSize = true;
            this.radVoucher.Location = new System.Drawing.Point(13, 86);
            this.radVoucher.Name = "radVoucher";
            this.radVoucher.Size = new System.Drawing.Size(83, 24);
            this.radVoucher.TabIndex = 11;
            this.radVoucher.Text = "Voucher";
            this.radVoucher.UseVisualStyleBackColor = true;
            this.radVoucher.CheckedChanged += new System.EventHandler(this.radVoucher_CheckedChanged);
            // 
            // radInPerson
            // 
            this.radInPerson.AutoSize = true;
            this.radInPerson.Location = new System.Drawing.Point(8, 24);
            this.radInPerson.Name = "radInPerson";
            this.radInPerson.Size = new System.Drawing.Size(157, 24);
            this.radInPerson.TabIndex = 12;
            this.radInPerson.Text = "In Person Shopping";
            this.radInPerson.UseVisualStyleBackColor = true;
            // 
            // radCollect
            // 
            this.radCollect.AutoSize = true;
            this.radCollect.Location = new System.Drawing.Point(6, 56);
            this.radCollect.Name = "radCollect";
            this.radCollect.Size = new System.Drawing.Size(131, 24);
            this.radCollect.TabIndex = 13;
            this.radCollect.Text = "Collect In Store";
            this.radCollect.UseVisualStyleBackColor = true;
            // 
            // radHomeDelivery
            // 
            this.radHomeDelivery.AutoSize = true;
            this.radHomeDelivery.Checked = true;
            this.radHomeDelivery.Location = new System.Drawing.Point(6, 86);
            this.radHomeDelivery.Name = "radHomeDelivery";
            this.radHomeDelivery.Size = new System.Drawing.Size(129, 24);
            this.radHomeDelivery.TabIndex = 14;
            this.radHomeDelivery.TabStop = true;
            this.radHomeDelivery.Text = "Home Delivery";
            this.radHomeDelivery.UseVisualStyleBackColor = true;
            this.radHomeDelivery.CheckedChanged += new System.EventHandler(this.radHomeDelivery_CheckedChanged);
            // 
            // grbPayment
            // 
            this.grbPayment.Controls.Add(this.btnShowPic);
            this.grbPayment.Controls.Add(this.picPaymentType);
            this.grbPayment.Controls.Add(this.radCash);
            this.grbPayment.Controls.Add(this.radCard);
            this.grbPayment.Controls.Add(this.radVoucher);
            this.grbPayment.Location = new System.Drawing.Point(498, 220);
            this.grbPayment.Name = "grbPayment";
            this.grbPayment.Size = new System.Drawing.Size(299, 161);
            this.grbPayment.TabIndex = 15;
            this.grbPayment.TabStop = false;
            this.grbPayment.Text = "Payment Type";
            this.grbPayment.Enter += new System.EventHandler(this.grbPayment_Enter);
            // 
            // btnShowPic
            // 
            this.btnShowPic.Location = new System.Drawing.Point(129, 134);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(109, 24);
            this.btnShowPic.TabIndex = 20;
            this.btnShowPic.Text = "Show Pic";
            this.btnShowPic.UseVisualStyleBackColor = true;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // picPaymentType
            // 
            this.picPaymentType.Location = new System.Drawing.Point(102, 26);
            this.picPaymentType.Name = "picPaymentType";
            this.picPaymentType.Size = new System.Drawing.Size(188, 84);
            this.picPaymentType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaymentType.TabIndex = 19;
            this.picPaymentType.TabStop = false;
            this.picPaymentType.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grbShoppingMethods
            // 
            this.grbShoppingMethods.Controls.Add(this.radInPerson);
            this.grbShoppingMethods.Controls.Add(this.radCollect);
            this.grbShoppingMethods.Controls.Add(this.radHomeDelivery);
            this.grbShoppingMethods.Location = new System.Drawing.Point(498, 12);
            this.grbShoppingMethods.Name = "grbShoppingMethods";
            this.grbShoppingMethods.Size = new System.Drawing.Size(163, 164);
            this.grbShoppingMethods.TabIndex = 16;
            this.grbShoppingMethods.TabStop = false;
            this.grbShoppingMethods.Text = "Shopping Methods";
            this.grbShoppingMethods.Enter += new System.EventHandler(this.grbShoppingMethods_Enter);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPaymentType.Location = new System.Drawing.Point(498, 399);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(238, 32);
            this.lblPaymentType.TabIndex = 17;
            this.lblPaymentType.Click += new System.EventHandler(this.lblPaymentType_Click);
            // 
            // lblShoppingMethods
            // 
            this.lblShoppingMethods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShoppingMethods.Location = new System.Drawing.Point(498, 185);
            this.lblShoppingMethods.Name = "lblShoppingMethods";
            this.lblShoppingMethods.Size = new System.Drawing.Size(163, 32);
            this.lblShoppingMethods.TabIndex = 18;
            this.lblShoppingMethods.Click += new System.EventHandler(this.lblShoppingMethods_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShoppingMethods);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.grbShoppingMethods);
            this.Controls.Add(this.grbPayment);
            this.Controls.Add(this.btnShoppingList);
            this.Controls.Add(this.txtShoppingList);
            this.Controls.Add(this.chkVeg);
            this.Controls.Add(this.chkSalad);
            this.Controls.Add(this.chkFruits);
            this.Controls.Add(this.chkBread);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.chkExample);
            this.Name = "frmMain";
            this.Text = "Some simple properties";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbPayment.ResumeLayout(false);
            this.grbPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaymentType)).EndInit();
            this.grbShoppingMethods.ResumeLayout(false);
            this.grbShoppingMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkExample;
        private Button btnShowResult;
        private Label lblResult;
        private CheckBox chkBread;
        private CheckBox chkFruits;
        private CheckBox chkSalad;
        private CheckBox chkVeg;
        private TextBox txtShoppingList;
        private Button btnShoppingList;
        private RadioButton radCash;
        private RadioButton radCard;
        private RadioButton radVoucher;
        private RadioButton radInPerson;
        private RadioButton radCollect;
        private RadioButton radHomeDelivery;
        private GroupBox grbPayment;
        private GroupBox grbShoppingMethods;
        private Label lblPaymentType;
        private Label lblShoppingMethods;
        private Button btnShowPic;
        private PictureBox picPaymentType;
    }
}