<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TotalPeople.aspx.cs" Inherits="NewLifeKtm.Admin.TotalPeople" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row mt-5">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                        <h1 class="text-center">Total People</h1>
                        <hr />
                        <div class="row">
                            <div class="col-lg-4">
                                <label>Date</label>
                                <asp:TextBox ID="txtDate" CssClass="form-control" runat="server" placeholder="Enter Date" TextMode="Date"></asp:TextBox>
                            </div>
                            <div class="col-lg-4">
                                <label>Service</label>
                                <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                            <div class="col-lg-4">
                                <label>Preacher</label>
                                <asp:TextBox ID="txtPreacher" CssClass="form-control" runat="server" placeholder="Preacher Name"></asp:TextBox>
                            </div>
                            <div class="col-lg-4">
                                <label>Total People</label>
                                <asp:TextBox ID="txtTotal" CssClass="form-control" runat="server" placeholder="Total People" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="col-lg-4">
                                <label>New People</label>
                                <asp:TextBox ID="txtNew" CssClass="form-control" runat="server" placeholder="no. of new People" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="col-lg-4">
                                <label>Done By</label>
                                <asp:TextBox ID="txtDone" CssClass="form-control" runat="server" placeholder="Name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="mt-3">
                            <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="Submit" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnDelete" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row m-5">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <h1 class="text-center">List</h1>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:GridView ID="GridView1" class="table table-success table-striped" runat="server"> 
                                    <%--<asp:BoundField HeaderText="Date" DataField="Date"/>
                                    <asp:BoundField HeaderText="Service" DataField="Service"/>
                                    <asp:BoundField HeaderText="Preacher" DataField="Preacher"/>
                                    <asp:BoundField HeaderText="Total_People" DataField="Total No. of People"/>
                                    <asp:BoundField HeaderText="New_People" DataField="New People"/>
                                    <asp:BoundField HeaderText="Done_by" DataField="Done By"/>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:Button runat="server" cssClass="btn btn-danger" CommandName="Delete" Text="Remove" />
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
