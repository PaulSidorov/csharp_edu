using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS
{
    public class GroupHelper : HelperBase
    {

        public GroupHelper(AppManager manager):base(manager)
        {
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper FillGroupData(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);

            return this;
        }
        
        public GroupHelper Create(GroupData group)
        {

            manager.Navigator.OpenGroupsPage();

            InitCreateNewGroup();
            FillGroupData(group);
            SubmitGroupCreation();
            ReturnToGroupPage();

            return this;
        }
        
        public GroupHelper InitCreateNewGroup()
        {
            driver.FindElement(By.Name("new")).Click();

            return this;
        }

        public GroupHelper ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();

            return this;
        }

        // первая группа, чекбокс  


        public GroupHelper SelectGroup(int groupNumber)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + groupNumber.ToString() + "]/input")).Click();
          

            return this;
        }

        public GroupHelper InitGroupEditing()
        {
            driver.FindElement(By.Name("edit")).Click();

            return this;
        }


        public GroupHelper SubmitGroupUdate()
        {
            driver.FindElement(By.Name("update")).Click();

            return this;
        }


        public GroupHelper InitDeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();

            return this;
        }
        


    }
}
