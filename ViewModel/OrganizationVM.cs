using SampleAjaxDemo.Models;
using SampleAjaxDemo.Models.DAL;
using SampleAjaxDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.ViewModel
{
    public class OrganizationVM
    {
        public OrganizationMasterDto organizationMasterDto { get; set; }
        public OrganizationMasterEntity OrganizationMasterEntity { get; set; }
        public List<OrganizationMasterDto> OrganizationMasterDtoList { get; set; }
        public string Message { get; set; }

        public List<OrganizationMasterDto> GetAllOrganizations()
        {
            OrganizationDal Odal = new OrganizationDal();
            OrganizationMasterDtoList = new List<OrganizationMasterDto>();
            try
            {
                List<OrganizationMasterEntity> OrganizationMasterEntityList = Odal.GetAllOrgainzations();
                foreach (OrganizationMasterEntity organizationMasterEntity in OrganizationMasterEntityList)
                {
                    organizationMasterDto = new OrganizationMasterDto();
                    Mapper.MapOrganizationMasterEntityToDto(organizationMasterEntity, organizationMasterDto);
                    OrganizationMasterDtoList.Add(organizationMasterDto);
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            return OrganizationMasterDtoList;
        }

        public void SaveOrUpdateOrganization(OrganizationMasterDto organizationMasterDto)
        {
            OrganizationDal Odal = new OrganizationDal();
            OrganizationMasterEntity organizationMasterEntity = new OrganizationMasterEntity();
            try
            {
                Mapper.MapOrganizationMasterDtoToEntity(organizationMasterDto, organizationMasterEntity);
                Odal.SaveOrganization(organizationMasterEntity);
                Message = "Organization Save Successfully";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
    }
}