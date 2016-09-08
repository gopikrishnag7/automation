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
    public class WelcomePane
    {
        public static void welcome_SaveNContinue()
        {
            
            //Create BrowserWindow
            BrowserWindow Browind = new BrowserWindow();

            //Welcome Pane
            HtmlControl welPane = new HtmlControl(Browind);
            welPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Welcome";
             
            //check checkbox
            HtmlCheckBox chkBox = new HtmlCheckBox(Browind);
            chkBox.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "privacy_ack";

            //Save And Continue button
            HtmlControl SaveCont = new HtmlControl(Browind);
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
                Mouse.Click(SaveCont);
            }
            
            Browind.WaitForControlReady(50000);
            

        }

       

     

    }
}
