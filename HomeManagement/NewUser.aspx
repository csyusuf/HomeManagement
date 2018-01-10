<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="HomeManagement.NewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">User Name</span>
                <asp:TextBox ID="txbUserName" runat="server" CssClass="form-control"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Password</span>
                <asp:TextBox ID="txbPassword" runat="server" TextMode="Password" CssClass="form-control"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Password Repeat</span>
                <asp:TextBox ID="txbPasswordRepeat" runat="server" TextMode="Password" CssClass="form-control"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">First Name</span>
                <asp:TextBox ID="txbFirstName" runat="server" CssClass="form-control"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Last Name</span>
                <asp:TextBox ID="txbLastName" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">User Type</span>
                <asp:DropDownList ID="ddlUserType" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Please select..." Selected="True" />
                    <asp:ListItem Value="Admin" Text="Admin" />
                    <asp:ListItem Value="Member" Text="Member" />
                </asp:DropDownList>
            </div>
        </div>
         <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnSave" runat="server" Text="Register" CssClass="btn" OnClick="btnSave_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
              <span id="spnMessage" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
