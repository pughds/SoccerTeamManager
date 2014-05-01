<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createTeamPage.aspx.cs" Inherits="SoccerTeamManager.createTeamPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="teamInputArea">
    
        Team Name:<asp:TextBox ID="txtTeamName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnCreateTeam" runat="server" OnClick="Button1_Click" Text="Create Team" />
        <br />
    
    </div>
    </form>
</body>
</html>
