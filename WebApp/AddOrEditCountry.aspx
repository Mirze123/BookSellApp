<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddOrEditCountry.aspx.cs" Inherits="WebApp.AddOrEditCountry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="row mt-3">
        <div class="col-6">
            <asp:Label Text="Kodu" runat="server" />
        </div>
        <div class="col-6">
            <asp:TextBox runat="server" ID="txtCode" CssClass="form-control" />
        </div>
    </div>
      <div class="row mt-3">
        <div class="col-6">
            <asp:Label Text="Ad" runat="server" />
        </div>
        <div class="col-6">
            <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
        </div>
    </div>
    <div class="row mt-3">
        <div class="col-12">
            <asp:Button Text="Save" ID="btnSave" CssClass="btn btn-primary" runat="server" OnClick="btnSave_Click" />
            <asp:Button Text="Cancel" ID="btnCancel" CssClass="btn btn-primary" runat="server" OnClick="btnCancel_Click" />
        </div>
    </div>
</asp:Content>
