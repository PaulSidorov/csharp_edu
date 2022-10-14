using Address_book_PS.model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS.tests
{
    public class TestBase
    {



        protected AppManager appManager;


        [SetUp]
        public void SetupTest()
        {

            appManager = new AppManager();
            appManager.Navigator.OpenHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));

        }


        [TearDown]
        public void TeardownTest()
        {
            appManager.Stop();
        }

    }
}
