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
    class AccessCasesTests : TestBase
    {
        #region Pages and Flows Objects
        LoginPage loginPage;
        MainPage mainPage;
        LoginFlows loginFlows;
        ManageProjectsPage manageProjectsPage;
        ProjectsPage projectsPage;
        TrainingPage trainingPage;
        AccessEditTestsCasesPage accessEditTestsCasesPage;
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
            accessEditTestsCasesPage = new AccessEditTestsCasesPage();
            logoutPage = new LogoutPage();
            logoutFlows = new LogoutFlows();

            #region Parameters
            string usuario = "carolina.miranda@base2.com.br";
            string senha = "base2tecnologia";
            string gerenciarProjetos = "Gerencie seus projetos aqui";
            string projetos = "Projetos";
            string treinamento = "Treinamento Carolina Miranda";
            string casosDeTestes = "CT09 - Verificar Acesso";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);

            Assert.AreEqual(gerenciarProjetos, manageProjectsPage.RetornaValidacaoPaginaGerenciarProjetos());
            manageProjectsPage.ClicarEmGerencieSeusProjetosAqui();

            Assert.AreEqual(projetos, projectsPage.RetornaValidacaoPaginaProjetos());
            projectsPage.ClicarEmProjetos();

            Assert.AreEqual(treinamento, trainingPage.RetornaValidacaoPaginaTreinamento());
            trainingPage.ClicarEmVisualizarTreinamento();

            trainingPage.ClicarEmCasosDeTestes();
            Assert.AreEqual(casosDeTestes, accessEditTestsCasesPage.RetornaValidacaoPaginaCasosDeTestes());

            logoutFlows.EfetuarLogout();
        }
    }
}
