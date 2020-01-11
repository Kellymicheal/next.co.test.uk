using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next.Co.Test.Uk.pages
{
    public class SearchResultPage : BaseClass
    {
        IWebElement PageText;

        public void IsResultDisplayed()
        {
            PageText = GetElementByClassName("spell-correct");
            Assert.IsTrue(PageText.Displayed);
        }
    }
}
