﻿<%@ Page language="C#" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<WebPartPages:AllowFraming ID="AllowFraming" runat="server" />

<html>
<head>
    <title></title>
    <script type="text/javascript">
        // Set the style of the client web part page to be consistent with the host web.
        function setStyleSheet() {
            var hostUrl = ""
            if (document.URL.indexOf("?") != -1) {
                var params = document.URL.split("?")[1].split("&");
                for (var i = 0; i < params.length; i++) {
                    p = decodeURIComponent(params[i]);
                    if (/^SPHostUrl=/i.test(p)) {
                        hostUrl = p.split("=")[1];
                        document.write("<link rel=\"stylesheet\" href=\"" + hostUrl + "/_layouts/15/defaultcss.ashx\" />");
                        break;
                    }
                }
            }
            if (hostUrl == "") {
                document.write("<link rel=\"stylesheet\" href=\"/_layouts/15/1033/styles/themable/corev15.css\" />");
            }
        }
        setStyleSheet();
    </script>
    <script src="../Scripts/MyClientWebPart.js"></script>
</head>
<body>
    <div id="appPartDiv"></div>
    <input type="button" value="Push Me!" onclick="helloAppPart();" />
</body>
</html>
