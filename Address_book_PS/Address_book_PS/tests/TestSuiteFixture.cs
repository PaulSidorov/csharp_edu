using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS
{
    [SetUpFixture]
    public class TestSuiteFixture
    {

        [OneTimeSetUp]
        public void InitAppManager()
        {
            AppManager app = AppManager.GetInstance();
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [OneTimeTearDown]
        public void StopApplicationManager()
        {
             AppManager.GetInstance().Stop();

        }

    }
}
