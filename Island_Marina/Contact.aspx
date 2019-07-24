<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Island_Marina.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-spacing">
        <div class="row">
      <div class="col-md-8 mb-5">
        <h2>Get in Touch</h2>
        <hr>
          <img class="imgwide" src="Images/marina.jpg" />
      </div>
      <div class="col-md-4 mb-5">
        <h2>Contact Us</h2>
        <hr>
        <address>
          <strong>Inland Lake</strong>
          <br>Inland Lake Marina
          <br>Arcata, CA 68542
          <br>
          <br>San Diago Marina
          <br>San Diago, CA 90210
          <br>
        </address>
        <address>
          <abbr title="Phone">P:</abbr>
          (123) 456-7890
          <br>
          <abbr title="Email">E:</abbr>
          <a href="mailto:#">info@islandlake.com</a>
        </address>
      </div>
    </div>
    <!-- /.row -->
    </div>  
</asp:Content>
