﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slingshot.Helpers
{
    public class Constants
    {
        public class Path
        {
            public static char[] SlashChars = new char[] { '/' };
            public const string HexChars = "0123456789abcdfe";
        }

        public class Repository
        {
            public const string EmptySiteTemplateUrl = "https://raw.githubusercontent.com/Tuesdaysgreen/HelloWorld/master/siteWithRepository.json";
            public const string GitCustomTemplateFormat = "https://raw.githubusercontent.com/{0}/{1}/{2}/azuredeploy.json";
        }

        public class Headers
        {
            public const string X_MS_OAUTH_TOKEN = "X-MS-OAUTH-TOKEN";
            public const string X_MS_Ellapsed = "X-MS-Ellapsed";
            public const string X_MS_CLIENT_PRINCIPAL_NAME = "X-MS-CLIENT-PRINCIPAL-NAME";
            public const string X_MS_CLIENT_DISPLAY_NAME = "X-MS-CLIENT-DISPLAY-NAME";
        }

        public class CSM
        {
            public const string ApiVersion = "2014-04-01";
            public const string GetGitDeploymentStatusFormat = "{0}/subscriptions/{1}/resourceGroups/{2}/providers/Microsoft.Web/sites/{2}/deployments?api-version={3}";
            public const string GetDeploymentStatusFormat = "{0}/subscriptions/{1}/resourcegroups/{2}/deployments/{2}/operations?api-version={3}";
        }
    }
}