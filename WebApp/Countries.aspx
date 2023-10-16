<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Countries.aspx.cs" Inherits="WebApp.Countries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="row">
        <div class="col-3">
            <asp:Button Text="New" runat="server" ID="btnNew" CssClass="btn btn-primary" OnClick="btnNew_Click" />
        </div>
    </div>
    <div class="row mt-3">
        <div class="col-12">
            <div class="table-responsive">
                <table class="table table-bordered">
                    <thead class="bg-danger">
                        <tr>
                            <th colspan="2"></th>
                            <th>ID</th>
                            <th>Code</th>
                            <th>Name</th>
                            <th>Created Date</th>
                            <th>Last Update Date</th>
                        </tr>
                    </thead>
                    <tbody class="bg-success">
                        <asp:Repeater runat="server" ID="rptData" OnItemCommand="rptData_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:LinkButton Text="Edit" CommandArgument='<%# Eval("ID") %>' CommandName="EDIT" CssClass="btn btn-warning" runat="server"></asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton runat="server" Text="Remove"  CommandArgument='<%# Eval("ID") %>' CommandName="REMOVE" CssClass="btn btn-danger"></asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:Label Text='<%# Eval("ID") %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label Text='<%# Eval("Code") %>' runat="server" />
                                    </td>
                                    <td>
                                       <asp:Label Text='<%# Eval("Name") %>' runat="server" />
                                    </td>
                                    <td>
                                       <asp:Label Text='<%# Eval("CreatedDate") %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label Text='<%# Eval("LastUpdateDate") %>' runat="server" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>

        </div>
    </div>
</asp:Content>
