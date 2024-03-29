﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using JMeterApp.WebForm;

namespace JMeterApp.WebForm
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // アプリケーションのスタートアップで実行するコードです
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
        }

        void Application_End(object sender, EventArgs e)
        {
            //  アプリケーションのシャットダウンで実行するコードです

        }

        void Application_Error(object sender, EventArgs e)
        {
            // ハンドルされていないエラーが発生したときに実行するコードです

        }
    }
}
