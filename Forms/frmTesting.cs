using SISTRENT.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SISTRENT
{
    public partial class frmTesting : Form
    {

        public frmTesting()
        {
            InitializeComponent();
        }

        SISRENTEntities db = new SISRENTEntities();
        List<vwVehicle> lstVeh = new List<vwVehicle>();
        List<vwVehicle> lstResult = new List<vwVehicle>();

        string strConn = "Data Source=" + Properties.Settings.Default.ServerName.ToString() + ";Initial Catalog=" + Properties.Settings.Default.DBName.ToString() + ";User ID=" + Properties.Settings.Default.DBUser + ";Password=" + Properties.Settings.Default.DBPass + ";MultipleActiveResultSets=True";
        private void frmTesting_Load(object sender, EventArgs e)
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);

            }

            //// Set to details view.
            //listView1.View = View.Details;
            //// Add a column with width 20 and left alignment.
            //listView1.Columns.Add("File type", 100, HorizontalAlignment.Left);
            //listView1.Columns.Add("Size", 60, HorizontalAlignment.Left);
            
            
            //CreateMyListView();
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        private void LoadDataFilters()
        { 

            listView1.Items.Clear();

            //string sqlStr = "select VehicleId,PlateNumber,Description,manufactureYear from vehicles inner join";
            string sqlStr1 = "select distinct clasDescription from vwVehicles";
            string sqlStr2 = "select distinct clasDescription from vwVehicles";

            bool success = true;
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd1 = new SqlCommand(sqlStr1, conn);
            SqlCommand cmd2 = null;

            try
            {
                conn.Open();
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    listView1.View = View.Tile;
                    listView1.Groups.Clear();

                    while (reader.Read())
                    {
                        ListViewGroup grupo = new ListViewGroup(reader.GetString(0).ToString(),HorizontalAlignment.Left);
                        listView1.Groups.Add(grupo);

                        sqlStr2 = "select PlateNumber,Description,ManufactureYear,statDescription,VehicleId from vwVehicles where clasDescription='" + reader.GetString(0).ToString() + "'";
                        cmd2 = new SqlCommand(sqlStr2, conn);
                        using (SqlDataReader reader2 = cmd2.ExecuteReader()) 
                        {
                            while (reader2.Read())
                            {
                                ListViewItem lista = new ListViewItem(reader2.GetString(0).ToString(),grupo);
                                lista.SubItems.Add(reader2.GetString(1).ToString());
                                lista.SubItems.Add(reader2.GetString(2).ToString());
                                lista.SubItems.Add(reader2.GetString(3).ToString());
                                lista.SubItems.Add(reader2.GetInt32(4).ToString());
                                listView1.Items.Add(lista);

                            }
                            reader2.Close();
                        }

                            //listView1.Groups.Add(new ListViewGroup(reader.GetString(0), HorizontalAlignment.Left));
                    }
                    reader.Close(); 
                }
            }
            catch (Exception ex)
            {
                success = false;
                MessageBox.Show(ex.Message.ToString(),"Mensaje de Error:",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) 
                { 
                    conn.Close();
                }

                if (success)
                {
                    //MessageBox.Show("Informacion cargada de manera exitosa", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmdTestConnection_Click(object sender, EventArgs e)
        {
            LoadDataFilters();
        }

        private void cmdFindSeleted_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
                MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text);
                MessageBox.Show(listView1.SelectedItems[0].SubItems[2].Text);
                MessageBox.Show(listView1.SelectedItems[0].SubItems[3].Text);
                MessageBox.Show(listView1.SelectedItems[0].SubItems[4].Text);
            }
            catch (Exception)
            {

            }

        }
        private void FillDataGrid()
        {
            try
            {
                //lstVeh = db.vwVehicles.Select(xc => new { Placa = xc.PlateNumber, Descripcion = xc.Description, Year = xc.ManufactureYear, Id = xc.VehicleId }).ToList();

                lstResult = db.vwVehicles.ToList();
                dgConsulta.DataSource = lstResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cmdFillDataGrid_Click(object sender, EventArgs e)
        {
            FillDataGrid();
            dgFormat();
            dgConsulta.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         if(string.IsNullOrEmpty(textBox1.Text))
            {
                lstResult.Clear();
                lstResult = db.vwVehicles.ToList(); //.Where(xc => xc.Description.ToUpper().Contains(textBox1.Text.ToUpper()) || xc.PlateNumber.Contains(textBox1.Text)).ToList();
                dgConsulta.DataSource = lstResult;
            }
            else
            {
                lstResult.Clear();
                lstResult = db.vwVehicles.Where(xc => xc.Description.ToUpper().Contains(textBox1.Text.ToUpper()) || xc.PlateNumber.Contains(textBox1.Text)).ToList();
                dgConsulta.DataSource = lstResult;
            }
        }

        private void dgFormat()
        {

            for (int i = 0;i<=dgConsulta.Columns.Count - 1; i++)
            {
                if (dgConsulta.Columns[i].HeaderText != "VehicleId" && dgConsulta.Columns[i].HeaderText != "PlateNumber" && dgConsulta.Columns[i].HeaderText != "Description" && dgConsulta.Columns[i].HeaderText != "ManufacturerYear" && dgConsulta.Columns[i].HeaderText != "statDescription")
                {
                    dgConsulta.Columns[i].Visible = false;
                }else
                {
                    if (dgConsulta.Columns[i].HeaderText == "VehicleId")
                    {
                        dgConsulta.Columns[i].HeaderText = "Id";
                    }
                    if (dgConsulta.Columns[i].HeaderText == "PlateNumber")
                    {
                        dgConsulta.Columns[i].HeaderText = "Placa";
                    }
                    if (dgConsulta.Columns[i].HeaderText == "Description")
                    {
                        dgConsulta.Columns[i].HeaderText = "Descripcion";
                    }
                    if (dgConsulta.Columns[i].HeaderText == "ManufactureYear")
                    {
                        dgConsulta.Columns[i].HeaderText = "Año Fab.";
                    }
                    if (dgConsulta.Columns[i].HeaderText == "statDescription")
                    {
                        dgConsulta.Columns[i].HeaderText = "Estatus";
                    }

                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openPic.InitialDirectory = @"C:\";
            openPic.Filter = "Jpg (*.jpg)|*.jpg|Png (*.Png)|*.Png|Todos los archivos (*.*)|*.*";
            openPic.FilterIndex = 1;
            openPic.RestoreDirectory = true;
            openPic.Title = "Imagenes";

            if (openPic.ShowDialog().Equals(DialogResult.OK))
            {
                if (!string.IsNullOrEmpty(openPic.FileName))
                {
                    pictureBox1.Image = new Bitmap(openPic.FileName);
                    pictureBox1.Image = Image.FromFile(openPic.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
       }

        private void cmdSavePicture_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            Byte[] picStream = null;

            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            picStream = ms.ToArray();
            db.VehiclesImagens.Add(new VehiclesImagen() { idVehicle = 1, Picture = picStream, DefaultImagen = true});
            db.SaveChanges();
        }

        private void cmdFillListviewPic_Click(object sender, EventArgs e)
        {
            //List<VehiclesImagen> lista = new List<VehiclesImagen>();
            //lista = db.VehiclesImagens.Where(xc=>xc.idVehicle==1).Select(x => {x.idVehicle, x.Picture});
            ////lstVeh = db.vwVehicles.Select(xc => new { Placa = xc.PlateNumber, Descripcion = xc.Description, Year = xc.ManufactureYear, Id = xc.VehicleId }).ToList();

            //dgCarImage.DataSource = lista;
            //dgCarImage.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
