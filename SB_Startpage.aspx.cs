using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diplomarbeit
{
    public partial class SB_Startpage : System.Web.UI.Page
    {
        Listen_Generator gLst = new Listen_Generator();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;

            if (!IsPostBack == true)
            {
                                              
                //Get Veranstaltungen within 21 days
                Session["VerA"] = gLst.GetVlist().Where(v => v.Datumvon < DateTime.Now.AddDays(21)).ToList();
                grvMain.DataSource = Session["VerA"];
                grvMain.DataBind();


                lblName.Text = (string)Session["User"];
                lblStandort.Text += "ORT";
            }
            else
            {
                if (Session["User"] == null)
                    Response.Redirect("Default.aspx");
            }

        }

        protected void grvMain_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grvMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDetails_Click(object sender, EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;


            //Reads VeranstID of Object in Row, where Button was pressed.
            int selVeranstID = ((List<Veranstaltung>)Session["VerA"]).ElementAt(gvr.RowIndex).VeranstID;

            //TEST
            Response.Write("Ausgewählte VeranstaltungsID" + selVeranstID);
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;

            //Reads VeranstID of Object in Row, where Button was pressed.
            int selVeranstID = ((List<Veranstaltung>)Session["VerA"]).ElementAt(gvr.RowIndex).VeranstID;

            //TEST
            Response.Write("Ausgewählte VeranstaltungsID" + selVeranstID);
        }

        protected void btnAllVerans_Click(object sender, EventArgs e)
        {
            grvMain.DataSource = gLst.GetVlist();
            grvMain.DataBind();
        }

        protected void btnAktSem_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Month < 3) //zweiter Teil Wintersemester
                grvMain.DataSource = gLst.GetVlist().Where(v => (v.Datumvon.Month < 3 && v.Datumvon.Year == DateTime.Now.Year) ||
                v.Datumvon.Month > 8 && v.Datumvon.Year == DateTime.Now.Year - 1).ToList();
            if (DateTime.Now.Month >= 8) //erster Tiel Wintersemester
                grvMain.DataSource = gLst.GetVlist().Where(v => (v.Datumvon.Month < 3 && v.Datumvon.Year == DateTime.Now.Year + 1) ||
                (v.Datumvon.Month > 8) && v.Datumvon.Year == DateTime.Now.Year).ToList();

            if (DateTime.Now.Month < 8 && DateTime.Now.Month >= 3) // Sommersemester
                grvMain.DataSource = gLst.GetVlist().Where(v => (v.Datumvon.Month > 3 &&
                v.Datumvon.Month <= 8) && v.Datumvon.Year == DateTime.Now.Year).ToList();

            grvMain.DataBind();
        }

        protected void btnNxtSem_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Month < 3) //zweiter Teil Wintersemester -> Sommersemester
                grvMain.DataSource = gLst.GetVlist().Where(v => v.Datumvon.Month <= 8 && v.Datumvon.Month >= 3 &&
                v.Datumvon.Year == DateTime.Now.Year);
            if (DateTime.Now.Month > 8) //erster Teil Wintersemester -> Sommersemester
                grvMain.DataSource = gLst.GetVlist().Where(v => v.Datumvon.Month <= 8 && v.Datumvon.Month >= 3
                && v.Datumvon.Year == DateTime.Now.Year + 1);

            if (DateTime.Now.Month <= 8 && DateTime.Now.Month >= 3) //Sommersemester -> Wintersemester
                grvMain.DataSource = gLst.GetVlist().Where(v => v.Datumvon.Month > 8 && v.Datumvon.Year == DateTime.Now.Year ||
                v.Datumvon.Month < 3 && v.Datumvon.Year == DateTime.Now.Year + 1);

            grvMain.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}