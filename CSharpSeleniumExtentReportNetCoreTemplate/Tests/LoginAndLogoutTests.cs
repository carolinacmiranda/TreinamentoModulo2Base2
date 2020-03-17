using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.DataBaseSteps;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using CSharpSeleniumExtentReportNetCoreTemplate.Flows;
using NUnit.Framework;
using System.Collections;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class LoginAndLogoutTests : TestBase
    {

        #region Pages and Flows Objects
        LoginPage loginPage;
        LoginFlows loginFlows;
        MainPage mainPage;
        LogoutPage logoutPage;
        LogoutFlows logoutFlows;
        #endregion

        [Test]
        public void RealizarLoginELogoutComSucesso()
        {
            loginPage = new LoginPage();
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            logoutPage = new LogoutPage();
            logoutFlows = new LogoutFlows();

            #region Parameters
            string usuario = "carolina.miranda@base2.com.br";
            string senha = "base2tecnologia";
            string login = "carolina.miranda";
            string logout = "×\r\nLogout com sucesso!";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            Assert.AreEqual(login, mainPage.RetornaUsernameDasInformacoesDeLogin());

            logoutFlows.EfetuarLogout();
            Assert.AreEqual(logout, mainPage.RetornaValidacaoDeLogoutComSucesso());
        }
    }
}
