using SISTRENT.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SISTRENT.Forms
{
    public partial class frmVehicles : Form
    {
        public frmVehicles()
        {
            InitializeComponent();
        }

        private  SISRENTEntities db;
        List<vwVehicle> lstResult = new List<vwVehicle>();

        List<Filter> lstFilters = new List<Filter>();
        List<vwBrand> lstBrand = new List<vwBrand>();
        List<vwModel> lstModel = new List<vwModel>();
        List<vwClass> lstClass = new List<vwClass>();
        List<vwFuel> lstFuel = new List<vwFuel>();
        List<vwTran> lstTrans = new List<vwTran>();
        List<vwStatu> lstStatus = new List<vwStatu>();
        List<Insurence> lstInsurence = new List<Insurence>();
        List<Partner> lstPartners = new List<Partner>();
        List<vwSpentType> lstSpentType = new List<vwSpentType>();
        List<VehiclesExpenss> lstSpents = new List<VehiclesExpenss>();

        string strConn = "Data Source=" + Properties.Settings.Default.ServerName.ToString() + ";Initial Catalog=" + Properties.Settings.Default.DBName.ToString() + ";User ID=" + Properties.Settings.Default.DBUser + ";Password=" + Properties.Settings.Default.DBPass + ";MultipleActiveResultSets=True";

        string @tableName = "Vehicles";

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            db = new SISRENTEntities();
            FillDataGrid();
            dgFormat();
            FillCombox();
        }

        private void cmdLoadPic_Click(object sender, EventArgs e)
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
                    picVehicle.Image = new Bitmap(openPic.FileName);
                    picVehicle.Image = Image.FromFile(openPic.FileName);
                    picVehicle.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }

        private void dgFormat()
        {
            for (int i = 0; i <= dgConsulta.Columns.Count - 1; i++)
            {
                if (dgConsulta.Columns[i].HeaderText != "VehicleId" && dgConsulta.Columns[i].HeaderText != "PlateNumber" && dgConsulta.Columns[i].HeaderText != "Description" && dgConsulta.Columns[i].HeaderText != "ManufacturerYear" && dgConsulta.Columns[i].HeaderText != "statDescription")
                {
                    dgConsulta.Columns[i].Visible = false;
                }
                else
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
            dgConsulta.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void FillDataGrid()
        {
            try
            {
                //lstVeh = db.vwVehicles.Select(xc => new { Placa = xc.PlateNumber, Descripcion = xc.Description, Year = xc.ManufactureYear, Id = xc.VehicleId }).ToList();
                //lstResult.Clear();
                //lstResult = db.vwVehicles.ToList();
                dgConsulta.DataSource = db.vwVehicles.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FillGridSpent(int idVeh)
        {
            try
            {

                var listSpents = db.VehiclesExpensses.Join(db.vwSpentTypes, veh => veh.ExpenseType, st => st.Code, (veh, et) => new { veh, et}).Where(xc=> xc.veh.VehicleId==idVeh && xc.veh.ExpenseDate.Year==DateTime.Today.Year  && xc.veh.ExpenseDate.Month == DateTime.Today.Month).Select(xc => new {Id = xc.veh.Id, idVehiculo = xc.veh.VehicleId, idTipo = xc.veh.ExpenseType, Fecha = xc.veh.ExpenseDate,Tipo = xc.et.Description, Monto = xc.veh.ExpenseAmount, Nota = xc.veh.ExpenseNotes }).OrderBy(o=>o.Fecha) .ToList();
              
                dgSpents.DataSource = listSpents;
                dgSpents.Columns["idVehiculo"].Visible= false;
                dgSpents.Columns["IdTipo"].Visible = false;
                dgSpents.Columns["Monto"].DefaultCellStyle.Format = "N2";
                dgSpents.Columns["Monto"].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleRight;
                dgSpents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillGridPrices(int idVeh)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = null;
                SqlDataAdapter da = null;

                cmd = new SqlCommand("SELECT * FROM VehiclesPrices WHERE VehicleId=" + idVeh.ToString(), conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 3000;
                da = new SqlDataAdapter(cmd);
                dtPrices.Clear();
                da.Fill(dtPrices);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillGridSpent(int idVeh, DateTime fecha1, DateTime fecha2)
        {
            try
            {

                var listSpents = db.VehiclesExpensses.Join(db.vwSpentTypes, veh => veh.ExpenseType, st => st.Code, (veh, et) => new { veh, et }).Where(xc => xc.veh.VehicleId == idVeh && xc.veh.ExpenseDate>= fecha1 && xc.veh.ExpenseDate <= fecha2).Select(xc => new { Id = xc.veh.Id, idVehiculo = xc.veh.VehicleId, idTipo = xc.veh.ExpenseType, Fecha = xc.veh.ExpenseDate, Tipo = xc.et.Description, Monto = xc.veh.ExpenseAmount, Nota = xc.veh.ExpenseNotes }).OrderBy(o => o.Fecha).ToList();

                dgSpents.DataSource = listSpents;
                dgSpents.Columns["idVehiculo"].Visible = false;
                dgSpents.Columns["IdTipo"].Visible = false;
                dgSpents.Columns["Monto"].DefaultCellStyle.Format = "N2";
                dgSpents.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgSpents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillCombox()
        {
            try
            {
                //Fill Filters combox
                lstFilters = db.Filters.Where(xc=>xc.TableName.Equals(tableName)).OrderBy(o=>o.FieldOrder) .ToList();
                cmbFiltros.DataSource  = lstFilters;
                cmbFiltros.DisplayMember = "Descripcion"; 
                cmbFiltros.ValueMember = "FieldName";

                //Fill Brand combox
                lstBrand = db.vwBrands.OrderBy(o => o.Description ).ToList();
                cmbBrand.DataSource = lstBrand;
                cmbBrand.DisplayMember = "Description";
                cmbBrand.ValueMember = "Code";

                //Fill Models combox
                lstModel = db.vwModels.OrderBy(o => o.Description).ToList();
                cmbModels.DataSource = lstModel;
                cmbModels.DisplayMember = "Description";
                cmbModels.ValueMember = "Code";

                //Fill Classes combox
                lstClass = db.vwClasses.OrderBy(o => o.Description).ToList();
                cmbClasses.DataSource = lstClass;
                cmbClasses.DisplayMember = "Description";
                cmbClasses.ValueMember = "Code";

                //Fill Transmission combox
                lstTrans = db.vwTrans.OrderBy(o => o.Description).ToList();
                cmbTrans.DataSource = lstTrans;
                cmbTrans.DisplayMember = "Description";
                cmbTrans.ValueMember = "Code";

                //Fill Fuel combox
                lstFuel = db.vwFuels.OrderBy(o => o.Description).ToList();
                cmbFuel.DataSource = lstFuel;
                cmbFuel.DisplayMember = "Description";
                cmbFuel.ValueMember = "Code";

                //Fill Status combox
                lstStatus = db.vwStatus.OrderBy(o => o.Description).ToList();
                cmbStatus.DataSource = lstStatus;
                cmbStatus.DisplayMember = "Description";
                cmbStatus.ValueMember = "Code";

                //Fill Partners combox
                lstPartners = db.Partners.OrderBy(o => o.Name).ToList();
                cmbOwner.DataSource = lstPartners;
                cmbOwner.DisplayMember = "Name";
                cmbOwner.ValueMember = "Id";

                //Fill Insurences combox
                lstInsurence = db.Insurences.OrderBy(o => o.Name).ToList();
                cmbInsurences.DataSource = lstInsurence;
                cmbInsurences.DisplayMember = "Name";
                cmbInsurences.ValueMember = "id";

                //Fill Spent Type combox
                lstSpentType = db.vwSpentTypes.OrderBy(o => o.Description).ToList();
                cmbSpentType.DataSource = lstSpentType;
                cmbSpentType.DisplayMember = "Description";
                cmbSpentType.ValueMember = "Code";

                int year = DateTime.Now.Year+1;

                for (int i = 1; i < 20; i++)
                {
                    cmbYears.Items.Add(year);
                    year = year - 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadVehicle(int id)
        {

            //List<vwVehicle> lstResult = new List<vwVehicle>();
            var v = db.vwVehicles.Where(x => x.VehicleId == id).FirstOrDefault();
           
            txtVehicleId.Text = v.VehicleId.ToString();
            txtPriceVehicleId.Text = v.VehicleId.ToString();
            txtPlate.Text= v.PlateNumber.ToString();
            txtChassis.Text = v.Chassis;
            cmbBrand.SelectedValue = v.brandCode;
            cmbClasses.SelectedValue = v.ClassCode;
            txtColor.Text = v.Color;
            cmbYears.Text = v.ManufactureYear;
            cmbModels.SelectedValue = v.modelCode;
            cmbTrans.SelectedValue = v.tranCode;
            cmbFuel.SelectedValue = v.fuelCode;
            cmbStatus.SelectedValue = v.statCode;
            dpAcqDate.Value = v.AcquisitionDate;
            txtMileage.Text= v.Mileage;
            txtDescription.Text = v.Description;
            cmbOwner.SelectedValue= v.ownerCode;    
            vPrice1.Value = v.Price1;
            vPrice2.Value = v.Price2;
            vPrice3.Value = v.Price3;
            vPrice4.Value = v.Price4;
            vPrice5.Value = v.Price5;
            vPrice1A.Value = v.Price1A;
            vPrice2A.Value = v.Price2A;
            vPrice3A.Value = v.Price3A;
            vPrice4A.Value = v.Price4A;
            vPrice5A.Value = v.Price5A;

            try
            {
                if (v.binPicture != null)
                {
                    using (var contex = new SISRENTEntities()) 
                    {
                        var im = contex.VehiclesImagens.Where(x => x.idVehicle == v.VehicleId).FirstOrDefault(); 
                        MemoryStream Documento = new MemoryStream(im.Picture);
                        picVehicle.Image = Image.FromStream(Documento);
                        picVehicle.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else
                {
                        picVehicle.Image = null;    
                }

                LoadMainInfo(v.VehicleId);
                FillGridSpent(v.VehicleId);
                FillGridPrices(v.VehicleId);
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void LoadMainInfo(int vId)
        {
            try
            {
                var mi = db.VehiclesMaintenaceInfoes.Where(v => v.VehicleID == vId).FirstOrDefault();
                if (mi != null)
                {
                    vLastMileage.Value = mi.LastMileageService;
                    vIntervalMileage.Value = mi.IntervalMileageService;
                    dpLastServiceDate.Value = mi.LastServiceDate;
                    dpNextServiceDate.Value = mi.NextServiceDate;
                    dpNextInspectionDate.Value = mi.NextInspectionDate;
                    dpPlateExpirationDate.Value = mi.PlateExpirationDate;
                    cmbInsurences.SelectedValue = mi.InsuranceCode;
                    txtPolicy.Text = mi.InsurancePolicyNumber;
                    dpInsurenceExpiractionDate.Value = mi.InsuranceExpirationDate;
                    vInsuranceAmount.Value = mi.InsuranceAmount;

                }
                else
                {
                    vLastMileage.Value = 0;
                    vIntervalMileage.Value = 0;
                    dpLastServiceDate.Value = DateTime.Today;
                    dpNextServiceDate.Value = DateTime.Today;
                    dpNextInspectionDate.Value = DateTime.Today;
                    dpPlateExpirationDate.Value = DateTime.Today;
                    cmbInsurences.SelectedIndex = 0;
                    txtPolicy.Text = string.Empty;
                    dpInsurenceExpiractionDate.Value = DateTime.Today;
                    vInsuranceAmount.Value = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgConsulta_Click(object sender, EventArgs e)
        {
            bool Sucess = true;
            try
            {
                if (dgConsulta.Rows.Count > 0) 
                {
                    loadVehicle((int)dgConsulta.CurrentRow.Cells["Vehicleid"].Value);
                }
            }
            catch (Exception)
            {
                Sucess = false;
            }
            finally
            {
                if (Sucess)
                {
                    FieldsEnable(true);
                }
            }
        }

        private void clearFields()
        {
            try
            {
                txtVehicleId.Text = string.Empty;
                txtPlate.Text = string.Empty;
                txtChassis.Text = string.Empty;
                txtColor.Text = string.Empty;
                cmbYears.SelectedIndex =0;
                dpAcqDate.Value = DateTime.Today;
                txtMileage.Text = string.Empty;
                txtDescription.Text = string.Empty;
                picVehicle.Image = null;
                vPrice1.Value = 0;
                vPrice2.Value = 0;
                vPrice3.Value = 0;
                vPrice4.Value = 0;
                vPrice5.Value = 0;
                vPrice1A.Value = 0;
                vPrice2A.Value = 0;
                vPrice3A.Value = 0;
                vPrice4A.Value = 0;
                vPrice5A.Value = 0;
                vLastMileage.Value = 0;
                vIntervalMileage.Value = 0;
                dpLastServiceDate.Value = DateTime.Today;
                dpNextServiceDate.Value = DateTime.Today;
                dpNextInspectionDate.Value = DateTime.Today;
                dpPlateExpirationDate.Value = DateTime.Today;
                cmbInsurences.SelectedIndex=0;
                cmbOwner.SelectedIndex=0;
                txtPolicy.Text = string.Empty;
                dpInsurenceExpiractionDate.Value = DateTime.Today;
                vInsuranceAmount.Value =0;


                try
                {
                    cmbBrand.SelectedIndex = 0;
                    cmbClasses.SelectedIndex = 0;
                    cmbModels.SelectedIndex = 0;
                    cmbTrans.SelectedIndex = 0;
                    cmbFuel.SelectedIndex = 0;
                    cmbStatus.SelectedIndex = 0;
                }
                catch (Exception)
                {
                }
                finally
                {
                    txtPlate.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdAdd.Enabled = false; 
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;
            FieldsEnable(true);
            ClearSpentFields();
            clearFields();            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!TextControlsValided(txtPlate))
            {
                MessageBox.Show("El numero de placa es requerido!!!", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlate.Focus();
                return;
            }

            if (!TextControlsValided(txtChassis))
            {
                MessageBox.Show("El numero de chasis es requerido!!!", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChassis.Focus();
                return;
            }

            if (!TextControlsValided(txtColor))
            {
                MessageBox.Show("El color es requerido!!!", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtColor.Focus();
                return;
            }

           
            if (!TextControlsValided(txtMileage))
            {
                MessageBox.Show("El kilometraje es requerido!!!", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMileage.Focus();
                return;
            }

            if (!TextControlsValided(txtDescription))
            {
                MessageBox.Show("La descripción es requerido!!!", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            int id = 0;
            bool Success = true;

            MemoryStream ms = new MemoryStream();
            Byte[] picStream = null;

            if (picVehicle.Image != null)
            {
                picVehicle.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                picStream = ms.ToArray();
            }

            if (txtVehicleId.Text.Trim().Length>0)
            {
                id = Convert.ToInt32(txtVehicleId.Text);
            }

            try
            {

                int lastident = 0, ii=0;

                var v = new Vehicle { VehicleId = id, PlateNumber = txtPlate.Text, Chassis = txtChassis.Text, Class = (int)cmbClasses.SelectedValue, Description = txtDescription.Text, Brand = (int)cmbBrand.SelectedValue, Model = (int)cmbModels.SelectedValue, Color = txtColor.Text, Transmission = (int)cmbTrans.SelectedValue, Fuel = (int)cmbFuel.SelectedValue, ManufactureYear = cmbYears.Text , Status = (int)cmbStatus.SelectedValue, AcquisitionDate = dpAcqDate.Value, Owner = (int)cmbOwner.SelectedValue, Mileage = txtMileage.Text, Price1 = vPrice1.Value, Price1A = vPrice1A.Value, Price2 = vPrice2.Value, Price2A = vPrice2A.Value, Price3 = vPrice3.Value, Price3A = vPrice3A.Value, Price4 = vPrice4.Value, Price4A = vPrice4A.Value, Price5 = vPrice5.Value, Price5A = vPrice5A.Value, CreateBy = "Admin", CreateDate = DateTime.Today};
                db.Vehicles.AddOrUpdate(v);
                db.SaveChanges();
                lastident = v.VehicleId;

                var vi = db.VehiclesImagens.Where(x => x.idVehicle == lastident).FirstOrDefault();
                var newid = Guid.NewGuid();

                if (vi!= null)
                {
                    ii = vi.IdImagen;
                    newid = vi.Rid;

                }

                db.VehiclesImagens.AddOrUpdate(new VehiclesImagen { IdImagen = ii, idVehicle = lastident, DefaultImagen = true, Picture = picStream,Rid = newid});
                db.VehiclesMaintenaceInfoes.AddOrUpdate(new VehiclesMaintenaceInfo { Id = lastident, VehicleID = lastident, LastMileageService = (int)vLastMileage.Value, IntervalMileageService = (int)vIntervalMileage.Value, LastServiceDate = dpLastServiceDate.Value, NextServiceDate = dpNextServiceDate.Value, NextInspectionDate = dpNextInspectionDate.Value, PlateExpirationDate = dpPlateExpirationDate.Value, InsuranceCode = (int)cmbInsurences.SelectedValue, InsurancePolicyNumber = txtPolicy.Text.Trim().ToUpper(), InsuranceExpirationDate = dpInsurenceExpiractionDate.Value, InsuranceAmount = vInsuranceAmount.Value });

                //Grabar los precios.
                foreach (DataRow d in dtPrices.Rows)
                {
                    db.VehiclesPrices.AddOrUpdate(new VehiclesPrice { PriceId = Convert.ToInt32(d["PriceId"]), VehicleId = lastident, DayRange1 = Convert.ToInt32(d["DayRange1"]), DayRange2 = Convert.ToInt32(d["DayRange2"]), Price1 = Convert.ToDecimal(d["Price1"]), Price2 = Convert.ToDecimal(d["Price2"]) });
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Success = false;
                MessageBox.Show(ex.Message, "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Success)
                {
                    MessageBox.Show("Información actualizadas de manera exitosa!!!","Información:",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillDataGrid();
                    clearFields();
                    ClearSpentFields();
                    FillGridSpent(0);
                    ClearPricesFields();

                    cmdAdd.Enabled = true;
                    cmdSave.Enabled = false;
                    cmdCancel.Enabled = false;
                    FieldsEnable(false);
                    dtPrices.Clear();
                }
            }

        }

        private bool TextControlsValided(Control control)
        {
            return (control.Text.Trim().Length > 0);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea cancelar la operación?","Confirmación:",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                clearFields();
                ClearSpentFields();
                FillGridSpent(0);
                ClearPricesFields();

                cmdAdd.Enabled = true;
                cmdSave.Enabled = false;
                cmdCancel.Enabled = false;
                FieldsEnable(false);
                dtPrices.Clear();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                //lstResult.Clear();
                dgConsulta.DataSource = db.vwVehicles.ToList(); 
            }
            else
            {
                //lstResult.Clear();
                //lstResult = db.vwVehicles.Where(xc => xc.Description.ToUpper().Contains(txtBuscar.Text.ToUpper()) || xc.PlateNumber.Contains(txtBuscar.Text)).ToList();
                dgConsulta.DataSource = db.vwVehicles.Where(xc => xc.Description.ToUpper().Contains(txtBuscar.Text.ToUpper()) || xc.PlateNumber.Contains(txtBuscar.Text)).ToList();
            }

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVehicles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea salir del programa?","Confirmación:",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.No )
            {
                e.Cancel = true;
            }
        }

        private void ClearSpentFields()
        {
            txtIdSpent.Text = string.Empty;
            cmbSpentType.SelectedIndex = 0;
            dpSpentDate.Value = DateTime.Today;
            vSpentAmount.Value = 0;
            txtSpentNote.Text = string.Empty;
            vSpentAmount.Value = 0;
            vSpentAmount.Select(0, vSpentAmount.Text.Length);
            vSpentAmount.Focus();

            cmdAddSpent.Enabled = true;
            cmdSaveSpent.Enabled = false;
            cmdCancelSpent.Enabled = false;

            cmbSpentType.Enabled = false;
            dpSpentDate.Enabled = false;
            vSpentAmount.Enabled = false;
            txtSpentNote.ReadOnly = true;

        }

        private void ClearPricesFields()
        {
            txtPriceId.Text = string.Empty;
            vDay1.Value = 0;
            vDay2.Value = 0;
            vPriceRange1.Value = 0;
            vPriceRange2.Value = 0;

            cmdAddPrice.Enabled = true;
            cmdSavePrice.Enabled = false;
            cmdCancelPrice.Enabled = false;

            vDay1.Enabled = false;
            vDay2.Enabled = false;
            vPriceRange1.Enabled = false;
            vPriceRange2.Enabled = false;
            
         }

        private void cmdAddSpent_Click(object sender, EventArgs e)
        {
            ClearSpentFields();

            cmdAddSpent.Enabled = false;
            cmdSaveSpent.Enabled = true;
            cmdCancelSpent.Enabled = true;
            
            cmbSpentType.Enabled = true;
            dpSpentDate.Enabled = true;
            vSpentAmount.Enabled = true;
            txtSpentNote.ReadOnly = false;    

        }

        private void cmdSaveSpent_Click(object sender, EventArgs e)
        {
            int idSpent = 0, idVeh=0;
            bool Sucess = true;

            if (txtVehicleId.Text.Trim().Length > 0)
            {
                idVeh = Convert.ToInt32(txtVehicleId.Text);
            }

            if (txtIdSpent.Text.Trim().Length>0)
            {
                idSpent = Convert.ToInt32(txtIdSpent.Text);
            }

            if (idVeh == 0)
            {
                MessageBox.Show("Favor seleccionar el vehiculo antes de registrar el gastos!!!", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((int)cmbSpentType.SelectedValue == 0)
            {
                MessageBox.Show("Favor seleccionar el tipo de gastos antes de grabar!!!","Mensaje de Error:",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (vSpentAmount.Value == 0)
            {
                MessageBox.Show("Favor indicar el monto del gastos antes de grabar!!!", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.VehiclesExpensses.AddOrUpdate(new VehiclesExpenss { Id = idSpent, VehicleId = idVeh, ExpenseDate = dpSpentDate.Value, ExpenseType = (int)cmbSpentType.SelectedValue, ExpenseAmount = vSpentAmount.Value, ExpenseNotes = txtSpentNote.Text });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Sucess=false;
                MessageBox.Show(ex.Message, "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Sucess)
                {
                    cmdAddSpent.Enabled = true;
                    cmdSaveSpent.Enabled = false;
                    cmdCancelSpent.Enabled = false;

                    cmbSpentType.Enabled = false;
                    dpSpentDate.Enabled = false;
                    vSpentAmount.Enabled = false;
                    txtSpentNote.ReadOnly = true;

                    FillGridSpent(idVeh);
                    ClearSpentFields();
                }

            }


        }

        private void cmdCancelSpent_Click(object sender, EventArgs e)
        {
            if (vSpentAmount.Value!=0 || txtSpentNote.Text.Trim().Length>0) 
            {
                if (MessageBox.Show("Realmente cancelar el registro de gastos?", "Confirmación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

            }
            cmdAddSpent.Enabled = true;
            cmdSaveSpent.Enabled = false;
            cmdCancelSpent.Enabled = false;

            cmbSpentType.Enabled = false;
            dpSpentDate.Enabled = false;
            vSpentAmount.Enabled = false;
            txtSpentNote.ReadOnly = true;

            ClearSpentFields();
        }

        private void cmdDeletePic_Click(object sender, EventArgs e)
        {
            if (picVehicle.Image!=null)
            {
                if (MessageBox.Show("Realmente desea borrar la foto del vehiculo?", "Confirmación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    picVehicle.Image = null;
                }
            }
        }

        private void dgSpents_Click(object sender, EventArgs e)
        {
            if (dgSpents.Rows == null) return;
            if (dgSpents.Rows.Count<=0) return;

            bool Sucess = true;

            try
            {
                txtIdSpent.Text = dgSpents.CurrentRow.Cells["Id"].Value.ToString();
                cmbSpentType.SelectedValue = dgSpents.CurrentRow.Cells["idTipo"].Value;
                dpSpentDate.Value = (DateTime)dgSpents.CurrentRow.Cells["Fecha"].Value;
                vSpentAmount.Value = (decimal)dgSpents.CurrentRow.Cells["Monto"].Value;
                txtSpentNote.Text = dgSpents.CurrentRow.Cells["Nota"].Value.ToString();
            }
            catch (Exception ex)
            {
                Sucess=false;
                MessageBox.Show(ex.Message, "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Sucess)
                {
                    cmdAddSpent.Enabled = false;
                    cmdSaveSpent.Enabled = true;
                    cmdCancelSpent.Enabled = true;

                    cmbSpentType.Enabled = true;
                    dpSpentDate.Enabled = true;
                    vSpentAmount.Enabled = true;
                    txtSpentNote.ReadOnly = false;

                    vSpentAmount.Select(0, vSpentAmount.Text.Length);
                    vSpentAmount.Focus();
                }
            }
        }

        private void btnFindExpensse_Click(object sender, EventArgs e)
        {
            if (txtVehicleId.Text.Length==0)
            {
                return;
            }

            FillGridSpent(Convert.ToInt32(txtVehicleId.Text),dpSpentDate1.Value,dpSpentDate2.Value);

        }

        private void cmdSpentFindCancel_Click(object sender, EventArgs e)
        {
            dpSpentDate1.Value = DateTime.Today;
            dpSpentDate2.Value = DateTime.Today;
            if (txtVehicleId.Text.Length==0)
            {
                FillGridSpent(0);
            }
            else
            {
                FillGridSpent(Convert.ToInt32(txtVehicleId.Text));
            }
        }

        private void frmVehicles_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void FieldsEnable(bool enable)
        {
            txtPlate.Enabled= enable;
            txtChassis.Enabled= enable;
            cmbBrand.Enabled= enable;
            cmbClasses.Enabled= enable;
            txtColor.Enabled= enable;
            cmbYears.Enabled= enable;
            cmbModels.Enabled = enable;
            cmbTrans.Enabled= enable;
            cmbFuel.Enabled= enable;
            cmbOwner.Enabled= enable;
            cmbStatus.Enabled= enable;
            dpAcqDate.Enabled= enable;
            txtMileage.Enabled= enable;
            txtDescription.Enabled= enable;
            vLastMileage.Enabled= enable;
            vIntervalMileage.Enabled= enable;
            dpLastServiceDate.Enabled= enable;  
            dpNextServiceDate.Enabled= enable;
            dpNextInspectionDate.Enabled= enable;
            dpPlateExpirationDate.Enabled= enable;
            cmbInsurences.Enabled= enable;
            txtPolicy.Enabled= enable;
            dpInsurenceExpiractionDate.Enabled= enable;
            vInsuranceAmount.Enabled= enable;
            cmdLoadPic.Enabled= enable;
            cmdDeletePic.Enabled= enable;
            vPrice1.Enabled= enable;
            vPrice2.Enabled= enable;
            vPrice3.Enabled= enable;
            vPrice4.Enabled= enable;
            vPrice5.Enabled= enable;
            vPrice1A.Enabled = enable;
            vPrice2A.Enabled = enable;
            vPrice3A.Enabled = enable;
            vPrice4A.Enabled = enable;
            vPrice5A.Enabled = enable;


            if (enable)
            {
                cmdAdd.Enabled = false;
                cmdSave.Enabled = true;
                cmdCancel.Enabled = true;
            }
            else
            {
                cmdAdd.Enabled = true;
                cmdSave.Enabled = false;
                cmdCancel.Enabled = false;
            }
        }

        private void vDay1_Enter(object sender, EventArgs e)
        {
            vDay1.Select(0, vDay1.Text.Length);
        }

        private void vDay2_Enter(object sender, EventArgs e)
        {
            vDay2.Select(0, vDay2.Text.Length);
        }

        private void vPriceRange1_Enter(object sender, EventArgs e)
        {
            vPriceRange1.Select(0, vPriceRange1.Text.Length);
        }

        private void vPriceRange2_Enter(object sender, EventArgs e)
        {
            vPriceRange2.Select(0, vPriceRange2.Text.Length);
        }

        private void cmdAddPrice_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length==0)
            {
                MessageBox.Show("Debe completar la informacion del vehiculo antes de colocar los precios","Mensaje de Error:",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ClearPricesFields();

            cmdDeletePrice.Enabled = false;
            cmdAddPrice.Enabled = false;
            cmdSavePrice.Enabled = true;
            cmdCancelPrice.Enabled = true;

            vDay1.Enabled= true;
            vDay2.Enabled= true;
            vPriceRange1.Enabled= true;
            vPriceRange2.Enabled = true;

            vDay1.Focus();
        }

        private void cmdCancelPrice_Click(object sender, EventArgs e)
        {
            if (vPriceRange1.Value != 0)
            {
                if (MessageBox.Show("Realmente cancelar el registro de precios?", "Confirmación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

            }
            cmdAddPrice.Enabled = true;
            cmdSavePrice.Enabled = false;
            cmdCancelPrice.Enabled = false;
            cmdDeletePrice.Enabled = false;

            vDay1.Enabled = false;
            vDay2.Enabled = false;
            vPriceRange1.Enabled = false;
            vPriceRange1.Enabled = false;
            vPriceRange2.Enabled = false;

            ClearPricesFields();

        }

        private void cmdSavePrice_Click(object sender, EventArgs e)
        {
            if (vDay1.Value==0)
            {
                MessageBox.Show("Favor indicar la cantidad de dias desde", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vDay1.Focus();
                return;
            }

            if (vDay2.Value == 0)
            {
                MessageBox.Show("Favor indicar la cantidad de dias hasta", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vDay2.Focus();
                return;
            }

            if (vPrice1.Value == 0)
            {
                MessageBox.Show("Favor indicar el precio de renta", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vPrice1.Focus();    
                return;
            }


            if (vPrice2.Value == 0)
            {
                MessageBox.Show("Favor indicar el precio de inversionista", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vPrice2.Focus();
                return;
            }
            if (txtPriceId.Text.Trim().Length==0)
            {
                txtPriceId.Text = "0";
            }
            int PriceId = Convert.ToInt32(txtPriceId.Text);
            int PriVehId = Convert.ToInt32(txtPriceVehicleId.Text);
            DataRow[] row = null;

            if (PriceId==0)
            {
                row = dtPrices.Select("PriceId=" + PriceId.ToString() + " AND VehicleId=" + txtPriceVehicleId.Text + " AND DayRange1=" + vDay1.Value.ToString() + " AND DayRange2=" + vDay2.Value.ToString());
            }else
            {
                row = dtPrices.Select("PriceId=" + PriceId.ToString() + " AND VehicleId=" + txtPriceVehicleId.Text);
            }

            if (row.Length==0)
            {
                DataRow r = dtPrices.NewRow();
                r["PriceId"]=PriceId;
                r["VehicleId"]= PriVehId;
                r["DayRange1"] = vDay1.Value;
                r["DayRange2"] = vDay2.Value;
                r["Price1"] = vPriceRange1.Value;
                r["Price2"] = vPriceRange2.Value;
                dtPrices.Rows.Add(r);
            }
            else
            {
                row[0]["PriceId"] = PriceId;
                row[0]["VehicleId"] = PriVehId;
                row[0]["DayRange1"] = vDay1.Value;
                row[0]["DayRange2"] = vDay2.Value;
                row[0]["Price1"] = vPriceRange1.Value;
                row[0]["Price2"] = vPriceRange2.Value;
            }
            dtPrices.AcceptChanges();

            cmdAddPrice.Enabled = true;
            cmdSavePrice.Enabled = false;
            cmdCancelPrice.Enabled = false;
            cmdDeletePrice.Enabled = false;

            vDay1.Enabled = false;
            vDay2.Enabled = false;
            vPriceRange1.Enabled = false;
            vPriceRange1.Enabled = false;
            vPriceRange2.Enabled = false;

            ClearPricesFields();
        }

        private void dgPrices_Click(object sender, EventArgs e)
        {
            if (dgPrices.Rows.Count>0)
            {

                txtPriceId.Text = dgPrices.CurrentRow.Cells["PriceId"].Value.ToString();
                txtPriceVehicleId.Text = dgPrices.CurrentRow.Cells["VehicleId"].Value.ToString();
                vDay1.Value = (int)dgPrices.CurrentRow.Cells["DayRange1"].Value;
                vDay2.Value = (int)dgPrices.CurrentRow.Cells["DayRange2"].Value;
                vPriceRange1.Value = (decimal)dgPrices.CurrentRow.Cells["Price1"].Value;
                vPriceRange2.Value = (decimal)dgPrices.CurrentRow.Cells["Price2"].Value;

                cmdAddPrice.Enabled = false;
                cmdSavePrice.Enabled = true;
                cmdCancelPrice.Enabled = true;
                cmdDeletePrice.Enabled = true;

                vDay1.Enabled = true;
                vDay2.Enabled = true;
                vPriceRange1.Enabled = true;
                vPriceRange2.Enabled = true;

                vDay1.Focus();
            }
        }

        private void cmdDeletePrice_Click(object sender, EventArgs e)
        {
            if (txtPriceVehicleId.Text.Trim().Length==0 && txtPriceId.Text.Trim().Length==0)
            {
                MessageBox.Show("Favor seleccionar el precio antes de eliminarlo.", "Mensaje de Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string condition = "PriceId=" + txtPriceId.Text + " AND VehicleId=" + txtVehicleId.Text + " AND DayRange1=" + vDay1.Value.ToString() + " AND DayRange2=" + vDay2.Value.ToString();
            int priceId = 0;
            DataRow[] r = dtPrices.Select(condition);


            if (r.Length>0)
            {
                if (MessageBox.Show("Esta seguro de borrar el rango de precio","Confirmación:",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
                {
                    return;
                }

                r[0].Delete();
                dtPrices.AcceptChanges();

                if (txtPriceId.Text!="0")
                {
                    priceId = Convert.ToInt32(txtPriceId.Text);

                    var removeRecord = db.VehiclesPrices.Single(vp => vp.PriceId == priceId);
                    db.VehiclesPrices.Remove(removeRecord);
                    db.SaveChanges();
                }

                cmdAddPrice.Enabled = true;
                cmdSavePrice.Enabled = false;
                cmdCancelPrice.Enabled = false;
                cmdDeletePrice.Enabled = false;

                vDay1.Enabled = false;
                vDay2.Enabled = false;
                vPriceRange1.Enabled = false;
                vPriceRange1.Enabled = false;
                vPriceRange2.Enabled = false;

                ClearPricesFields();

            }

        }
    }
}
