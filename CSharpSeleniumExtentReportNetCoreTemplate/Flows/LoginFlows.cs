using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Flows
{
    public class LoginFlows
    {
        #region Page Object and Constructor
        LoginPage loginPage;
        MainPage mainPage;

        public LoginFlows()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();
        }
        #endregion

        public void EfetuarLogin(string username, string password)
        {
            loginPage.PreencherUsuario(username);
            loginPage.PreencherSenha(password);
            loginPage.ClicarEmLogin();
        }
    }
}
