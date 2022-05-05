<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Views_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập hệ thống</title>
    <link href="../assets/css/jquery-ui.min.css" rel="stylesheet" />
    <link href="../assets/css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-card">
            <h1>Đăng nhập</h1>
            <asp:Label ID="lblError" Font-Size="9" Font-Bold="true" ForeColor="Red" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:TextBox ID="txtTenDangNhap" runat="server" placeholder="Tên đăng nhập"></asp:TextBox>
            <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password" placeholder="Mật khẩu"></asp:TextBox>
            <asp:Button ID="btnDangNhap" runat="server" CssClass="login login-submit" Text="Đăng nhập" OnClick="btnDangNhap_Click" />
            <div class="login-help">
                <br />
                <a href="#">Quên mật khẩu ?</a>
            </div>
        </div>
        <script src="assets/js/jquery.1.11.1.min.js"></script>
        <script src="assets/js/jquery-ui.min.js"></script>
    </form>
</body>
</html>
