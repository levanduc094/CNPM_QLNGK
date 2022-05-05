<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Views/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="QLDanhmucMonAn.aspx.cs" Inherits="Admin_Views_QLDanhmucMonAn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    Quản lý Danh Mục Món Ăn
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">   
    <asp:Panel CssClass="panel panel-primary" ID="pnlThem" runat="server" Visible="true">
        <div class="panel-heading">Thông tin </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="">Mã danh muc</label>
                <asp:TextBox runat="server" CssClass="form-control"  Enabled="false" ID="txtMaChuyenMuc" placeholder="Nhập mã danh mục" />
            </div>
            <div class="form-group">
                <label for="">Tên danh mục</label>
                <asp:TextBox runat="server" CssClass="form-control" Enabled="false" ID="txtTenChuyenMuc" placeholder="Nhập tên danh mục" />
            </div>                       
            <br />
            <asp:Button runat="server" ID="btnNew" CssClass="btn btn-sm btn-primary" Text="Thêm mới" OnClick="btnNew_Click" />
            <asp:Button runat="server" ID="btnSaveChanges" CssClass="btn btn-sm btn-success" Text="Lưu thay đổi" OnClick="btnSaveChanges_Click" />
            <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-sm btn-default" Text="Đóng" OnClick="btnCancel_Click" />
            &nbsp;<asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="green"></asp:Label>
        </div>
    </asp:Panel>
    <br />
    <div class="panel panel-primary">
        <div class="panel-heading">
            Danh sách danh mục
        </div>
        <div class="panel-body">
            <asp:GridView ID="gvChuyenMuc" CssClass="table table-responsive table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="idCategoryFood" GridLines="None" PageSize="5" OnRowCommand="gvChuyenMuc_RowCommand">
                <Columns>
                    <asp:BoundField DataField="idCategoryFood" HeaderText="Mã danh mục" />
                    <asp:BoundField DataField="name" HeaderText="Tên danh mục" />                    
                    <asp:ButtonField CommandName="btnSua" HeaderText="Sửa" Text="Sửa" />
                    <asp:ButtonField CommandName="btnXoa" HeaderText="Xóa" Text="Xóa" />
                </Columns>
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>

