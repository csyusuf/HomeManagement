<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="HomeManagement.Activity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Name</span>
                <asp:TextBox ID="txbName" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Date</span>
                <asp:TextBox ID="txbDate" runat="server" TextMode="Date" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Attendees</span>
                <asp:CheckBoxList ID="cblAttendees" runat="server" DataValueField="ID" DataTextField="UserName" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <span id="spnMessage" runat="server"/>
            </div>
        </div>
    </div>
</asp:Content>
