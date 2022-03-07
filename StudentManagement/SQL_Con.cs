using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentManagement
{
    public abstract class SQL_Con
    {
        private readonly string cs;
        public SQL_Con()
        {
            cs = "Data Source = GURUTECH; Initial Catalog = spi_project; Trusted_Connection=True;";
        }
        protected SqlConnection cnn()
        {
            return new SqlConnection(cs);
        }


    }
}
