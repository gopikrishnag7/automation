using eRegistration_Seg1Prospect.TestData;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRegistration_Seg1Prospect
{
    public class eRegLogin
    {
        public static void Login2eRegistration()
        {
           
            //Create BrowserWindow
            BrowserWindow Browind = new BrowserWindow();
            

            //wait for control ready
            Browind.WaitForControlReady(30000);
            Browind.SearchProperties[UITestControl.PropertyNames.Name] = "Abacus Logon";

            //Enter Username
            HtmlEdit txtusername = new HtmlEdit(Browind);
            txtusername.SearchProperties[HtmlEdit.PropertyNames.Id] = "userNameTB";
            Keyboard.SendKeys(txtusername, UsernamePasswordTD.ReadData(1, "Username"));
            
            

            //Enter Password
            HtmlEdit password = new HtmlEdit(Browind);
            password.SearchProperties[HtmlEdit.PropertyNames.Id] = "passwordTB";
            Keyboard.SendKeys(password, UsernamePasswordTD.ReadData(1, "Password"));
            


            //Click "Login" button
            HtmlInputButton btnLogin = new HtmlInputButton(Browind);
            btnLogin.SearchProperties[HtmlButton.PropertyNames.Id] = "LoginButton_button";
            Mouse.Click(btnLogin);

            //
            BrowserWindow window = BrowserWindow.Locate("Welcome");
            window.WaitForControlReady(40000);
            
            

                         
            
            
        }
         
                
    }
}
