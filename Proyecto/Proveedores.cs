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
using MySql.Data.MySqlClient;

namespace Proyecto
{
    public partial class Proveedores : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        // La siguiente linea es la que provee la conexión entre C# y MySQL.
        // Debes cambiar el nombre de usuario, contrasenia y nombre de base de datos
        // de acuerdo a tus datos
        // Puedes ignorar la opción de base de datos (database) si quieres acceder a todas
        // 127.0.0.1 es de localhost y el puerto predeterminado para conectar
        public MySqlConnection cadenaconexion = new MySqlConnection("server=192.168.1.191;database=proyectopizzas;uid=root;pwd=;");
        DataSet ds;
        public Proveedores()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            RegistrarProveedores();
            ResgitroMYSQL();
        }
        public void RegistrarProveedores()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "AltaProveedores";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombreProveedor";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApePatPro";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApePat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApeMatPro";
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

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Marca";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Time;
                _sql.ParameProyeto.Value = txtMarca.Text;
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
                _sql.ComandProyecto.CommandText = "ActualizarProveedores";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdProveedor";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtId.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombreProveedor";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApePatPro";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApePat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApeMatPro";
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

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Marca";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Time;
                _sql.ParameProyeto.Value = txtMarca.Text;
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
                _sql.DataAdapterProyecto = new SqlDataAdapter("select * from Proveedores", _sql.ConProyecto);
            }
            _sql.DatasetProyecto.Clear();
            _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "Proveedores");
            GwidEmpleados.DataSource = _sql.DatasetProyecto;
            GwidEmpleados.DataMember = "Proveedores";
            _sql.DatasetProyecto = null;
            _sql.DataAdapterProyecto = null;
            _sql.ConProyecto.Close();
        }
        public void IngresoMysql()
        {
            string cadenaconexion = "server=192.168.1.191;database=proyectopizzas;uid=root;pwd=;";
            string query = "INSERT INTO proveedores('IdProveedor', 'NombreProveedor', 'ApePatPro', 'ApeMatPro','Direccion','Telefono') VALUES ('" + txtId.Text + "', '" + txtNombre.Text + "', '" + txtApePat.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "')";
            // Que puede ser traducido con un valor a:
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

            MySqlConnection databaseConnection = new MySqlConnection(cadenaconexion);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuario insertado satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }
        }
        public void ResgitroMYSQL()
        {

            string agregar = "insert into proveedores values (" + txtId.Text + ",'" + txtNombre.Text + "'," + txtApePat.Text + "'," + txtApeMat.Text + "'," + txtDireccion.Text + "'," + txtTelefono.Text + ")";
            MySqlCommand commandDatabase = new MySqlCommand(agregar,cadenaconexion);
            commandDatabase.CommandTimeout = 60;

            try
            {

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuario insertado satisfactoriamente");

            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedores _Eliminar = new EliminarProveedores();
            _Eliminar.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            try
            {
                cadenaconexion.Open();
                //conectado = true;
                MessageBox.Show("Se realizo la conexión con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {

            Pedidos _pedidos = new Pedidos();
            _pedidos.Show();
        }

        private void btnMYSQL_Click(object sender, EventArgs e)
        {
            ConsultardeMYSQL();
        }

        public void ConsultardeMYSQL()            
        {
            try
            {
                /*MySqlConnection Conexion = new MySqlConnection("server=192.168.1.105;port=8081;database=proyectopizzas;uid=root;pwd=;");
                Conexion.Open();*/
                MySqlCommand mostrar = new MySqlCommand("SELECT * FROM proveedores", cadenaconexion);

                MySqlDataAdapter m_datos = new MySqlDataAdapter(mostrar);
                ds = new DataSet();
                m_datos.Fill(ds,"proveedores");

                GwidEmpleados.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("", ex.Message);
            }
           
        }
    }
}
