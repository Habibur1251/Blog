<%@ Page Language="C#" MasterPageFile="~/MasterPage_green.master" AutoEventWireup="true"  CodeFile="Articles.aspx.cs" Inherits="Articles" Title="Articles" %>


 <asp:Content ID="Content1"   ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
     <asp:Content ID="Content2"   ContentPlaceHolderID="BodyP" Runat="Server">
     <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
    <div class="article_design">
     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "Articles.aspx?id="+ DataBinder.Eval (Container.DataItem,"article_id") %>'
                           Text='<%# DataBinder.Eval(Container.DataItem,"article_title")%>' CssClass="article_header"></asp:HyperLink><br><br />

      <asp:Label ID="lblDescription" runat="server"
                Text='<%# Limit(DataBinder.Eval(Container.DataItem, "article_body"),500) %>' CssClass="article_detail" >
      </asp:Label>
      <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "Articles.aspx?id="+ DataBinder.Eval (Container.DataItem,"article_id") %>' Text='<%#  AddReadMore() %>' ></asp:HyperLink>


    </div>
    </ItemTemplate>
    </asp:Repeater>
   
    
      <div id="comment" runat="server">
      <h4 style="padding:10px;text-decoration:underline">Comments:</h4>
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
            <div class="comment">
            <asp:Label ID="lblDescription" runat="server"
                    Text='<%# DataBinder.Eval(Container.DataItem, "com_des") %>' CssClass="article_detail" >
            </asp:Label><br />
            <asp:Label ID="Label2" runat="server"
                    Text='<%# "---- "+DataBinder.Eval(Container.DataItem, "display_name") %>' CssClass="article_detail" >
            </asp:Label><br />
            <br />
            </div>
            </ItemTemplate>
        </asp:Repeater>
        <hr>
          <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>Comment:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="comment_des" runat="server" TextMode="MultiLine" Rows="10" Columns="50"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Display Name:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="displayname" runat="server">
                    </asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>E-Mail:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="email" runat="server">
                    </asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><br></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Submit" runat="server" Text="Submit Comment" OnClick="submit_comment" />
                </asp:TableCell>
            </asp:TableRow>
          </asp:Table>
          

      </div>
         <asp:Panel ID="Panel1" runat="server">
         </asp:Panel>
      

    </asp:Content>

