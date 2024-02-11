<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="WordVoyager.Frontend.Settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container my-5">
  <div class="row">

    <div class="container">
      <div class="row">
        <div class="col">
        
          
          <nav aria-label="breadcrumb mb-3">
            <ol class="breadcrumb">
              <li class="breadcrumb-item"><a href="#">Home</a></li>
              <li class="breadcrumb-item active" aria-current="page">Settings</li>
            </ol>
          </nav>
          
        </div>
      </div>
    </div>
    <div class="col-lg-5">
      <h3>Update Your Information  </h3>
    </div>
    <div class="col-lg-5">

      <form class="needs-validation" novalidate="">
        <div class="mb-3">
          <label for="userId" class="form-label">UserId</label>
          <input type="text" name="userId" class="form-control" disabled placeholder="#232" required>
        </div>
        <div class="mb-3">
          <label for="registrationDate" class="form-label">Joined On</label>
          <input type="text" name="registrationDate"  disabled
            class="form-control" placeholder="" required placeholder="10th Jan 2024">
        </div>
        <div class="mb-3">
          <label for="emailAdderss" class="form-label">E-Mail</label>
          <input type="email" name="emailAdderss" class="form-control" disabled required placeholder="lotushotmail111@gmail.com">
        </div>
        <div class="mb-3">
          <label for="username" class="form-label">Username</label>
          <input type="text" name="username" class="form-control" placeholder="lotusbiswas" required>
        </div>
        <div class="mb-3">
          <label for="password" class="form-label">Password</label>
          <input type="password" name="password" class="form-control" required placeholder="**********">
        </div>
        <button type="submit" class="btn btn-dark col-12" >Update details</button>
      </form>
    </div>
  </div>
<%--</div>--%>
</asp:Content>
