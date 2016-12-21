using System.ServiceModel;

namespace AndritzSiteProvisioning
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISiteProvisioningService" in both code and config file together.
    [ServiceContract]
    public interface ISiteProvisioningService
    {
        [OperationContract]
        string CreatSite(string Param);
    }
}

