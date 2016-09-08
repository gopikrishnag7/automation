﻿using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRegistration_Seg1Prospect
{
    public class WorkExperienceExempt
    {
        public static void workExperienceExmpt_SaveNContinue()
        {
            //Create BrowserWindow

            BrowserWindow browind = new BrowserWindow();

            //Work Experience Exmpt pane
            browind.WaitForControlReady(20000);
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Work Experience Exempt";

            //check checkbox
            HtmlCheckBox chkBox = new HtmlCheckBox(browind);
            chkBox.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "Employer1_minMonths_claim";
            

            //Button Save And Continue 
            HtmlControl SaveCont = new HtmlControl(browind);
            SaveCont.SearchProperties[HtmlButton.PropertyNames.Id] = "ForwardButton_button";
            
            if (chkBox.Checked == false)
            {
                //Verify SaveNContinue button is unable
                Assert.IsFalse(SaveCont.Enabled);
                chkBox.SetProperty(HtmlCheckBox.PropertyNames.Checked, true);
            }
            else
            {
                Assert.IsTrue(SaveCont.Enabled);
                
            }


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
                //Assert.AreEqual(percentage, "55%");
                Assert.AreEqual(percentage, "50%");
            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }

            //Click Save And Continue 

            Mouse.Click(SaveCont);
            browind.WaitForControlReady(2000);

        }
    }
}
