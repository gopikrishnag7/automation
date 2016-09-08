using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.Diagnostics;
using eRegistration_Seg1Prospect.TestData;


namespace eRegistration_Seg1Prospect
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {


        private static BrowserWindow browserWindow = null;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Playback.Initialize();
            PersonalInformation1.PopulateInCollection(@"C:\Users\SHYM005\Documents\Visual Studio 2013\Projects\eRegistration_Seg1Prospect\DataSheet.xlsx");
            UsernamePasswordTD.PopulateInCollection(@"C:\Users\SHYM005\Documents\Visual Studio 2013\Projects\eRegistration_Seg1Prospect\DataSheet.xlsx");
            var bw = BrowserWindow.Launch(new Uri("https://sqa.registration.kellyservices.com/Abacus/LoginForm.aspx?JScript=1"));
            bw.Maximized = true;
            bw.CloseOnPlaybackCleanup = false;
            bw.WaitForControlExist(30000);
        }

        [ClassCleanup]
        public static void TestCleanup()
        {
            browserWindow.Close();
            Playback.Cleanup();
        }

        public CodedUITest1()
        {
        }

                
        [TestMethod]
        public void eReg_Segmented_Wyoming()
        {
            BrowserWindow Browind = BrowserWindow.Locate("Abacus Logon");
            eRegLogin.Login2eRegistration();
            WelcomePane.welcome_SaveNContinue();
            PersonalInformation_CurrentAddress_ContactInformation.personalInformation();
            PersonalInformation_PaycheckStub.paycheck_Stub();
            AddressHistory.S1AddressHistory();
            EmergencyContact.EmergencyContactInformation();
            PersonalInformation_StateOfEmployee.stateOfEmployee();
            Preferences.eReg_Preferences();
            EducationHistory.eReg_EducationHistory();
            WorkExperience.eReg_WorkExperiance();
            //WorkExperienceExempt.workExperienceExmpt_SaveNContinue();
            Browind.CloseOnPlaybackCleanup = false;
         }

        [TestMethod]
        public void eReg_ToBeTested()
        {
            //BrowserWindow Browind = BrowserWindow.Locate("Work Experience");
           
            
            


        }





        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;

        
    }
}
