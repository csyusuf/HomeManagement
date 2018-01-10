<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HomeManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>Wellcome to Home Management Application</h3>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div id="divBillInfo" runat="server" class="jumbotron" style="padding: 3px">
                    <h4>Coming Bills</h4>
                    <div class="row">
                        <div class="col-md-4">
                            <span class="label label-default">Bill Type</span>
                        </div>
                        <div class="col-md-4">
                            <span class="label label-default">Amount</span>
                        </div>
                        <div class="col-md-4">
                            <span class="label label-default">Due Date</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div id="divFoodInfo" runat="server" class="jumbotron" style="padding: 3px">
                    <h4>Consumed Foods</h4>
                    <div class="row">
                        <div class="col-md-4">
                            <span class="label label-default">Name</span>
                        </div>
                        <div class="col-md-4">
                            <span class="label label-default">Buy Date</span>
                        </div>
                        <div class="col-md-4">
                            <span class="label label-default">Consumed Date</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>


    </div>



</asp:Content>
