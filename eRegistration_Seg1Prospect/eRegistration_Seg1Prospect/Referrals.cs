using eRegistration_Seg1Prospect.TestData;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace eRegistration_Seg1Prospect
{
    public class Referrals
    {
        public static void Referal2eRegistration()
        {
            //Create BrowserWindow
            BrowserWindow Browind = new BrowserWindow();


            //wait for control ready
            Browind.WaitForControlReady(1000);

            // Referral pane
            Browind.SearchProperties[UITestControl.PropertyNames.Name] = "Referrals";

            //Progress Meter 
            HtmlCustom progress = new HtmlCustom(Browind);
            progress.SearchProperties[HtmlCustom.PropertyNames.Id] = "progressmeter";
            bool availabilty = (bool)progress.GetProperty(HtmlCustom.PropertyNames.Exists);
            string workflowEvent = PersonalInformation1.ReadData(1, "WORKFLOW");
            if (workflowEvent == "S1PROSPECT")
            {
                Assert.IsTrue(availabilty, "Progress Meter is not showing");

                HtmlSpan bar = new HtmlSpan(Browind);
                bar.SearchProperties[HtmlSpan.PropertyNames.Id] = "meterlabel";
                string percentage = (string)bar.GetProperty(HtmlSpan.PropertyNames.InnerText);
                Assert.AreEqual(percentage, "60%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }




            //Save And Continue button
            HtmlControl SaveCont = new HtmlControl(Browind);
            SaveCont.SearchProperties[HtmlButton.PropertyNames.Id] = "ForwardButton_button";


            //Click button Save And Continue
            Assert.IsTrue(SaveCont.Enabled);
            Mouse.Click(SaveCont);

            Browind.WaitForControlReady(1000);
        }
    }
}