﻿<%@ Page Title="Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="LibraryApp.Admin.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %></h1>
    <div style="margin:auto">
        <asp:Label ID="LabelResponse" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <br />
    <div>
        <table>
            <tr>                
                <td>
                    <asp:TextBox runat="server" ID="TextBoxSearch"></asp:TextBox>
                </td>
                <td>
                    <asp:Button runat="server" ID="ButtonSearch" Text="Search"></asp:Button>
                </td>
                <td>
                    <asp:Button runat="server" ID="ButtonReset" Text="Reset" OnClick="ButtonReset_Click"></asp:Button>
                </td>
            </tr>
        </table>
        
    </div>
    <asp:HyperLink NavigateUrl="~/Admin/AddBook2" Text="Add New Book" runat="server"></asp:HyperLink>
    <asp:GridView runat="server" ID="booksGrid" DataKeyNames="book_id" ItemType="LibraryApp.Models.book" SelectMethod="booksGrid_GetData" UpdateMethod="booksGrid_UpdateItem2" DeleteMethod="booksGrid_DeleteItem" AllowPaging="false" AllowSorting="true" PageSize="5" AutoGenerateDeleteButton="true" AutoGenerateColumns="false" >
        <Columns>
            <asp:HyperLinkField Text="Details" DataNavigateUrlFormatString="~/BookDetail.aspx?book_id={0}" DataNavigateUrlFields="book_id"/>
            <asp:HyperLinkField Text="Edit" DataNavigateUrlFormatString="~/Admin/AddBook2.aspx?book_id={0}" DataNavigateUrlFields="book_id" />
            <asp:DynamicField DataField="book_id" />
            <asp:DynamicField DataField="book_name" />
            <asp:DynamicField DataField="edition" />
            <asp:DynamicField DataField="year_published" />
            <asp:DynamicField DataField="publisher_name" />
            <asp:DynamicField DataField="genre_name" />
            <asp:DynamicField DataField="rating" />
            <asp:HyperLinkField Text="Authors" DataNavigateUrlFormatString="~/Admin/Authors?book_id={0}" DataNavigateUrlFields="book_id" />
        </Columns>
    </asp:GridView>
</asp:Content>
