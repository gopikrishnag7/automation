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
    public class SelfIdentificationSurvey
    {
        public static void SelfIdentificationSurvey1()
        {
            //Create browserwindow
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Self-Identification Survey";
            Mouse.MoveScrollWheel(-120);

            //Button "Save And Continue"

            HtmlInputButton SaveNContinue = new HtmlInputButton(browind);
            SaveNContinue.SearchProperties[HtmlButton.PropertyNames.Id] = "ForwardButton_button";
           


            // Progress Meter

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
                Assert.AreEqual(percentage, "70%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }

            //Click Save and Continue button
            Mouse.Click(SaveNContinue);

            browind.WaitForControlReady(2000);




        }
    }
}
