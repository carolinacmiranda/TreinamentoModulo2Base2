using System;
using System.Collections.Generic;
using System.Text;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using NUnit.Framework;
using CSharpSeleniumExtentReportNetCoreTemplate.Flows;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    class EditCasesTests : TestBase
    {
        #region Pages and Flows Objects
        LoginPage loginPage;
        MainPage mainPage;
        LoginFlows loginFlows;
        ManageProjectsPage manageProjectsPage;
        ProjectsPage projectsPage;
        TrainingPage trainingPage;
        AccessEditTestsCasesPage accessEditTestsCasesPage;
        EditTestsCasesPage editTestsCasesPage;
        LogoutPage logoutPage;
        LogoutFlows logoutFlows;
        #endregion

        [Test]
        public void AcessarCasosDeTestes()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();
            loginFlows = new LoginFlows();
            manageProjectsPage = new ManageProjectsPage();
            projectsPage = new ProjectsPage();
            trainingPage = new TrainingPage();
            accessEditTestsCasesPage =  new AccessEditTestsCasesPage();
            editTestsCasesPage = new EditTestsCasesPage();
            logoutPage = new LogoutPage();
            logoutFlows = new LogoutFlows();

            #region Parameters
            string usuario = "carolina.miranda@base2.com.br";
            string senha = "base2tecnologia";
            string observacoesGerais = "Editando caso de teste";
            string alteracaoSucesso = "O Caso de Teste ( CT09 - Verificar Acesso ) foi alterado com sucesso!";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            manageProjectsPage.ClicarEmGerencieSeusProjetosAqui();
            projectsPage.ClicarEmProjetos();
            trainingPage.ClicarEmVisualizarTreinamento();
            trainingPage.ClicarEmCasosDeTestes();
            accessEditTestsCasesPage.ClicarEmEditarCasosDeTestes();
            editTestsCasesPage.InserirInfoEmObservacoesGerais(observacoesGerais);

            editTestsCasesPage.ClicarEmAlterar();
            Assert.AreEqual(alteracaoSucesso, editTestsCasesPage.RetornaAlteracaoCasosDeTestesComSucesso());

            logoutFlows.EfetuarLogout();
        }
    }
}
