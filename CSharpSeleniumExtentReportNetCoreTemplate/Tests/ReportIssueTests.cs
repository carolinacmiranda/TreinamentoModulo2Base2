﻿using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.Flows;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class ReportIssueTests : TestBase
    {
        #region Page Objects
        [AutoInstance] LoginFlows loginFlows;
        [AutoInstance] MainPage mainPage;
        [AutoInstance] ManageProjectsPage manageProjectsPage;
        [AutoInstance] ProjectsPage projectsPage;
        [AutoInstance] TrainingPage trainingPage;
        [AutoInstance] AccessEditTestsCasesPage accessEditTestsCasesPage;
        [AutoInstance] EditTestsCasesPage editTestsCasesPage;
        [AutoInstance] LogoutFlows logoutFlows;
        [AutoInstance] BugReportPage bugReportPage;
        #endregion

        //[Test]
        //public void CadastrarNovaIssueComSucessoInformandoSomenteCamposObrigatorios()
        //{
        //    #region Parameters
        //    string usuario = "templateautomacao";
        //    string senha = "123456";
        //    string categoria = "[All Projects] Desafio jMeter";
        //   // string resumo = "Resumo teste automático " + GeneralHelpers.ReturnStringWithRandomCharacters(5);
        //    string descricao = "Descrição teste automático";
        //    //string caminhoArquivo = GeneralHelpers.ReturnProjectPath() + "Resources/Files/anexo_ocorrencia.jpg";
        //    #endregion

        //    loginFlows.EfetuarLogin(usuario, senha);
        //    mainPage.ClicarEmReportIssue();
        //    bugReportPage.SelecionarCategoria(categoria);
        //    bugReportPage.PreencherResumo(resumo);
        //    bugReportPage.PreencherDescricao(descricao);
        //    bugReportPage.InserirAnexo(caminhoArquivo);
        //    bugReportPage.ClicarEmSubmitReport();
        //}
    }
}
