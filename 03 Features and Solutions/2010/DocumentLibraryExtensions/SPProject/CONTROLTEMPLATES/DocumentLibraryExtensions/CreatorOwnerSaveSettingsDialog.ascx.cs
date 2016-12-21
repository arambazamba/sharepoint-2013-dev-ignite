﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace Integrations.DocumentLibraryExtensions.CONTROLTEMPLATES.DocumentLibraryExtensions
{
    public partial class CreatorOwnerSaveSettingsDialog : UserControl
    {
        protected const string EvtReceiverClass = "Integrations.DocumentLibraryExtensions.CreatorOwnerEventReceiver";
        protected const string key = "creatorownerpermissions";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                BindListCheckbox();
            }
        }

        protected void BindListCheckbox()
        {
            List<string> lists = null;
            if (SPContext.Current.Web.Properties[key] != null)
            {
                lists = SPContext.Current.Web.Properties[key].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            chklbLibs.Items.Clear();
            foreach (SPList list in SPContext.Current.Web.GetListsOfType(SPBaseType.DocumentLibrary))
            {
                if (list.Hidden == false && list.OnQuickLaunch)
                {
                    if (lists != null && lists.Contains(list.Title))
                    {
                        chklbLibs.Items.Add(new ListItem(list.Title) { Selected = true });
                    }
                    else
                    {
                        chklbLibs.Items.Add(new ListItem(list.Title));
                    }
                }
            }
        }

        protected void SaveSettings(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            foreach (ListItem item in chklbLibs.Items)
            {
                if (item.Selected)
                {
                    result.Add(item.Text);
                }
                EvalBindHandler(item.Text, item.Selected);
            }

            SPContext.Current.Web.AllowUnsafeUpdates = true;
            if (SPContext.Current.Web.Properties.ContainsKey(key))
            {
                SPContext.Current.Web.Properties.Remove(key);
            }
            SPContext.Current.Web.Properties.Add(key, string.Join(";", result.ToArray()));
            SPContext.Current.Web.Properties.Update();
            SPContext.Current.Web.Update();

            lblStatus.Text = "Änderungen wurden gespeichert";
        }

        protected void EvalBindHandler(string ListName, bool Bind)
        {
            SPList list = SPContext.Current.Web.Lists[ListName];
            if (list != null)
            {
                if (Bind)
                {
                    list.EventReceivers.Add(SPEventReceiverType.ItemAdded, Assembly.GetExecutingAssembly().FullName, EvtReceiverClass);
                }
                else
                {
                    foreach (SPEventReceiverDefinition  evtrd in list.EventReceivers)
                    {
                        if (evtrd.Class == EvtReceiverClass)
                        {
                            evtrd.Delete();
                        }
                    }
                }
            }
        }        
    }
}
