using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS
{
    public class TestBase
    {
        protected AppManager app;


        [SetUp]
        public void SetupTest()
        {
            app = AppManager.GetInstance();
     
        }

      

       
    }
}
