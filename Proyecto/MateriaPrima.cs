using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto
{
    public partial class MateriaPrima : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        public MateriaPrima()
        {
            InitializeComponent();
        }

        private void MateriaPrima_Load(object sender, EventArgs e)
        {

        }
        public void Ingresar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "AltaMateriaPrima";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Nombre";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                
                if(rbtnLacteos.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "LAC";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnCarnes.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "CAR";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if(RbtnVerduras.Checked==true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "VER";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if(rbtnFrutas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "FRU";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if(rbtnArinas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "HAR";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if(rbtnGrasas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "GRS";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Cantidad";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtCantidad.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ComandProyecto.Connection = _sql.ConProyecto;
                int i = _sql.ComandProyecto.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Datos registrados con éxito", "Datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Eror", "Datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _sql.ConProyecto.Close();
            }
            
        }
        public void Actualizar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "ActualizarMP";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtId.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Nombre";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                if (rbtnLacteos.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "LAC";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnCarnes.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "CAR";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (RbtnVerduras.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "VER";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnFrutas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "FRU";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnArinas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "HAR";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnGrasas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoMP";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "GRS";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Cantidad";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtCantidad.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ComandProyecto.Connection = _sql.ConProyecto;
                int i = _sql.ComandProyecto.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Datos registrados con éxito", "Datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Eror", "Datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _sql.ConProyecto.Close();
            }
        }
       
        public void Consultar()
        {
            _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
            _sql.ConProyecto.Open();
            if (_sql.DatasetProyecto == null)
            {
                _sql.DatasetProyecto = new DataSet();
            }
            if (_sql.DataAdapterProyecto == null)
            {
                _sql.DataAdapterProyecto = new SqlDataAdapter("select * from MateriaPrima", _sql.ConProyecto);
            }
            _sql.DatasetProyecto.Clear();
            _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "MateriaPrima");
            DWVMateria.DataSource = _sql.DatasetProyecto;
            DWVMateria.DataMember = "MateriaPrima";
            _sql.DatasetProyecto = null;
            _sql.DataAdapterProyecto = null;
            _sql.ConProyecto.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void DWVMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = DWVMateria.SelectedCells[0].RowIndex;
            txtId.Text = DWVMateria.Rows[i].Cells[0].Value.ToString();
            txtNombre.Text = DWVMateria.Rows[i].Cells[1].Value.ToString();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            Consultar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Ingresar();
            Consultar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMateriaPrima _MP = new EliminarMateriaPrima();
            _MP.ShowDialog();
            Close();
        }
    }
}
