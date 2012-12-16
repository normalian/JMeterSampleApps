<%@ Page Title="ホーム ページ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JMeterApp.WebForm._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>WebForm 版の投票アプリの予定</h2>
            </hgroup>
            <p>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>以下のキャラから投票してくだされ。</h3>

    <asp:Repeater ID="Repeater1" runat="server" EnableViewState="true" OnItemCommand="Repeater1_ItemCommand">
        <HeaderTemplate>
            <table style="border-color: Black; border-style: Solid;">
                <thead>
                    <tr>
                        <th scope="col" style="border-color: Black; border-style: Solid;">名前</th>
                        <th scope="col" style="border-color: Black; border-style: Solid;">概要</th>
                        <th scope="col" style="border-color: Black; border-style: Solid;">削除</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td style="border-color: Black; border-style: Solid;">
                    <asp:Label ID="txtColumn1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                </td>
                <td style="border-color: Black; border-style: Solid;">
                    <asp:Label ID="txtColumn2" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                </td>
                <td style="border-color: Black; border-style: Solid;">
                    <asp:Button runat="server" Text="選択" ID="SubmitButton" />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
