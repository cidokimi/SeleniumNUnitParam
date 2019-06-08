using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class BrowserTest : Hooks
    {


        [Test]
        public void GoogleTest()
        {
           Driver.Navigate().GoToUrl("http://www.google.com");

        }

    }
}
