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

            using (SqlConnection con = MarinaDB.GetConnection())
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
            using (SqlConnection con = MarinaDB.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Slip.ID, Width, Length, WaterService, ElectricalService, Name as Dock from Slip " +
                                                "INNER JOIN Dock ON Slip.DockID = Dock.ID " +
                                                "WHERE Slip.ID NOT IN(SELECT SlipID FROM Lease) AND dockID = @dockId", con);
                cmd.Parameters.AddWithValue("@dockId", dockId);
                SqlDataReader dr = cmd.ExecuteReader();
                gridView.DataSource = dr;
                gridView.DataBind();
                con.Close();
            }
        }
    }
}
