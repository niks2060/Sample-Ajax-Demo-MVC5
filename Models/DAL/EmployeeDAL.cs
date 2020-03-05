using SampleAjaxDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.Models.DAL
{
    public class EmployeeDAL
    {
        public List<EmployeeMasterEntity> GetAllEmployees()
        {
            List<EmployeeMasterEntity> listEmp = new List<EmployeeMasterEntity>();
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnectionstring()))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from EmployeeMaster", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                listEmp = ds.Tables[0].AsEnumerable().Select(dataRow => new EmployeeMasterEntity
                {
                    EmployeeId = dataRow.Field<int>("EId"),
                    Name = dataRow.Field<string>("Name"),
                    Age = dataRow.Field<int>("Age"),
                    ContactNo = dataRow.Field<string>("ContactNo"),
                    City = dataRow.Field<string>("City"),
                    Gender = dataRow.Field<string>("Gender"),
                    Address = dataRow.Field<string>("Address"),
                    DepartmentId = dataRow.Field<int>("DId")

                }).ToList();
            }

            foreach (var item in listEmp)
            {
                DepartmentDal Ddal = new DepartmentDal();
                item.DepartmentMasterEntity = Ddal.GetDepartmentById(item.DepartmentId);
            }
            return listEmp;
        }
    }
}