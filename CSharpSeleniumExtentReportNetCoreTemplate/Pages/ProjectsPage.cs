using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class ProjectsPage : PageBase
    {
        By projectsButton = By.XPath("//a[@href='/backoffice/projects']");
        By projectsPageTextArea = By.XPath("//a[@href='/backoffice/projects']");

        public void ClicarEmProjetos()
        {
            Click(projectsButton);
        }

        public string RetornaValidacaoPaginaProjetos()
        {
            return GetText(projectsPageTextArea);
        }
    }
}
