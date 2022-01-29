<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SB_Startpage.aspx.cs" Inherits="Diplomarbeit.SB_Startpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <script type="text/javascript" src="JS/Default.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
        integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link rel="stylesheet" href="/CSS/StyleSheet.css" />
    <title></title>
</head>
<body onload="window.history.forward();"> <%--disable back button from previeous page--%>
    <form id="form1" runat="server">
        <embed style="margin: 25px 0px 0px 25px" src="Resources/Pictures/HeaderIcon.svg" />
        <div style="margin: 10px 50px 50px 50px">
            <table style="width: fit-content">
                <tr>
                    <td>
                        <h1>Willkommen</h1>
                        <asp:Label runat="server"
                            ID="lblName"
                            Text="">
                        </asp:Label>
                    </td>
                    <td style="vertical-align:bottom; text-align:left"">
                        <asp:Label runat="server"
                            Text="Termine anzeigen">
                        </asp:Label>
                    </td>
                </tr>
                <tr style="border-top:1pt solid black;">
                    <td>
                        <asp:Label runat="server" ID="lblStandort" Text="Betreute Veranstaltungen in "></asp:Label>
                    </td>
                    <td>
                        <asp:Table runat="server" HorizontalAlign="Left">
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Button class="btnTopSelect"
                                        ID="btnAktSem"
                                        runat="server"
                                        AutoPostBack="true"
                                        OnClick="btnAktSem_Click"
                                        Text="aktuelles Semester"></asp:Button>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Button CssClass="btnTopSelect"
                                        ID="btnNxtSem"
                                        runat="server"
                                        AutoPostBack="true"
                                        OnClick="btnNxtSem_Click"
                                        Text="nächstes Semester"></asp:Button>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Button class="btnTopSelect"
                                        ID="btnAllVerans"
                                        runat="server"
                                        AutoPostBack="true"
                                        OnClick="btnAllVerans_Click"
                                        Text="Alle Termine"></asp:Button>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Button class="btnTopSelect"
                                        ID="btnLogout"
                                        runat="server"
                                        AutoPostBack="true"
                                        OnClick="btnLogout_Click"
                                        Text="Logout"></asp:Button>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="grvMain"
                            CssClass="GridView"
                            AutoGenerateColumns="false"
                            runat="server"
                            OnRowDataBound="grvMain_RowDataBound"
                            OnSelectedIndexChanged="grvMain_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="Datumvon" HeaderText="von" />
                                <asp:BoundField DataField="Datumbis" HeaderText="bis" />
                                <asp:BoundField DataField="Ort" HeaderText="Ort" />
                                <asp:BoundField DataField="Veranstaltungsart" HeaderText="Veranstaltungsart" />
                                <asp:BoundField DataField="Vortragender" HeaderText="Vortragender" />
                                <asp:BoundField DataField="Studiengruppe" HeaderText="Studiengruppe" />
                                <asp:BoundField DataField="Modul" HeaderText="Modul" />
                                <asp:BoundField DataField="AnzTeiln" HeaderText="Teiln." />

                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <asp:Button class="btnGrv"
                                            ID="btnDetails"
                                            runat="server"
                                            AutoPostBack="true"
                                            OnClick="btnDetails_Click"
                                            Text="Details"></asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <asp:Button class="btnGrv"
                                            ID="btnExport"
                                            runat="server"
                                            AutoPostBack="true"
                                            OnClick="btnExport_Click"
                                            Text="PDF"></asp:Button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <RowStyle HorizontalAlign="Center" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

