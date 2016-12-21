using System;
using System.Collections.Generic;
using System.Linq;
using AndritzSiteProvisioning;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using ServiceTester;
using SiteProvisioningShared;

namespace CreateSiteConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ProjectCreateInfo param = new ProjectCreateInfo
                                          {
                                              HostWeb = "http://portal.shark.com",
                                              Title = "ProjectA",
                                              Description = "A sample Project A",
                                              WebTemplate = "STS#1",
                                              OwnerLogin = @"shark\spfarm",
                                              ProjectOwner = @"shark\po",
                                              URL = Guid.NewGuid().ToString()
                                          };

            param.User.Add( @"shark\psampras");
            param.User.Add(@"shark\svettel");

            string xml = Helper.ToString(param);

            string url = ProvisioningLogic.CreateSiteCollection(param);
         
        }

     
    }
}
