<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Island_Marina.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="page-spacing">
        <div class="row">
            <div class="col-md-6">
                <h2><%: Title %>.</h2>
    <div class="form-horizontal">
        <h4>Create a new account</h4>
        <hr />

        
        
        <div class="form-group">
            <asp:Label ID="lblFirstName" runat="server" Text="First Name" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtFirstName" class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldFName" runat="server" ControlToValidate="txtFirstName" CssClass="text-danger" ErrorMessage="First name is required."></asp:RequiredFieldValidator>
                &nbsp;<asp:CustomValidator ID="CustomValidatorFName" runat="server" ControlToValidate="txtFirstName" CssClass="text-danger" ErrorMessage="A valid first name is required" validationexpression="^[a-zA-Z]+$"></asp:CustomValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtLastName" class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldLName" runat="server" ControlToValidate="txtLastName" CssClass="text-danger" ErrorMessage="Last name is required."></asp:RequiredFieldValidator>
                &nbsp;<asp:CustomValidator ID="CustomValidatorLName" runat="server" ControlToValidate="txtLastName" CssClass="text-danger" ErrorMessage="A valid last name is required" validationexpression="^[a-zA-Z]+$"></asp:CustomValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPhone" runat="server" Text="Phone Number" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtPhone" class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldPhone" runat="server" ControlToValidate="txtPhone" CssClass="text-danger" ErrorMessage="Phone number is required."></asp:RequiredFieldValidator>
                &nbsp;<asp:CustomValidator ID="CustomValidatorPhone" runat="server" ControlToValidate="txtPhone" CssClass="text-danger" ErrorMessage="A valid phone number is required" validationexpression="^(\(?\d{3}\)?-? *\d{3}-? *-?\d{4})$"></asp:CustomValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCity" runat="server" Text="City" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtCity" class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldCity" runat="server" ControlToValidate="txtCity" CssClass="text-danger" ErrorMessage="City is required."></asp:RequiredFieldValidator>
                &nbsp;<asp:CustomValidator ID="CustomValidatorCity" runat="server" ControlToValidate="txtCity" CssClass="text-danger" ErrorMessage="A valid city is required" validationexpression="^[A-Za-z ]+$"></asp:CustomValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" Text="Email" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" Text="Password" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" Text="Confirm Password" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
    
            </div>
            <div class="col-md-6">
                <img class="imgwide" src="../Images/anchored-1850849_1280.jpg" />
            </div>
        </div>
    </div>

        
</asp:Content>
