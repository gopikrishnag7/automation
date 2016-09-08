using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eRegistration_Seg1Prospect
{
    public class WorkExperience
    {
        private BrowserWindow browser;

        public WorkExperience(BrowserWindow browser)
        {
            // TODO: Complete member initialization
            this.browser = browser;
        }
        public static void eReg_WorkExperiance()
        {
            //Create browserwindow
            BrowserWindow browind = new BrowserWindow();
            browind.SearchProperties[UITestControl.PropertyNames.Name] = "Work Experience";


            // Is this employer a staffing company? 

            HtmlComboBox empstaff = new HtmlComboBox(browind);
            empstaff.SearchProperties[HtmlComboBox.PropertyNames.Id] = "Employer1_staffingBox";
            //empstaff.DrawHighlight();

            //Employer (If you worked through a staffing company, enter the Staffing Company name as the Employer)

            HtmlEdit employer = new HtmlEdit(browind);
            employer.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_name";
            //employer.DrawHighlight();

            //Current or Former Employer?
            HtmlComboBox currentemp = new HtmlComboBox(browind);
            currentemp.SearchProperties[HtmlComboBox.PropertyNames.Id] = "Employer1_type";
            //currentemp.DrawHighlight();

            //Job Title
            HtmlEdit jobtitle = new HtmlEdit(browind);
            jobtitle.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_jobtitle";
            //jobtitle.DrawHighlight();

            //Pay Rate/Salary  xx.xx
            HtmlEdit empsal = new HtmlEdit(browind);
            empsal.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_salary";
            //empsal.DrawHighlight();

            //Pay Frequency
            HtmlComboBox emprate = new HtmlComboBox(browind);
            emprate.SearchProperties[HtmlComboBox.PropertyNames.Id] = "Employer1_rate";
           // emprate.DrawHighlight();

            //Start Date  mm/yyyy
            HtmlEdit empstart = new HtmlEdit(browind);
            empstart.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_start";
            //empstart.DrawHighlight();

            //End Date  mm/yyyy
            HtmlEdit empend = new HtmlEdit(browind);
            empend.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_end";
            //empend.DrawHighlight();

            //Supervisor/Manager Name
            HtmlEdit supename = new HtmlEdit(browind);
            supename.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_supename";
            //supename.DrawHighlight();

            //Mouse.MoveScrollWheel(-100);

            //Supervisor/Manager Title
            HtmlEdit suptitle = new HtmlEdit(browind);
            suptitle.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_supetitle";
            //suptitle.DrawHighlight();


            //Address
            HtmlEdit empadd = new HtmlEdit(browind);
            empadd.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_address";
            //empadd.DrawHighlight();

            //City
            HtmlEdit empcity = new HtmlEdit(browind);
            empcity.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_city";
            //empcity.DrawHighlight();

            //State/Prov.
            HtmlComboBox empstate = new HtmlComboBox(browind);
            empstate.SearchProperties[HtmlComboBox.PropertyNames.Id] = "Employer1_state";
           // empstate.DrawHighlight();

            //Postal/ZIP Code
            HtmlEdit empzip = new HtmlEdit(browind);
            empzip.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_zip";
            //empzip.DrawHighlight();

            //Country
            HtmlComboBox empcountry = new HtmlComboBox(browind);
            empcountry.SearchProperties[HtmlComboBox.PropertyNames.Id] = "Employer1_country";
            //empcountry.DrawHighlight();

            //Area Code
            HtmlEdit areacode = new HtmlEdit(browind);
            areacode.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_phone_areacode";
           // areacode.DrawHighlight();

            //Phone
            HtmlEdit empphone = new HtmlEdit(browind);
            empphone.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_phone";
            //empphone.DrawHighlight();

            //Ext.
            HtmlEdit empext = new HtmlEdit(browind);
            empext.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_ext";
            //empext.DrawHighlight();

            //Job Duties (2000 characters max)
            HtmlEdit duties = new HtmlEdit(browind);
            duties.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_duties";
            duties.SearchProperties[HtmlEdit.PropertyNames.TagName] = "TEXTAREA";
            //duties.DrawHighlight();

            //Reason for leaving?
            HtmlEdit leaving = new HtmlEdit(browind);
            leaving.SearchProperties[HtmlEdit.PropertyNames.Id] = "Employer1_leaving";
            //leaving.DrawHighlight();

            // Verify any WorkExperience is exist
            
            //Click on Delete
            HtmlHyperlink empdel = new HtmlHyperlink(browind);
            empdel.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Delete";
            while (empdel.TryFind())
            {
                Mouse.MoveScrollWheel(-100);
                Mouse.Click(empdel);
                browind.WaitForControlReady(200);

            }

            //Fill up mandatory field and click "Add and Update" button
            empstaff.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, "No");
            employer.SetProperty(HtmlEdit.PropertyNames.Text, "Kelly Services");
            currentemp.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, "Current Employer");
            jobtitle.SetProperty(HtmlEdit.PropertyNames.Text, "Senior QA Analyst");
            empsal.SetProperty(HtmlEdit.PropertyNames.Text, "4000.00");
            emprate.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, "Monthly");
            empstart.SetProperty(HtmlEdit.PropertyNames.Text, "01/2006");
            empend.SetProperty(HtmlEdit.PropertyNames.Text, "08/2012");
            empcity.SetProperty(HtmlEdit.PropertyNames.Text, "Detroit");
            empstate.SetProperty(HtmlComboBox.PropertyNames.SelectedItem, "Michigan");


            //Click on Add and Update
            HtmlInputButton addupdate = new HtmlInputButton(browind);
            addupdate.SearchProperties[HtmlInputButton.PropertyNames.Id] = "SaveRecordButton_button";
            addupdate.DrawHighlight();
            Mouse.Click(addupdate);


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
                bar.SearchProperties[HtmlSpan.PropertyNames.Id] = "meterlabel";
                bar.DrawHighlight();
                string percentage = (string)bar.GetProperty(HtmlSpan.PropertyNames.InnerText);
                Assert.AreEqual(percentage, "45%");

            }
            else
            {
                Assert.IsFalse(availabilty, "Progress Meter is showing");
            }

            //Button "Save And Continue" 
            HtmlInputButton SaveNContinue = new HtmlInputButton(browind);
            SaveNContinue.SearchProperties[HtmlInputButton.PropertyNames.Id] = "ForwardButton_button";
            SaveNContinue.DrawHighlight();

            Mouse.Click(SaveNContinue);

        }
    }
}
