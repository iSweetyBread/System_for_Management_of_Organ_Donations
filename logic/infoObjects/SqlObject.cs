using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic.infoObjects
{
    public abstract class SqlObject
    {
        public List<SqlParameter> parameters = new List<SqlParameter>();
    }
}
