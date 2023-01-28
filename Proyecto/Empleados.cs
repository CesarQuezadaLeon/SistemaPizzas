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
    public partial class Empleados : Form
    {
        ParametrosSQL _sql = new ParametrosSQL();
        
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }
        public void RegistroEmpleados()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "AltaEmpleados";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@NombreEmp";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtNombre.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApePatEmp";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApePat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApeMatEmp";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApeMat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                if (rbtnMasculino.Checked)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@SexoEmp";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "M";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnFemenino.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@SexoEmp";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "F";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                if (rbtnVendedor.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Puesto";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "V";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                else if (rbtnCocinerop.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Puesto";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "C";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                else if (rbtnGerente.Checked== true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Puesto";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "G";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                else if (rbtnRepartidor.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Puesto";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "R";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }


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
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
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
                _sql.ParameProyeto.ParameterName = "@HoraEntrada";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Time;
                _sql.ParameProyeto.Value = txtHoraEntrada.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@HoraSalida";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Time;
                _sql.ParameProyeto.Value = txtHoraSalida.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Salario";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Money;
                _sql.ParameProyeto.Value = txtsalario.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Contraseña";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtContraseña.Text;
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
        public void ActualizarEmpleado()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                _sql.ComandProyecto = new SqlCommand();
                _sql.ComandProyecto.CommandText = "AcutualizarEmpleados";
                _sql.ComandProyecto.CommandType = CommandType.StoredProcedure;
                _sql.ComandProyecto.Parameters.Clear();

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@IdEmpleado";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Int;
                _sql.ParameProyeto.Value = txtIdEmpleado.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "NombreEmp";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtIdEmpleado.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApePatEmp";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApePat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@ApeMatEmp";
                _sql.ParameProyeto.SqlDbType = SqlDbType.VarChar;
                _sql.ParameProyeto.Value = txtApeMat.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                if (rbtnMasculino.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@SexoEmp";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "M";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }
                else if (rbtnFemenino.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@SexoEmp";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "F";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                if (rbtnVendedor.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Puesto";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "V";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                else if (rbtnCocinerop.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Puesto";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "C";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                else if (rbtnGerente.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Puesto";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "G";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

                else if (rbtnRepartidor.Checked == true)
                {
                    _sql.ParameProyeto = new SqlParameter();
                    _sql.ParameProyeto.ParameterName = "@Puesto";
                    _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                    _sql.ParameProyeto.Value = "R";
                    _sql.ParameProyeto.Direction = ParameterDirection.Input;
                    _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);
                }

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
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtTelefono.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@HoraEntrada";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Time;
                _sql.ParameProyeto.Value = txtHoraEntrada.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@HoraSalida";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Time;
                _sql.ParameProyeto.Value = txtHoraSalida.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Salario";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Money;
                _sql.ParameProyeto.Value = txtsalario.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ParameProyeto = new SqlParameter();
                _sql.ParameProyeto.ParameterName = "@Contraseña";
                _sql.ParameProyeto.SqlDbType = SqlDbType.Char;
                _sql.ParameProyeto.Value = txtContraseña.Text;
                _sql.ParameProyeto.Direction = ParameterDirection.Input;
                _sql.ComandProyecto.Parameters.Add(_sql.ParameProyeto);

                _sql.ComandProyecto.Connection = _sql.ConProyecto;
                int i = _sql.ComandProyecto.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Datos registrados con éxito", "Datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void Consultar()
        {
            try
            {
                _sql.ConProyecto = new SqlConnection(Program.CadenaConexion);
                _sql.ConProyecto.Open();
                if (_sql.DatasetProyecto == null)
                {
                    _sql.DatasetProyecto = new DataSet();
                }
                if (_sql.DataAdapterProyecto == null)
                {
                    _sql.DataAdapterProyecto = new SqlDataAdapter("select * from Empleados", _sql.ConProyecto);
                }
                _sql.DatasetProyecto.Clear();
                _sql.DataAdapterProyecto.Fill(_sql.DatasetProyecto, "Empleados");
                GwidEmpleados.DataSource = _sql.DatasetProyecto;
                GwidEmpleados.DataMember = "Empleados";
                _sql.DatasetProyecto = null;
                _sql.DataAdapterProyecto = null;
                _sql.ConProyecto.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            RegistroEmpleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado _elimiaremp = new EliminarEmpleado();
            _elimiaremp.ShowDialog();
        }

        private void GwidEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = GwidEmpleados.SelectedCells[0].RowIndex;
            txtIdEmpleado.Text = GwidEmpleados.Rows[i].Cells[0].Value.ToString();
            txtNombre.Text = GwidEmpleados.Rows[i].Cells[1].Value.ToString();
            txtApePat.Text = GwidEmpleados.Rows[i].Cells[2].Value.ToString();
            txtApeMat.Text = GwidEmpleados.Rows[i].Cells[3].Value.ToString();            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
