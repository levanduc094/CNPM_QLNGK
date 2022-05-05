<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Views/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="Admin_Views_User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    Quản lý người dùng
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <asp:Button ID="btnThemChuyenMuc" runat="server" CssClass="btn btn-sm btn-primary" Text="Thêm người dùng" OnClick="btnThemChuyenMuc_Click" />
    <br />
    <asp:Panel CssClass="panel panel-primary" ID="pnlThem" runat="server" Visible="false">
        <div class="panel-heading">Thông tin </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="">UserName</label>
                <asp:TextBox runat="server" CssClass="form-control"  Enabled="false" ID="txtMaChuyenMuc" placeholder="Nhập tên đăng nhập" />
            </div>
            <div class="form-group">
                <label for="">Password</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtTenChuyenMuc" placeholder="Nhập mật khẩu" />
            </div>            
             <div class="form-group">
                <label for="">DisplayName</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="TxtDisplayName" placeholder="Nhập hiện thị" />
            </div>  
            <div class="form-group">
                <label for="">Type</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="TxtType" placeholder="Nhập kiểu" />
            </div>
            <br />
            <asp:Button runat="server" ID="btnSave" CssClass="btn btn-sm btn-primary" Text="Lưu và thêm" OnClick="btnSave_Click" />
            <asp:Button runat="server" ID="btnSaveChanges" CssClass="btn btn-sm btn-success" Text="Lưu và đóng" OnClick="btnSaveChanges_Click" />
            <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-sm btn-default" Text="Đóng" OnClick="btnCancel_Click" />
            &nbsp;<asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </div>
    </asp:Panel>

    <br />
    <div class="panel panel-primary">
        <div class="panel-heading">
            Danh sách người dùng
        </div>
        <div class="panel-body">
            <asp:GridView ID="gvChuyenMuc" CssClass="table table-responsive table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="UserName" GridLines="None" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="Tên đăng nhập" />
                    <asp:BoundField DataField="PassWord" HeaderText="Mật khẩu" />
                    <asp:BoundField DataField="DisplayName" HeaderText="Tên hiện thị" />
                    <asp:BoundField DataField="Type" HeaderText="Type" />
                    <asp:HyperLinkField DataNavigateUrlFields="UserName" DataNavigateUrlFormatString="?Action=Edit&amp;ID={0}" HeaderText="Sửa" Text="Sửa" />
                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnDel" Text="Xóa" runat="server"
                                OnClick="btnXoa_Click" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa ?')" CommandName="Delete"
                                CommandArgument='<%# Eval("UserName") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
