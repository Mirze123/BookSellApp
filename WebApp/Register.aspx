<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/assets/css/app.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="auth-full-height d-flex flex-row align-items-center">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-md-4">
                        <div class="card">
                            <div class="card-body">
                                <div class="m-2">

                                    <div class="text-center mt-3">
                                        <h3 class="fw-bolder">Sign Up</h3>
                                        <p class="text-muted">Sign up account to get free reward!</p>
                                    </div>
                                    <div class="text-center mt-3" runat="server" id="divErrorMessages">
                                        <asp:Label Text="" ID="lblErrorMessages" runat="server" />
                                    </div>

                                    <div class="form-group mb-3">
                                        <label class="form-label">Username</label>
                                        <asp:TextBox runat="server"
                                            CssClass="form-control no-validation-icon no-success-validation"
                                            ID="txtUsername" />
                                    </div>
                                    <div class="form-group mb-3">
                                        <label class="form-label">Email</label>
                                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control no-validation-icon no-success-validation" />
                                    </div>
                                    <div class="form-group mb-3">
                                        <label class="form-label">Password</label>
                                        <asp:TextBox runat="server" CssClass="form-control no-validation-icon no-success-validation" ID="txtPassword" TextMode="Password" />
                                    </div>
                                    <div class="form-group mb-3">
                                        <label class="form-label">Confirm Password</label>
                                        <asp:TextBox runat="server" CssClass="form-control no-validation-icon no-success-validation" ID="txtConfirmPassword" TextMode="Password" />
                                    </div>
                                    <div class="form-group mb-3">
                                        <label class="form-label">Role</label>
                                        <asp:DropDownList runat="server" ID="ddlRoles" CssClass="form-control">
                                            <asp:ListItem Value="1" Text="Admin" />
                                            <asp:ListItem Value="2" Text="Moderator" />
                                            <asp:ListItem Value="3" Text="User" />
                                        </asp:DropDownList>
                                    </div>
                                    <asp:Button Text="Sign Up" CssClass="btn btn-primary d-block w-100" ID="btnRegister" runat="server" OnClick="btnRegister_Click" />

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="Content/assets/js/vendors.min.js"></script>
    <script src="Content/assets/js/app.min.js"></script>
</body>
</html>
