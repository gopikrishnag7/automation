using Microsoft.VisualStudio.TestTools.UITesting;
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
    public class Agreement
    {
        public static void Ereg_Agreement()
        {
            //Create BrowserWindow

            BrowserWindow browind = new BrowserWindow();

            //Agreement Pane
            browind.WaitForControlReady(20000);
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Agreement";
            Mouse.MoveScrollWheel(-120);

            //check checkbox
            HtmlCheckBox chkBox = new HtmlCheckBox(browind);
            chkBox.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "empapp_ack";
            chkBox.DrawHighlight();


            //Button Save And Continue 
            HtmlControl SaveCont = new HtmlControl(browind);
            SaveCont.SearchProperties[HtmlButton.PropertyNames.Id] = "ForwardButton_button";
            SaveCont.DrawHighlight();

            //chkBox.DrawHighlight();
            if (chkBox.Checked == false)
            {
                //Verify SaveNContinue button is unable
                Assert.IsFalse(SaveCont.Enabled);
                chkBox.SetProperty(HtmlCheckBox.PropertyNames.Checked, true);
            }
            else
            {
                Assert.IsTrue(SaveCont.Enabled);
                Mouse.Click(SaveCont);
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
                Assert.AreEqual(percentage, "80%");

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
