using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;
using TestStack.White;
using TestStack.White.AutomationElementSearch;
using TestStack.White.Factory;
using TestStack.White.UIA;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
         public Application aplicacion;
         public Window ventana;

        [TestInitialize]
        public void SetUp()
        {
            // Iniciar la aplicación
            aplicacion = Application.Launch(@"C:\Users\andys\Downloads\VyVSW\InterfazAluxito\InterfazAluxito\bin\Debug\InterfazAluxito.exe");
            //aplicacion = Application.Launch(@"C:\Users\andys\Downloads\VyVSW\InterfazAluxito\InterfazAluxito\bin\Debug\InterfazAluxito.exe");


                // Obtener la ventana principal de la aplicación
                ventana = aplicacion.GetWindow("Inicio de sesión", InitializeOption.WithCache);
                Process.GetProcessesByName(aplicacion.Name);
        }


        [TestMethod]
        public void ProbarLogin()
        {

            TextBox BoxUser = ventana.Get<TextBox>(SearchCriteria.ByAutomationId("BoxUser"));
            TextBox BoxPass = ventana.Get<TextBox>(SearchCriteria.ByAutomationId("BoxPass"));
            Button button1 = ventana.Get<Button>(SearchCriteria.ByAutomationId("button1"));
            Label lblAviso = ventana.Get<Label>(SearchCriteria.ByAutomationId("lblAviso"));
            

            Assert.IsNotNull(BoxUser);
            Assert.IsNotNull(BoxPass);

            // Simular la entrada de usuario y contraseña
            BoxUser.Text = "Andyf";
            Thread.Sleep(1500);
            BoxPass.Text = "12345";
            Thread.Sleep(1500);

            // Simular el clic en el botón de inicio de sesión
            button1.Click();
            Thread.Sleep(2000);

            // Verificar el mensaje en el label
            Assert.AreEqual("Es correcto", lblAviso.Text);

        }

        [TestCleanup]
        public void TearDown()
        {
            // Finaliza
            
            aplicacion.Close();
        }
    }
}
