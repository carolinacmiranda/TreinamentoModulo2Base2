using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Flows
{
    public class LogoutFlows
    {
        LogoutPage logoutPage;
        MainPage mainPage;

        public LogoutFlows()
        {
            logoutPage = new LogoutPage();
            mainPage = new MainPage();
        }

        public void EfetuarLogout()
        {
            logoutPage.ClicarNoUsernameParaDeslogar();
            logoutPage.ClicarEmSair();
        }
    }
}
