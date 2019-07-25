using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Island_Marina.Models
{
    public class LeaseSlipDB
    {
        public void LeaseDocksDropDown(DropDownList inputList)
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

        public void LeaseBindSlipGrid(int dockId, GridView gridView)
        {
            using (SqlConnection con = MarinaDB.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Slip.ID, Width, Length, WaterService, ElectricalService, Name as Dock from Slip " +
                                                "INNER JOIN Dock ON Slip.DockID = Dock.ID " +
                                                "WHERE Slip.ID NOT IN (SELECT SlipID FROM Lease) AND DockID = @dockId", con);
                cmd.Parameters.AddWithValue("@dockId", dockId);

                SqlDataReader reader = cmd.ExecuteReader();
                SqlDataReader sqlDataReader = reader;
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Width");
                dataTable.Columns.Add("Length");
                dataTable.Columns.Add("WaterService");
                dataTable.Columns.Add("ElectricalService");
                dataTable.Columns.Add("Dock");

                while (reader.Read())
                {
                    string waterService;
                    if(Convert.ToBoolean(reader["WaterService"]) == true)
                    {
                       waterService = "Yes";
                    }
                    else
                    {
                       waterService = "No";
                    }

                    string electricalService;
                    if (Convert.ToBoolean(reader["ElectricalService"]) == true)
                    {
                        electricalService = "Yes";
                    }
                    else
                    {
                        electricalService = "No";
                    }

                    DataRow row = dataTable.NewRow();
                    row["ID"] = reader["ID"];
                    row["Width"] = reader["Width"];
                    row["Length"] = reader["Length"];
                    row["WaterService"] = waterService;
                    row["ElectricalService"] = electricalService;
                    row["Dock"] = reader["Dock"];
                    dataTable.Rows.Add(row);
                }
                gridView.DataSource = dataTable;
                gridView.DataBind();

                con.Close();
            }
        }

        public void CustomerSlips(string custEmail, GridView gridView)
        {
            using (SqlConnection con = MarinaDB.GetConnection())
            {
                con.Open();
                SqlCommand getCustID = new SqlCommand("SELECT ID FROM Customer WHERE Email = @custEmail", con);
                getCustID.Parameters.AddWithValue("@custEmail", custEmail);
                SqlDataReader id = getCustID.ExecuteReader();
                id.Read();
                int custID = Convert.ToInt32(id[0]);
                con.Close();

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, SlipID, CustomerID from Lease WHERE CustomerID = @CustomerID", con);
                cmd.Parameters.AddWithValue("@CustomerID", custID);
                SqlDataReader dr = cmd.ExecuteReader();
                gridView.DataSource = dr;
                gridView.DataBind();
                con.Close();       
            }
        }

        public void LeaseSlip(int slipID, string custEmail)
        {
            using (SqlConnection con = MarinaDB.GetConnection())
            {
                con.Open();
                SqlCommand getCustID = new SqlCommand("SELECT ID FROM Customer WHERE Email = @custEmail", con);
                getCustID.Parameters.AddWithValue("@custEmail", custEmail);
                SqlDataReader id = getCustID.ExecuteReader();
                id.Read();
                int custID = Convert.ToInt32(id[0]);
                con.Close();

                string addLeaseSlipQuery = @"INSERT INTO Lease " +
                                         "(SlipID, CustomerID) " +
                                         "VALUES (@SlipID, @CustomerID)";

                SqlCommand sqlCommand = new SqlCommand(addLeaseSlipQuery, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@SlipID", slipID);
                sqlCommand.Parameters.AddWithValue("@CustomerID", custID);
                sqlCommand.ExecuteScalar();
                con.Close();
            }
        }

        public void RemoveSlip(int slipID)
        {
            using (SqlConnection con = MarinaDB.GetConnection())
            {
                con.Open();
                SqlCommand deleteSlipCMD = new SqlCommand("DELETE FROM Lease WHERE ID = @SlipID", con);
                deleteSlipCMD.Parameters.AddWithValue("@slipID", slipID);
                deleteSlipCMD.ExecuteScalar();
                con.Close();
            }
        }
    }
}