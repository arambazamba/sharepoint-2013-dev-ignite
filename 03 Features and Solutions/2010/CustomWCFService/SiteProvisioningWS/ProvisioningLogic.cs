using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndritzSiteProvisioning;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;

namespace SiteProvisioningShared
{
    public class ProvisioningLogic
    {
        public static string CreateSiteCollection(ProjectCreateInfo Param)
        {
            using (var cs = new SPSite(Param.HostWeb))
            {
                SPSite site = cs.WebApplication.Sites.Add(Param.RelativeURL, Param.Title, Param.Description, 1033, Param.WebTemplate, Param.OwnerLogin, Param.OwnerLogin, "OwnerMail");

                //site.RootWeb.Features.Add(new Guid("252efa43-2642-4eca-90d6-adff65570cf7"));

                SPWeb root = site.RootWeb;

                AddMembersGroup("Owners", "Full Control", new[] { Param.ProjectOwner }, Param.OwnerLogin, root);
                AddMembersGroup("Members", "Contribute", Param.User.ToArray(), Param.OwnerLogin, root);

                CreateProjectOverviewListItem(Param);

                return Param.FullURL;
            }
            
            return string.Empty;
        }

        public static void CreateProjectOverviewListItem(ProjectCreateInfo Param)
        {
            SPSite site = new SPSite(Param.OverviewSiteURL);
            SPWeb web = site.OpenWeb();
            SPList list = web.Lists[Param.ProjectOverviewListName];
            SPListItem Item = list.Items.Add();
            Item["Title"] = Param.Title;
            Item["Project Room URL"] = Param.FullURL;
           // Item["Project Manager"] = Param.ProjectOwner;
            Item.Update();
            site.Dispose();

        }



        public static SPGroup AddSiteGroup(string GroupName, SPWeb Web, string OwnerLogin, string WebTitle)
        {
            string gn = string.Format("{0} {1}", WebTitle, GroupName);
            string gd = string.Format("{0} Group", GroupName);
            SPUser owner = Web.Users[OwnerLogin];
            if (owner != null)
            {
                Web.SiteGroups.Add(gn, owner, owner, gd);
                return Web.SiteGroups[gn];
            }
            return null;
        }

        public static void AddMembersGroup(string GroupName, string PermissionLevel, string[] Users, string OwnerLogin, SPWeb Web)
        {
            SPRoleDefinition permlevel = Web.RoleDefinitions[PermissionLevel];
            SPGroup grp = AddSiteGroup(GroupName, Web, OwnerLogin, Web.Title);

            if (grp != null && permlevel != null)
            {
                var assignment = new SPRoleAssignment(grp);
                assignment.RoleDefinitionBindings.Add(permlevel);
                Web.RoleAssignments.Add(assignment);

                foreach (string usr in Users)
                {
                    if (string.IsNullOrEmpty(usr)==false)
                    {
                        SPPrincipalInfo userInfo = SPUtility.ResolvePrincipal(Web, usr, SPPrincipalType.All, SPPrincipalSource.All, null, false);
                        string displayName = userInfo != null ? userInfo.DisplayName : usr;
                        string mail = userInfo != null ? userInfo.Email : usr;
                        string descr = userInfo != null ? userInfo.Department : usr;
                        grp.Users.Add(usr, mail, displayName, descr);
                        
                    }
                }
            }
        }
    }
}
