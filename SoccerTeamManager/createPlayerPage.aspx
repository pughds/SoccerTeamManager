<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createPlayerPage.aspx.cs" Inherits="SoccerTeamManager.createPlayerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="playerInputArea">
    
        Player Name:<asp:TextBox ID="txtPlayerName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnCreatePlayer" runat="server"  Text="Create Player" OnClick="btnCreatePlayer_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
