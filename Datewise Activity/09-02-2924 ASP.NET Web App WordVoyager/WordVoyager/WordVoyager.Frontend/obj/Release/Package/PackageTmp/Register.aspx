<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WordVoyager.Frontend.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register : WordVoyager</title>
    <webopt:bundlereference runat="server" path="~/Content/css" />
 <webopt:bundlereference runat="server" path="~/Content/pages/login.css" />
</head>
<body>
    <main runat="server">
        <div class="container-fluid">
  <div class="row vh-100">

    <div class="col-lg-5 col-md-5 col-sm-12 d-flex align-items-center my-5 my-auto mx-auto py-lg-0 py-md-0 py-5">
      <div class="card my-auto mx-auto ">
        <div class="card-body">
          <div class="mb-4">
            <h3>Register</h3>
            <p>Sign up now and share your voice effortlessly.</p>
          </div>
         
          <form class="needs-validation" novalidate="">
            <div class="mb-3">
              <label for="username" class="form-label">Username</label>
              <input type="text" name="username" class="form-control " ngModel required>
            </div>
            <div class="mb-3">
              <label for="emailAdderss" class="form-label">Email</label>
              <input type="email" name="emailAdderss" class="form-control " ngModel required>
            </div>
            <div class="mb-3">
              <label for="password" class="form-label">Password</label>
              <input type="password" name="password" class="form-control " ngModel required>
            </div>
            <button type="submit" class="btn btn-dark col-12">Login to your account</button>
          </form>
          <div>
            <p class="pt-3">Already have an account? <span><a href="Login">Sign In</a></span> </p>
            <p class="">Forgot Password ? <span> <a href="ResetPassword">Click Here</a></span> </p>
          </div>
        </div>
        <div class="card-footer text-muted">
          <i class="fa fa-check-circle-o" aria-hidden="true"></i> I agree to terms and condition
        </div>
      </div>
    </div>
  </div>

</div>
    </main>
</body>
</html>
