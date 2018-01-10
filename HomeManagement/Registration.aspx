<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Registration.aspx.cs" Inherits="HomeManagement.Registration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
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
                <span class="label label-default">Home Type</span>
                <asp:DropDownList ID="ddlHomeType" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Please select..." Selected="True" />
                    <asp:ListItem Value="Family" Text="Family" />
                    <asp:ListItem Value="Friends" Text="Friends" />
                    <asp:ListItem Value="Single" Text="Single" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Home Name</span>
                <asp:TextBox ID="txbHomeName" runat="server" CssClass="form-control"/>
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
