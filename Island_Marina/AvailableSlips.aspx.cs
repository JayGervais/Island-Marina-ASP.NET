using Island_Marina.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Island_Marina
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SlipDB docksDropDown = new SlipDB();
                docksDropDown.DocksDropDown(ddlDocks);
            }

            int dock = Convert.ToInt32(ddlDocks.SelectedValue);
            SlipDB slipGridView = new SlipDB();
            slipGridView.BindSlipGrid(dock, gvAvailableSlips);
        }
    }
}