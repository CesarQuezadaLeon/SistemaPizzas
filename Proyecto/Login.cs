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
        SqlConnection ConProyecto;
        SqlCommand ComandProyecto;
        SqlParameter ParameProyeto;
        DataSet DatasetProyecto;
        SqlDataAdapter DataAdapterProyecto;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void logins()
        {
        }

    

    }
}
