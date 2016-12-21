using System;
using System.Collections.Generic;

namespace AndritzSiteProvisioning
{
    public class ProjectCreateInfo
    {
        public ProjectCreateInfo()
        {
            User = new List<string>();
            Metadata = new List<KeyValuePair<string, string>>();
        }

        //public const string ManagedPath = "projects";

        public string HostWeb { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string WebTemplate { get; set; }
        public string OwnerLogin { get; set; }
        public string ProjectOwnerMail { get; set; }
        public string ProjectOwnerDisplayName { get; set; }
        public string ProjectOwner { get; set; }
        public string URL { get; set; }
        public string ManagedPath {get; set; }
        public string OverviewSiteURL { get; set; }
        public string ProjectOverviewListName { get; set; }

        public List<string> User { get; set; }
        public List<KeyValuePair<string, string>> Metadata { get; set; }

        public string RelativeURL { get { return "/" + ManagedPath + "/" + URL; } }
        public string FullURL { get { return HostWeb + RelativeURL + "/"; } }
    }

}
