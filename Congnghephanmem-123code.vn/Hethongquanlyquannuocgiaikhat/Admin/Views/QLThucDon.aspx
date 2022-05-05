<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="QLThucDon.aspx.cs" Inherits="Admin_Views_QLThucDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    Quản lý thực đơn
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <asp:Button ID="btnThemChuyenMuc" runat="server" CssClass="btn btn-sm btn-primary" Text="Thêm thực đơn"  />
    <br />
    <asp:Panel CssClass="panel panel-primary" ID="pnlThem" runat="server" Visible="false">
        <div class="panel-heading">Thông tin chuyên mục</div>
        <div class="panel-body">
            <div class="form-group">
                <label for="">Mã chuyên mục</label>
                <asp:TextBox runat="server" CssClass="form-control" Enabled="false" ID="txtMaChuyenMuc" placeholder="Hệ thống tự động sinh mã" />
            </div>
            <div class="form-group">
                <label for="">Tên chuyên mục</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtTenChuyenMuc" placeholder="Nhập tên chuyên mục" />
            </div>
            <div class="form-group">
                <label for="">Mô tả</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtMoTa" placeholder="Nhập mô tả" />
            </div>
            <div class="checkbox">
                <label>
                    <asp:CheckBox runat="server" ID="chkTrangThai" Text="Đang hoạt động" Checked="true" />
                </label>
            </div>
            <br />
            <asp:Button runat="server" ID="btnSave" CssClass="btn btn-sm btn-primary" Text="Lưu và thêm" />
            <asp:Button runat="server" ID="btnSaveChanges" CssClass="btn btn-sm btn-success" Text="Lưu và đóng"  />
            <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-sm btn-default" Text="Đóng"  />
            &nbsp;<asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </div>
    </asp:Panel>

    <br />
    <div class="panel panel-primary">
        <div class="panel-heading">
            Danh sách thực đơn
        </div>
        <div class="panel-body">
            <asp:GridView ID="gvChuyenMuc" CssClass="table table-responsive table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="MaChuyenMuc" GridLines="None" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="MaChuyenMuc" HeaderText="ID" />
                    <asp:BoundField DataField="TenChuyenMuc" HeaderText="Tên chuyên mục" />
                    <asp:BoundField DataField="MoTa" HeaderText="Mô tả" />
                    <asp:BoundField DataField="TrangThai" HeaderText="Trạng thái" />
                    <asp:HyperLinkField DataNavigateUrlFields="MaChuyenMuc" DataNavigateUrlFormatString="?Action=Edit&amp;ID={0}" HeaderText="Sửa" Text="Sửa" />
                    <asp:TemplateField HeaderText="Xóa">
                        <%--<ItemTemplate>
                            <asp:LinkButton ID="btnDel" Text="Xóa" runat="server"
                                OnClick="btnXoa_Click" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa ?')" CommandName="Delete"
                                CommandArgument='<%# Eval("MaChuyenMuc") %>' />
                        </ItemTemplate>--%>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
    </div>

</asp:Content>
