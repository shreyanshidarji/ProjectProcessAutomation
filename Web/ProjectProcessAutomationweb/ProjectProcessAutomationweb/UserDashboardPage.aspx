<%@ Page Title =" UserDashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDashboardPage.aspx.cs" Inherits="ProjectProcessAutomationweb.UserDashboardPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<p>&nbsp;welcome to user Dashboard</p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <p>
       <%-- <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="userId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="userId" HeaderText="userId" ReadOnly="True" SortExpression="userId" />
                <asp:BoundField DataField="userName" HeaderText="userName" SortExpression="userName" />
                <asp:BoundField DataField="userPassword" HeaderText="userPassword" SortExpression="userPassword" />
                <asp:BoundField DataField="userEmail" HeaderText="userEmail" SortExpression="userEmail" />
                <asp:BoundField DataField="userMobile" HeaderText="userMobile" SortExpression="userMobile" />
                <asp:CheckBoxField DataField="userActive" HeaderText="userActive" SortExpression="userActive" />
                <asp:BoundField DataField="userSalary" HeaderText="userSalary" SortExpression="userSalary" />
                <asp:BoundField DataField="createdOn" HeaderText="createdOn" SortExpression="createdOn" />
                <asp:BoundField DataField="updatedOn" HeaderText="updatedOn" SortExpression="updatedOn" />
            </Columns>
        </asp:GridView>--%>
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connection %>" SelectCommand="SELECT userId, userName, userEmail, userMobile FROM ppa.UserTable" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>--%>
    </p>
    <p>
        <asp:Repeater ID="Repeater1" runat="server"  >
            <ItemTemplate>
                
                         ID :    <asp:Label ID="Label1" runat="server" Text='<% #Eval("userId")%>'></asp:Label><br />
                       
                                                

                       UserName :      <asp:Label ID="Label2" runat="server" Text='<% #Eval("userName" )%>'></asp:Label><br />
                
                

            </ItemTemplate>
           
        </asp:Repeater>
    </p>
    <p>&nbsp;</p>


</asp:Content>
