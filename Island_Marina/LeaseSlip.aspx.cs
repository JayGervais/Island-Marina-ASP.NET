using Island_Marina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Island_Marina
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Account/Login.aspx");
            }
            else
            {
                if (!this.IsPostBack)
                {
                    LeaseSlipDB leaseDocksDropDown = new LeaseSlipDB();
                    leaseDocksDropDown.LeaseDocksDropDown(ddlLeaseDocks);
                }

                int dock = Convert.ToInt32(ddlLeaseDocks.SelectedValue);
                LeaseSlipDB slipGridView = new LeaseSlipDB();
                slipGridView.LeaseBindSlipGrid(dock, gvAvailableLeaseSlips);

                string custEmail = Convert.ToString(Session["email"]);
                LeaseSlipDB custSlipGridView = new LeaseSlipDB();
                custSlipGridView.CustomerSlips(custEmail, gvCustomerSlips);

                foreach (TableRow row in gvAvailableLeaseSlips.Rows)
                {
                    TableCell btnCell = new TableCell();
                    Button btn = new Button();

                    int id = Convert.ToInt32(row.Cells[0].Text);

                    btn.Text = "Lease Slip";
                    btn.CssClass = "btn";
                    btn.ID = id.ToString();
                    btn.Click += new EventHandler(BtnLease_Click);
                    btnCell.Controls.Add(btn);
                    row.Cells.Add(btnCell);
                }
            } 
        }

        public void BtnLease_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            int id = Convert.ToInt32(row.Cells[0].Text);

            string custEmail = Convert.ToString(Session["email"]);
            LeaseSlipDB newSlip = new LeaseSlipDB();
            newSlip.LeaseSlip(id, custEmail);

            Response.Redirect("LeaseSlip.aspx");
        }
    }
}