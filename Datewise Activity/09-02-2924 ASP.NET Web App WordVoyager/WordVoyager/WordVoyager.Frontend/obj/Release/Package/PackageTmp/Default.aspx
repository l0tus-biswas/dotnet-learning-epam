<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WordVoyager.Frontend._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .card-img-top{
            border-radius: 30px;
        }
</style>
    <section class="articles my-5">

    <div class="container">
        <div>
            <h3 class="mb-4">Latest Articles</h3>
        </div>
        <div class="row g-4">
            <div class="col-lg-4 col-md-6 col-12">
                <a href="viewarticles">
                    <div class="card position-relative " >
                        <span class="badge bg-primary position-absolute top-0 start-0 mt-3 ms-3 ">New</span>
                        <img src="https://img.freepik.com/premium-vector/hand-drawn-people-working-together-illustration_52683-76157.jpg?t=st=1707149053~exp=1707149653~hmac=002f84838dc0a2f58f01c0552b61472d919900c6d4ef4c428a93e33070edf4ae"
                            class="card-img-top" alt="...">
                        <div class="card-body">
    
                            <div class="article-user-deatils d-flex mb-3">
                                <div class="user-image me-2">
                                    <img src="https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8dXNlcnxlbnwwfHwwfHx8MA%3D%3D"
                                        class="rounded" alt="">
    
                                </div>
                                <div class="user-info">
                                    <ul>
                                        <li>Lotus Biswas</li>
                                        <li>Updated on 06-Feb-2024 11:16:02</li>
                                    </ul>
                                </div>
    
                            </div>
                            <h5 class="card-text mb-3">Some quick example text to build on the card title and make up the bulk of
                                the card's content.</h5>
                            <a href="viewarticles" id="tags" >#SAP</a>
                            <div class="d-flex justify-content-between mt-5">
                            
                                <p><i class="fa fa-eye me-2"></i><span>633</span></p>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class="col-lg-4 col-md-6 col-12">
                <a href="viewarticles">
                    <div class="card position-relative " >
                        <span class="badge bg-primary position-absolute top-0 start-0 mt-3 ms-3 ">New</span>
                        <img src="https://img.freepik.com/premium-vector/hand-drawn-people-working-together-illustration_52683-76157.jpg?t=st=1707149053~exp=1707149653~hmac=002f84838dc0a2f58f01c0552b61472d919900c6d4ef4c428a93e33070edf4ae"
                            class="card-img-top" alt="...">
                        <div class="card-body">
    
                            <div class="article-user-deatils d-flex mb-3">
                                <div class="user-image me-2">
                                    <img src="https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8dXNlcnxlbnwwfHwwfHx8MA%3D%3D"
                                        class="rounded" alt="">
    
                                </div>
                                <div class="user-info">
                                    <ul>
                                        <li>Lotus Biswas</li>
                                        <li>Updated on 06-Feb-2024 11:16:02</li>
                                    </ul>
                                </div>
    
                            </div>
                            <h5 class="card-text mb-3">Some quick example text to build on the card title and make up the bulk of
                                the card's content.</h5>
                            <a href="viewarticles" id="tags" >#SAP</a>
                            <div class="d-flex justify-content-between mt-5">
                            
                                <p><i class="fa fa-eye me-2"></i><span>633</span></p>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class="col-lg-4 col-md-6 col-12">
                <a href="viewarticles">
                    <div class="card position-relative " >
                        <span class="badge bg-primary position-absolute top-0 start-0 mt-3 ms-3 ">New</span>
                        <img src="https://img.freepik.com/premium-vector/hand-drawn-people-working-together-illustration_52683-76157.jpg?t=st=1707149053~exp=1707149653~hmac=002f84838dc0a2f58f01c0552b61472d919900c6d4ef4c428a93e33070edf4ae"
                            class="card-img-top" alt="...">
                        <div class="card-body">
    
                            <div class="article-user-deatils d-flex mb-3">
                                <div class="user-image me-2">
                                    <img src="https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8dXNlcnxlbnwwfHwwfHx8MA%3D%3D"
                                        class="rounded" alt="">
    
                                </div>
                                <div class="user-info">
                                    <ul>
                                        <li>Lotus Biswas</li>
                                        <li>Updated on 06-Feb-2024 11:16:02</li>
                                    </ul>
                                </div>
    
                            </div>
                            <h5 class="card-text mb-3">Some quick example text to build on the card title and make up the bulk of
                                the card's content.</h5>
                            <a href="viewarticles" id="tags" >#SAP</a>
                            <div class="d-flex justify-content-between mt-5">
                            
                                <p><i class="fa fa-eye me-2"></i><span>633</span></p>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </div>
</section>


<section class="articles my-5">

    <div class="container">
        <div>
            <h3 class="mb-4">Most loved articles</h3>
        </div>
        <div class="row g-4">
            <div class="col-lg-4 col-md-6 col-12">
                <a href="viewarticles">
                    <div class="card position-relative " >
                        <span class="badge bg-primary position-absolute top-0 start-0 mt-3 ms-3 ">New</span>
                        <img src="https://img.freepik.com/premium-vector/hand-drawn-people-working-together-illustration_52683-76157.jpg?t=st=1707149053~exp=1707149653~hmac=002f84838dc0a2f58f01c0552b61472d919900c6d4ef4c428a93e33070edf4ae"
                            class="card-img-top" alt="...">
                        <div class="card-body">
    
                            <div class="article-user-deatils d-flex mb-3">
                                <div class="user-image me-2">
                                    <img src="https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8dXNlcnxlbnwwfHwwfHx8MA%3D%3D"
                                        class="rounded" alt="">
    
                                </div>
                                <div class="user-info">
                                    <ul>
                                        <li>Lotus Biswas</li>
                                        <li>Updated on 06-Feb-2024 11:16:02</li>
                                    </ul>
                                </div>
    
                            </div>
                            <h5 class="card-text mb-3">Some quick example text to build on the card title and make up the bulk of
                                the card's content.</h5>
                            <a href="viewarticles" id="tags" >#SAP</a>
                            <div class="d-flex justify-content-between mt-5">
                            
                                <p><i class="fa fa-eye me-2"></i><span>633</span></p>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class="col-lg-4 col-md-6 col-12">
                <a href="viewarticles">
                    <div class="card position-relative " >
                        <span class="badge bg-primary position-absolute top-0 start-0 mt-3 ms-3 ">New</span>
                        <img src="https://img.freepik.com/premium-vector/hand-drawn-people-working-together-illustration_52683-76157.jpg?t=st=1707149053~exp=1707149653~hmac=002f84838dc0a2f58f01c0552b61472d919900c6d4ef4c428a93e33070edf4ae"
                            class="card-img-top" alt="...">
                        <div class="card-body">
    
                            <div class="article-user-deatils d-flex mb-3">
                                <div class="user-image me-2">
                                    <img src="https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8dXNlcnxlbnwwfHwwfHx8MA%3D%3D"
                                        class="rounded" alt="">
    
                                </div>
                                <div class="user-info">
                                    <ul>
                                        <li>Lotus Biswas</li>
                                        <li>Updated on 06-Feb-2024 11:16:02</li>
                                    </ul>
                                </div>
    
                            </div>
                            <h5 class="card-text mb-3">Some quick example text to build on the card title and make up the bulk of
                                the card's content.</h5>
                            <a href="viewarticles" id="tags" >#SAP</a>
                            <div class="d-flex justify-content-between mt-5">
                            
                                <p><i class="fa fa-eye me-2"></i><span>633</span></p>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class="col-lg-4 col-md-6 col-12">
                <a href="viewarticles">
                    <div class="card position-relative " >
                        <span class="badge bg-primary position-absolute top-0 start-0 mt-3 ms-3 ">New</span>
                        <img src="https://img.freepik.com/premium-vector/hand-drawn-people-working-together-illustration_52683-76157.jpg?t=st=1707149053~exp=1707149653~hmac=002f84838dc0a2f58f01c0552b61472d919900c6d4ef4c428a93e33070edf4ae"
                            class="card-img-top" alt="...">
                        <div class="card-body">
    
                            <div class="article-user-deatils d-flex mb-3">
                                <div class="user-image me-2">
                                    <img src="https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8dXNlcnxlbnwwfHwwfHx8MA%3D%3D"
                                        class="rounded" alt="">
    
                                </div>
                                <div class="user-info">
                                    <ul>
                                        <li>Lotus Biswas</li>
                                        <li>Updated on 06-Feb-2024 11:16:02</li>
                                    </ul>
                                </div>
    
                            </div>
                            <h5 class="card-text mb-3">Some quick example text to build on the card title and make up the bulk of
                                the card's content.</h5>
                            <a href="viewarticles" id="tags" >#SAP</a>
                            <div class="d-flex justify-content-between mt-5">
                            
                                <p><i class="fa fa-eye me-2"></i><span>633</span></p>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </div>
</section>

</asp:Content>
