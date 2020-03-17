using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class MainPage : PageBase
    {
        #region Mapping
        By usernameLoginInfoTextArea = By.XPath("//*[@class='dropdown-toggle toplink-b2']");   
        By successLogout = By.XPath("//*[@class='alert alert-danger alert-dismissable']");
        #endregion

        #region Actions
        public string RetornaUsernameDasInformacoesDeLogin()
        {
            return GetText(usernameLoginInfoTextArea);
        }

        public string RetornaValidacaoDeLogoutComSucesso()
        {
            return GetText(successLogout);
        }
        #endregion
    }
}
