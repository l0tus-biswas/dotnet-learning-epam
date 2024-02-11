<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddArticles.aspx.cs" Inherits="WordVoyager.Frontend.AddArticles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="bg-light">
  <section class="py-5">

    <div class="container">
      <div class="row">
        <div class="col">
        
          
          <nav aria-label="breadcrumb mb-3">
            <ol class="breadcrumb">
              <li class="breadcrumb-item"><a href="/">Home</a></li>
              <li class="breadcrumb-item active" aria-current="page">Add Articles</li>
            </ol>
          </nav>
          
        </div>
      </div>
    </div>
    <div class="container mt-3">
      <div class="row">
        <div class="col-lg-8">
          <nav>
            <div class="nav nav-tabs" id="nav-tab" role="tablist">
              <button class="nav-link active fs-5 bg-dark text-white" id="nav-home-tab" data-bs-toggle="tab" data-bs-target="#nav-home"
                type="button" role="tab" aria-controls="nav-home" aria-selected="true">Add Articles</button>
            </div>
          </nav>
          <div class="tab-content" id="nav-tabContent">
            <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab"
              tabindex="0">
             <form action="" class="my-3">
  
              <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Article Title</label>
                <input type="text" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com">
              </div>
              <div class="mb-3">
                <label for="exampleFormControlTextarea1" class="form-label">Article Content</label>
                <textarea class="form-control" id="exampleFormControlTextarea1" rows="5"></textarea>
              </div>
  
              <p>Upload Attachments</p>
              <div class="input-group mb-3">
                
                <input type="file" class="form-control" id="inputGroupFile02">
                <label class="input-group-text" for="inputGroupFile02">Upload</label>
              </div>
              
             
             </form>
            
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</div>

</asp:Content>
