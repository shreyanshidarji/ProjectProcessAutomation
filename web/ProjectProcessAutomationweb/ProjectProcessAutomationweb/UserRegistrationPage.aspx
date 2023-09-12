<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistrationPage.aspx.cs" Inherits="ProjectProcessAutomationweb.UserRegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form runat="server">
            
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbluserid" runat="server" Text=" UserID :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="lblusername" runat="server" Text="UserName : "></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            <br />
            <br />
            UserPassword :
            <asp:TextBox ID="txtuserpassword" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtuseremail" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MobileNo:
            <asp:TextBox ID="txtusermobile" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp; UserActive :
            <asp:TextBox ID="txtuseractive" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Salary :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtusersalary" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnregister" runat="server" OnClick="btnregister_Click" Text="Register" style="margin-bottom: 0px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br/>
 --></form>
   
        </body>
</html>
