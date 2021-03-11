using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        lblStatus.Text = "Logged In Failed..";
        //        if (txtUsername.Text.Trim() == "")
        //        {
        //            lblStatus.Text = "Please enter username";
        //            txtUsername.Focus();
        //            return;
        //        }
        //        if (txtPassword.Text.Trim() == "")
        //        {
        //            lblStatus.Text = "Please enter password";
        //            txtPassword.Focus();
        //            return;
        //        }

        //        string requestUrl = ConfigurationManager.AppSettings["loginapiurl"].ToString();
        //        requestUrl += "?username="+txtUsername.Text+"&password="+txtPassword.Text;
        //        WebRequest request = WebRequest.Create(requestUrl);
        //        request.Credentials = CredentialCache.DefaultCredentials;
        //        WebResponse response = request.GetResponse();
        //        Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        //        using (Stream dataStream = response.GetResponseStream())
        //        {
        //            StreamReader reader = new StreamReader(dataStream);
        //            string responseFromServer = reader.ReadToEnd();
        //            if (responseFromServer.ToUpper() == "TRUE")
        //            {
        //                lblStatus.Text = "Logged In Successfull....!";
        //            }
        //            else
        //                lblStatus.Text = "Logged In Failed..";
        //        }
        //        response.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        lblStatus.Text = ex.Message;
        //    }

        //}
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Logged In Failed..";
                if (txtUsername.Text.Trim() == "")
                {
                    lblStatus.Text = "Please enter username";
                    txtUsername.Focus();
                    return;
                }
                if (txtPassword.Text.Trim() == "")
                {
                    lblStatus.Text = "Please enter password";
                    txtPassword.Focus();
                    return;
                }

                string requestUrl = ConfigurationManager.AppSettings["loginapiurl"].ToString();
               // string requestUrl = _configuration.GetValue<string>("loginurl:url");
                requestUrl = requestUrl.Replace("@USERID", txtUsername.Text.Trim()).Replace("@PASSWORD", txtPassword.Text.Trim());
                WebRequest request = WebRequest.Create(requestUrl);
                request.Method = "POST";
                request.ContentLength = 0;
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    if (responseFromServer.ToUpper().Contains("FIRSTNAME"))//if profile comes means credential's are properly
                        lblStatus.Text = "Logged In Successfull....!";
                }
                response.Close();

            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }

        }
    }
}