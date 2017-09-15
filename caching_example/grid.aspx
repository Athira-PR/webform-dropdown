<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grid.aspx.cs" Inherits="caching_example.grid" %>
<%@ OutputCache Duration="60"  VaryByParam="DropDownList1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
       
         <asp:ListItem text="all" Value="all" Selected="True"></asp:ListItem>
         <asp:ListItem text="CS" Value="CS" ></asp:ListItem>
         <asp:ListItem text="EC" Value="EC"></asp:ListItem>
         <asp:ListItem text="EE" Value="EE" ></asp:ListItem>
         <asp:ListItem text="BM" Value="BM"></asp:ListItem>
            </asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" >
           
        </asp:GridView>
        <%--  --%>
    </div>
    </form>
</body>
</html>
