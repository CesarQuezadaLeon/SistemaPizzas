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
    public partial class Productos : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        int auxiliar;
        string dato;
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.DatasetProyecto = new DataSet();
                _sql.DataAdapterProyecto = new SqlDataAdapter("select NombrePro from Producto", _sql.ConProyecto);
                _sql.DatasetProyecto.Clear();
                _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "Producto");
                ComboProducto.DataSource = _sql.DatasetProyecto;
                ComboProducto.DisplayMember = "Producto.NombrePro";
                _sql.DatasetProyecto = null;
                _sql.DataAdapterProyecto = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.Message);
            }
            finally
            {
                _sql.ConProyecto.Close();
            }

        }
        public void Registrar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "AltaProducto";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombrePro";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@PrecioPro";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Money;
                _sql.ParameProyeto.Value = Convert.ToDecimal(txtPrecio.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Descripcion";
                _sql.ParameProyeto.SqlDbType = SqlDbType.NVarChar;
                _sql.ParameProyeto.Value = txtDescripcion.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "ActualizarProducto";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdProducto";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtId.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombrePro";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@PrecioPro";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Money;
                _sql.ParameProyeto.Value = Convert.ToDecimal(txtPrecio.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Descripcion";
                _sql.ParameProyeto.SqlDbType = SqlDbType.NVarChar;
                _sql.ParameProyeto.Value = txtDescripcion.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                _sql.DataAdapterProyecto = new SqlDataAdapter("select * from Producto", _sql.ConProyecto);
            }
            _sql.DatasetProyecto.Clear();
            _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "Producto");
            Datos.DataSource = _sql.DatasetProyecto;
            Datos.DataMember = "Producto";
            _sql.DatasetProyecto = null;
            _sql.DataAdapterProyecto = null;
            _sql.ConProyecto.Close();
        }
        public void ConsultarDetalle()
        {
            _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
            _sql.ConProyecto.Open();
            if (_sql.DatasetProyecto == null)
            {
                _sql.DatasetProyecto = new DataSet();
            }
            if (_sql.DataAdapterProyecto == null)
            {
                _sql.DataAdapterProyecto = new SqlDataAdapter("select * from DetalleProducto", _sql.ConProyecto);
            }
            _sql.DatasetProyecto.Clear();
            _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "DetalleProducto");
            dwvDetalleProducto.DataSource = _sql.DatasetProyecto;
            dwvDetalleProducto.DataMember = "DetalleProducto";
            _sql.DatasetProyecto = null;
            _sql.DataAdapterProyecto = null;
            _sql.ConProyecto.Close();
        }
        public void Eliminar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "EliminarProducto";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdProducto";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtId.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

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
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            Registrar();
            Consultar();
        }

        private void BtnActualizat_Click(object sender, EventArgs e)
        {
            Actualizar();
            Consultar();
        }

        private void BtnMonstrar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            Eliminar();
            Consultar();
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
           
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ComboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                dato = "select IdProducto from Producto where Producto.NombrePro='" + ComboProducto.Text + "'";
                _sql.ComandProyecto = new SqlCommand(dato, _sql.ConProyecto);
                _sql.DataReaderProyecto = _sql.ComandProyecto.ExecuteReader();
                while (_sql.DataReaderProyecto.Read())
                {
                    auxiliar = Convert.ToInt32(_sql.DataReaderProyecto.GetValue(0).ToString());
                }
                txtIdProducto.Text = Convert.ToString(auxiliar);
                _sql.DataReaderProyecto.Close();
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

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "AltaDetalleProducto";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                if(rbtPiza.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Categoria";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "Pizza";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if(rbtnChurro.Checked==true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Categoria";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "Churro";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnChurro.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Categoria";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "Elado";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnChurro.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Categoria";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "Bebida";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                if (rbtnLacteos.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 1;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnCarnes.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 2;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (RbtnVerduras.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 3;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnFrutas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 4;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnArinas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 5;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnGrasas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 6;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }                
                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdProducto";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtIdProducto.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

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
            ConsultarDetalle();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "ActualizarDetalleProducto";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdDetalleProducto";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtCodigoDetalle.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                if (rbtPiza.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Categoria";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "Pizza";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnChurro.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Categoria";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "Churro";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnChurro.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Categoria";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "Elado";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnChurro.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Categoria";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                    _sql.ParameProyeto.Value = "Bebida";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                if (rbtnLacteos.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 1;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnCarnes.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 2;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (RbtnVerduras.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 3;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnFrutas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 4;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnArinas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 5;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnGrasas.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@IdMateriaPrima";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                    _sql.ParameProyeto.Value = 6;
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdProducto";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtIdProducto.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

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
            ConsultarDetalle();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarDetalle();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
