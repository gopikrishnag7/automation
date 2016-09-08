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
    public class PersonalInformation_CurrentAddress_ContactInformation
    {
        public static void personalInformation()
        { 
            //Create BrowserWindow
            BrowserWindow Browind = new BrowserWindow();
            Browind.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Information";

            //Verify Personal Information pane is available
            HtmlControl PersonalInformationPane = new HtmlControl(Browind);
            PersonalInformationPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Personal Information";


            /*******************/
            /* Personal Detail */
            /*******************/

            //Name section - FirstName
            HtmlControl FirstName = new HtmlControl(Browind);
            FirstName.SearchProperties[HtmlEdit.PropertyNames.Id] = "first_name";
            //Compare FirstName between eReg & KSN
            string eRegFN = (string)FirstName.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNFn = PersonalInformation1.ReadData(1, "FIRSTNAME");

            //Name section - MiddleName
            HtmlControl MiddleName = new HtmlControl(Browind);
            MiddleName.SearchProperties[HtmlEdit.PropertyNames.Id] = "middle_name";
            //Compare Middle Name between KSN & eReg
            string eRegMN = (string)MiddleName.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNMn = PersonalInformation1.ReadData(1, "MIDDLENAME");

            //Name section - LastName
            HtmlControl LastName = new HtmlControl(Browind);
            LastName.SearchProperties[HtmlEdit.PropertyNames.Id] = "last_name";
            //Compare Last Name between KSN & eReg
            string eRegLN = (string)LastName.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNLn = PersonalInformation1.ReadData(1, "LASTNAME");

            //Name section - PreferredName
            HtmlControl PreferredName = new HtmlControl(Browind);
            PreferredName.SearchProperties[HtmlEdit.PropertyNames.Id] = "prefname";
            //Compare Preferred Name between KSN & eReg
            string eRegPN = (string)PreferredName.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNPn = PersonalInformation1.ReadData(1, "PREFERREDNAME");

            //Name section - Social Security #
            HtmlControl SSNumber = new HtmlControl(Browind);
            SSNumber.SearchProperties[HtmlEdit.PropertyNames.Name] = "ssn";
            //Get Social Security # from  KSN 
            string eRegTaxID = (string)SSNumber.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNTaxID = PersonalInformation1.ReadData(1, "TAXID");

            //Name section - Social Security #-Re-type
            HtmlControl SSNumber2 = new HtmlControl(Browind);
            SSNumber2.SearchProperties[HtmlEdit.PropertyNames.Id] = "ssn_verify";
            string eRegTaxIDVer = (string)SSNumber2.GetProperty(HtmlEdit.PropertyNames.Text);
            string TaxIDVer = PersonalInformation1.ReadData(1, "TAXID");

            /********************/
            /* Personal Address */
            /********************/

            //Address
            HtmlControl Add1 = new HtmlControl(Browind);
            Add1.SearchProperties[HtmlEdit.PropertyNames.Id] = "Address";
            //Compare Address between KSN & eReg
            string eRegAdd1 = (string)Add1.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNAdd1 = PersonalInformation1.ReadData(1, "ADDRESS1");

            // Apt./Lot #
            HtmlControl Add2 = new HtmlControl(Browind);
            Add2.SearchProperties[HtmlEdit.PropertyNames.Id] = "AptSuite";
            //Compare Address between KSN & eReg
            string eRegAdd2 = (string)Add2.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNAdd2 = PersonalInformation1.ReadData(1, "ADDRESS2");

            //City
            HtmlControl ct = new HtmlControl(Browind);
            ct.SearchProperties[HtmlEdit.PropertyNames.Id] = "city";
            //Compare city between KSN & eReg
            string eRegCt = (string)ct.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNCt = PersonalInformation1.ReadData(1, "CITY");

            //State
            HtmlComboBox st = new HtmlComboBox(Browind);
            st.SearchProperties[HtmlComboBox.PropertyNames.Id] = "state";
            //Compare State between KSN & eReg
            string eRegSt = (string)st.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);
            string KSNSt = PersonalInformation1.ReadData(1, "ESTATE");

            //Zip
            HtmlEdit zp = new HtmlEdit(Browind);
            zp.SearchProperties[HtmlEdit.PropertyNames.Id] = "zip";
            //Compare Zip between KSN & ereg
            string eRegZip = (string)zp.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNZip = PersonalInformation1.ReadData(1, "ZIP");

            // Zip Last 4 digit
            HtmlEdit zp4 = new HtmlEdit(Browind);
            zp4.SearchProperties[HtmlEdit.PropertyNames.Id] = "zip_four";
            //Compare Zip between KSN & ereg
            string eRegZip4 = (string)zp4.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNZip4 = PersonalInformation1.ReadData(1, "ZIP4");

            //County
            HtmlEdit cty = new HtmlEdit(Browind);
            cty.SearchProperties[HtmlEdit.PropertyNames.Id] = "county";
            //Compare Zip between KSN & ereg
            string eRegcty = (string)cty.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNcty = PersonalInformation1.ReadData(1, "COUNTY");

            //Country
            HtmlComboBox crty = new HtmlComboBox(Browind);
            crty.SearchProperties[HtmlComboBox.PropertyNames.Id] = "country";
            //Compare State between KSN & eReg
            string eRegcrty = (string)crty.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);
            string KSNcrty = PersonalInformation1.ReadData(1, "COUNTRY");

            /***************************/
            /* Personal Contact Number */
            /***************************/

            // Primary Phone Area Code
            HtmlEdit areacode = new HtmlEdit(Browind);
            areacode.SearchProperties[HtmlEdit.PropertyNames.Id] = "phone_areacode";
            //Compare phone area code between KSN & eReg
            string eRegAreaCode1 = (string)areacode.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNAreaCode1 = PersonalInformation1.ReadData(1, "HOMEAREACODE");

            //Primary Phone
            HtmlEdit primaryphone = new HtmlEdit(Browind);
            primaryphone.SearchProperties[HtmlEdit.PropertyNames.Id] = "phone";
            //Compare Primary Phone number between KSN & eReg
            string eRegPhone1 = (string)primaryphone.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNPhone1 = PersonalInformation1.ReadData(1, "HOMEPHONENUMBER");

            //Secondary Phone Area Code 
            HtmlEdit AreaCode2 = new HtmlEdit(Browind);
            AreaCode2.SearchProperties[HtmlEdit.PropertyNames.Id] = "mobilephone_areacode";
            //Compare Second Phone number between KSN & eReg
            string eRegAreaCode2 = (string)AreaCode2.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNAreaCode2 = PersonalInformation1.ReadData(1, "CELLAREACODE");

            //Secondary Phone 
            HtmlEdit phone2 = new HtmlEdit(Browind);
            phone2.SearchProperties[HtmlEdit.PropertyNames.Id] = "mobilephone";
            //Compare Second Phone number between KSN & eReg
            string eRegphone2 = (string)phone2.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNphone2 = PersonalInformation1.ReadData(1, "CELLAREANUMBER");

            //Primary Email Address
            HtmlEdit email = new HtmlEdit(Browind);
            email.SearchProperties[HtmlEdit.PropertyNames.Id] = "EmpEmail";
            //Compare emailAddress between KSN & eReg
            string eRegemail = (string)email.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNemail = PersonalInformation1.ReadData(1, "EMAILADDRESS");

            // Alternate Email Address
            HtmlEdit email2 = new HtmlEdit(Browind);
            email2.SearchProperties[HtmlEdit.PropertyNames.Id] = "altemail";
            //Compare Alternate Email Address between KSN & eReg
            string eRegemail2 = (string)email2.GetProperty(HtmlEdit.PropertyNames.Text);
            string KSNemail2 = PersonalInformation1.ReadData(1, "ALT_EMAILADDRESS");

            // Preferred Method of Contact
            HtmlComboBox ContactMethod = new HtmlComboBox(Browind);
            ContactMethod.SearchProperties[HtmlComboBox.PropertyNames.Id] = "PrefContact";
            //Get data from eReg and KSN
            string eRegCM = (string)ContactMethod.GetProperty(HtmlComboBox.PropertyNames.SelectedItem);
            string KSNCM = PersonalInformation1.ReadData(1, "PREFERMETHOD");


            /******************************/
            /* Button "Save And Continue" */
            /******************************/
            HtmlInputButton btnSaveNCont = new HtmlInputButton(Browind);
            btnSaveNCont.SearchProperties[HtmlInputButton.PropertyNames.Id] = "ForwardButton_button";


            //If Mandatory field is null, verify SaveNContinue button is unable
            if (eRegFN == "" || eRegLN == "" || eRegTaxID == "" || eRegTaxIDVer == "" ||
                eRegAdd1 == "" || eRegCt == "" || eRegSt == "" || eRegZip == "" || eRegcty == "" || eRegcrty =="" ||
                eRegAreaCode1 == "" || eRegPhone1 == "" || eRegemail == "" || eRegCM =="")
            {
                Assert.IsFalse(btnSaveNCont.Enabled);
            }
           
            //Fill up Personal Information

            // if eRegFN != KSNFn, then insert KSNFn
            if (eRegFN != KSNFn)
            {
                Mouse.DoubleClick(FirstName);
                FirstName.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "FIRSTNAME"));
            }
                                            
             // if eRegMN != KSNMn, then insert KSNMn
            if (eRegMN != KSNMn)
            {
                Mouse.DoubleClick(MiddleName);
                MiddleName.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "MIDDLENAME"));
            }
                        
            // if eRegLN != KSNLn, then insert KSNLn
            if (eRegLN != KSNLn)
            {
                Mouse.DoubleClick(LastName);
                LastName.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "LASTNAME"));
            }
                        
            // if eRegPN != KSNPn, then insert KSNPn
            if (eRegPN != KSNPn)
            {
                Mouse.DoubleClick(PreferredName);
                PreferredName.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "PREFERREDNAME"));
            }
                        
            if (KSNTaxID == "")
            {
                Keyboard.SendKeys(SSNumber, "123121234");
            }
            else                 
            {
                Keyboard.SendKeys(SSNumber, KSNTaxID);
            }
            Keyboard.SendKeys("{Tab}");

            //Pop Up window handler
            WinWindow pop = new WinWindow(null);
            pop.SearchProperties[WinWindow.PropertyNames.Name] = "Message from webpage";
            Mouse.Click(pop);
            while (pop.Exists)
            {
                //  Click "OK" button
                WinButton btnOK = new WinButton(pop);
                btnOK.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                btnOK.TechnologyName = "MSAA";
                Mouse.Click(btnOK);
            }

                       
            if (KSNTaxID == "")
                Keyboard.SendKeys(SSNumber2, "123121234");
            else 
                Keyboard.SendKeys(SSNumber2, TaxIDVer);


            // if eRegAdd1 != KSNAdd1, then insert KSNAdd1
            if (eRegAdd1 != KSNAdd1)
            {
                Mouse.DoubleClick(Add1);
                Add1.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "ADDRESS1"));
            }

                        
            // if eRegAdd2 != KSNAdd2, then insert KSNAdd2
            if (eRegAdd2 != KSNAdd2)
            {
                Mouse.DoubleClick(Add2);
                Add2.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "ADDRESS2"));
            }

            //Mouse scroll to bottom page
            Mouse.MoveScrollWheel(-50);

            
            // if eRegCt != KSNCt, then insert KSNCt
            if (eRegCt != KSNCt)
            {
                Mouse.DoubleClick(ct);
                ct.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "CITY"));
            }
                        
            //if eRegSt != KSNSt, then insert KSNSt
            if (eRegSt != KSNSt)
            {
                st.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, PersonalInformation1.ReadData(1, "ESTATE"));
            }

            
            //if eRegZip != KSNZip, then insert KSNZip
            if (eRegZip != KSNZip)
            {
                zp.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "ZIP"));
            }

                        
            //if eRegZip4 != KSNZip4, then insert KSNZip4
            if (eRegZip4 != KSNZip4)
            {
                zp4.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "ZIP4"));
            }
                        
            //if eRegcty != KSNcty, then insert KSNcty
            if (eRegcty != KSNcty)
            {
                cty.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "COUNTY"));
            }

                       
            //if eRegcrty != KSNcrty, then insert KSNcrty
            if (eRegcrty != KSNcrty)
            {
                crty.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, PersonalInformation1.ReadData(1, "COUNTRY"));
            }
                     
            
            if (eRegAreaCode1 == "")
            {
                if (KSNAreaCode1 == "")
                    areacode.SetProperty(HtmlEdit.PropertyNames.Text, "999");
                else
                    areacode.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "HOMEAREACODE"));

            }

           
            if (eRegPhone1 == "")
            {
                if (KSNPhone1 == "")
                    areacode.SetProperty(HtmlEdit.PropertyNames.Text, "12345678");
                else
                    areacode.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "HOMEPHONENUMBER"));

            }

                        
            if (eRegAreaCode2 != KSNAreaCode2)
            {
                AreaCode2.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "CELLAREACODE"));
            }
                        
            if (eRegphone2 != KSNphone2)
            {
                phone2.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "CELLAREANUMBER"));
            }
                        
            if (eRegemail == "")
            {
                email.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "EMAILADDRESS"));
            }

            
            if (eRegemail2 != KSNemail2)
            {
                email2.SetProperty(HtmlEdit.PropertyNames.Text, PersonalInformation1.ReadData(1, "ALT_EMAILADDRESS"));
            }
            
            
            if (eRegCM == "")
            {
                if (KSNCM == "")
                {
                    ContactMethod.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, "Cell Phone");
                }
                else
                {
                    ContactMethod.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, PersonalInformation1.ReadData(1, "PREFERMETHOD"));
                }
            }

            /*****************/
            /* Progress Meter*/
            /*****************/
            HtmlCustom progress = new HtmlCustom(Browind);
            progress.SearchProperties[HtmlCustom.PropertyNames.Id] = "progressmeter";
            bool availabilty = (bool)progress.GetProperty(HtmlCustom.PropertyNames.Exists);
            string workflowEvent = PersonalInformation1.ReadData(1,"WORKFLOW");
            if (workflowEvent == "S1PROSPECT")
            {
                Assert.IsTrue(availabilty, "Progress Meter is not showing");
                
                HtmlSpan bar = new HtmlSpan(Browind);
                bar.SearchProperties[HtmlSpan.PropertyNames.Id] = "meterlabel";
                string percentage = (string)bar.GetProperty(HtmlSpan.PropertyNames.InnerText);
                Assert.AreEqual(percentage, "10%");
                
            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }


            //Click button Save And Continue
            Assert.IsTrue(btnSaveNCont.Enabled);
            Mouse.Click(btnSaveNCont);
            
            Browind.WaitForControlReady(2000);
            

        }

       







     
        
      

       



       }

    }

