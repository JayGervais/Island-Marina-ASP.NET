<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AvailableSlips.aspx.cs" Inherits="Island_Marina.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-spacing">
        <div class="row">
        <div class="col-md-3">
            <h2>Available Slips</h2>
            <p>Choose a dock to see availability</p>
            <asp:DropDownList ID="ddlDocks" CssClass="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="col-md-8">
            <table class="table table-striped">
                <asp:GridView ID="gvAvailableSlips" CssClass="table-striped table-grid" GridLines="None" runat="server"></asp:GridView>
            </table>
        </div>
    </div>
    </div>
</asp:Content>
