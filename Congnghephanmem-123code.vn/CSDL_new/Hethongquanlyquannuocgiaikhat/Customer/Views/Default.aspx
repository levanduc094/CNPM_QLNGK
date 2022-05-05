<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Customer_Views_images_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta name="viewport" content="width=device-width, initial-scale=1"/>
 <!-- Latest compiled and minified CSS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>

	<!-- jQuery library -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

	<!-- Popper JS -->
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>

	<!-- Latest compiled JavaScript -->
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script> 
  <style>
  body {
      position: relative; 
  }
  </style>
  <link rel="stylesheet" type="text/css" href="styles.css"/>
    <title></title>
</head>
<body data-spy="scroll" data-target=".navbar" data-offset="50">
    <form id="form1" runat="server">
    <div>
 <div>
  <ul class="nav justify-content-right flex-column fixed-top" style="font-size:20px;">
    <li class="nav-item dropdown">
    <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#"><p>Đồ uống</p></a>
    <div class="dropdown-menu">
      <a class="dropdown-item" href="#">Trà</a>
      <a class="dropdown-item" href="#">Nước trái cây</a>
      <a class="dropdown-item" href="#">Nước ngọt</a>
      <a class="dropdown-item" href="#">Đồ uống khác</a>
    </div>
  </li>
    <li class="nav-item">
          <a class="nav-link " href="#"><p>Đồ ăn</p></a>
      </li>
  </ul>
</div>
  <div class="container-fluid text-center" style="margin-top:100px">
      <div id="section11">    
        <h1>Trà</h1>
        <hr/>
        <!-- <p>Trà Sen;Trà Nhài; Trà Bạc Hà;Trà Đào; Trà Dâu;Trà Lipton;Trà Hoa Cúc Mật Ong</p> -->
     <div class="row">
			  <div class="col-sm-4 item"> <img src="./images/trahoasen.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>
                  <asp:Label ID="Label1" runat="server" Text="Trà hoa sen"></asp:Label>
                  </h2><p class="price"><asp:Label ID="Label2" runat="server" Text="20000"></asp:Label></p></div>
			  <div class="col-sm-4 item"><img src="./images/tradau.png" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Dâu</h2><p class="price">20000</p></div>
			  <div class="col-sm-4 item"><img src="./images/tranhai.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Nhài</h2><p class="price">20000</p></div>
				</div> 
         	<div class="row">
			  <div class="col-sm-4 item"> <img src="./images/trabacha.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Bạc Hà</h2><p class="price">20000</p></div>
			  <div class="col-sm-4 item"><img src="./images/trahoacucmatong.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Hoa Cúc</h2><p class="price">20000</p></div>
			  <div class="col-sm-4 item"><img src="./images/tralipton.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Lipton</h2><p class="price">20000</p></div>
				</div>				
      </div>
      <div id="section12"> 
        <h1>Nước trái cây</h1>
        <hr/>
<!--         <p>Nước Can; Nước Chanh tươi; Nước Chanh Leo; Nước Ổi;Nước Dứa;Nước Xoài; Nước Dưa Hấu; Nước Táo; Nước Cà rốt</p> -->
    <div class="row">
			  <div class="col-sm-4 item"> <img src="./images/trahoasen.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Sen</h2><p class="price">20000</p></div>
			  <div class="col-sm-4 item"><img src="./images/tradau.png" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Dâu</h2><p class="price">20000</p></div>
			  <div class="col-sm-4 item"><img src="./images/tranhai.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Nhài</h2><p class="price">20000</p></div>
				</div> 
         	<div class="row">
			  <div class="col-sm-4 item"> <img src="./images/trabacha.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Bạc Hà</h2><p class="price">20000</p></div>
			  <div class="col-sm-4 item"><img src="./images/trahoacucmatong.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Hoa Cúc</h2><p class="price">20000</p></div>
			  <div class="col-sm-4 item"><img src="./images/tralipton.jpg" class="img-thumbnail" alt="Cinque Terre" width="200"/><h2>Trà Lipton</h2><p class="price">20000</p></div>
				</div>	
      </div>        
      <div id="section13">         
        <h1>Section 4-1</h1>
        <p>Cà phê Espresso; Espresso Doppio; Cà phê Latte;Cà phê Cappuccino;
        Molstar Coffee</p>
      </div> 
      <div id="section14">         
        <h1>Section 4-1</h1>
        <p>Coca Cola;Redbull;Soda;Sting;Fantal;Spring;Nước suối</p>
      </div>
      <div id="section15">         
        <h1>Section 4-1</h1>
        <p>Sữa chua; Sữa chua đánh đá;Socola;Sữa tươi;Cacao</p>
      </div>  
      <div id="section2">         
        <h1>Section 4-1</h1>
        <p>Khoai lang kén;Khoai tây phủ phô mai;Ngô chiên;Quẩy;Trứng cút lộn</p>
      </div>    
    </div>
  </div>
    </form>
</body>
</html>
