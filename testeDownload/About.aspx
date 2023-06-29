<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="testeDownload.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Teste</h3>
        <asp:Button ID="btn_download" runat="server" Text="Download" OnClick="btn_download_Click" />
        
    </main>
</asp:Content>