<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SOAP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cliente SOAP</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Num1: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            Num2: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            Resultado: <asp:TextBox ID="TextBoxResult" runat="server" ></asp:TextBox><br />
          
            <br /><asp:Button ID="Button1" runat="server" Text="Suma" OnClick="Button1_Click" /><br />
            <br /><asp:Button ID="Button2" runat="server" Text="Resta" OnClick="Button2_Click" /><br />
            <br /><asp:Button ID="Button3" runat="server" Text="Multiplicación" OnClick="Button3_Click" /><br />
            <br /><asp:Button ID="Button4" runat="server" Text="División" OnClick="Button4_Click" /><br />

            <%--<br /><asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>--%>
        </div>
    </form>
</body>
</html>
