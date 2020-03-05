using SampleAjaxDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.Models.DAL
{
    public class OrganizationDal
    {
        public List<OrganizationMasterEntity> GetAllOrgainzations()
        {
            List<OrganizationMasterEntity> listOrg = new List<OrganizationMasterEntity>();
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnectionstring()))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from OrganizationMaster", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                listOrg = ds.Tables[0].AsEnumerable().Select(dataRow => new OrganizationMasterEntity
                {
                    Name = dataRow.Field<string>("Name"),
                    OrganizationId = dataRow.Field<int>("OId"),
                    Address = dataRow.Field<string>("Address"),
                    City = dataRow.Field<string>("City"),
                    Country = dataRow.Field<string>("Country")

                }).ToList();
            }
            return listOrg;
        }

        public OrganizationMasterEntity GetOrganizationById(int Id)
        {
            OrganizationMasterEntity organizationMasterEntity = new OrganizationMasterEntity();
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnectionstring()))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from OrganizationMaster where OId = @OId", con);
                da.SelectCommand.Parameters.AddWithValue("OId", Id);
                DataSet ds = new DataSet();
                da.Fill(ds);
                organizationMasterEntity = ds.Tables[0].AsEnumerable().Select(dataRow => new OrganizationMasterEntity
                {
                    Name = dataRow.Field<string>("Name"),
                    OrganizationId = dataRow.Field<int>("OId"),
                    Address = dataRow.Field<string>("Address"),
                    City = dataRow.Field<string>("City"),
                    Country = dataRow.Field<string>("Country")
                }).FirstOrDefault();
            }
            return organizationMasterEntity;
        }

        public void SaveOrganization(OrganizationMasterEntity organizationMasterEntity)
        {           
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnectionstring()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[OrganizationMaster]([Name],[Address],[City],[Country]) VALUES (@Name, @Address, @City, @Country)", con);
                cmd.Parameters.AddWithValue("@Name", organizationMasterEntity.Name);
                cmd.Parameters.AddWithValue("@Address", organizationMasterEntity.Address);
                cmd.Parameters.AddWithValue("@City", organizationMasterEntity.City);
                cmd.Parameters.AddWithValue("@Country", organizationMasterEntity.Country);
                cmd.ExecuteNonQuery();
            }            
        }
    }
}