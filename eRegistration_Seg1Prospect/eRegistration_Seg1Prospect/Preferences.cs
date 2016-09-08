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
    public class Preferences
    {
        public static void eReg_Preferences()
        {
            //Create browserwindow
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Preferences";

            /*****************/
            /*Contact Methods*/
            /*****************/
            HtmlSpan ContactMethods = new HtmlSpan(browind);
            ContactMethods.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Contact Methods";
            

            /***************/
            /*Work Schedule*/
            /***************/
            HtmlSpan WorkSchedule = new HtmlSpan(browind);
            WorkSchedule.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Work Schedule";
            

            Mouse.MoveScrollWheel(-100);

            /********/
            /*Shifts*/
            /********/
            HtmlSpan Sh = new HtmlSpan(browind);
            Sh.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Shifts";
            


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
                Assert.AreEqual(percentage, "35%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }

            //Button "Save And Continue" -- Inactive
            HtmlInputButton SaveNContinue = new HtmlInputButton(browind);
            SaveNContinue.SearchProperties[HtmlInputButton.PropertyNames.Id] = "ForwardButton_button";
           
            Mouse.Click(SaveNContinue);
            
            browind.WaitForControlReady(2000);


        }
    }

}