<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectProcessAutomationweb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <br />
    <br />
    <asp:Label ID="lbluseremail" runat="server" Text="Enter Email :" BackColor="#99FFCC" ForeColor="Black" style="background-color: #FFFFFF"></asp:Label>
    <br style="background-color: #FFFFFF" />
    <asp:TextBox ID="txtuseremail" runat="server" BackColor="White" Width="229px"></asp:TextBox>
    <br style="background-color: #FFFFFF" />
    <br style="background-color: #FFFFFF" />
    <asp:Label ID="lbluserpassword" runat="server" Text="password :" style="background-color: #FFFFFF"></asp:Label>
    <br />
    <asp:TextBox ID="txtuserpassword" runat="server" Width="229px"></asp:TextBox>
    </p>
<p>
    &nbsp;</p>
<p>
    <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="font-size: small" Text="Remember me" />
    <br />
<br />
<asp:Label ID="lblloginsuccess" runat="server"></asp:Label>
    <br style="background-color: #FFFFFF" />
    <br style="background-color: #FFFFFF" />
    <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click1" Text="login" style="background-color: #FFFFFF; height: 26px;" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnclear" runat="server" OnClick="btnclear_Click" style="background-color: #FFFFFF" Text="clear" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnsignup" runat="server" OnClick="btnsignup_Click" Text="SignUp" />
    <br style="background-color: #FFFFFF" />
    </p>
    <p>
    </p>

</asp:Content>
