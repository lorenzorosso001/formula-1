<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormulaOneWebFormProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLoadCountries" runat="server" Text="CARICA NAZIONI" OnClick="btnLoadData_Click" />
            <asp:Button ID="btnLoadDrivers" runat="server" Text="CARICA PILOTI" OnClick="btnLoadDrivers_Click" />
            <asp:Button ID="btnLoadTeams" runat="server" Text="CARICA TEAM" OnClick="btnLoadTeams_Click" />
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>

            <div>
                <asp:Label ID="idTeam" runat="server"></asp:Label><br />
                <asp:Label ID="nameTeam" runat="server"></asp:Label><br />
                <asp:Label ID="fullNameTeam" runat="server"></asp:Label><br />
                <asp:Label ID="countryTeam" runat="server"></asp:Label><br />
                <asp:Label ID="powerUnitTeam" runat="server"></asp:Label><br />
                <asp:Label ID="technicalChiefTeam" runat="server"></asp:Label><br />
                <asp:Label ID="chassisTeam" runat="server"></asp:Label><br />
                <asp:Label ID="nameFirstTeam" runat="server"></asp:Label><br />
                <asp:Label ID="nameSecondDriver" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
