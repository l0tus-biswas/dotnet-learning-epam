<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="WordVoyager.Frontend.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset your password : WordVoyager</title>
         <webopt:bundlereference runat="server" path="~/Content/css" />
 
</head>
<body>
   <main runat="server">
       <div class="container main-cover">
    <div class="row d-flex justify-content-center mt-5 mb-4">
        <div class="col-md-5 ">
            <div class="text-center">
               
                     <h3>WordVoyager</h3>
            </div>
          <div class="text-center pb-4">
              <h4>Reset your password</h4>
          </div>
            <div class="card">
            
              <div class="card-body">
               
                <form  class="needs-validation" novalidate="">
                  <div class="mb-3">
                    <label for="emailAdderss" class="form-label">Enter your account's email address</label>
                    <input type="email" name="emailAdderss"  class="form-control "  ngModel required>
                  
                  </div>
                
                <button type="submit" class="btn btn-dark col-12">Send Reset email</button>
                </form>
              
               <div>
                    <p class="pt-3">To go back 👉 <span><a href="login">Click Here</a></span> </p>
                    
                </div>
              </div>
              <div class="card-footer text-muted">
                We will system generate and auto password reset and email you.
              </div>
            </div>
          </div>
        </div>
        </div>
   </main>
</body>
</html>
