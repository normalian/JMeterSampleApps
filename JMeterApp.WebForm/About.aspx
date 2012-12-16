<%@ Page Title="については" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="JMeterApp.WebForm.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>アプリケーションの説明ページ。</h2>
    </hgroup>

    <article>
        <p>        
            この領域を使用して追加の情報を提供します。
        </p>

        <p>        
            この領域を使用して追加の情報を提供します。
        </p>

        <p>        
            この領域を使用して追加の情報を提供します。
        </p>
    </article>

    <aside>
        <h3>別タイトル</h3>
        <p>        
            この領域を使用して追加の情報を提供します。
        </p>
        <ul>
            <li><a runat="server" href="~/">ホーム</a></li>
            <li><a runat="server" href="~/About.aspx">については</a></li>
            <li><a runat="server" href="~/Contact.aspx">連絡先</a></li>
        </ul>
    </aside>
</asp:Content>