<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="FirstTime.aspx.cs" Inherits="NewLifeKtm.User.FirstTime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row m-5">
            <div class="col-lg-2"></div>
            <div class="col-lg-8">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <h1 class="text-center">Fill the Form</h1>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Date</label>
                                <asp:TextBox ID="txtDate" CssClass="form-control" TextMode="Date" placeholder="Enter Today's Date" runat="server" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Name</label>
                                <asp:TextBox ID="txtName" CssClass="form-control" runat="server" placeholder="Enter Your Name" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Email</label>
                                <asp:TextBox ID="txtEmail" CssClass="form-control" TextMode="Email" placeholder="Enter Your Email" runat="server" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Number</label>
                                <asp:TextBox ID="txtNumber" CssClass="form-control" TextMode="Number" placeholder="Enter 10 Digit Number" runat="server" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Address</label>
                                <asp:TextBox ID="txtAddress" CssClass="form-control" runat="server" placeholder="Enter Your Address" TextMode="MultiLine" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="d-grid mt-3">
                                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="Button1_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-2"></div>
        </div>
    </div>


</asp:Content>
