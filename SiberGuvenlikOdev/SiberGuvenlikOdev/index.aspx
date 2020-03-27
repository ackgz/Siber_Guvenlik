<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SiberGuvenlikOdev.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="tara" runat="server" OnClick="tara_Click" Text="Tara" />
    
        <br />
        <asp:Label ID="sonuc" runat="server" Height="1000px" Width="1000px"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
