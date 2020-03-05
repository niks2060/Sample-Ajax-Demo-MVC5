using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.Models.DAL
{
    public static class ConnectionString
    {
        public static string getConnectionstring() {

            string Connectionstr = "Data Source=.;Initial Catalog=EntityCodeFirst;Integrated Security=True";
            return Connectionstr;
        }
    }
}