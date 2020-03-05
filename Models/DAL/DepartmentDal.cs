using SampleAjaxDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Transactions;

namespace SampleAjaxDemo.Models.DAL
{
    public class DepartmentDal
    {
        public List<DepartmentMasterEntity> GetAllDepartments()
        {
            List<DepartmentMasterEntity> listDept = new List<DepartmentMasterEntity>();
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnectionstring()))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from DepartmentMaster", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                listDept = ds.Tables[0].AsEnumerable().Select(dataRow => new DepartmentMasterEntity
                {
                    Name = dataRow.Field<string>("Name"),
                    DepartmentId = dataRow.Field<int>("DId"),
                    Origin = dataRow.Field<string>("Origin"),
                    Slogan = dataRow.Field<string>("Slogan"),
                    OrganizationId = dataRow.Field<int>("OId")                   
                    
                }).ToList();
            }
            foreach (var item in listDept)
            {
                OrganizationDal ODal = new OrganizationDal();
                item.OrganizationMasterEntity = ODal.GetOrganizationById(item.OrganizationId);
            }
            return listDept;
        }

        public DepartmentMasterEntity GetDepartmentById(int Id) {
            DepartmentMasterEntity departmentMasterEntity = new DepartmentMasterEntity();
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnectionstring()))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from DepartmentMaster where DId = @DId", con);
                da.SelectCommand.Parameters.AddWithValue("DId", Id);
                DataSet ds = new DataSet();
                da.Fill(ds);
                departmentMasterEntity = ds.Tables[0].AsEnumerable().Select(dataRow => new DepartmentMasterEntity
                {
                    Name = dataRow.Field<string>("Name"),
                    OrganizationId = dataRow.Field<int>("OId"),
                    DepartmentId = dataRow.Field<int>("DId"),
                    Origin = dataRow.Field<string>("Origin"),
                    Slogan = dataRow.Field<string>("Slogan")
                }).FirstOrDefault();
            }
            OrganizationDal Odal = new OrganizationDal();
            departmentMasterEntity.OrganizationMasterEntity = Odal.GetOrganizationById(departmentMasterEntity.OrganizationId);

            return departmentMasterEntity;
        }

        public void SaveDepartment(DepartmentMasterEntity departmentMasterEntity) {

        }
    }
}