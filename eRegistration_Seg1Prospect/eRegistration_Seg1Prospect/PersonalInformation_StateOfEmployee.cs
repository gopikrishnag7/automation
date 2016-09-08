using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRegistration_Seg1Prospect
{
    public class PersonalInformation_StateOfEmployee
    {
        public static void stateOfEmployee()
        {
            

            //Create browserwindow
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Information";
           

            //State of Employment  (i.e., the state in which you expect to work) 
            HtmlComboBox state = new HtmlComboBox(browind);
            state.SearchProperties[HtmlComboBox.PropertyNames.Id] = "BGInfo_StateWorkIn";
            string eRegstate = (string)state.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);
           

            //Are you authorized to work in the United States
            HtmlComboBox authorization = new HtmlComboBox(browind);
            authorization.SearchProperties[HtmlComboBox.PropertyNames.Id] = "workUS";
            string eRegauthorization = (string)authorization.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);
           

            //Are You Under the Age of 18?
            HtmlComboBox age18 = new HtmlComboBox(browind);
            age18.SearchProperties[HtmlComboBox.PropertyNames.Id] = "under18";
            string eRegage18 = (string)age18.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);
            

            //Button "Save And Continue" -- Inactive
            HtmlInputButton SaveNContinue = new HtmlInputButton(browind);
            SaveNContinue.SearchProperties[HtmlInputButton.PropertyNames.Id] = "ForwardButton_button";
            

            if (eRegstate == "" || eRegauthorization == "" || eRegage18 == "")
            {
                Assert.IsFalse(SaveNContinue.Enabled);
                
            }


           

            /*****************/
            /* Progress Meter*/
            /*****************/
            HtmlCustom progress = new HtmlCustom(browind);
            progress.SearchProperties[HtmlCustom.PropertyNames.Id] = "progressmeter";
            bool availabilty = (bool)progress.GetProperty(HtmlCustom.PropertyNames.Exists);
            string workflowEvent = PersonalInformation1.ReadData(1, "WORKFLOW");
            if (workflowEvent == "S1PROSPECT")
            {
                Assert.IsTrue(availabilty, "Progress Meter is not showing");

                HtmlSpan bar = new HtmlSpan(browind);
                bar.SearchProperties[HtmlSpan.PropertyNames.Id] = "meterlabel";
                string percentage = (string)bar.GetProperty(HtmlSpan.PropertyNames.InnerText);
                Assert.AreEqual(percentage, "30%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }


            //Fill in Mandatory Field
            state.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, PersonalInformation1.ReadData(1, "PersonalInformation_StateOfEmployee"));
            authorization.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, PersonalInformation1.ReadData(1, "PersonalInformation_Authorization"));
            age18.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, PersonalInformation1.ReadData(1, "PersonalInformation_Age18"));

            //Click Save And Continue button
            Mouse.Click(SaveNContinue);



            browind.WaitForControlReady(2000);




        }
    }
}
