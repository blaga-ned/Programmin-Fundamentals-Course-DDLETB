namespace CarsDatabase
{
    partial class frmCars
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCars));
            System.Windows.Forms.Label vehicleRegNoLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label engineSizeLabel;
            System.Windows.Forms.Label dateRegisteredLabel;
            System.Windows.Forms.Label rentalPerDayLabel;
            System.Windows.Forms.Label availableLabel;
            this.hireDataSet = new CarsDatabase.HireDataSet();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarTableAdapter = new CarsDatabase.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            this.tblCarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblCarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vehicleRegNoTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.dateRegisteredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalPerDayTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblCurrentRecord = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            vehicleRegNoLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            engineSizeLabel = new System.Windows.Forms.Label();
            dateRegisteredLabel = new System.Windows.Forms.Label();
            rentalPerDayLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingNavigator)).BeginInit();
            this.tblCarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "tblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarTableAdapter = this.tblCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCarBindingNavigator
            // 
            this.tblCarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblCarBindingNavigator.BindingSource = this.tblCarBindingSource;
            this.tblCarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblCarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblCarBindingNavigatorSaveItem});
            this.tblCarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCarBindingNavigator.Name = "tblCarBindingNavigator";
            this.tblCarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCarBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblCarBindingNavigator.TabIndex = 0;
            this.tblCarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblCarBindingNavigatorSaveItem
            // 
            this.tblCarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblCarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblCarBindingNavigatorSaveItem.Image")));
            this.tblCarBindingNavigatorSaveItem.Name = "tblCarBindingNavigatorSaveItem";
            this.tblCarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblCarBindingNavigatorSaveItem.Text = "Save Data";
            this.tblCarBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblCarBindingNavigatorSaveItem_Click);
            // 
            // vehicleRegNoLabel
            // 
            vehicleRegNoLabel.AutoSize = true;
            vehicleRegNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vehicleRegNoLabel.Location = new System.Drawing.Point(30, 151);
            vehicleRegNoLabel.Name = "vehicleRegNoLabel";
            vehicleRegNoLabel.Size = new System.Drawing.Size(114, 18);
            vehicleRegNoLabel.TabIndex = 18;
            vehicleRegNoLabel.Text = "Vehicle Reg No:";
            // 
            // vehicleRegNoTextBox
            // 
            this.vehicleRegNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "VehicleRegNo", true));
            this.vehicleRegNoTextBox.Location = new System.Drawing.Point(198, 152);
            this.vehicleRegNoTextBox.Name = "vehicleRegNoTextBox";
            this.vehicleRegNoTextBox.Size = new System.Drawing.Size(119, 20);
            this.vehicleRegNoTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.vehicleRegNoTextBox, "Enter the vehicle registration number");
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            makeLabel.Location = new System.Drawing.Point(30, 177);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(49, 18);
            makeLabel.TabIndex = 19;
            makeLabel.Text = "Make:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(198, 178);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(265, 20);
            this.makeTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.makeTextBox, "Enter the make of the vehicle");
            // 
            // engineSizeLabel
            // 
            engineSizeLabel.AutoSize = true;
            engineSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            engineSizeLabel.Location = new System.Drawing.Point(30, 203);
            engineSizeLabel.Name = "engineSizeLabel";
            engineSizeLabel.Size = new System.Drawing.Size(90, 18);
            engineSizeLabel.TabIndex = 20;
            engineSizeLabel.Text = "Engine Size:";
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.engineSizeTextBox.Location = new System.Drawing.Point(198, 204);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.engineSizeTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.engineSizeTextBox, "Enter the engine size of the vehicle");
            // 
            // dateRegisteredLabel
            // 
            dateRegisteredLabel.AutoSize = true;
            dateRegisteredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateRegisteredLabel.Location = new System.Drawing.Point(30, 232);
            dateRegisteredLabel.Name = "dateRegisteredLabel";
            dateRegisteredLabel.Size = new System.Drawing.Size(118, 18);
            dateRegisteredLabel.TabIndex = 21;
            dateRegisteredLabel.Text = "Date Registered:";
            // 
            // dateRegisteredDateTimePicker
            // 
            this.dateRegisteredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCarBindingSource, "DateRegistered", true));
            this.dateRegisteredDateTimePicker.Location = new System.Drawing.Point(198, 230);
            this.dateRegisteredDateTimePicker.Name = "dateRegisteredDateTimePicker";
            this.dateRegisteredDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateRegisteredDateTimePicker.TabIndex = 4;
            // 
            // rentalPerDayLabel
            // 
            rentalPerDayLabel.AutoSize = true;
            rentalPerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rentalPerDayLabel.Location = new System.Drawing.Point(33, 258);
            rentalPerDayLabel.Name = "rentalPerDayLabel";
            rentalPerDayLabel.Size = new System.Drawing.Size(111, 18);
            rentalPerDayLabel.TabIndex = 22;
            rentalPerDayLabel.Text = "Rental Per Day:";
            rentalPerDayLabel.Click += new System.EventHandler(this.rentalPerDayLabel_Click);
            // 
            // rentalPerDayTextBox
            // 
            this.rentalPerDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalPerDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.rentalPerDayTextBox.Location = new System.Drawing.Point(198, 256);
            this.rentalPerDayTextBox.Name = "rentalPerDayTextBox";
            this.rentalPerDayTextBox.Size = new System.Drawing.Size(100, 20);
            this.rentalPerDayTextBox.TabIndex = 5;
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            availableLabel.Location = new System.Drawing.Point(33, 285);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(69, 18);
            availableLabel.TabIndex = 23;
            availableLabel.Text = "Available:";
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.availableCheckBox.Location = new System.Drawing.Point(198, 284);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(104, 24);
            this.availableCheckBox.TabIndex = 6;
            this.availableCheckBox.Text = "checkBox1";
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(226, 72);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(178, 24);
            this.lblHeading.TabIndex = 13;
            this.lblHeading.Text = "Bowman Car Hire";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(565, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(565, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(565, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(565, 232);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(565, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(565, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFirst.Location = new System.Drawing.Point(7, 408);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(95, 30);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrevious.Location = new System.Drawing.Point(111, 408);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(95, 30);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.Location = new System.Drawing.Point(295, 408);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 30);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLast.Location = new System.Drawing.Point(396, 408);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(95, 30);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblCurrentRecord
            // 
            this.lblCurrentRecord.BackColor = System.Drawing.Color.White;
            this.lblCurrentRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentRecord.Location = new System.Drawing.Point(214, 411);
            this.lblCurrentRecord.Name = "lblCurrentRecord";
            this.lblCurrentRecord.Size = new System.Drawing.Size(75, 25);
            this.lblCurrentRecord.TabIndex = 17;
            this.lblCurrentRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCurrentRecord);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(rentalPerDayLabel);
            this.Controls.Add(this.rentalPerDayTextBox);
            this.Controls.Add(dateRegisteredLabel);
            this.Controls.Add(this.dateRegisteredDateTimePicker);
            this.Controls.Add(engineSizeLabel);
            this.Controls.Add(this.engineSizeTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(vehicleRegNoLabel);
            this.Controls.Add(this.vehicleRegNoTextBox);
            this.Controls.Add(this.tblCarBindingNavigator);
            this.Name = "frmCars";
            this.Text = "Blaga Nedyalkova 02/11/2022";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingNavigator)).EndInit();
            this.tblCarBindingNavigator.ResumeLayout(false);
            this.tblCarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblCarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblCarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vehicleRegNoTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.DateTimePicker dateRegisteredDateTimePicker;
        private System.Windows.Forms.TextBox rentalPerDayTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblCurrentRecord;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

