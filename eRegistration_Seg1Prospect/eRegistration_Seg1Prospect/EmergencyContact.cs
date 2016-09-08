using eRegistration_Seg1Prospect.TestData;
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
    public class EmergencyContact
    {
        public static void EmergencyContactInformation()
        {
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Emergency Contact Information";
            
            /*****************/
            /*Primary Contact*/
            /*****************/
            HtmlEdit firstname = new HtmlEdit(browind);
            firstname.SearchProperties[HtmlEdit.PropertyNames.Id] = "emergnam1";
            string fn = (string)firstname.GetProperty(HtmlEdit.PropertyNames.Text);
           

            HtmlEdit middlename = new HtmlEdit(browind);
            middlename.SearchProperties[HtmlEdit.PropertyNames.Id] = "emergnam_mid1";
            

            HtmlEdit lastname = new HtmlEdit(browind);
            lastname.SearchProperties[HtmlEdit.PropertyNames.Id] = "emergnam_last1";
            string ln = (string)lastname.GetProperty(HtmlEdit.PropertyNames.Text);
           

            Mouse.MoveScrollWheel(-100);

            /***********/
            /*Telephone*/
            /***********/
            HtmlEdit homeArea = new HtmlEdit(browind);
            homeArea.SearchProperties[HtmlEdit.PropertyNames.Id] = "emerghphon1_areacode";
            string ha = (string)homeArea.GetProperty(HtmlEdit.PropertyNames.Text);
            

            HtmlEdit homephone = new HtmlEdit(browind);
            homephone.SearchProperties[HtmlEdit.PropertyNames.Id] = "emerghphon1";
            string hp = (string)homephone.GetProperty(HtmlEdit.PropertyNames.Text);
           

            HtmlEdit workAreaCode = new HtmlEdit(browind);
            workAreaCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "emergwphone1_areacode";
            

            HtmlEdit workPhone = new HtmlEdit(browind);
            workPhone.SearchProperties[HtmlEdit.PropertyNames.Id] = "emergwphone1";
           

            HtmlEdit CellAreaCode = new HtmlEdit(browind);
            CellAreaCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "emergcphone1_areacode";
           

            HtmlEdit CellPhone = new HtmlEdit(browind);
            CellPhone.SearchProperties[HtmlEdit.PropertyNames.Id] = "emergcphone1";
            

            //Button "Save And Continue"
            HtmlInputButton SaveNContinue = new HtmlInputButton(browind);
            SaveNContinue.SearchProperties[HtmlInputButton.PropertyNames.Id] = "ForwardButton_button";
            

            //Verify button "Save And Continue" is enable to click if mandatory field is not filled
            if(fn=="" || ln=="" || ha=="" || hp=="")
            {
                Console.WriteLine("Save N Continue button is inactive");
                Assert.IsFalse(SaveNContinue.Enabled);
            }

            //Fill the form
            if (fn == "")
            {
                firstname.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "Emer_FirstName"));
                
            }

            if (ln == "")
            {
                lastname.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "Emer_LastName"));
                
            }

            Mouse.MoveScrollWheel(-100);

            if (ha == "")
            {
                homeArea.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "Emer_HomeAreaCode"));
                
            }
               
            if (hp == "")
            {
                homephone.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "Emer_HomePhone"));
                
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
                Assert.AreEqual(percentage, "25%");

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
