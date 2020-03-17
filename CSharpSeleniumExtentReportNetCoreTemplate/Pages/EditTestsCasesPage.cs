using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Bases;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    class EditTestsCasesPage : PageBase
    {
        By commentsTextArea = By.Id("test_case_comments");
        By changeButton = By.XPath("//*[@class='ppt-btn-default ppt-btn-save']");
        By successChange = By.XPath("//*[@class='notifyjs-bootstrap-base notifyjs-bootstrap-success']");

        public void InserirInfoEmObservacoesGerais(string observacoesGerais)
        {
            SendKeys(commentsTextArea, observacoesGerais);
        }

        public void ClicarEmAlterar()
        {
            Click(changeButton);
        }
         public string RetornaAlteracaoCasosDeTestesComSucesso()
        {
            return GetText(successChange);
        }
    }
}
