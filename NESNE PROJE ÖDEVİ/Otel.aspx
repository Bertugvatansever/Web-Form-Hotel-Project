<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Otel.aspx.cs" Inherits="NESNE_PROJE_ÖDEVİ.Otel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Oteller</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    
    <link href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Alex+Brush" rel="stylesheet">

    <link rel="stylesheet" href="css/open-iconic-bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
    
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <link rel="stylesheet" href="css/magnific-popup.css">

    <link rel="stylesheet" href="css/aos.css">

    <link rel="stylesheet" href="css/ionicons.min.css">

    <link rel="stylesheet" href="css/bootstrap-datepicker.css">
    <link rel="stylesheet" href="css/jquery.timepicker.css">

    
    <link rel="stylesheet" href="css/flaticon.css">
    <link rel="stylesheet" href="css/icomoon.css">
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <form id="form1" runat="server">
       <nav class="navbar navbar-expand-lg navbar-dark ftco_navbar bg-dark ftco-navbar-light" id="ftco-navbar">
    <div class="container">
      <a class="navbar-brand" href="Default.aspx">VatanseverTur</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#ftco-nav" aria-controls="ftco-nav" aria-expanded="false" aria-label="Toggle navigation">
        <span class="oi oi-menu"></span> Menu
      </button>

      <div class="collapse navbar-collapse" id="ftco-nav">
        <ul class="navbar-nav ml-auto">
          <li class="nav-item"><a href="Default.aspx" class="nav-link">Ana Sayfa</a></li>
          <li class="nav-item"><a href="Tur.aspx" class="nav-link">Tur</a></li>
          <li class="nav-item active"><a href="Otel.aspx" class="nav-link">Oteller</a></li>
          <li class="nav-item"><a href="Restoran.aspx" class="nav-link">Restoranlar</a></li>
          <li class="nav-item"><a href="Contact.aspx" class="nav-link">İletişim</a></li>
        </ul>
      </div>
    </div>
  </nav>
    <!-- END nav -->
    
    <div class="hero-wrap js-fullheight" style="background-image: url('images/bg_5.jpg');">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-center justify-content-center" data-scrollax-parent="true">
          <div class="col-md-9 ftco-animate text-center" data-scrollax=" properties: { translateY: '70%' }">
            <p class="breadcrumbs" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }"><span class="mr-2"><a href="Default.aspx">Ana Sayfa</a></span> <span>Otel</span></p>
            <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }">Oteller</h1>
          </div>
        </div>
      </div>
    </div>


    <section class="ftco-section ftco-degree-bg">
      <div class="container">
        <div class="row">
        	<div class="col-lg-3 sidebar">
        		<div class="sidebar-wrap bg-light ftco-animate">
        			<h3 class="heading mb-4">Şehir bul</h3>
        			<form action="#">
        				<div class="fields">
		              <div class="form-group">
		                <select name="" id="ulke" class="form-control" placeholder="Keyword search" runat="server">
	                      <option value="">Ülke seçiniz</option>
	                      <option value="Türkiye">Türkiye</option>
	                      <option value="İtalya">İtalya</option>
	                      <option value="Hindistan">Hindistan</option>
	                      <option value="Fransa">Fransa</option>
						  <option value="Japonya">Japonya</option>
						  <option value="Çin">Çin</option>
						  <option value="Belçika">Belçika</option>
	                    </select>
		              </div>
		              <div class="form-group">
		                <div class="select-wrap one-third">
	                    <div class="icon"><span class="ion-ios-arrow-down"></span></div>
	                    <select name="" id="sehir" class="form-control" placeholder="Keyword search" runat="server">
	                      <option value="">Şehir seçin</option>
	                      <option value="Antalya">Antalya</option>
	                      <option value="Bodrum">Bodrum</option>
	                      <option value="İstanbul">İstanbul</option>
	                      <option value="Aydın">Aydın</option>
						  <option value="Paris">Paris</option>
						  <option value="Roma">Roma</option>
						  <option value="Venedik">Venedik</option>
						  <option value="Tokyo">Tokyo</option>
						  <option value="Pekin">Pekin</option>
						  <option value="Brüksel">Brüksel</option>
						  <option value="Mumbai">Mumbai</option>

	                    </select>
	                  </div>
		              </div>
		              
		              <div class="form-group">
		              	<div class="range-slider">
		              		<span>
										    <input type="number" value="0" min="0" max="1000" runat="server" id="fiyat" />
                                                -
										    <input type="number" value="100" min="0" max="1000" runat="server" id="sonfiyat" />
                                            </span>
                                            <input value="0" min="0" max="1000" step="100" type="range" />
                                            <input value="100" min="0" max="1000" step="100" type="range" />
										 
										</div>
		              </div>
		              <div class="form-group">
		                <asp:Button ID="Btn2" runat="server" Text="Araştır" class="btn btn-primary py-3 px-5" runat="server" OnClick="Btn2_Click"/>
		              </div>
		            </div>
	            </form>
        		</div>
        		<div class="sidebar-wrap bg-light ftco-animate">
        			<h3 class="heading mb-4">Yıldız</h3>
        			<form method="post" class="star-rating">
							  <div class="form-check">
									<input type="checkbox" class="form-check-input" id="exampleCheck1">
									<label class="form-check-label" for="exampleCheck1">
										<p class="rate"><span><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i></span></p>
									</label>
							  </div>
							  <div class="form-check">
						      <input type="checkbox" class="form-check-input" id="exampleCheck1">
						      <label class="form-check-label" for="exampleCheck1">
						    	   <p class="rate"><span><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star-o"></i></span></p>
						      </label>
							  </div>
							  <div class="form-check">
						      <input type="checkbox" class="form-check-input" id="exampleCheck1">
						      <label class="form-check-label" for="exampleCheck1">
						      	<p class="rate"><span><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star-o"></i><i class="icon-star-o"></i></span></p>
						     </label>
							  </div>
							  <div class="form-check">
							    <input type="checkbox" class="form-check-input" id="exampleCheck1">
						      <label class="form-check-label" for="exampleCheck1">
						      	<p class="rate"><span><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star-o"></i><i class="icon-star-o"></i><i class="icon-star-o"></i></span></p>
						      </label>
							  </div>
							  <div class="form-check">
						      <input type="checkbox" class="form-check-input" id="exampleCheck1">
						      <label class="form-check-label" for="exampleCheck1">
						      	<p class="rate"><span><i class="icon-star"></i><i class="icon-star-o"></i><i class="icon-star-o"></i><i class="icon-star-o"></i><i class="icon-star-o"></i></span></p>
							    </label>
							  </div>
							</form>
        		</div>
          </div>
          <div class="col-lg-9">
          	<div class="row">
				  <%--buraya eklenecek--%>
          		<asp:Repeater ID="repeaterOtelList" runat="server">
                                <ItemTemplate>
                                    <div class="col-md-4 ftco-animate">
                                        <div class="destination">
                                            <a href="satinalma.aspx" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/antalyatur.jpg);">
                                                <div class="icon d-flex justify-content-center align-items-center">
                                                    <span class="icon-search2"></span>
                                                </div>
                                            </a>
                                            <div class="text p-3">
                                                <div class="d-flex">
                                                    <div class="one">
                                                        <h3><a href="#"> <%# Eval("sehirAdi")%></a></h3>
                                                        <p class="rate">
                                                            <p> <%# Eval("ulkeAdi")%> </p>
                                                        </p>
                                                    </div>
                                                    <div class="two">
                                                        <span class="price"><%# Eval("fiyat")%>₺</span>
                                                    </div>
                                                </div>
                                                <p class="days"><span>2 gün 3 gece</span></p>
                                                <hr>
                                                <p class="bottom-area d-flex">
                                                    <span><i class="icon-map-o"></i>Antalya </span>
                                                    <span class="ml-auto"><a href="satinalma.aspx">Keşfet</a></span>
                                                </p>
                                            </div>
                                        </div>
                                    </div>





                                </ItemTemplate>
                            </asp:Repeater>
				  <%-- Buraya eklenecek --%>
			  </div>
          	<div class="row mt-5">
		          <div class="col text-center">
		            <div class="block-27">
		              
		            </div>
		          </div>
		        </div>
          </div> <!-- .col-md-8 -->
        </div>
      </div>
    </section> <!-- .section -->

    <footer class="ftco-footer ftco-bg-dark ftco-section">
      <div class="container">
        <div class="row mb-5">
          <div class="col-md">
            <div class="ftco-footer-widget mb-4">
              <h2 class="ftco-heading-2">VatanseverTur</h2>
              <ul class="ftco-footer-social list-unstyled float-md-left float-lft mt-5">
                <li class="ftco-animate"><a href="https://www.twitter.com"><span class="icon-twitter"></span></a></li>
                <li class="ftco-animate"><a href="https://www.facebook.com"><span class="icon-facebook"></span></a></li>
                <li class="ftco-animate"><a href="https://www.instagram.com"><span class="icon-instagram"></span></a></li>
              </ul>
            </div>
          </div>
          <div class="col-md">
            <div class="ftco-footer-widget mb-4 ml-md-5">
              <h2 class="ftco-heading-2">Information</h2>
              <ul class="list-unstyled">
              </ul>
            </div>
          </div>
          <div class="col-md">
             <div class="ftco-footer-widget mb-4">
              <h2 class="ftco-heading-2">Customer Support</h2>
              <ul class="list-unstyled">
              </ul>
            </div>
          </div>
          <div class="col-md">
            <div class="ftco-footer-widget mb-4">
            	<h2 class="ftco-heading-2">İletişim</h2>
            	<div class="block-23 mb-3">
	              <ul>
	                <li><span class="icon icon-map-marker"></span><span class="text">Türkiye Muğla Menteşe </span></li>
	                <li><a href="#"><span class="icon icon-phone"></span><span class="text">0850 220 00 00</span></a></li>
	                <li><a href="#"><span class="icon icon-envelope"></span><span class="text">bertugvatansever@hotmail.com</span></a></li>
	              </ul>
	            </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12 text-center">

            <p><!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
  Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class="icon-heart" aria-hidden="true"></i> by <a href="https://colorlib.com" target="_blank">Colorlib</a>
  <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. --></p>
          </div>
        </div>
      </div>
    </footer>
    
  

  <!-- loader -->
  <div id="ftco-loader" class="show fullscreen"><svg class="circular" width="48px" height="48px"><circle class="path-bg" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke="#eeeeee"/><circle class="path" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke-miterlimit="10" stroke="#F96D00"/></svg></div>


  <script src="js/jquery.min.js"></script>
  <script src="js/jquery-migrate-3.0.1.min.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/jquery.easing.1.3.js"></script>
  <script src="js/jquery.waypoints.min.js"></script>
  <script src="js/jquery.stellar.min.js"></script>
  <script src="js/owl.carousel.min.js"></script>
  <script src="js/jquery.magnific-popup.min.js"></script>
  <script src="js/aos.js"></script>
  <script src="js/jquery.animateNumber.min.js"></script>
  <script src="js/bootstrap-datepicker.js"></script>
  <script src="js/jquery.timepicker.min.js"></script>
  <script src="js/scrollax.min.js"></script>
  <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBVWaKrjvy3MaE7SQ74_uJiULgl1JY0H2s&sensor=false"></script>
  <script src="js/google-map.js"></script>
  <script src="js/main.js"></script>
    </form>
</body>
</html>
