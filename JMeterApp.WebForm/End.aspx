<%@ Page Title="投票完了！" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="End.aspx.cs" Inherits="JMeterApp.WebForm.End" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
            </hgroup>
            <p>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2>
        <asp:Label ID="CharName" runat="server" />
        への投票が完了しました</h2>
    <dl>
        <dt>あなたのコメント：
        </dt>
        <dd><asp:Label ID="Comment" runat="server" />
        </dd>
    </dl>
</asp:Content>
