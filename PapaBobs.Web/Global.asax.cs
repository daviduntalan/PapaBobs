using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace PapaBobs.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Console.WriteLine("Starting application...");

            Console.WriteLine("I'm excited to learn about Git and GitHub in Visual Studio!");

            Console.WriteLine("Adding my new change");

        }
    }
}