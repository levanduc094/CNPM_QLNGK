<%@ Page Language="C#" AutoEventWireup="true" CodeFile="puttable.aspx.cs" Inherits="Customer_Views_about" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đặt bàn</title>
     <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <!-- Popper JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body>
 <form id="form1" runat="server">
     <div class="container">
         <div class="row">
             <h1>Thực hiện đặt bàn</h1>           
         </div>
         <div class="row ">
        <p>Quý khách vui lòng điền đúng thông tin để cửa hàng có thể xác nhận lại đơn hàng.</p>
        <h2>Xin cảm ơn !</h2>
         </div>
         <div class="row">
        <div class="col-sm-2">
  <!-- Button to Open the Modal -->
  <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal" style="width:100px;height:100px">
    Bàn 1
  </button>
  <!-- The Modal -->
  <div class="modal fade" id="myModal">
    <div class="modal-dialog modal-xl">
      <div class="modal-content">      
        <!-- Modal Header -->
        <div class="modal-header">
          <h4 class="modal-title">Thực hiện đặt bàn</h4>
          <button type="button" class="close" data-dismiss="modal">&times;</button>
        </div>       
        <!-- Modal body -->
        <div class="modal-body">
          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>        
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-dismiss="modal" >Close</button>
        </div>        
      </div>
    </div>
  </div>
    </div>
   </div>
    </div>    
     
    </form>
</body>
</html>
