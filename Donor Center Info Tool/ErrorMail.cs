using System;
using System.Collections.Generic;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Donor_Center_Info_Tool
{
    class ErrorMail : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
    {

    }
        public void SendMail()
        {
            try
            {
                List<string> lstAllRecipients = new List<string>();

                //Below is hardcoded - can be replaced with db data
                lstAllRecipients.Add("ben.skinner@external.grifols.com");
 

                Outlook.Application outlookApp = new Outlook.Application();
                Outlook._MailItem oMailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                Outlook.Inspector oInspector = oMailItem.GetInspector;


                // Recipient
                Outlook.Recipients oRecips = (Outlook.Recipients)oMailItem.Recipients;
                foreach (String recipient in lstAllRecipients)
                {
                    Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(recipient);
                    oRecip.Resolve();
                }

                //Add Subject
                oMailItem.Subject = "DCIT - Error Notification";

                // body, bcc etc...
                oMailItem.Body = "<< Please Remove Before Sending - Please provide as much information" +
                                 " as possible about the issue you have experienced. Screen Shots are always helpful >>";

                //Display the mailbox
                oMailItem.Display(true);
            }
            catch (Exception objEx)
            {
                Response.Write(objEx.ToString());
            }

        }
    } 
}
