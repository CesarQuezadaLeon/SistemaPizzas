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
    public partial class Pedidos : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        string Dato;
        int auxiliar;
        public Pedidos()
        {
            InitializeComponent();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (rbtNormal.Checked == true)
            {
                ConsultarDetallePedido();
            }
            else if (rbtFecha.Checked == true)
            {
                ConsultarDetallePedidoFecha();
            }
        }
        public void ConsultarDetallePedido()
        {
            _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
            _sql.ConProyecto.Open();
            if (_sql.DatasetProyecto == null)
            {
                _sql.DatasetProyecto = new DataSet();
            }
            if (_sql.DataAdapterProyecto == null)
            {
                _sql.DataAdapterProyecto = new SqlDataAdapter("select * from PedidoProveedor", _sql.ConProyecto);
            }
            _sql.DatasetProyecto.Clear();
            _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "PedidoProveedor");
            DatosConsulados.DataSource = _sql.DatasetProyecto;
            DatosConsulados.DataMember = "PedidoProveedor";
            _sql.DatasetProyecto = null;
            _sql.DataAdapterProyecto = null;
            _sql.ConProyecto.Close();
        }
        public void ConsultarDetallePedidoFecha()
        {
             try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand("FechaDePedido",_sql.ConProyecto);                
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.DataAdapterProyecto = new SqlDataAdapter(_sql.ComandProyecto);
                _sql.DatasetProyecto = new DataSet();
                _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto);

                DatosConsulados.DataSource = _sql.DatasetProyecto.Tables[0];
                _sql.ComandProyecto.Connection = _sql.ConProyecto;
                int i = _sql.ComandProyecto.ExecuteNonQuery();
                
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
        public void ConsultarPagos()
        {
            _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
            _sql.ConProyecto.Open();
            if (_sql.DatasetProyecto == null)
            {
                _sql.DatasetProyecto = new DataSet();
            }
            if (_sql.DataAdapterProyecto == null)
            {
                _sql.DataAdapterProyecto = new SqlDataAdapter("select * from PagosProveedor", _sql.ConProyecto);
            }
            _sql.DatasetProyecto.Clear();
            _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "PagosProveedor");
            DatosConsulados.DataSource = _sql.DatasetProyecto;
            DatosConsulados.DataMember = "PagosProveedor";
            _sql.DatasetProyecto = null;
            _sql.DataAdapterProyecto = null;
            _sql.ConProyecto.Close();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            ConsultarPagos();
        }

        private void rbtFecha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DetalleProveevor_Load(object sender, EventArgs e)
        {
           
        }

        private void ComboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        public void Registrar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "AltaPedidoProveedor";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Pedido";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtPedido.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Cantidad";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtCantidad.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Precio";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Money;
                _sql.ParameProyeto.Value = Convert.ToDouble(txtPrecio.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@FechaPedido";
                _sql.ParameProyeto.SqlDbType = SqlDbType.DateTime;
                _sql.ParameProyeto.Value = Convert.ToDateTime(txtFecha.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Observaciones";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtObservaciones.Text;
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
                _sql.ComandProyecto.CommandText = "ActualizarPedidoProveedor";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdDetallePP";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtIdPedido.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Pedido";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtPedido.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Cantidad";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = Convert.ToInt32(txtCantidad.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Precio";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Money;
                _sql.ParameProyeto.Value = Convert.ToDouble(txtPrecio.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@FechaPedido";
                _sql.ParameProyeto.SqlDbType = SqlDbType.DateTime;
                _sql.ParameProyeto.Value = Convert.ToDateTime(txtFecha.Text);
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Observaciones";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtObservaciones.Text;
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
                _sql.DataAdapterProyecto = new SqlDataAdapter("select * from PedidoProveedor", _sql.ConProyecto);
            }
            _sql.DatasetProyecto.Clear();
            _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "PedidoProveedor");
            DatosConsulados.DataSource = _sql.DatasetProyecto;
            DatosConsulados.DataMember = "PedidoProveedor";
            _sql.DatasetProyecto = null;
            _sql.DataAdapterProyecto = null;
            _sql.ConProyecto.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
            _sql.ConProyecto.Open();
            _sql.ComandProyecto = new SqlCommand();
            _sql.ComandProyecto.CommandText = "EliminarDPP";
            _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
            _sql.ComandProyecto.Parameters.Clear();

            _sql.ParameProyeto = new SqlParameter();
            _sql.ParameProyeto.ParameterName = "@IdDetallePP";
            _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
            _sql.ParameProyeto.Value = Convert.ToInt32(txtIdPedido.Text);
            _sql.ParameProyeto.Direction = ParameterDirection.Input;
            _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

        }
    }
}
