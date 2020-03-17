using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    class AccessEditTestsCasesPage : PageBase
    {
        By editButton = By.XPath("//*[@class='ppt-btn-circle ppt-btn-circle-edit']");
        By testsCasesPageTextArea = By.ClassName("sorting_1");

        public void ClicarEmEditarCasosDeTestes()
        {
            Click(editButton);
        }

        public string RetornaValidacaoPaginaCasosDeTestes()
        {
            return GetText(testsCasesPageTextArea);
        }
    }
}