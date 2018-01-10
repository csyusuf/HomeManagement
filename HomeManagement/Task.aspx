<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="HomeManagement.Task" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
            <h3>Task Assignment</h3>
        </div>
    <div class="jumbotron" style="padding-top:0px; padding-bottom:0px">
        
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Name</span>
            <asp:TextBox ID="txbTaskName" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Responsible User</span>
                <asp:DropDownList ID="ddlUsers" runat="server" CssClass="form-control" DataValueField="ID" DataTextField="UserName"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn" OnClick="btnSave_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblMessage" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
