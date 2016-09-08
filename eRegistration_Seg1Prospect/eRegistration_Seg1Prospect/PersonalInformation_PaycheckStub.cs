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
    public class PersonalInformation_PaycheckStub
    {
        public static void paycheck_Stub()
        {
            //Create BrowserWindow
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Information";

            /********************/
            /*Period of Resident*/
            /********************/
            HtmlEdit since = new HtmlEdit(browind);
            since.SearchProperties[HtmlEdit.PropertyNames.Id] = "current_from";
            //Get data from eReg
            string eRegSinceDate = (string)since.GetProperty(HtmlEdit.PropertyNames.Text);

            /******************************/
            /* Button "Save And Continue" */
            /******************************/
            HtmlInputButton btnSaveNCont = new HtmlInputButton(browind);
            btnSaveNCont.SearchProperties[HtmlInputButton.PropertyNames.Id] = "ForwardButton_button";

            //Verify if button Save and Continue is disable if mandatory field is empty
            if  (eRegSinceDate == "")
            {
                Assert.IsFalse(btnSaveNCont.Enabled);
            }


            if (eRegSinceDate =="")
            {
                //Get data from KSN/Excel
                string  KSNSinceDate = PersonalInformation1.ReadData(1,"RESIDENTPERIOD");
                if (KSNSinceDate =="")
                {
                    since.SetProperty(HtmlEdit.PropertyNames.Text,"01/1990");
                }
                else
                {
                    since.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "RESIDENTPERIOD"));
                }
            }

            Mouse.MoveScrollWheel(-100);


            /***********************/
            /*Paycheck/Stub Address*/
            /***********************/

            //Checkbox
            HtmlCheckBox chk = new HtmlCheckBox(browind);
            chk.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "paycheck_current";
            if (chk.Checked == false)
            {
                chk.SetProperty(HtmlCheckBox.PropertyNames.Checked, true);
            }

            //Verify if the address is disable
            //Address
            HtmlEdit add = new HtmlEdit(browind);
            add.SearchProperties[HtmlEdit.PropertyNames.Id] = "Address_pay_clone";
            Assert.IsFalse(add.Enabled);
            
            HtmlEdit apt = new HtmlEdit(browind);
            apt.SearchProperties[HtmlEdit.PropertyNames.Id] = "AptSuite_pay_clone";
            Assert.IsFalse(apt.Enabled);

            HtmlEdit ct = new HtmlEdit(browind);
            ct.SearchProperties[HtmlEdit.PropertyNames.Id] = "city_pay_clone";
            Assert.IsFalse(ct.Enabled);

            HtmlComboBox st = new HtmlComboBox(browind);
            st.SearchProperties[HtmlComboBox.PropertyNames.Id] = "state_pay_clone";
            Assert.IsFalse(st.Enabled);

            HtmlEdit postal = new HtmlEdit(browind);
            postal.SearchProperties[HtmlEdit.PropertyNames.Id] = "zip_pay_clone";
            Assert.IsFalse(postal.Enabled);
            
            HtmlEdit z4 = new HtmlEdit(browind);
            z4.SearchProperties[HtmlEdit.PropertyNames.Id] = "zip_four_pay_clone";
            Assert.IsFalse(z4.Enabled);

            HtmlEdit county = new HtmlEdit(browind);
            county.SearchProperties[HtmlEdit.PropertyNames.Id] = "county_pay_clone";
            Assert.IsFalse(county.Enabled);

            HtmlComboBox country = new HtmlComboBox(browind);
            country.SearchProperties[HtmlComboBox.PropertyNames.Id] = "country_pay_clone";
            Assert.IsFalse(country.Enabled);

            HtmlEdit from = new HtmlEdit(browind);
            from.SearchProperties[HtmlEdit.PropertyNames.Id] = "pay_from_clone";
            Assert.IsFalse(from.Enabled);

            HtmlEdit to = new HtmlEdit(browind);
            to.SearchProperties[HtmlEdit.PropertyNames.Id] = "pay_to_clone";
            Assert.IsFalse(to.Enabled);

            /****************/
            /*Progress Meter*/
            /****************/

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
                Assert.AreEqual(percentage, "15%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }

             Assert.IsTrue(btnSaveNCont.Enabled);
             Mouse.Click(btnSaveNCont);

            browind.WaitForControlReady(2000);


        }
        
        



    }
}
