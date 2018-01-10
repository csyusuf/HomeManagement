<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="HomeManagement.Shopping" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-4">
                <span class="label label-default">What do you want to shop? </span>
                <asp:TextBox ID="txbShoppingItem" runat="server" CssClass="form-control"/>
            </div>
        </div>
        <div class="row"> 
             <div class="col-md-4">
                 <span class="label label-default">Who will go shopping?</span>
                 <asp:DropDownList ID="ddlUserList" runat="server" CssClass="form-control" DataValueField="ID" DataTextField="UserName"/>
             </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnSave" runat="server" CssClass="btn" Text="Save" OnClick="btnSave_Click"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <span id="spnMessage" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
