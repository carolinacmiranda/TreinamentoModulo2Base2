using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Bases;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    class TrainingPage : PageBase
    {
        By trainingButton = By.Id("btn_open_project_595");
        By testCasesButton = By.Id("li-test-cases-link");
        By trainingPageTextArea = By.CssSelector("#dataTables-projects > tbody > tr > td:nth-child(2)");

        public void ClicarEmVisualizarTreinamento()
        {
            Click(trainingButton);
        }

        public void ClicarEmCasosDeTestes()
        {
            Click(testCasesButton);
        }
        
        public string RetornaValidacaoPaginaTreinamento()
        {
            return GetText(trainingPageTextArea);
        }
    }
}
