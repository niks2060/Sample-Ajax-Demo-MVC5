using SampleAjaxDemo.Models;
using SampleAjaxDemo.Models.DAL;
using SampleAjaxDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.ViewModel
{
    public class DepartmentVM
    {
        public DepartmentMasterDto DepartmentMasterDto { get; set; }
        public DepartmentMasterEntity DepartmentMasterEntity { get; set; }
        public List<DepartmentMasterDto> DepartmentMasterDtoList { get; set; }
        public OrganizationMasterDto OrganizationMasterDto { get; set; }
        public string Message { get; set; }

        public List<DepartmentMasterDto> GetAllDepartments()
        {
            DepartmentDal Ddal = new DepartmentDal();
            DepartmentMasterDtoList = new List<DepartmentMasterDto>();
            try
            {
                List<DepartmentMasterEntity> DepartmentMasterEntityList = Ddal.GetAllDepartments();
                foreach (DepartmentMasterEntity departmentMasterEntity in DepartmentMasterEntityList)
                {
                    DepartmentMasterDto = new DepartmentMasterDto();
                    Mapper.MapDepartmentMasterEntityToDto(departmentMasterEntity, DepartmentMasterDto);
                    DepartmentMasterDtoList.Add(DepartmentMasterDto);
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            return DepartmentMasterDtoList;
        }

        public void SaveOrupdateDepartment(DepartmentMasterDto departmentMasterDto)
        {
            DepartmentDal Ddal = new DepartmentDal();
            DepartmentMasterEntity departmentMasterEntity = new DepartmentMasterEntity();
            try
            {
                Mapper.MapDepartmentMasterDtoToEntity(departmentMasterDto, departmentMasterEntity);
                Ddal.SaveDepartment(departmentMasterEntity);
                Message = "Organization Save Successfully";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
    }
}