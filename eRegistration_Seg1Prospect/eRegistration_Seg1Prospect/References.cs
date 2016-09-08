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
    public class References
    {
        public static void eReg_Reference()
        {

            /*****************/
            //Create browserwindow
            /*****************/
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "References";

            //Verify References pane is available
            HtmlControl ReferencesPane = new HtmlControl(browind);
            ReferencesPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "References";




            // References 1
            /*References1 Name*/
            HtmlSpan Reference1Name = new HtmlSpan(browind);
            Reference1Name.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_name";
            Reference1Name.DrawHighlight();

            //Reference1 Type
            HtmlComboBox Ref1type = new HtmlComboBox(browind);
            Ref1type.SearchProperties[HtmlComboBox.PropertyNames.Id] = "Ref1_type";
            Ref1type.DrawHighlight();
            // string ReferenceType = (string)Ref1type.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);

            //Ref1 Current Title
            HtmlSpan RefTitle = new HtmlSpan(browind);
            RefTitle.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_title";
            RefTitle.DrawHighlight();

            //Ref1 Company Name
            HtmlSpan Ref1CompanyName = new HtmlSpan(browind);
            Ref1CompanyName.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_company";
            Ref1CompanyName.DrawHighlight();

            //Ref1 Location (City, State/Prov, and Country)
            HtmlSpan RefLocation = new HtmlSpan(browind);
            RefLocation.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_location";
            RefLocation.DrawHighlight();

            //Ref1Area Code
            HtmlSpan RefAreaCode = new HtmlSpan(browind);
            RefAreaCode.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_phone_areacode";
            RefAreaCode.DrawHighlight();

            //Ref1 Phone
            HtmlSpan Ref1Phone = new HtmlSpan(browind);
            Ref1Phone.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_phone";
            Ref1Phone.DrawHighlight();

            //Ref1 Phone Ext
            HtmlSpan Ref1PhoneExt = new HtmlSpan(browind);
            Ref1PhoneExt.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_ext";
            Ref1PhoneExt.DrawHighlight();

            //Ref1 Fax No
            HtmlSpan Ref1FaxNo = new HtmlSpan(browind);
            Ref1FaxNo.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_fax";
            Ref1FaxNo.DrawHighlight();

            //Ref1 Email Address
            HtmlSpan Ref1EmailAddress = new HtmlSpan(browind);
            Ref1EmailAddress.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref1_email";
            Ref1EmailAddress.DrawHighlight();


            //*******************
            // References 2
            //*******************

            /*References2 Name*/
            HtmlSpan Reference2Name = new HtmlSpan(browind);
            Reference2Name.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_name";
            Reference2Name.DrawHighlight();

            //Reference2 Type
            HtmlComboBox Ref2type = new HtmlComboBox(browind);
            Ref2type.SearchProperties[HtmlComboBox.PropertyNames.Id] = "Ref2_type";
            Ref2type.DrawHighlight();
            // string eRegstate = (string)Ref2type.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);

            //Ref2 Current Title
            HtmlSpan Ref2Title = new HtmlSpan(browind);
            Ref2Title.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_title";
            Ref2Title.DrawHighlight();

            //Ref2 Company Name
            HtmlSpan Ref2CompanyName = new HtmlSpan(browind);
            Ref2CompanyName.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_company";
            Ref2CompanyName.DrawHighlight();

            //Ref2 Location (City, State/Prov, and Country)
            HtmlSpan Ref2Location = new HtmlSpan(browind);
            Ref2Location.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_location";
            Ref2Location.DrawHighlight();

            //Ref2 Area Code
            HtmlSpan Ref2AreaCode = new HtmlSpan(browind);
            Ref2AreaCode.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_phone_areacode";
            Ref2AreaCode.DrawHighlight();

            //Ref2 Phone
            HtmlSpan Ref2Phone = new HtmlSpan(browind);
            Ref2Phone.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_phone";
            Ref2Phone.DrawHighlight();

            //Ref2 Phone Ext
            HtmlSpan Ref2PhoneExt = new HtmlSpan(browind);
            Ref2PhoneExt.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_ext";
            Ref2PhoneExt.DrawHighlight();

            //Ref2 Fax No
            HtmlSpan Ref2FaxNo = new HtmlSpan(browind);
            Ref2FaxNo.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_fax";
            Ref2FaxNo.DrawHighlight();

            //Ref2 Email Address
            HtmlSpan Ref2EmailAddress = new HtmlSpan(browind);
            Ref2EmailAddress.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref2_email";
            Ref2EmailAddress.DrawHighlight();

            //*******************
            // References 3
            //*******************

            /*References3 Name*/
            HtmlSpan Reference3Name = new HtmlSpan(browind);
            Reference3Name.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_name";
            Reference1Name.DrawHighlight();

            //Reference3 Type
            HtmlComboBox Ref3type = new HtmlComboBox(browind);
            Ref3type.SearchProperties[HtmlComboBox.PropertyNames.Id] = "Ref3_type";
            Ref3type.DrawHighlight();
            // string eRegstate = (string)Ref3type.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);

            //Ref3 Current Title
            HtmlSpan Ref3Title = new HtmlSpan(browind);
            Ref3Title.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_title";
            Ref3Title.DrawHighlight();

            //Ref3 Company Name
            HtmlSpan Ref3CompanyName = new HtmlSpan(browind);
            Ref3CompanyName.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_company";
            Ref3CompanyName.DrawHighlight();

            //Ref3 Location (City, State/Prov, and Country)
            HtmlSpan Ref3Location = new HtmlSpan(browind);
            Ref3Location.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_location";
            Ref3Location.DrawHighlight();

            //Ref3 Area Code
            HtmlSpan Ref3AreaCode = new HtmlSpan(browind);
            Ref3AreaCode.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_phone_areacode";
            Ref3AreaCode.DrawHighlight();

            //Ref3 Phone
            HtmlSpan Ref3Phone = new HtmlSpan(browind);
            Ref3Phone.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_phone";
            Ref3Phone.DrawHighlight();

            //Ref3 Phone Ext
            HtmlSpan Ref3PhoneExt = new HtmlSpan(browind);
            Ref3PhoneExt.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_ext";
            Ref3PhoneExt.DrawHighlight();

            //Ref3 Fax No
            HtmlSpan Ref3FaxNo = new HtmlSpan(browind);
            Ref3FaxNo.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_fax";
            Ref3FaxNo.DrawHighlight();

            //Ref3 Email Address
            HtmlSpan Ref3EmailAddress = new HtmlSpan(browind);
            Ref3EmailAddress.SearchProperties[HtmlSpan.PropertyNames.InnerText] = "Ref3_email";
            Ref3EmailAddress.DrawHighlight();


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
                bar.SearchProperties[HtmlSpan.PropertyNames.Id] = "meterdiv";
                bar.DrawHighlight();
                string percentage = (string)bar.GetProperty(HtmlSpan.PropertyNames.InnerText);
                Assert.AreEqual(percentage, "55%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }


            //Click button Save And Continue
            HtmlSpan SaveAndCountinue = new HtmlSpan(browind);
            SaveAndCountinue.SearchProperties[HtmlSpan.PropertyNames.Id] = "ForwardButton_button";
            SaveAndCountinue.DrawHighlight();
            Mouse.Click(SaveAndCountinue);

            browind.WaitForControlReady(2000);


        }
    }
}
