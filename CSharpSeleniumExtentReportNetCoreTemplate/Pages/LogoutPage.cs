using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    class LogoutPage : PageBase
    {
        By usernameButton = By.XPath("//*[@class='dropdown-toggle toplink-b2']");
        By logoutButton = By.XPath("//a[@href='/backoffice/users/user_logout']");

        public void ClicarNoUsernameParaDeslogar()
        {
            Click(usernameButton);
        }

        public void ClicarEmSair()
        {
            Click(logoutButton);
        }
    }
}
