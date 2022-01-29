using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diplomarbeit
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
            else
            {

            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            alblStatus.Text = "";
            var ilias = new Ilias.LIASSoapWebservicePortTypeClient();
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try
            {
                ilias.login("ingenium", username, password);
                Session["User"] = String.Format(username);
                Response.Redirect("SB_Startpage.aspx"); // MUSS NOCH NACH RECHTEN DER NUTZER IMPLEMENTIERT WERDEN
            }

            catch (Exception exe)
            {
                alblStatus.Text = "Fehler bei der Anmeldung"; //exe.StackTrace;
            }
        }
    }
}