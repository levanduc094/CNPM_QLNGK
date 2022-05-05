<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Views/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="QLThucDonNuocUong.aspx.cs" Inherits="Admin_Views_QLThucDonNuocUong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    Quản lý thực đơn nước uống
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">        
    <asp:Panel CssClass="panel panel-primary" ID="pnlThem" runat="server" Visible="true">
        <div class="panel-heading">Thông tin </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="">Mã đồ uống</label>
                <asp:TextBox runat="server" CssClass="form-control"  Enabled="false" ID="txtMaChuyenMuc" placeholder="Hệ thống tự động sinh mã" />
            </div>
            <div class="form-group">
                <label for="">Tên đồ uống</label>
                <asp:TextBox runat="server" CssClass="form-control" Enabled="false" ID="txtTenChuyenMuc" placeholder="Nhập tên đồ uống" />
            </div>        
             <div class="form-group">
                <label for="">Tên loại danh mục</label>
                <asp:DropDownList runat="server" CssClass="form-control" Enabled="false" ID="DropListMaLoai"></asp:DropDownList>
            </div> 
             <div class="form-group">
                <label for="">Giá</label>
                <asp:TextBox runat="server" CssClass="form-control" Enabled="false" ID="TxtGia" placeholder="Nhập giá" />
            </div>     
            <br />
            <asp:Button runat="server" ID="btnNew" CssClass="btn btn-sm btn-primary" Text="Thêm mới" OnClick="btnNew_Click" />
            <asp:Button runat="server" ID="btnSaveChanges" CssClass="btn btn-sm btn-success" Text="Lưu thay đổi" OnClick="btnSaveChanges_Click" />
            <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-sm btn-default" Text="Đóng" OnClick="btnCancel_Click" />
            &nbsp;<asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </div>
    </asp:Panel>

    <br />
    <div class="panel panel-primary">
        <div class="panel-heading">
            Danh sách đò uống
        </div>
        <div class="panel-body">
            <asp:GridView ID="gvChuyenMuc" CssClass="table table-responsive table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="idDrink" GridLines="None" PageSize="5" OnRowCommand="gvChuyenMuc_RowCommand">
                <Columns>
                    <asp:BoundField DataField="idDrink" HeaderText="Mã đồ uống" />
                    <asp:BoundField DataField="name" HeaderText="Tên đồ uống" />
                    <asp:BoundField DataField="idCategoryDrink" HeaderText="Mã danh mục" />
                    <asp:BoundField DataField="price" HeaderText="Giá" />
                    <asp:ButtonField CommandName="btnSua" HeaderText="Sửa" Text="Sửa" />
                    <asp:ButtonField CommandName="btnXoa" HeaderText="Xóa" Text="Xóa" />
                </Columns>
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>


