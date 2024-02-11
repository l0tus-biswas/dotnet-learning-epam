<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WordVoyager.Frontend.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
      <webopt:bundlereference runat="server" path="~/Content/css" />
       <webopt:bundlereference runat="server" path="~/Content/pages/login.css" />
</head>
<body>
   <main runat="server">
       <div class="container-fluid bg-white">
    <div class="row">
        <div
            class="col-lg-6 col-md-6 col-sm-12 vh-100 bg-login text-light d-flex align-items-center d-flex justify-content-center">
            <div class="company-desc p-2">
                <div class="text-center">
                    <div class="mt-3">
                        <h1 class="fw-bolder pb-3 fs-1">WordVoyager</h1>
                        <p class="fs-5">Easily share your wisdom with the world</p>
                    </div>
                </div>
            </div>

        </div>
        <div class="col-lg-6 col-md-6 col-sm-12 d-flex align-items-center my-5 my-auto mx-auto py-lg-0 py-md-0 py-5">
            <div class="card my-auto mx-auto ">
                
                <div class="card-body">

                    <form class="needs-validation" novalidate="" method="post" runat="server">

                        <div class="mb-3">
                            <label for="emailAdderss" class="form-label">Email</label>
                            <input type="email" name="emailAdderss" class="form-control "  required>
                         
                        </div>
                        <div class="mb-3">
                            <label for="password" class="form-label">Password</label>
                            <input type="password" name="password" class="form-control " required>
                        </div>
                        <asp:Button ID="loginBtn" class="btn btn-dark col-12" runat="server" Text="Login to your account" OnClick="loginBtn_Click" />
                        <!-- <a href="home" >Login to your account</a> -->
                    </form>

                    <div>
                        <p class="pt-3">Don't have an account ? <span><a href="Register">Sign Up</a></span> </p>
                        <p class="">Forgot Password ? <span> <a href="ResetPassword">Click Here</a></span> </p>

                    </div>
                </div>
                <div class="card-footer text-muted">
                    Good to see you back 🙏
                </div>
            </div>
        </div>
    </div>

</div>
   </main>
</body>
</html>
