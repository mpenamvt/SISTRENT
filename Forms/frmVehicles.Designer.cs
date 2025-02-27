namespace SISTRENT.Forms
{
    partial class frmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp4 = new System.Windows.Forms.TabPage();
            this.cmdDeletePrice = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtPriceVehicleId = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.vPriceRange2 = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.vDay2 = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.vDay1 = new System.Windows.Forms.NumericUpDown();
            this.vPriceRange1 = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.cmdCancelPrice = new System.Windows.Forms.Button();
            this.cmdSavePrice = new System.Windows.Forms.Button();
            this.cmdAddPrice = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgPrices = new System.Windows.Forms.DataGridView();
            this.PriceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayRange1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayRange2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dtPrices = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.txtPriceId = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.vInsuranceAmount = new System.Windows.Forms.NumericUpDown();
            this.dpInsurenceExpiractionDate = new System.Windows.Forms.DateTimePicker();
            this.txtPolicy = new System.Windows.Forms.TextBox();
            this.cmbInsurences = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dpPlateExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dpNextInspectionDate = new System.Windows.Forms.DateTimePicker();
            this.dpNextServiceDate = new System.Windows.Forms.DateTimePicker();
            this.dpLastServiceDate = new System.Windows.Forms.DateTimePicker();
            this.vIntervalMileage = new System.Windows.Forms.NumericUpDown();
            this.vLastMileage = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.cmdCancelSpent = new System.Windows.Forms.Button();
            this.cmdSaveSpent = new System.Windows.Forms.Button();
            this.cmdAddSpent = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmdSpentFindCancel = new System.Windows.Forms.Button();
            this.btnFindExpensse = new System.Windows.Forms.Button();
            this.dpSpentDate2 = new System.Windows.Forms.DateTimePicker();
            this.label40 = new System.Windows.Forms.Label();
            this.dpSpentDate1 = new System.Windows.Forms.DateTimePicker();
            this.label39 = new System.Windows.Forms.Label();
            this.dgSpents = new System.Windows.Forms.DataGridView();
            this.txtSpentNote = new System.Windows.Forms.TextBox();
            this.vSpentAmount = new System.Windows.Forms.NumericUpDown();
            this.dpSpentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSpentType = new System.Windows.Forms.ComboBox();
            this.txtIdSpent = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdDeletePic = new System.Windows.Forms.Button();
            this.cmdLoadPic = new System.Windows.Forms.Button();
            this.picVehicle = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.vPrice5A = new System.Windows.Forms.NumericUpDown();
            this.vPrice4A = new System.Windows.Forms.NumericUpDown();
            this.vPrice3A = new System.Windows.Forms.NumericUpDown();
            this.vPrice2A = new System.Windows.Forms.NumericUpDown();
            this.vPrice1A = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.vPrice5 = new System.Windows.Forms.NumericUpDown();
            this.vPrice4 = new System.Windows.Forms.NumericUpDown();
            this.vPrice3 = new System.Windows.Forms.NumericUpDown();
            this.vPrice2 = new System.Windows.Forms.NumericUpDown();
            this.vPrice1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dpAcqDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTrans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbModels = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.txtVehicleId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.openPic = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vPriceRange2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPriceRange1)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrices)).BeginInit();
            this.tp1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vInsuranceAmount)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIntervalMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLastMileage)).BeginInit();
            this.tp2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSpentAmount)).BeginInit();
            this.tp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice5A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice4A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice3A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice2A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice1A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.dgConsulta);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cmbYears);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.txtDescription);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.txtMileage);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.dpAcqDate);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.cmbOwner);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.cmbStatus);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.cmbFuel);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.cmbTrans);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.cmbClasses);
            this.splitContainer1.Panel2.Controls.Add(this.txtColor);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.cmbModels);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtChassis);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtPlate);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cmbBrand);
            this.splitContainer1.Panel2.Controls.Add(this.txtVehicleId);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 745);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cmbFiltros);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(12, 57);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 22);
            this.txtBuscar.TabIndex = 36;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 14);
            this.label21.TabIndex = 23;
            this.label21.Text = "Filtrar por:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltros.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Location = new System.Drawing.Point(77, 29);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(235, 22);
            this.cmbFiltros.TabIndex = 22;
            // 
            // dgConsulta
            // 
            this.dgConsulta.AllowUserToAddRows = false;
            this.dgConsulta.AllowUserToDeleteRows = false;
            this.dgConsulta.AllowUserToResizeColumns = false;
            this.dgConsulta.AllowUserToResizeRows = false;
            this.dgConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Location = new System.Drawing.Point(3, 123);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.ReadOnly = true;
            this.dgConsulta.RowHeadersVisible = false;
            this.dgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConsulta.Size = new System.Drawing.Size(369, 619);
            this.dgConsulta.TabIndex = 4;
            this.dgConsulta.Click += new System.EventHandler(this.dgConsulta_Click);
            // 
            // cmbYears
            // 
            this.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYears.Enabled = false;
            this.cmbYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(344, 100);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(121, 22);
            this.cmbYears.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 417);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(730, 298);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otras Informaciones:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tp4);
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Controls.Add(this.tp3);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 277);
            this.tabControl1.TabIndex = 0;
            // 
            // tp4
            // 
            this.tp4.Controls.Add(this.cmdDeletePrice);
            this.tp4.Controls.Add(this.txtPriceVehicleId);
            this.tp4.Controls.Add(this.groupBox9);
            this.tp4.Controls.Add(this.cmdCancelPrice);
            this.tp4.Controls.Add(this.cmdSavePrice);
            this.tp4.Controls.Add(this.cmdAddPrice);
            this.tp4.Controls.Add(this.groupBox8);
            this.tp4.Controls.Add(this.txtPriceId);
            this.tp4.Controls.Add(this.label47);
            this.tp4.Location = new System.Drawing.Point(4, 23);
            this.tp4.Name = "tp4";
            this.tp4.Padding = new System.Windows.Forms.Padding(3);
            this.tp4.Size = new System.Drawing.Size(710, 250);
            this.tp4.TabIndex = 3;
            this.tp4.Text = "Precios";
            this.tp4.UseVisualStyleBackColor = true;
            // 
            // cmdDeletePrice
            // 
            this.cmdDeletePrice.Enabled = false;
            this.cmdDeletePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeletePrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeletePrice.ImageIndex = 2;
            this.cmdDeletePrice.ImageList = this.imageList1;
            this.cmdDeletePrice.Location = new System.Drawing.Point(232, 11);
            this.cmdDeletePrice.Name = "cmdDeletePrice";
            this.cmdDeletePrice.Size = new System.Drawing.Size(35, 23);
            this.cmdDeletePrice.TabIndex = 35;
            this.toolTip1.SetToolTip(this.cmdDeletePrice, "Eliminar registro de precio");
            this.cmdDeletePrice.UseVisualStyleBackColor = true;
            this.cmdDeletePrice.Click += new System.EventHandler(this.cmdDeletePrice_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "car_front_vehicle_icon.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "accept.png");
            this.imageList1.Images.SetKeyName(4, "book_go.png");
            this.imageList1.Images.SetKeyName(5, "1320591123_Shleves.ico");
            this.imageList1.Images.SetKeyName(6, "1320591262_33.ico");
            this.imageList1.Images.SetKeyName(7, "1320591556_truck.ico");
            this.imageList1.Images.SetKeyName(8, "1320590675_Badge-plus.ico");
            this.imageList1.Images.SetKeyName(9, "Cancelar_Rojo.png");
            this.imageList1.Images.SetKeyName(10, "find.png");
            this.imageList1.Images.SetKeyName(11, "save_as.png");
            this.imageList1.Images.SetKeyName(12, "6035_exit_icon.png");
            // 
            // txtPriceVehicleId
            // 
            this.txtPriceVehicleId.Location = new System.Drawing.Point(37, 32);
            this.txtPriceVehicleId.Name = "txtPriceVehicleId";
            this.txtPriceVehicleId.ReadOnly = true;
            this.txtPriceVehicleId.Size = new System.Drawing.Size(66, 22);
            this.txtPriceVehicleId.TabIndex = 34;
            this.txtPriceVehicleId.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.vPriceRange2);
            this.groupBox9.Controls.Add(this.label41);
            this.groupBox9.Controls.Add(this.vDay2);
            this.groupBox9.Controls.Add(this.label46);
            this.groupBox9.Controls.Add(this.vDay1);
            this.groupBox9.Controls.Add(this.vPriceRange1);
            this.groupBox9.Controls.Add(this.label44);
            this.groupBox9.Controls.Add(this.label45);
            this.groupBox9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(18, 60);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(257, 180);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Precio por rango de dias:";
            // 
            // vPriceRange2
            // 
            this.vPriceRange2.DecimalPlaces = 2;
            this.vPriceRange2.Enabled = false;
            this.vPriceRange2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPriceRange2.Location = new System.Drawing.Point(97, 117);
            this.vPriceRange2.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPriceRange2.Name = "vPriceRange2";
            this.vPriceRange2.Size = new System.Drawing.Size(122, 22);
            this.vPriceRange2.TabIndex = 3;
            this.vPriceRange2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPriceRange2.ThousandsSeparator = true;
            this.vPriceRange2.Enter += new System.EventHandler(this.vPriceRange2_Enter);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(11, 121);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 14);
            this.label41.TabIndex = 41;
            this.label41.Text = "Precio Inv.:";
            // 
            // vDay2
            // 
            this.vDay2.Enabled = false;
            this.vDay2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vDay2.Location = new System.Drawing.Point(97, 63);
            this.vDay2.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.vDay2.Name = "vDay2";
            this.vDay2.Size = new System.Drawing.Size(84, 22);
            this.vDay2.TabIndex = 1;
            this.vDay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vDay2.ThousandsSeparator = true;
            this.vDay2.Enter += new System.EventHandler(this.vDay2_Enter);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(11, 35);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(45, 14);
            this.label46.TabIndex = 38;
            this.label46.Text = "Desde:";
            // 
            // vDay1
            // 
            this.vDay1.Enabled = false;
            this.vDay1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vDay1.Location = new System.Drawing.Point(97, 33);
            this.vDay1.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.vDay1.Name = "vDay1";
            this.vDay1.Size = new System.Drawing.Size(84, 22);
            this.vDay1.TabIndex = 0;
            this.vDay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vDay1.ThousandsSeparator = true;
            this.vDay1.Enter += new System.EventHandler(this.vDay1_Enter);
            // 
            // vPriceRange1
            // 
            this.vPriceRange1.DecimalPlaces = 2;
            this.vPriceRange1.Enabled = false;
            this.vPriceRange1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPriceRange1.Location = new System.Drawing.Point(97, 89);
            this.vPriceRange1.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPriceRange1.Name = "vPriceRange1";
            this.vPriceRange1.Size = new System.Drawing.Size(122, 22);
            this.vPriceRange1.TabIndex = 2;
            this.vPriceRange1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPriceRange1.ThousandsSeparator = true;
            this.vPriceRange1.Enter += new System.EventHandler(this.vPriceRange1_Enter);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(11, 93);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(80, 14);
            this.label44.TabIndex = 35;
            this.label44.Text = "Precio Renta:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(11, 65);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 14);
            this.label45.TabIndex = 36;
            this.label45.Text = "Hasta:";
            // 
            // cmdCancelPrice
            // 
            this.cmdCancelPrice.Enabled = false;
            this.cmdCancelPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelPrice.ImageIndex = 6;
            this.cmdCancelPrice.ImageList = this.imageList1;
            this.cmdCancelPrice.Location = new System.Drawing.Point(191, 11);
            this.cmdCancelPrice.Name = "cmdCancelPrice";
            this.cmdCancelPrice.Size = new System.Drawing.Size(35, 23);
            this.cmdCancelPrice.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cmdCancelPrice, "Cancelar registro de gasto");
            this.cmdCancelPrice.UseVisualStyleBackColor = true;
            this.cmdCancelPrice.Click += new System.EventHandler(this.cmdCancelPrice_Click);
            // 
            // cmdSavePrice
            // 
            this.cmdSavePrice.Enabled = false;
            this.cmdSavePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSavePrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSavePrice.ImageIndex = 11;
            this.cmdSavePrice.ImageList = this.imageList1;
            this.cmdSavePrice.Location = new System.Drawing.Point(150, 12);
            this.cmdSavePrice.Name = "cmdSavePrice";
            this.cmdSavePrice.Size = new System.Drawing.Size(35, 23);
            this.cmdSavePrice.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmdSavePrice, "Grabar registro de gasto");
            this.cmdSavePrice.UseVisualStyleBackColor = true;
            this.cmdSavePrice.Click += new System.EventHandler(this.cmdSavePrice_Click);
            // 
            // cmdAddPrice
            // 
            this.cmdAddPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddPrice.ImageIndex = 8;
            this.cmdAddPrice.ImageList = this.imageList1;
            this.cmdAddPrice.Location = new System.Drawing.Point(109, 12);
            this.cmdAddPrice.Name = "cmdAddPrice";
            this.cmdAddPrice.Size = new System.Drawing.Size(35, 23);
            this.cmdAddPrice.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmdAddPrice, "Agregar registro de gasto");
            this.cmdAddPrice.UseVisualStyleBackColor = true;
            this.cmdAddPrice.Click += new System.EventHandler(this.cmdAddPrice_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.dgPrices);
            this.groupBox8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(281, 9);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(415, 231);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Listado de Precios:";
            // 
            // dgPrices
            // 
            this.dgPrices.AllowUserToAddRows = false;
            this.dgPrices.AllowUserToDeleteRows = false;
            this.dgPrices.AllowUserToResizeColumns = false;
            this.dgPrices.AllowUserToResizeRows = false;
            this.dgPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPrices.AutoGenerateColumns = false;
            this.dgPrices.BackgroundColor = System.Drawing.Color.White;
            this.dgPrices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceId,
            this.VehicleId,
            this.DayRange1,
            this.DayRange2,
            this.Price1,
            this.Price2});
            this.dgPrices.DataMember = "dtPrices";
            this.dgPrices.DataSource = this.dataSet1;
            this.dgPrices.Location = new System.Drawing.Point(6, 51);
            this.dgPrices.Name = "dgPrices";
            this.dgPrices.ReadOnly = true;
            this.dgPrices.RowHeadersVisible = false;
            this.dgPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPrices.Size = new System.Drawing.Size(403, 174);
            this.dgPrices.TabIndex = 8;
            this.dgPrices.Click += new System.EventHandler(this.dgPrices_Click);
            // 
            // PriceId
            // 
            this.PriceId.DataPropertyName = "Priceid";
            this.PriceId.HeaderText = "Id";
            this.PriceId.Name = "PriceId";
            this.PriceId.ReadOnly = true;
            this.PriceId.Width = 50;
            // 
            // VehicleId
            // 
            this.VehicleId.DataPropertyName = "VehicleId";
            this.VehicleId.HeaderText = "VehicleId";
            this.VehicleId.Name = "VehicleId";
            this.VehicleId.ReadOnly = true;
            this.VehicleId.Visible = false;
            // 
            // DayRange1
            // 
            this.DayRange1.DataPropertyName = "DayRange1";
            this.DayRange1.HeaderText = "Desde";
            this.DayRange1.Name = "DayRange1";
            this.DayRange1.ReadOnly = true;
            this.DayRange1.Width = 75;
            // 
            // DayRange2
            // 
            this.DayRange2.DataPropertyName = "DayRange2";
            this.DayRange2.HeaderText = "Hasta";
            this.DayRange2.Name = "DayRange2";
            this.DayRange2.ReadOnly = true;
            this.DayRange2.Width = 75;
            // 
            // Price1
            // 
            this.Price1.DataPropertyName = "Price1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Price1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price1.HeaderText = "Precio Renta";
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
            // 
            // Price2
            // 
            this.Price2.DataPropertyName = "Price2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.Price2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price2.HeaderText = "Precio Inv";
            this.Price2.Name = "Price2";
            this.Price2.ReadOnly = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtPrices});
            // 
            // dtPrices
            // 
            this.dtPrices.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtPrices.TableName = "dtPrices";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Priceid";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "VehicleId";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "DayRange1";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "DayRange2";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Price1";
            this.dataColumn5.DataType = typeof(decimal);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Price2";
            this.dataColumn6.DataType = typeof(decimal);
            // 
            // txtPriceId
            // 
            this.txtPriceId.Location = new System.Drawing.Point(37, 12);
            this.txtPriceId.Name = "txtPriceId";
            this.txtPriceId.ReadOnly = true;
            this.txtPriceId.Size = new System.Drawing.Size(66, 22);
            this.txtPriceId.TabIndex = 20;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(15, 16);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(22, 14);
            this.label47.TabIndex = 26;
            this.label47.Text = "Id:";
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.groupBox6);
            this.tp1.Controls.Add(this.groupBox5);
            this.tp1.Location = new System.Drawing.Point(4, 23);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(710, 250);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Datos de Mantenimiento:";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.vInsuranceAmount);
            this.groupBox6.Controls.Add(this.dpInsurenceExpiractionDate);
            this.groupBox6.Controls.Add(this.txtPolicy);
            this.groupBox6.Controls.Add(this.cmbInsurences);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(374, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 201);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Seguro:";
            // 
            // vInsuranceAmount
            // 
            this.vInsuranceAmount.DecimalPlaces = 2;
            this.vInsuranceAmount.Enabled = false;
            this.vInsuranceAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vInsuranceAmount.Location = new System.Drawing.Point(145, 125);
            this.vInsuranceAmount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vInsuranceAmount.Name = "vInsuranceAmount";
            this.vInsuranceAmount.Size = new System.Drawing.Size(120, 22);
            this.vInsuranceAmount.TabIndex = 10;
            this.vInsuranceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vInsuranceAmount.ThousandsSeparator = true;
            // 
            // dpInsurenceExpiractionDate
            // 
            this.dpInsurenceExpiractionDate.Enabled = false;
            this.dpInsurenceExpiractionDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInsurenceExpiractionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpInsurenceExpiractionDate.Location = new System.Drawing.Point(147, 92);
            this.dpInsurenceExpiractionDate.Name = "dpInsurenceExpiractionDate";
            this.dpInsurenceExpiractionDate.Size = new System.Drawing.Size(120, 22);
            this.dpInsurenceExpiractionDate.TabIndex = 9;
            // 
            // txtPolicy
            // 
            this.txtPolicy.Enabled = false;
            this.txtPolicy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolicy.Location = new System.Drawing.Point(145, 58);
            this.txtPolicy.Name = "txtPolicy";
            this.txtPolicy.Size = new System.Drawing.Size(172, 22);
            this.txtPolicy.TabIndex = 8;
            // 
            // cmbInsurences
            // 
            this.cmbInsurences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsurences.Enabled = false;
            this.cmbInsurences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInsurences.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInsurences.FormattingEnabled = true;
            this.cmbInsurences.Location = new System.Drawing.Point(77, 30);
            this.cmbInsurences.Name = "cmbInsurences";
            this.cmbInsurences.Size = new System.Drawing.Size(244, 22);
            this.cmbInsurences.TabIndex = 7;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(11, 129);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(109, 14);
            this.label33.TabIndex = 7;
            this.label33.Text = "Monto de la Poliza:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(11, 94);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(133, 14);
            this.label32.TabIndex = 7;
            this.label32.Text = "Fecha de Vencimiento:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(11, 63);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 14);
            this.label31.TabIndex = 7;
            this.label31.Text = "Número Poliza:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(11, 33);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 14);
            this.label30.TabIndex = 7;
            this.label30.Text = "Seguro:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dpPlateExpirationDate);
            this.groupBox5.Controls.Add(this.dpNextInspectionDate);
            this.groupBox5.Controls.Add(this.dpNextServiceDate);
            this.groupBox5.Controls.Add(this.dpLastServiceDate);
            this.groupBox5.Controls.Add(this.vIntervalMileage);
            this.groupBox5.Controls.Add(this.vLastMileage);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(14, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 201);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mantenimiento:";
            // 
            // dpPlateExpirationDate
            // 
            this.dpPlateExpirationDate.Enabled = false;
            this.dpPlateExpirationDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpPlateExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpPlateExpirationDate.Location = new System.Drawing.Point(188, 159);
            this.dpPlateExpirationDate.Name = "dpPlateExpirationDate";
            this.dpPlateExpirationDate.Size = new System.Drawing.Size(122, 22);
            this.dpPlateExpirationDate.TabIndex = 6;
            // 
            // dpNextInspectionDate
            // 
            this.dpNextInspectionDate.Enabled = false;
            this.dpNextInspectionDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNextInspectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNextInspectionDate.Location = new System.Drawing.Point(188, 131);
            this.dpNextInspectionDate.Name = "dpNextInspectionDate";
            this.dpNextInspectionDate.Size = new System.Drawing.Size(122, 22);
            this.dpNextInspectionDate.TabIndex = 5;
            // 
            // dpNextServiceDate
            // 
            this.dpNextServiceDate.Enabled = false;
            this.dpNextServiceDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNextServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNextServiceDate.Location = new System.Drawing.Point(188, 107);
            this.dpNextServiceDate.Name = "dpNextServiceDate";
            this.dpNextServiceDate.Size = new System.Drawing.Size(122, 22);
            this.dpNextServiceDate.TabIndex = 4;
            // 
            // dpLastServiceDate
            // 
            this.dpLastServiceDate.Enabled = false;
            this.dpLastServiceDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpLastServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpLastServiceDate.Location = new System.Drawing.Point(188, 82);
            this.dpLastServiceDate.Name = "dpLastServiceDate";
            this.dpLastServiceDate.Size = new System.Drawing.Size(122, 22);
            this.dpLastServiceDate.TabIndex = 3;
            // 
            // vIntervalMileage
            // 
            this.vIntervalMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vIntervalMileage.Enabled = false;
            this.vIntervalMileage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vIntervalMileage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vIntervalMileage.Location = new System.Drawing.Point(186, 55);
            this.vIntervalMileage.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.vIntervalMileage.Name = "vIntervalMileage";
            this.vIntervalMileage.Size = new System.Drawing.Size(120, 22);
            this.vIntervalMileage.TabIndex = 2;
            this.vIntervalMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vLastMileage
            // 
            this.vLastMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vLastMileage.Enabled = false;
            this.vLastMileage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vLastMileage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vLastMileage.Location = new System.Drawing.Point(186, 31);
            this.vLastMileage.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.vLastMileage.Name = "vLastMileage";
            this.vLastMileage.Size = new System.Drawing.Size(120, 22);
            this.vLastMileage.TabIndex = 1;
            this.vLastMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(22, 161);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(138, 14);
            this.label29.TabIndex = 1;
            this.label29.Text = "Fecha vencto. de Placa:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(22, 133);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(151, 14);
            this.label28.TabIndex = 2;
            this.label28.Text = "Fecha Proxima Inspeccion:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(22, 109);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(135, 14);
            this.label27.TabIndex = 3;
            this.label27.Text = "Fecha Proximo Servicio:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(22, 84);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(126, 14);
            this.label26.TabIndex = 4;
            this.label26.Text = "Fecha Ultimo Servicio:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(22, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(155, 14);
            this.label25.TabIndex = 5;
            this.label25.Text = "Intervalo de KMs de Mant.:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(22, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 14);
            this.label24.TabIndex = 6;
            this.label24.Text = "Ultimo Kilomentraje:";
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.cmdCancelSpent);
            this.tp2.Controls.Add(this.cmdSaveSpent);
            this.tp2.Controls.Add(this.cmdAddSpent);
            this.tp2.Controls.Add(this.groupBox7);
            this.tp2.Controls.Add(this.txtSpentNote);
            this.tp2.Controls.Add(this.vSpentAmount);
            this.tp2.Controls.Add(this.dpSpentDate);
            this.tp2.Controls.Add(this.cmbSpentType);
            this.tp2.Controls.Add(this.txtIdSpent);
            this.tp2.Controls.Add(this.label38);
            this.tp2.Controls.Add(this.label37);
            this.tp2.Controls.Add(this.label36);
            this.tp2.Controls.Add(this.label35);
            this.tp2.Controls.Add(this.label34);
            this.tp2.Location = new System.Drawing.Point(4, 23);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(710, 250);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Gastos";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // cmdCancelSpent
            // 
            this.cmdCancelSpent.Enabled = false;
            this.cmdCancelSpent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelSpent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelSpent.ImageIndex = 6;
            this.cmdCancelSpent.ImageList = this.imageList1;
            this.cmdCancelSpent.Location = new System.Drawing.Point(195, 14);
            this.cmdCancelSpent.Name = "cmdCancelSpent";
            this.cmdCancelSpent.Size = new System.Drawing.Size(35, 23);
            this.cmdCancelSpent.TabIndex = 16;
            this.toolTip1.SetToolTip(this.cmdCancelSpent, "Cancelar registro de gasto");
            this.cmdCancelSpent.UseVisualStyleBackColor = true;
            this.cmdCancelSpent.Click += new System.EventHandler(this.cmdCancelSpent_Click);
            // 
            // cmdSaveSpent
            // 
            this.cmdSaveSpent.Enabled = false;
            this.cmdSaveSpent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveSpent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveSpent.ImageIndex = 11;
            this.cmdSaveSpent.ImageList = this.imageList1;
            this.cmdSaveSpent.Location = new System.Drawing.Point(154, 15);
            this.cmdSaveSpent.Name = "cmdSaveSpent";
            this.cmdSaveSpent.Size = new System.Drawing.Size(35, 23);
            this.cmdSaveSpent.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cmdSaveSpent, "Grabar registro de gasto");
            this.cmdSaveSpent.UseVisualStyleBackColor = true;
            this.cmdSaveSpent.Click += new System.EventHandler(this.cmdSaveSpent_Click);
            // 
            // cmdAddSpent
            // 
            this.cmdAddSpent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddSpent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddSpent.ImageIndex = 8;
            this.cmdAddSpent.ImageList = this.imageList1;
            this.cmdAddSpent.Location = new System.Drawing.Point(113, 15);
            this.cmdAddSpent.Name = "cmdAddSpent";
            this.cmdAddSpent.Size = new System.Drawing.Size(35, 23);
            this.cmdAddSpent.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cmdAddSpent, "Agregar registro de gasto");
            this.cmdAddSpent.UseVisualStyleBackColor = true;
            this.cmdAddSpent.Click += new System.EventHandler(this.cmdAddSpent_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.cmdSpentFindCancel);
            this.groupBox7.Controls.Add(this.btnFindExpensse);
            this.groupBox7.Controls.Add(this.dpSpentDate2);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.dpSpentDate1);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.dgSpents);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(329, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(371, 231);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Listado de Gastos:";
            // 
            // cmdSpentFindCancel
            // 
            this.cmdSpentFindCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSpentFindCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSpentFindCancel.ImageIndex = 6;
            this.cmdSpentFindCancel.ImageList = this.imageList1;
            this.cmdSpentFindCancel.Location = new System.Drawing.Point(190, 50);
            this.cmdSpentFindCancel.Name = "cmdSpentFindCancel";
            this.cmdSpentFindCancel.Size = new System.Drawing.Size(35, 23);
            this.cmdSpentFindCancel.TabIndex = 17;
            this.toolTip1.SetToolTip(this.cmdSpentFindCancel, "Cancelar filtro de busqueda");
            this.cmdSpentFindCancel.UseVisualStyleBackColor = true;
            this.cmdSpentFindCancel.Click += new System.EventHandler(this.cmdSpentFindCancel_Click);
            // 
            // btnFindExpensse
            // 
            this.btnFindExpensse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindExpensse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindExpensse.ImageIndex = 10;
            this.btnFindExpensse.ImageList = this.imageList1;
            this.btnFindExpensse.Location = new System.Drawing.Point(190, 21);
            this.btnFindExpensse.Name = "btnFindExpensse";
            this.btnFindExpensse.Size = new System.Drawing.Size(35, 23);
            this.btnFindExpensse.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnFindExpensse, "Buscar gastos");
            this.btnFindExpensse.UseVisualStyleBackColor = true;
            this.btnFindExpensse.Click += new System.EventHandler(this.btnFindExpensse_Click);
            // 
            // dpSpentDate2
            // 
            this.dpSpentDate2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpSpentDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSpentDate2.Location = new System.Drawing.Point(55, 50);
            this.dpSpentDate2.Name = "dpSpentDate2";
            this.dpSpentDate2.Size = new System.Drawing.Size(112, 22);
            this.dpSpentDate2.TabIndex = 6;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(5, 54);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(41, 14);
            this.label40.TabIndex = 9;
            this.label40.Text = "Hasta:";
            // 
            // dpSpentDate1
            // 
            this.dpSpentDate1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpSpentDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSpentDate1.Location = new System.Drawing.Point(55, 21);
            this.dpSpentDate1.Name = "dpSpentDate1";
            this.dpSpentDate1.Size = new System.Drawing.Size(112, 22);
            this.dpSpentDate1.TabIndex = 5;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(5, 25);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(45, 14);
            this.label39.TabIndex = 7;
            this.label39.Text = "Desde:";
            // 
            // dgSpents
            // 
            this.dgSpents.AllowUserToAddRows = false;
            this.dgSpents.AllowUserToDeleteRows = false;
            this.dgSpents.AllowUserToResizeColumns = false;
            this.dgSpents.AllowUserToResizeRows = false;
            this.dgSpents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSpents.BackgroundColor = System.Drawing.Color.White;
            this.dgSpents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSpents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSpents.Location = new System.Drawing.Point(6, 79);
            this.dgSpents.Name = "dgSpents";
            this.dgSpents.ReadOnly = true;
            this.dgSpents.RowHeadersVisible = false;
            this.dgSpents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSpents.Size = new System.Drawing.Size(359, 146);
            this.dgSpents.TabIndex = 8;
            this.dgSpents.Click += new System.EventHandler(this.dgSpents_Click);
            // 
            // txtSpentNote
            // 
            this.txtSpentNote.Location = new System.Drawing.Point(22, 157);
            this.txtSpentNote.Multiline = true;
            this.txtSpentNote.Name = "txtSpentNote";
            this.txtSpentNote.ReadOnly = true;
            this.txtSpentNote.Size = new System.Drawing.Size(300, 87);
            this.txtSpentNote.TabIndex = 4;
            // 
            // vSpentAmount
            // 
            this.vSpentAmount.DecimalPlaces = 2;
            this.vSpentAmount.Enabled = false;
            this.vSpentAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSpentAmount.Location = new System.Drawing.Point(113, 100);
            this.vSpentAmount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vSpentAmount.Name = "vSpentAmount";
            this.vSpentAmount.Size = new System.Drawing.Size(122, 22);
            this.vSpentAmount.TabIndex = 3;
            this.vSpentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vSpentAmount.ThousandsSeparator = true;
            // 
            // dpSpentDate
            // 
            this.dpSpentDate.Enabled = false;
            this.dpSpentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSpentDate.Location = new System.Drawing.Point(113, 72);
            this.dpSpentDate.Name = "dpSpentDate";
            this.dpSpentDate.Size = new System.Drawing.Size(122, 22);
            this.dpSpentDate.TabIndex = 2;
            // 
            // cmbSpentType
            // 
            this.cmbSpentType.BackColor = System.Drawing.Color.LightSalmon;
            this.cmbSpentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpentType.Enabled = false;
            this.cmbSpentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpentType.FormattingEnabled = true;
            this.cmbSpentType.Location = new System.Drawing.Point(113, 44);
            this.cmbSpentType.Name = "cmbSpentType";
            this.cmbSpentType.Size = new System.Drawing.Size(209, 22);
            this.cmbSpentType.TabIndex = 1;
            // 
            // txtIdSpent
            // 
            this.txtIdSpent.Location = new System.Drawing.Point(41, 15);
            this.txtIdSpent.Name = "txtIdSpent";
            this.txtIdSpent.ReadOnly = true;
            this.txtIdSpent.Size = new System.Drawing.Size(66, 22);
            this.txtIdSpent.TabIndex = 3;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(19, 129);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(42, 14);
            this.label38.TabIndex = 4;
            this.label38.Text = "Notas:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(19, 104);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(46, 14);
            this.label37.TabIndex = 4;
            this.label37.Text = "Monto:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(19, 76);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(43, 14);
            this.label36.TabIndex = 4;
            this.label36.Text = "Fecha:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(19, 48);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(88, 14);
            this.label35.TabIndex = 4;
            this.label35.Text = "Tipo de Gasto:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(19, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(22, 14);
            this.label34.TabIndex = 4;
            this.label34.Text = "Id:";
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.dataGridView2);
            this.tp3.Location = new System.Drawing.Point(4, 23);
            this.tp3.Name = "tp3";
            this.tp3.Size = new System.Drawing.Size(710, 250);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "Historial de Renta";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(704, 244);
            this.dataGridView2.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdDeletePic);
            this.groupBox2.Controls.Add(this.cmdLoadPic);
            this.groupBox2.Controls.Add(this.picVehicle);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(408, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 187);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto:";
            // 
            // cmdDeletePic
            // 
            this.cmdDeletePic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdDeletePic.Enabled = false;
            this.cmdDeletePic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdDeletePic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeletePic.ImageIndex = 9;
            this.cmdDeletePic.ImageList = this.imageList1;
            this.cmdDeletePic.Location = new System.Drawing.Point(192, 101);
            this.cmdDeletePic.Name = "cmdDeletePic";
            this.cmdDeletePic.Size = new System.Drawing.Size(107, 72);
            this.cmdDeletePic.TabIndex = 1;
            this.cmdDeletePic.Text = "Borrar Imagen";
            this.cmdDeletePic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDeletePic.UseVisualStyleBackColor = true;
            this.cmdDeletePic.Click += new System.EventHandler(this.cmdDeletePic_Click);
            // 
            // cmdLoadPic
            // 
            this.cmdLoadPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdLoadPic.Enabled = false;
            this.cmdLoadPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLoadPic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoadPic.ImageIndex = 8;
            this.cmdLoadPic.ImageList = this.imageList1;
            this.cmdLoadPic.Location = new System.Drawing.Point(192, 21);
            this.cmdLoadPic.Name = "cmdLoadPic";
            this.cmdLoadPic.Size = new System.Drawing.Size(107, 68);
            this.cmdLoadPic.TabIndex = 0;
            this.cmdLoadPic.Text = "Cargar Imagen";
            this.cmdLoadPic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdLoadPic.UseVisualStyleBackColor = true;
            this.cmdLoadPic.Click += new System.EventHandler(this.cmdLoadPic_Click);
            // 
            // picVehicle
            // 
            this.picVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVehicle.Enabled = false;
            this.picVehicle.Location = new System.Drawing.Point(6, 21);
            this.picVehicle.Name = "picVehicle";
            this.picVehicle.Size = new System.Drawing.Size(180, 152);
            this.picVehicle.TabIndex = 38;
            this.picVehicle.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.vPrice5A);
            this.groupBox1.Controls.Add(this.vPrice4A);
            this.groupBox1.Controls.Add(this.vPrice3A);
            this.groupBox1.Controls.Add(this.vPrice2A);
            this.groupBox1.Controls.Add(this.vPrice1A);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.vPrice5);
            this.groupBox1.Controls.Add(this.vPrice4);
            this.groupBox1.Controls.Add(this.vPrice3);
            this.groupBox1.Controls.Add(this.vPrice2);
            this.groupBox1.Controls.Add(this.vPrice1);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 187);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios:";
            this.groupBox1.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(269, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 14);
            this.label23.TabIndex = 46;
            this.label23.Text = "Inversionista";
            // 
            // vPrice5A
            // 
            this.vPrice5A.DecimalPlaces = 2;
            this.vPrice5A.Enabled = false;
            this.vPrice5A.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice5A.Location = new System.Drawing.Point(255, 151);
            this.vPrice5A.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice5A.Name = "vPrice5A";
            this.vPrice5A.Size = new System.Drawing.Size(120, 22);
            this.vPrice5A.TabIndex = 9;
            this.vPrice5A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice5A.ThousandsSeparator = true;
            // 
            // vPrice4A
            // 
            this.vPrice4A.DecimalPlaces = 2;
            this.vPrice4A.Enabled = false;
            this.vPrice4A.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice4A.Location = new System.Drawing.Point(255, 123);
            this.vPrice4A.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice4A.Name = "vPrice4A";
            this.vPrice4A.Size = new System.Drawing.Size(120, 22);
            this.vPrice4A.TabIndex = 7;
            this.vPrice4A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice4A.ThousandsSeparator = true;
            // 
            // vPrice3A
            // 
            this.vPrice3A.DecimalPlaces = 2;
            this.vPrice3A.Enabled = false;
            this.vPrice3A.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice3A.Location = new System.Drawing.Point(255, 95);
            this.vPrice3A.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice3A.Name = "vPrice3A";
            this.vPrice3A.Size = new System.Drawing.Size(120, 22);
            this.vPrice3A.TabIndex = 5;
            this.vPrice3A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice3A.ThousandsSeparator = true;
            // 
            // vPrice2A
            // 
            this.vPrice2A.DecimalPlaces = 2;
            this.vPrice2A.Enabled = false;
            this.vPrice2A.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice2A.Location = new System.Drawing.Point(255, 67);
            this.vPrice2A.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice2A.Name = "vPrice2A";
            this.vPrice2A.Size = new System.Drawing.Size(120, 22);
            this.vPrice2A.TabIndex = 3;
            this.vPrice2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice2A.ThousandsSeparator = true;
            // 
            // vPrice1A
            // 
            this.vPrice1A.DecimalPlaces = 2;
            this.vPrice1A.Enabled = false;
            this.vPrice1A.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice1A.Location = new System.Drawing.Point(255, 39);
            this.vPrice1A.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice1A.Name = "vPrice1A";
            this.vPrice1A.Size = new System.Drawing.Size(120, 22);
            this.vPrice1A.TabIndex = 1;
            this.vPrice1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice1A.ThousandsSeparator = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(151, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 14);
            this.label22.TabIndex = 40;
            this.label22.Text = "Alquiler";
            // 
            // vPrice5
            // 
            this.vPrice5.DecimalPlaces = 2;
            this.vPrice5.Enabled = false;
            this.vPrice5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice5.Location = new System.Drawing.Point(129, 151);
            this.vPrice5.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice5.Name = "vPrice5";
            this.vPrice5.Size = new System.Drawing.Size(120, 22);
            this.vPrice5.TabIndex = 8;
            this.vPrice5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice5.ThousandsSeparator = true;
            // 
            // vPrice4
            // 
            this.vPrice4.DecimalPlaces = 2;
            this.vPrice4.Enabled = false;
            this.vPrice4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice4.Location = new System.Drawing.Point(129, 123);
            this.vPrice4.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice4.Name = "vPrice4";
            this.vPrice4.Size = new System.Drawing.Size(120, 22);
            this.vPrice4.TabIndex = 6;
            this.vPrice4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice4.ThousandsSeparator = true;
            // 
            // vPrice3
            // 
            this.vPrice3.DecimalPlaces = 2;
            this.vPrice3.Enabled = false;
            this.vPrice3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice3.Location = new System.Drawing.Point(129, 95);
            this.vPrice3.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice3.Name = "vPrice3";
            this.vPrice3.Size = new System.Drawing.Size(120, 22);
            this.vPrice3.TabIndex = 4;
            this.vPrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice3.ThousandsSeparator = true;
            // 
            // vPrice2
            // 
            this.vPrice2.DecimalPlaces = 2;
            this.vPrice2.Enabled = false;
            this.vPrice2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice2.Location = new System.Drawing.Point(129, 67);
            this.vPrice2.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice2.Name = "vPrice2";
            this.vPrice2.Size = new System.Drawing.Size(120, 22);
            this.vPrice2.TabIndex = 2;
            this.vPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice2.ThousandsSeparator = true;
            // 
            // vPrice1
            // 
            this.vPrice1.DecimalPlaces = 2;
            this.vPrice1.Enabled = false;
            this.vPrice1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice1.Location = new System.Drawing.Point(129, 39);
            this.vPrice1.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.vPrice1.Name = "vPrice1";
            this.vPrice1.Size = new System.Drawing.Size(120, 22);
            this.vPrice1.TabIndex = 0;
            this.vPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPrice1.ThousandsSeparator = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 14);
            this.label20.TabIndex = 39;
            this.label20.Text = "Precio (Mas 45 dias):";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 14);
            this.label19.TabIndex = 38;
            this.label19.Text = "Precio (31- 45 dias):";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 14);
            this.label18.TabIndex = 37;
            this.label18.Text = "Precio (16- 30 dias):";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 14);
            this.label17.TabIndex = 36;
            this.label17.Text = "Precio (8 - 15 dias):";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 14);
            this.label16.TabIndex = 35;
            this.label16.Text = "Precio (1 - 7 dias):";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(76, 188);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(326, 22);
            this.txtDescription.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 14);
            this.label15.TabIndex = 34;
            this.label15.Text = "Descripción:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMileage
            // 
            this.txtMileage.Enabled = false;
            this.txtMileage.Location = new System.Drawing.Point(513, 156);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(143, 22);
            this.txtMileage.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 14);
            this.label9.TabIndex = 32;
            this.label9.Text = "Kilometraje:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpAcqDate
            // 
            this.dpAcqDate.Enabled = false;
            this.dpAcqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpAcqDate.Location = new System.Drawing.Point(300, 159);
            this.dpAcqDate.Name = "dpAcqDate";
            this.dpAcqDate.Size = new System.Drawing.Size(127, 22);
            this.dpAcqDate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 14);
            this.label8.TabIndex = 30;
            this.label8.Text = "Fecha Adq.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(429, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 14);
            this.label14.TabIndex = 29;
            this.label14.Text = "Inversionista:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbOwner
            // 
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.Enabled = false;
            this.cmbOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(513, 127);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(222, 22);
            this.cmbOwner.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 14);
            this.label13.TabIndex = 27;
            this.label13.Text = "Estatus:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(61, 156);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 22);
            this.cmbStatus.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 14);
            this.label12.TabIndex = 24;
            this.label12.Text = "Año:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Combustible:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFuel
            // 
            this.cmbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuel.Enabled = false;
            this.cmbFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(297, 127);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(127, 22);
            this.cmbFuel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Transmisión:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTrans
            // 
            this.cmbTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrans.Enabled = false;
            this.cmbTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrans.FormattingEnabled = true;
            this.cmbTrans.Location = new System.Drawing.Point(86, 127);
            this.cmbTrans.Name = "cmbTrans";
            this.cmbTrans.Size = new System.Drawing.Size(125, 22);
            this.cmbTrans.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Clase:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbClasses
            // 
            this.cmbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasses.Enabled = false;
            this.cmbClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(44, 99);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(121, 22);
            this.cmbClasses.TabIndex = 4;
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(216, 99);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(86, 22);
            this.txtColor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Color:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Modelo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // cmbModels
            // 
            this.cmbModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModels.Enabled = false;
            this.cmbModels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModels.FormattingEnabled = true;
            this.cmbModels.Location = new System.Drawing.Point(535, 99);
            this.cmbModels.Name = "cmbModels";
            this.cmbModels.Size = new System.Drawing.Size(121, 22);
            this.cmbModels.TabIndex = 7;
            this.cmbModels.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marca:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChassis
            // 
            this.txtChassis.Enabled = false;
            this.txtChassis.Location = new System.Drawing.Point(348, 68);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(126, 22);
            this.txtChassis.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chasis:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlate
            // 
            this.txtPlate.Enabled = false;
            this.txtPlate.Location = new System.Drawing.Point(216, 68);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(86, 22);
            this.txtPlate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Placa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Enabled = false;
            this.cmbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(535, 68);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(121, 22);
            this.cmbBrand.TabIndex = 3;
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Location = new System.Drawing.Point(44, 68);
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.ReadOnly = true;
            this.txtVehicleId.Size = new System.Drawing.Size(121, 22);
            this.txtVehicleId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.cmdAdd);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 60);
            this.panel1.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClose.ImageIndex = 12;
            this.cmdClose.ImageList = this.imageList1;
            this.cmdClose.Location = new System.Drawing.Point(399, 3);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(126, 51);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Salir";
            this.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCancel.Enabled = false;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.ImageIndex = 6;
            this.cmdCancel.ImageList = this.imageList1;
            this.cmdCancel.Location = new System.Drawing.Point(267, 3);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(126, 51);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSave.Enabled = false;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSave.ImageIndex = 11;
            this.cmdSave.ImageList = this.imageList1;
            this.cmdSave.Location = new System.Drawing.Point(135, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(126, 51);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Grabar";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAdd.ImageKey = "add.png";
            this.cmdAdd.ImageList = this.imageList1;
            this.cmdAdd.Location = new System.Drawing.Point(3, 3);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(126, 51);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Crear";
            this.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // frmVehicles
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1126, 745);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVehicles_FormClosing);
            this.Load += new System.EventHandler(this.frmVehicles_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVehicles_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp4.ResumeLayout(false);
            this.tp4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vPriceRange2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPriceRange1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrices)).EndInit();
            this.tp1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vInsuranceAmount)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIntervalMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLastMileage)).EndInit();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSpentAmount)).EndInit();
            this.tp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice5A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice4A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice3A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice2A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice1A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrice1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        //private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbModels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.TextBox txtVehicleId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbFuel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpAcqDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown vPrice5;
        private System.Windows.Forms.NumericUpDown vPrice4;
        private System.Windows.Forms.NumericUpDown vPrice3;
        private System.Windows.Forms.NumericUpDown vPrice2;
        private System.Windows.Forms.NumericUpDown vPrice1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdDeletePic;
        private System.Windows.Forms.Button cmdLoadPic;
        private System.Windows.Forms.PictureBox picVehicle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.OpenFileDialog openPic;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown vPrice5A;
        private System.Windows.Forms.NumericUpDown vPrice4A;
        private System.Windows.Forms.NumericUpDown vPrice3A;
        private System.Windows.Forms.NumericUpDown vPrice2A;
        private System.Windows.Forms.NumericUpDown vPrice1A;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown vInsuranceAmount;
        private System.Windows.Forms.DateTimePicker dpInsurenceExpiractionDate;
        private System.Windows.Forms.TextBox txtPolicy;
        private System.Windows.Forms.ComboBox cmbInsurences;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dpPlateExpirationDate;
        private System.Windows.Forms.DateTimePicker dpNextInspectionDate;
        private System.Windows.Forms.DateTimePicker dpNextServiceDate;
        private System.Windows.Forms.DateTimePicker dpLastServiceDate;
        private System.Windows.Forms.NumericUpDown vIntervalMileage;
        private System.Windows.Forms.NumericUpDown vLastMileage;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnFindExpensse;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dpSpentDate2;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.DateTimePicker dpSpentDate1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DataGridView dgSpents;
        private System.Windows.Forms.TextBox txtSpentNote;
        private System.Windows.Forms.NumericUpDown vSpentAmount;
        private System.Windows.Forms.DateTimePicker dpSpentDate;
        private System.Windows.Forms.ComboBox cmbSpentType;
        private System.Windows.Forms.TextBox txtIdSpent;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button cmdCancelSpent;
        private System.Windows.Forms.Button cmdSaveSpent;
        private System.Windows.Forms.Button cmdAddSpent;
        private System.Windows.Forms.Button cmdSpentFindCancel;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.TabPage tp4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown vDay2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown vDay1;
        private System.Windows.Forms.NumericUpDown vPriceRange1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button cmdCancelPrice;
        private System.Windows.Forms.Button cmdSavePrice;
        private System.Windows.Forms.Button cmdAddPrice;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgPrices;
        private System.Windows.Forms.TextBox txtPriceId;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtPriceVehicleId;
        private System.Windows.Forms.NumericUpDown vPriceRange2;
        private System.Windows.Forms.Label label41;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtPrices;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayRange1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayRange2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price2;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.Button cmdDeletePrice;
    }
}