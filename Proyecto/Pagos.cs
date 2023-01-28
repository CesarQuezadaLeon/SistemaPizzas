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
    public partial class Pagos : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        int auxiliar;
        string dato;
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
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
            finally
            {
                _sql.ConProyecto.Close();
            }
        }

        private void ComboProveedor_SelectedIndexChanged(object sender, EventArgs e)
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
                txtIdProveedor.Text = Convert.ToString(auxiliar);
                _sql.DataReaderProyecto.Close();
                _sql.ConProyecto.Close();
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
