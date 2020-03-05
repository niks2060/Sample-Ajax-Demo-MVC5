using SampleAjaxDemo.Models;
using SampleAjaxDemo.Models.DAL;
using SampleAjaxDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.ViewModel
{
    public class EmployeeVM
    {
        public EmployeeMasterDto employeeMasterDto { get; set; }
        public List<EmployeeMasterDto> EmployeeMasterDtoList { get; set; }
        public EmployeeMasterEntity EmployeeMasterEntity { get; set; }
        public string Message { get; set; }
        public List<EmployeeMasterDto> GetAllEmployess()
        {
            EmployeeDAL Edal = new EmployeeDAL();
            EmployeeMasterDtoList = new List<EmployeeMasterDto>();
            try
            {
                List<EmployeeMasterEntity> EmployeeMasterEntityList = Edal.GetAllEmployees();
                foreach (EmployeeMasterEntity employeeMasterEntity in EmployeeMasterEntityList)
                {
                    employeeMasterDto = new EmployeeMasterDto();
                    Mapper.MapEmployeeMasterEntityToDto(employeeMasterEntity, employeeMasterDto);
                    EmployeeMasterDtoList.Add(employeeMasterDto);
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            return EmployeeMasterDtoList;
        }
    }
}