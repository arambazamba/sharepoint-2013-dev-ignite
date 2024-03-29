﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Runtime.Serialization;
using Microsoft.SharePoint.Phone.Application;
using Microsoft.SharePoint.Client;
using System.Collections.ObjectModel;

namespace JobsApp
{
    [DataContract]
    public class DesignEditItemViewModel : EditItemViewModelBase
    {
        /// <summary>
        /// Provides edit values for fields of the List, given its name. Also used for data binding to Edit form UI
        /// </summary>
        public DesignEditItemViewModel()
        {

            //Title
            this["Title"] = "Sample Text";

            //Description
            this["Description"] = "Sample Text";

            //AssignedTo
            this["AssignedTo"] = "Sample Text";

            //Attachments
            this["Attachments"] = new ObservableCollection<AttachmentFieldViewModel>
                                                            { 
                                                                new AttachmentFieldViewModel { Name = "FileName1.txt", IsChecked = true },
                                                                new AttachmentFieldViewModel { Name = "Picture1.jpg", IsChecked = true }, 
                                                                new AttachmentFieldViewModel { Name = "Test.docx", IsChecked = true }
                                                            };

        }

        /// <summary>
        /// Provides edit values for fields of the List, given its name. Also used for data binding to Edit form UI
        /// </summary>
        /// <param name="fieldName" />
        /// <returns />
        public override object this[string fieldName]
        {
            get
            {
                return base[fieldName];
            }
            set
            {
                base[fieldName] = value;
            }
        }
    }
}
