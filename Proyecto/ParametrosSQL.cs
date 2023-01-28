using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Proyecto
{
    class ParametrosSQL
    {
        public SqlConnection ConProyecto;
        public SqlCommand ComandProyecto;
        public SqlParameter ParameProyeto;
        public DataSet DatasetProyecto;
        public SqlDataAdapter DataAdapterProyecto;
        public SqlDataReader DataReaderProyecto; 
    }
}
