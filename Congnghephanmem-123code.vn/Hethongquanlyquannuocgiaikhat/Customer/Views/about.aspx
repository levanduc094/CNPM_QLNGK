<%@ Page Language="C#" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="Customer_Views_table" %/>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> 
    <title>SubPage</title>
	<meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js" ></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" ></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" ></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
  <style type="text/css">		
  	body{
  	background-image: url('./images/bak.jpg');
  		background-position: center;
  		background-size: cover;
  		color: white;
  	}	
  	.container-fluid{
  		margin-top: 50px;
  	}	
  	.well{
  		border: 1px white solid;
  		height: 50px;
  		padding-top: 5px;
  		margin-top: 5px;
  	}
  	a{
  		color: white;
  	}
  </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    	<div class="container-fluid">

   <div class="d-flex justify-content-center">        
         <a href="../index.html"><img src="./images/logo.png" width="150px"></a>
   </div>
   <h1 align="center">Giới thiệu</h1>
    
	  <div class="d-flex justify-content-center">
    	<div class="p-4"> <img src="./images/h1.jpg" width="500"/></div>
    	<div class="p-4">
    		<h3>Kujuz Coffee – Góc yên bình trong con phố nhỏ</h3>
    		<p>Quán Kujuz Coffee tách biệt với không gian bên ngoài bởi một chiếc cổng luôn khóa kỹ. Khách đến chơi bấm chuông, chủ quán ra mở cửa mời khách vào. Không một biển hiệu. Toàn bộ bề mặt ngoài của quán được tạo nên từ vô số ô cửa sổ một cách ngẫu nhiên, tạo nên nhiều trải nghiệm khác nhau mỗi khi nhìn vào từng ô cửa sổ, từng nếp nhà, từng tổ ấm…
			Dùng mỹ phẩm làm đẹp tại nhà là nhu cầu cần thiết cho mỗi người, ai cũng muốn mình trẻ đẹp mãi mãi. Mỹ phẩm cần cho quá trình nuôi dưỡng, ngăn ngừa các tổn thương da từ bên ngoài và phục hồi lại làn da đã bị thương.</p>
			<div class="well col-sm-3 "> <i class="fa fa-money" style="font-size:36px"></i> Giá rẻ bất ngờ</div>
			<a href="https://facebook.com"><div class="well col-sm-3"><i class="fa fa-whatsapp" style="font-size:36px"></i>Liên hệ</div></a>
		</div>
  		</div>
	</div>

    </div>
    </form>
</body>
</html>
