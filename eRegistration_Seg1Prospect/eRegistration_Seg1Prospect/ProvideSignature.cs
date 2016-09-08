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
    class Provide_signature
    {

        public static void eReg_Signature()
        {

            //*****************/
            //Create browserwindow
            /*****************/
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Provide your signature to proceed";

            //Verify Provide your signature to proceed pane is available
            HtmlControl EncryptionConsentPane = new HtmlControl(browind);
            EncryptionConsentPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Provide your signature to proceed";

            //Button "Save And Continue" -- 
            HtmlInputButton SaveNContinue = new HtmlInputButton(browind);
            SaveNContinue.SearchProperties[HtmlInputButton.PropertyNames.TagName] = "BUTTON";
            SaveNContinue.DrawHighlight();

            

            Mouse.Click(SaveNContinue);

            browind.WaitForControlReady(2000);





        }
    }
}