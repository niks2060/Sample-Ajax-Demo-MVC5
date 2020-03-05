using SampleAjaxDemo.Models.DAL;
using SampleAjaxDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.Models
{
    public sealed class Mapper
    {
        private Mapper()
        {
        }

        public static void MapOrganizationMasterEntityToDto(OrganizationMasterEntity organizationMasterEntity, OrganizationMasterDto organizationMasterDto)
        {
            organizationMasterDto.OrganizationId = organizationMasterEntity.OrganizationId;
            organizationMasterDto.Name = organizationMasterEntity.Name;
            organizationMasterDto.Address = organizationMasterEntity.Address;
            organizationMasterDto.City = organizationMasterEntity.City;
            organizationMasterDto.Country = organizationMasterEntity.Country;

        }

        public static void MapOrganizationMasterDtoToEntity(OrganizationMasterDto organizationMasterDto, OrganizationMasterEntity organizationMasterEntity)
        {
            organizationMasterEntity.OrganizationId = organizationMasterDto.OrganizationId;
            organizationMasterEntity.Name = organizationMasterDto.Name;
            organizationMasterEntity.Address = organizationMasterDto.Address;
            organizationMasterEntity.City = organizationMasterDto.City;
            organizationMasterEntity.Country = organizationMasterDto.Country;


        }

        public static void MapDepartmentMasterEntityToDto(DepartmentMasterEntity departmentMasterEntity, DepartmentMasterDto departmentMasterDto)
        {
            departmentMasterDto.DepartmentId = departmentMasterEntity.DepartmentId;
            departmentMasterDto.Name = departmentMasterEntity.Name;
            departmentMasterDto.Origin = departmentMasterEntity.Origin;
            departmentMasterDto.Slogan = departmentMasterEntity.Slogan;
            departmentMasterDto.OrganizationId = departmentMasterEntity.OrganizationId;
            departmentMasterDto.OrganizationMasterDto = new OrganizationMasterDto();
            MapOrganizationMasterEntityToDto(departmentMasterEntity.OrganizationMasterEntity, departmentMasterDto.OrganizationMasterDto);
        }

        public static void MapDepartmentMasterDtoToEntity(DepartmentMasterDto departmentMasterDto, DepartmentMasterEntity departmentMasterEntity)
        {
            departmentMasterEntity.DepartmentId = departmentMasterDto.DepartmentId;
            departmentMasterEntity.Name = departmentMasterDto.Name;
            departmentMasterEntity.Origin = departmentMasterDto.Origin;
            departmentMasterEntity.Slogan = departmentMasterDto.Slogan;
            departmentMasterEntity.OrganizationId = departmentMasterDto.OrganizationId;
        }

        public static void MapEmployeeMasterEntityToDto(EmployeeMasterEntity employeeMasterEntity, EmployeeMasterDto employeeMasterDto)
        {
            employeeMasterDto.EmployeeId = employeeMasterEntity.EmployeeId;
            employeeMasterDto.Name = employeeMasterEntity.Name;
            employeeMasterDto.Address = employeeMasterEntity.Address;
            employeeMasterDto.Age = employeeMasterEntity.Age;
            employeeMasterDto.City = employeeMasterEntity.City;
            employeeMasterDto.ContactNo = employeeMasterEntity.ContactNo;
            employeeMasterDto.Gender = employeeMasterEntity.Gender;
            employeeMasterDto.DepartmentId = employeeMasterEntity.DepartmentId;
            employeeMasterDto.DepartmentMasterDto = new DepartmentMasterDto();
            MapDepartmentMasterEntityToDto(employeeMasterEntity.DepartmentMasterEntity, employeeMasterDto.DepartmentMasterDto);

        }

        public static void MapEmployeeMasterDtoToEntity(EmployeeMasterDto employeeMasterDto, EmployeeMasterEntity employeeMasterEntity)
        {
            employeeMasterEntity = new EmployeeMasterEntity
            {
                EmployeeId = employeeMasterDto.EmployeeId,
                Name = employeeMasterDto.Name,
                Address = employeeMasterDto.Address,
                Age = employeeMasterDto.Age,
                City = employeeMasterDto.City,
                ContactNo = employeeMasterDto.ContactNo,
                Gender = employeeMasterDto.Gender,
                DepartmentId = employeeMasterDto.DepartmentId
            };
        }
    }
}