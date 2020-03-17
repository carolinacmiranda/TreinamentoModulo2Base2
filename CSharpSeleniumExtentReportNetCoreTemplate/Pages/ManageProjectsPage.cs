using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class ManageProjectsPage : PageBase
    {
        #region Mapping
        By manageProjectsButton = By.ClassName("column-button");
        By manageProjectsPageTextArea = By.XPath("//*[@class='ppt-btn-default ppt-btn-manager']");
        #endregion

        #region Actions
        public void ClicarEmGerencieSeusProjetosAqui()
        {
            Click(manageProjectsButton);
        }
 
        public string RetornaValidacaoPaginaGerenciarProjetos()
        {
            return GetText(manageProjectsPageTextArea);
        }
        #endregion
    }
}
