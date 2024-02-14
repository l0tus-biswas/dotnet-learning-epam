<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UsingMyCustomControl.WebForm1" %>

<%@ Register assembly="CustomControlASPDOTNet" namespace="CustomControlASPDOTNet" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:WebCustomControlLogin ID="WebCustomControlLogin1" runat="server" />
        <asp:TextBox ID="TextBox1" runat="server" Height="203px" TextMode="MultiLine" Width="626px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
