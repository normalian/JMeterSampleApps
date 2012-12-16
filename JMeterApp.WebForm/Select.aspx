<%@ Page Title="キャラ選択済み" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Select.aspx.cs" Inherits="JMeterApp.WebForm.Select" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>キャラに対する思い入れを記述してください</h2>
            </hgroup>
            <p>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>投票キャラ</h3>
    <table>
        <thead>
            <tr>
                <th>画像</th>
                <th>名前</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <asp:Image ID="CharImg" runat="server" />
                </td>
                <td>
                    <asp:Label runat="server" ID="CharName" />
                </td>
            </tr>
        </tbody>
    </table>
    <br />
    <h3>コメント</h3>
    <asp:TextBox ID="Comment" runat="server" TextMode="MultiLine" Height="98px" Width="262px" />
    <br />
    <asp:Button runat="server" Text="投票" ID="VoteButton" OnClick="VoteButton_Click" />
</asp:Content>
