<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="QuanLyQuanNuoc.Views.Shared.WebUserControl1" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<rsweb:ReportViewer ID="ReportViewer1" runat="server"></rsweb:ReportViewer>
