using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Island_Marina.Models
{
    public class SlipDB
    {
        public void DocksDropDown(DropDownList inputList)
        {
            DataTable docks = new DataTable();

            using (SqlConnection con = new SqlConnection(@"data source=localhost\SAITSQLEXPRESS;initial catalog=Marina;integrated security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT ID, Name FROM Dock", con);
                adapter.Fill(docks);

                inputList.DataSource = docks;
                inputList.DataTextField = "Name";
                inputList.DataValueField = "ID";
                inputList.DataBind();
            }
        }

        public void BindSlipGrid(int dockId, GridView gridView)
        {
            string constr = @"data source=localhost\SAITSQLEXPRESS;initial catalog=Marina;integrated security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, Width, Length, DockID from Slip where ID not in (select slipID from lease) and dockID = @dockId", con);
                cmd.Parameters.AddWithValue("@dockId", dockId);
                SqlDataReader dr = cmd.ExecuteReader();
                gridView.DataSource = dr;
                gridView.DataBind();
                con.Close();
            }
        }
    }
}
