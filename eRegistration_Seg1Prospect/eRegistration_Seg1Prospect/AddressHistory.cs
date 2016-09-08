using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRegistration_Seg1Prospect
{
    public class AddressHistory
    {
        public static void S1AddressHistory()
        {
            //Create browser window
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Address History"; 

            //Address
            HtmlEdit add = new HtmlEdit(browind);
            add.SearchProperties[HtmlEdit.PropertyNames.Id] = "Address1";
            
            //Apt./Box No.
            HtmlEdit apt = new HtmlEdit(browind);
            apt.SearchProperties[HtmlEdit.PropertyNames.Id] = "AptSuite1";
            
            //City
            HtmlEdit ct = new HtmlEdit(browind);
            ct.SearchProperties[HtmlEdit.PropertyNames.Id] = "city1";
            
            //State/Prov.
            HtmlComboBox st = new HtmlComboBox(browind);
            st.SearchProperties[HtmlComboBox.PropertyNames.Id] = "state1";
            
            //Postal/ZIP Code
            HtmlEdit zp = new HtmlEdit(browind);
            zp.SearchProperties[HtmlEdit.PropertyNames.Id] = "zip1";
            
            //Zip (last four digits)
            HtmlEdit zp4 = new HtmlEdit(browind);
            zp4.SearchProperties[HtmlEdit.PropertyNames.Id] = "zip_four1";
            
            //County
            HtmlEdit cty = new HtmlEdit(browind);
            cty.SearchProperties[HtmlEdit.PropertyNames.Id] = "county1";
            
            //Country
            HtmlComboBox country = new HtmlComboBox(browind);
            country.SearchProperties[HtmlComboBox.PropertyNames.Id] = "country1";
            
            //From  mm/yyyy
            HtmlEdit fr = new HtmlEdit(browind);
            fr.SearchProperties[HtmlEdit.PropertyNames.Id] = "1_from";
            
            //To  mm/yyyy
            HtmlEdit to = new HtmlEdit(browind);
            to.SearchProperties[HtmlEdit.PropertyNames.Id] = "1_to";

            //Mouse scroll to bottom page
            Mouse.MoveScrollWheel(-200);
            
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
                Assert.AreEqual(percentage, "20%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }

            Mouse.MoveScrollWheel(-200);

            /******************************/
            /* Button "Save And Continue" */
            /******************************/
            HtmlInputButton btnSaveNCont = new HtmlInputButton(browind);
            btnSaveNCont.SearchProperties[HtmlInputButton.PropertyNames.Id] = "ForwardButton_button";

            //Verify if there is any existing address history
            //If yes, click Continue and Save button
                //while there is error(s) return, 
                    //fixed the error(s)
           //else No, click Continue And Save button
            btnSaveNCont.SetFocus();
            Mouse.Click(btnSaveNCont);
            


            browind.WaitForControlReady(2000);

        }
    }
}
