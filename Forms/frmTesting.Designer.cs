namespace SISTRENT
{
    partial class frmTesting
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idVeh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdTestConnection = new System.Windows.Forms.Button();
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.cmdFillDataGrid = new System.Windows.Forms.Button();
            this.cmdFindSeleted = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openPic = new System.Windows.Forms.OpenFileDialog();
            this.cmdSavePicture = new System.Windows.Forms.Button();
            this.cmdFillListviewPic = new System.Windows.Forms.Button();
            this.dgCarImage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(162, 104);
            this.treeView1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.idVeh});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 202);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Placa";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Año";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estatus";
            this.columnHeader4.Width = 100;
            // 
            // idVeh
            // 
            this.idVeh.Text = "Id";
            this.idVeh.Width = 0;
            // 
            // cmdTestConnection
            // 
            this.cmdTestConnection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTestConnection.Location = new System.Drawing.Point(579, 122);
            this.cmdTestConnection.Name = "cmdTestConnection";
            this.cmdTestConnection.Size = new System.Drawing.Size(116, 38);
            this.cmdTestConnection.TabIndex = 2;
            this.cmdTestConnection.Text = "Fill Listview";
            this.cmdTestConnection.UseVisualStyleBackColor = true;
            this.cmdTestConnection.Click += new System.EventHandler(this.cmdTestConnection_Click);
            // 
            // dgConsulta
            // 
            this.dgConsulta.AllowUserToAddRows = false;
            this.dgConsulta.AllowUserToDeleteRows = false;
            this.dgConsulta.AllowUserToResizeColumns = false;
            this.dgConsulta.AllowUserToResizeRows = false;
            this.dgConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Location = new System.Drawing.Point(12, 367);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.ReadOnly = true;
            this.dgConsulta.RowHeadersVisible = false;
            this.dgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConsulta.Size = new System.Drawing.Size(360, 186);
            this.dgConsulta.TabIndex = 3;
            // 
            // cmdFillDataGrid
            // 
            this.cmdFillDataGrid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFillDataGrid.Location = new System.Drawing.Point(579, 330);
            this.cmdFillDataGrid.Name = "cmdFillDataGrid";
            this.cmdFillDataGrid.Size = new System.Drawing.Size(116, 38);
            this.cmdFillDataGrid.TabIndex = 4;
            this.cmdFillDataGrid.Text = "Fill DataGridView";
            this.cmdFillDataGrid.UseVisualStyleBackColor = true;
            this.cmdFillDataGrid.Click += new System.EventHandler(this.cmdFillDataGrid_Click);
            // 
            // cmdFindSeleted
            // 
            this.cmdFindSeleted.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFindSeleted.Location = new System.Drawing.Point(579, 166);
            this.cmdFindSeleted.Name = "cmdFindSeleted";
            this.cmdFindSeleted.Size = new System.Drawing.Size(116, 38);
            this.cmdFindSeleted.TabIndex = 2;
            this.cmdFindSeleted.Text = "Show Selected";
            this.cmdFindSeleted.UseVisualStyleBackColor = true;
            this.cmdFindSeleted.Click += new System.EventHandler(this.cmdFindSeleted_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(378, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // cmdSavePicture
            // 
            this.cmdSavePicture.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSavePicture.Location = new System.Drawing.Point(579, 374);
            this.cmdSavePicture.Name = "cmdSavePicture";
            this.cmdSavePicture.Size = new System.Drawing.Size(116, 38);
            this.cmdSavePicture.TabIndex = 7;
            this.cmdSavePicture.Text = "Save Picture";
            this.cmdSavePicture.UseVisualStyleBackColor = true;
            this.cmdSavePicture.Click += new System.EventHandler(this.cmdSavePicture_Click);
            // 
            // cmdFillListviewPic
            // 
            this.cmdFillListviewPic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFillListviewPic.Location = new System.Drawing.Point(758, 311);
            this.cmdFillListviewPic.Name = "cmdFillListviewPic";
            this.cmdFillListviewPic.Size = new System.Drawing.Size(116, 38);
            this.cmdFillListviewPic.TabIndex = 9;
            this.cmdFillListviewPic.Text = "Fill Listview Pictures";
            this.cmdFillListviewPic.UseVisualStyleBackColor = true;
            this.cmdFillListviewPic.Click += new System.EventHandler(this.cmdFillListviewPic_Click);
            // 
            // dgCarImage
            // 
            this.dgCarImage.AllowUserToAddRows = false;
            this.dgCarImage.AllowUserToDeleteRows = false;
            this.dgCarImage.AllowUserToResizeColumns = false;
            this.dgCarImage.AllowUserToResizeRows = false;
            this.dgCarImage.BackgroundColor = System.Drawing.Color.White;
            this.dgCarImage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgCarImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarImage.Location = new System.Drawing.Point(758, 119);
            this.dgCarImage.Name = "dgCarImage";
            this.dgCarImage.ReadOnly = true;
            this.dgCarImage.RowHeadersVisible = false;
            this.dgCarImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarImage.Size = new System.Drawing.Size(356, 186);
            this.dgCarImage.TabIndex = 10;
            // 
            // frmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 724);
            this.Controls.Add(this.dgCarImage);
            this.Controls.Add(this.cmdFillListviewPic);
            this.Controls.Add(this.cmdSavePicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdFillDataGrid);
            this.Controls.Add(this.dgConsulta);
            this.Controls.Add(this.cmdFindSeleted);
            this.Controls.Add(this.cmdTestConnection);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmTesting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTesting";
            this.Load += new System.EventHandler(this.frmTesting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button cmdTestConnection;
        private System.Windows.Forms.ColumnHeader idVeh;
        private System.Windows.Forms.Button cmdFillDataGrid;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.Button cmdFindSeleted;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openPic;
        private System.Windows.Forms.Button cmdSavePicture;
        private System.Windows.Forms.Button cmdFillListviewPic;
        private System.Windows.Forms.DataGridView dgCarImage;
    }
}

