<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Views/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ReportDoanhThu.aspx.cs" Inherits="Admin_Views_ReportDoanhThu" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
     <h1 class="page-header" style="text-align:center;background-color:#0094ff">Thống kê doanh thu </h1>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1060px">
        <LocalReport ReportPath="Admin\Reports\ReportDoanhThu.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="DoanhThuSqlDataSource" Name="ThongKeDataSet" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:SqlDataSource ID="DoanhThuSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:QuanNuocConnectionString %>" SelectCommand="SELECT * FROM [Bill]"></asp:SqlDataSource>
</asp:Content>

