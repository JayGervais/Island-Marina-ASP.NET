<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaseSlip.aspx.cs" Inherits="Island_Marina.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-spacing">
        <div class="row">
        <div class="col-md-3">
            <h2>Lease Slip</h2>
            <p>Choose a Dock</p>
            <asp:DropDownList ID="ddlLeaseDocks" CssClass="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="col-md-8">
            <h2>Available Slips</h2>
            <table class="table table-striped">
                <asp:GridView ID="gvAvailableLeaseSlips" CssClass="table-striped table-grid" GridLines="None" runat="server"></asp:GridView>
            </table>
        </div>
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-8">
                <h2>Your Slips</h2>
                <asp:GridView ID="gvCustomerSlips" CssClass="table-striped table-grid" GridLines="None" runat="server">
                </asp:GridView>
            </div>
        </div>
 

    </div>
    </div>
</asp:Content>
