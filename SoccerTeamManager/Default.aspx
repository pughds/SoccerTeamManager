<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SoccerTeamManager.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Soccer Data Manager</title>
</head>
<body style="height: 60px">
    <form id="form1" runat="server">
    <div id="infoArea">
        <h4>This web site will allow you to create Soccer teams and players. It will also give you the ability to assign these players to a team.</h4>
    </div>
        <div id="addTeam">

        <asp:Button ID="btnAddTeam" runat="server" Text="Add Team" OnClick="btnAddTeam_Click" />

    </div>
        <br />
    <div id="addPlayer">

        <asp:Button ID="btnAddPlayer" runat="server" Text="Add Player" OnClick="btnAddPlayer_Click" />

        <br />
        <br />

    </div>
        <br />
        Teams:<br />
    <div id="teamDisplay" >

        <asp:ListBox ID="listTeamNames" runat="server" ></asp:ListBox>

            <asp:Button ID="btnDeleteTeam" runat="server" Text="Delete Selected Team" OnClick="btnDeleteTeam_Click" />
        <br />
        Players:<div>

        <asp:ListBox ID="listPlayerNames" runat="server" ></asp:ListBox>

            <asp:Button ID="btnDeletePlayer" runat="server" Text="Delete Selected Player" OnClick="btnDeletePlayer_Click" />
        </div>

    </div>
    </form>
</body>
</html>
