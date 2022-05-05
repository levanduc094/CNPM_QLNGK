<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Views/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="QLBan1.aspx.cs" Inherits="Admin_Views_demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    Quản lý bàn
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">   
    <asp:Panel CssClass="panel panel-primary" ID="pnlThem" runat="server" Visible="true">
        <div class="panel-heading">Thông tin </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="">Mã bàn</label>
                <asp:TextBox runat="server" CssClass="form-control"  Enabled="false" ID="txtMaChuyenMuc" placeholder="Hệ thống tự động sinh mã" />
            </div>
            <div class="form-group">
                <label for="">Tên bàn</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtTenChuyenMuc" placeholder="Nhập tên bàn" />
            </div>       
           <div class="form-group">
                <label for="">Trạng thái</label>
                <br />
                <asp:CheckBox ID="ckbStatus" runat="server" Text="Đã đặt" ClientIDMode="Predictable" />
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
            Danh sách bàn
        </div>
        <div class="panel-body">
            <asp:GridView ID="gvChuyenMuc" CssClass="table table-responsive table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="idTable" GridLines="None" PageSize="5" OnRowCommand="gvChuyenMuc_RowCommand">
                <Columns>
                    <asp:BoundField DataField="idTable" HeaderText="Mã bàn" />
                    <asp:BoundField DataField="name" HeaderText="Tên bàn" />
                    <asp:BoundField DataField="status" HeaderText="Trạng thái" />
                    <asp:ButtonField CommandName="btnSua" HeaderText="Sửa" Text="Sửa" />
                    <asp:ButtonField CommandName="btnXoa" HeaderText="Xóa" Text="Xóa" />
                </Columns>
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>

