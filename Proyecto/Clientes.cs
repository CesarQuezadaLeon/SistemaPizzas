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
    public partial class Clientes : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        public Clientes()
        {
            InitializeComponent();
        }

        public void Registrar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "AltaCliente";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombreC";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApePatC";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApePat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApeMatC";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApeMat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombreCalle";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtDireccion.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NumExt";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtNumExt.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NumInt";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtNumInterior.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Colonia";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtColonia.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Municipio";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtMunicioio.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@CodigoPostal";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtCP.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);


                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Telefono";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = txtTelefono.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@CE";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Time;
                _sql.ParameProyeto.Value = txtCorreoElectronico.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                if(rbtnFrecuete.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoCliente";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.NVarChar;
                    _sql.ParameProyeto.Value = "F";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if(rbtnPremium.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoCliente";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.NVarChar;
                    _sql.ParameProyeto.Value = "P";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                _sql.ComandProyecto.Connection = _sql.ConProyecto;
                int i = _sql.ComandProyecto.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Datos registrados con éxito", "Datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public void Actualizar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "ActualizarCliente";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdCliente";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtNombre.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombreC";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApePatC";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApePat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApeMatC";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApeMat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombreCalle";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtDireccion.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NumExt";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtNumExt.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NumInt";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtNumInterior.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Colonia";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtColonia.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Municipio";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtMunicioio.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@CodigoPostal";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtCP.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);


                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Telefono";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = txtTelefono.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@CE";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Time;
                _sql.ParameProyeto.Value = txtCorreoElectronico.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                if (rbtnFrecuete.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoCliente";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.NVarChar;
                    _sql.ParameProyeto.Value = "F";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnPremium.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@TipoCliente";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.NVarChar;
                    _sql.ParameProyeto.Value = "P";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                _sql.ComandProyecto.Connection = _sql.ConProyecto;
                int i = _sql.ComandProyecto.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Datos registrados con éxito", "Datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        public void Eliminar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "ActualizarCliente";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdCliente";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtNombre.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);              
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
                _sql.DataAdapterProyecto = new SqlDataAdapter("select * from Cliente", _sql.ConProyecto);
            }
            _sql.DatasetProyecto.Clear();
            _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "Cliente");
            Datos.DataSource = _sql.DatasetProyecto;
            Datos.DataMember = "Cliente";
            _sql.DatasetProyecto = null;
            _sql.DataAdapterProyecto = null;
            _sql.ConProyecto.Close();
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
