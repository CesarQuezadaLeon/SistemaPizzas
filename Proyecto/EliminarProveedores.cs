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
    public partial class EliminarProveedores : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        int auxiliar;
        string dato;
        public EliminarProveedores()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.DatasetProyecto = new DataSet();
                _sql.DataAdapterProyecto = new SqlDataAdapter("select NombreProveedor from Proveedores", _sql.ConProyecto);
                _sql.DatasetProyecto.Clear();
                _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "Proveedores");
                ComboProveedor.DataSource = _sql.DatasetProyecto;
                ComboProveedor.DisplayMember = "Proveedores.NombreProveedor";
                _sql.ConProyecto.Close();
                _sql.DatasetProyecto = null;
                _sql.DataAdapterProyecto = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.Message);
            }
        }

        private void ComboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                dato = "select IdProveedor from Proveedores where Proveedores.NombreProveedor='" + ComboProveedor.Text + "'";
                _sql.ComandProyecto = new SqlCommand(dato, _sql.ConProyecto);
                _sql.DataReaderProyecto = _sql.ComandProyecto.ExecuteReader();
                while (_sql.DataReaderProyecto.Read())
                {
                    auxiliar = Convert.ToInt32(_sql.DataReaderProyecto.GetValue(0).ToString());
                }
                txtId.Text = Convert.ToString(auxiliar);
                _sql.DataReaderProyecto.Close();
                _sql.ConProyecto.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "EliminarProveedor";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdProveedor";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = txtId.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ComandProyecto.Connection = _sql.ConProyecto;
                int i = _sql.ComandProyecto.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Dato Borrado con exito");
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
    }
}
