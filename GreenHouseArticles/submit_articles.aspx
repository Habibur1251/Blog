<%@ Page Language="C#" MasterPageFile="~/MasterPage_green.master" AutoEventWireup="true" CodeFile="submit_articles.aspx.cs" Inherits="submit_articles" %>

 <asp:Content ID="Content1"   ContentPlaceHolderID="head" Runat="Server">

    </asp:Content>
     <asp:Content ID="Content2"   ContentPlaceHolderID="BodyP" Runat="Server">

         <asp:Table ID="Table1" CssClass="table_cont" runat="server" CellPadding="100" CellSpacing="100">
         <asp:TableRow Width="50px"><asp:TableCell>Title</asp:TableCell>
         <asp:TableCell><asp:TextBox ID="txttitle" runat="server" Width="250px" MaxLength="100"></asp:TextBox></asp:TableCell>
         </asp:TableRow>
         <asp:TableRow Width="50px"><asp:TableCell>Type</asp:TableCell>
         <asp:TableCell>
         <asp:ListBox ID="lsttype" runat="server" Width="250px">
             <asp:ListItem>Green Energy</asp:ListItem>
             <asp:ListItem>Forestry</asp:ListItem></asp:ListBox></asp:TableCell>
         </asp:TableRow>
         <asp:TableRow><asp:TableCell>Email Address</asp:TableCell>
         <asp:TableCell>
             <asp:TextBox ID="txtemail" runat="server" Width="250px"></asp:TextBox></asp:TableCell></asp:TableRow>
         <asp:TableRow Width="50px"><asp:TableCell>Article Content</asp:TableCell>
         <asp:TableCell>
             <asp:TextBox ID="txtmain" runat="server" TextMode="MultiLine" Width="250px" Height="150px" MaxLength="3000"></asp:TextBox></asp:TableCell></asp:TableRow>
              <asp:TableRow Width="50px"><asp:TableCell>Article Tags</asp:TableCell>
         <asp:TableCell>
             <asp:TextBox ID="txttags" runat="server" Width="250px"  MaxLength="200"></asp:TextBox></asp:TableCell></asp:TableRow>
             <asp:TableRow><asp:TableCell>Enter Image Code</asp:TableCell>
             <asp:TableCell><asp:Image ID="myImage" runat="server" CssClass="captcha" Width="100%" ImageUrl="~/CaptchaControl.aspx"  Height="25%"/></asp:TableCell>
             </asp:TableRow>
             <asp:TableRow><asp:TableCell>
             </asp:TableCell><asp:TableCell><asp:TextBox ID="txtcapcha" runat="server" Width="250px"></asp:TextBox></asp:TableCell></asp:TableRow>
         <asp:TableRow><asp:TableCell> </asp:TableCell>
         <asp:TableCell><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="submit_article" /></asp:TableCell></asp:TableRow>
         </asp:Table>
        
    </asp:Content>
    
