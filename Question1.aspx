<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question1.aspx.cs" Inherits="Assessment.Question1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvFnV" runat="server">
        </asp:GridView>
    <br />
    <asp:Button ID="btnPopulate" runat="server" OnClick="btnPopulate_Click" Text="Button" />
    </form>
</body>
</html>
