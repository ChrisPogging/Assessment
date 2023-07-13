<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question2.aspx.cs" Inherits="Assessment.Question2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="gvEmployees" runat="server">
        </asp:GridView>
    

        <asp:Button ID="btnGet" runat="server" OnClick="btnGet_Click" Text="Button" />
    </form>
    

</body>
</html>
