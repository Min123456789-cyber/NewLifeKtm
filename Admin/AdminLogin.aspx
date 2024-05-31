<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="NewLifeKtm.Admin.AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row m-5">
            <div class="col-lg-3"></div>
            
                <div class="col-lg-6">

                    <div class="card">
                        <div class="card-body">
                            <center>
                                <h2>Admin Login</h2>
                            </center>
                            <div class="form">
                                <div class="form-body">
                                    <label>Username</label>
                                    <asp:TextBox ID="txtUsername" class="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>

                                </div>
                                <div class="form-body">
                                    <label>Password</label>
                                    <asp:TextBox ID="txtPassword" class="form-control" placeholder="Enter Password" runat="server"></asp:TextBox>
                                </div>
                                <div class="d-grid mt-3">
                                    <asp:Button runat="server" ID="btnSubmit" class="btn btn-primary" Text="Login" OnClick="btnSubmit_Click" />
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            
            <div class="col-lg-3"></div>
        </div>
    </div>

</asp:Content>
