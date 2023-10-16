<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.Login" %>

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
                                        <h3 class="fw-bolder">Sign In</h3>
                                        <p class="text-muted">Sign in your account to continue</p>
                                    </div>

                                    <div class="form-group mb-3">
                                        <label class="form-label">Username</label>
                                        <asp:TextBox runat="server" ID="txtUsername" CssClass="form-control" />
                                    </div>
                                    <div class="mb-3">
                                        <label class="form-label d-flex justify-content-between">
                                            <span>Password</span>
                                            <a href="#" class="text-primary font">Forget Password?</a>
                                        </label>
                                        <div class="form-group input-affix flex-column">
                                            <label class="d-none">Password</label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="txtPassword" TextMode="Password" />
                                            <i class="suffix-icon feather cursor-pointer text-dark icon-eye" ng-reflect-ng-class="icon-eye"></i>
                                        </div>
                                    </div>
                                    <asp:Button Text="Log In" CssClass="btn btn-primary w-100" ID="btnLogin" runat="server" />



                                    <div class="text-center mt-4">
                                        <p class="text-muted">Don't have an account yet? <a href="Register.aspx">Sign Up</a></p>
                                    </div>
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
