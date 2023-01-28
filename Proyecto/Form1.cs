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
    public partial class Login : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void logins()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand("select IdEmpleado,Contraseña from Empleados where IdEmpleado='" + txtUsuario.Text + "'AND Contraseña='" + txtContraseña.Text + "'", _sql.ConProyecto);
                SqlDataReader drProyecto = _sql.ComandProyecto.ExecuteReader();
                if (drProyecto.Read())
                {
                    MessageBox.Show("Login Exitoso.");
                    Principal _Princi = new Principal();
                    _Princi.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Error usuario no encontrado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            logins();
            
        }
    }
}
