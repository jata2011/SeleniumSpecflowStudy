using System;
using TechTalk.SpecFlow;

namespace JataSpecflow_Project.StepDefinitions
{
    [Binding]
    public class ToolsQA
    {
        [Given(@"the user navigate to ToolsQA")]
        public void GivenTheUserNavigateToToolsQA()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Enter search criteria in Search Textbox")]
        public void GivenEnterSearchCriteriaInSearchTextbox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user press Enter Key")]
        public void WhenTheUserPressEnterKey()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the search result should appear")]
        public void ThenTheSearchResultShouldAppear()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
