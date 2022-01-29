<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Diplomarbeit.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <title>Hello, world!</title>
</head>
<body>
    <form id="form1" runat="server" style="max-width: 480px; margin:auto">
        <div class="text-center mt-5">
            <img src="https://ilias.ingenium.co.at/Customizing/global/skin/ingenium/images/HeaderIcon.svg" alt="Logo" style="max-width:420px"/>
            <hr/>
            <label>Username</label>
            <asp:TextBox ID="tbUsername" runat="server" Text="TestAdmin" ToolTip="Username"></asp:TextBox><br />
            <div class="mt-3">
                <label>P1ngu1n!!</label>
                <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" ToolTip="Password"></asp:TextBox><br />
            </div>
            <hr/>
            <div class="mt-3">
            <asp:Button class="btn btn-lg btn-primary btn-block" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/><br />
            </div>
            <label id="lblSatus"></label><br />
            <asp:Label ID="alblStatus" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
