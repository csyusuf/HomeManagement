<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Food.aspx.cs" Inherits="HomeManagement.Food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="jumbotron col-md-6">
            <div class="row">
                <div class="col-md-12">
                    <span class="label label-default">Food Name</span>
                    <asp:TextBox ID="txbFoodName" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <span class="label label-default">Bought Date</span>
                    <asp:TextBox ID="txbBuyDate" runat="server" TextMode="Date" CssClass="form-control" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <span class="label label-default">Best Before Date</span>
                    <asp:TextBox ID="txbBestBeforeDate" runat="server" TextMode="Date" CssClass="form-control" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn" OnClick="btnSave_Click" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <span id="spnMessage" runat="server" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
