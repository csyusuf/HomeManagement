<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="HomeManagement.Login" %>

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
                <asp:TextBox ID="txbPassword" runat="server" TextMode="Password" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <span id="spnMessage" runat="server"/>
            </div>
        </div>
    </div>

</asp:Content>
