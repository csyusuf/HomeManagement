<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bill.aspx.cs" Inherits="HomeManagement.Bill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-6">
                 <span class="label label-default">Bill Type</span>
            <asp:DropDownList ID="ddlBillType" runat="server" CssClass="form-control">
                <asp:ListItem Value="" Text="Select an option..." Selected="True"/>
                <asp:ListItem Value="Electric" Text="Electric" />
                <asp:ListItem Value="Gas" Text="Gas" />
                <asp:ListItem Value="Water" Text="Water" />
            </asp:DropDownList>
            </div>
           
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Amount</span>
                <asp:TextBox ID="txbAmount" runat="server" CssClass="form-control"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <span class="label label-default">Payment Due Date</span>
                <asp:TextBox ID="txbPaymentDueDate" runat="server" TextMode="Date" CssClass="form-control"/>
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
