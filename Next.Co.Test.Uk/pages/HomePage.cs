using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next.Co.Test.Uk.pages
{
    public class HomePage : BaseClass
    {
        IWebElement CustomerProduct;
        IWebElement CustomerSubmitButton;


        public void EnterProduct(string Product)
        {
            CustomerProduct = GetElementById("sli_search_1");
            CustomerProduct.SendKeys(Product);
        }
        public SearchResultPage ClickOnSearchButton()
            {

            CustomerSubmitButton = GetElementByClassName("SearchButton");
      CustomerSubmitButton.Click();
            return new SearchResultPage();

            }

        
        }
    }
    

   

     
