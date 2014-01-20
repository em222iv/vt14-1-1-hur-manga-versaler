<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Versaler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 144px">
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Text" runat="server" Height="158px" Width="379px"></asp:TextBox>
        
        <asp:Button ID="Button" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:Button ID="Button1" runat="server" Text="New try" OnClick="Button1_Click1" />
        <p>
        <asp:Label ID="Result" runat="server" Text="Label"></asp:Label>
        </p>
        </div>
    </form>
</body>
</html>
