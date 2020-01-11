using Next.Co.Test.Uk.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Next.Co.Test.Uk.StepDefination
{
    [Binding]
    public sealed class SearchStep : BaseClass
    {
        HomePage homePage = new HomePage();
        SearchResultPage searchResultPage = new SearchResultPage();

        [Given(@"i navigate to next homepage")]
        public void GivenINavigateToNextHomepage()
        {
            LaunchUrl("https://www.next.co.uk/");
        }

        [When(@"i enter ""(.*)"" of my choice")]
        public void WhenIEnterOfMyChoice(string Product)
        {
            homePage.EnterProduct(Product);
        }

        [When(@"click on submit button")]
        public void WhenClickOnSubmitButton()
        {
            searchResultPage = homePage.ClickOnSearchButton();

        }

        [Then(@"searching product page displayed\.")]
        public void ThenSearchingProductPageDisplayed_()
        {
        }


    }

  
    
    }

