﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleAjaxDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error()
        {
            Exception exception = Server.GetLastError().GetBaseException();
            LogError(exception);
        }
        private void LogError(Exception ex)
        {
            string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "===================================================================================================";
            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex.Message);
            message += Environment.NewLine;
            message += "---------------------------------------------------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("StackTrace: {0}", ex.StackTrace);
            message += Environment.NewLine;
            message += "---------------------------------------------------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Source: {0}", ex.Source);
            message += Environment.NewLine;
            message += "--------------------------------- ------------------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("TargetSite: {0}", ex.TargetSite.ToString());
            message += "--------------------------------- ------------------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("InnerException: {0}", ex.InnerException);
            message += "--------------------------------- ------------------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Data: {0}", ex.Data);
            message += Environment.NewLine;
            message += "===================================================================================================";
            message += Environment.NewLine;
            string path = Server.MapPath("~/ErrorLog/"+DateTime.UtcNow.ToString("dd-MM-yyyy") +".txt");
           
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
                writer.Close();
            }
        }
    }
}
