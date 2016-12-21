using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using ServiceTester.ProvisioningService;
using System.Windows.Forms;
using System.Drawing;

namespace ServiceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            ProjectCreateInfo param = new ProjectCreateInfo
            {
                HostWeb = "http://portal.shark.com",
                Title = "ProjectA",
                Description = "A sample Project A",
                WebTemplate = "STS#1",
                OwnerLogin = @"shark\spfarm",
                ProjectOwner = @"shark\po",
                ManagedPath = @"projects",
                URL = Guid.NewGuid().ToString()
            };

            param.User.Add(@"shark\psampras");
            param.User.Add(@"shark\svettel");

            string xml = Helper.ToString(param);

            MessageBox.Show(xml);

            var client = new SiteProvisioningServiceClient();
            if (client.ClientCredentials != null)
            {
                client.ClientCredentials.Windows.ClientCredential = CredentialCache.DefaultNetworkCredentials;
                client.ClientCredentials.Windows.AllowedImpersonationLevel = TokenImpersonationLevel.Impersonation;

                result = client.CreatSite(xml);
            }
        }

        static void SendReceive()
        {

        }


    }
}
