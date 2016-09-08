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
    class EncryptionConsent
    {


        public static void eReg_EncryptionConsent()
        {

            //*****************/
            //Create browserwindow
            /*****************/
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Encryption Consent";

            //Verify References pane is available
            HtmlControl EncryptionConsentPane = new HtmlControl(browind);
            EncryptionConsentPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Encryption Consent";

            // CheckBox I have read, understand, and agree to the policy above.

            //check checkbox
            HtmlCheckBox checkBox = new HtmlCheckBox(browind);
            checkBox.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "encrypt_consent_ack";
            checkBox.DrawHighlight();
            Mouse.Click(checkBox);


            //chkBox.DrawHighlight();
            if (checkBox.Checked == true)
            {

                //Verify SaveNContinue button is Enable

                Assert.IsTrue(checkBox.Enabled);
                checkBox.SetProperty(HtmlCheckBox.PropertyNames.Checked, true);
                Mouse.Click(checkBox);
            }
            else
            {
                Assert.IsTrue(checkBox.Enabled, "I have read, understand, and agree to the policy above");
            }

            /*****************/
            /* Progress Meter*/
            /*****************/
            HtmlCustom progress = new HtmlCustom(browind);
            progress.SearchProperties[HtmlCustom.PropertyNames.Id] = "progressmeter";
            progress.DrawHighlight();
            bool availabilty = (bool)progress.GetProperty(HtmlCustom.PropertyNames.Exists);
            string workflowEvent = PersonalInformation1.ReadData(1, "WORKFLOW");
            if (workflowEvent == "S1PROSPECT")
            {
                Assert.IsTrue(availabilty, "Progress Meter is not showing");

                HtmlSpan bar = new HtmlSpan(browind);
                bar.SearchProperties[HtmlSpan.PropertyNames.Id] = "progressmeterdiv";
                bar.DrawHighlight();
                string percentage = (string)bar.GetProperty(HtmlSpan.PropertyNames.InnerText);
                Assert.AreEqual(percentage, "95%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }


            //Click button Save And Continue
            HtmlSpan SaveAndContinue = new HtmlSpan(browind);
            SaveAndContinue.SearchProperties[HtmlSpan.PropertyNames.Id] = "ForwardButton_button";
            // SaveAndCountinue.DrawHighlight();
            Mouse.Click(SaveAndContinue);

            browind.WaitForControlReady(2000);

        }



    }
}
