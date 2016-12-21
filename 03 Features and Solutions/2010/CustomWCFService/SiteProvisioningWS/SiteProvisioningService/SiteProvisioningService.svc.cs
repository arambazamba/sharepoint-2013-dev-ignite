using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client.Services;
using System.ServiceModel.Activation;
using ServiceTester;
using SiteProvisioningShared;


namespace AndritzSiteProvisioning
{
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class SiteProvisioningService : ISiteProvisioningService
    {

        public string CreatSite(string Param)
        {
            string result = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(Param) == false)
                {
                    ProjectCreateInfo param = Helper.ToObject<ProjectCreateInfo>(Param);
                    if (param != null)
                    {
                        result = ProvisioningLogic.CreateSiteCollection(param);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            } 
            return result;
        }
    }
}
