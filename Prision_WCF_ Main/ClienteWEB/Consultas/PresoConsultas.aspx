<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PresoConsultas.aspx.cs" Inherits="Consultas_PresoConsultas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" 
                    NavigateUrl="~/Consultas/Consultas.aspx" Width="448px">Retornar al Menu de Consultas</asp:HyperLink>
                        <br />
        <table class="nav-justified" style="width: 36%">
            <tr>
                <td style="background-color: #0099CC">
                    <strong>
                    <asp:Label ID="label1" runat="server" Text="Ingrese DNI del preso :   " style="color: #FFFFFF"></asp:Label>
                    </strong>
                </td>
                <td style="background-color: #0099CC">
                    <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 21px">
                    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" Width="117px" />
                </td>
                <td style="height: 21px"></td>
            </tr>
        </table>
    </p>
    <table class="nav-justified" style="width: 56%">
        <tr>
            <td class="text-center" style="color: #FFFFFF; background-color: #0099CC"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NOMBRE COMPLETO &nbsp;</strong></td>
            <td class="text-center" style="color: #FFFFFF; background-color: #0099CC"><strong>&nbsp; DISTRITO&nbsp;</strong></td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;<strong><asp:Label ID="lblNombre" runat="server"></asp:Label>
                </strong>
            </td>
            <td>
                <strong>
                <asp:Label ID="lblDistrito" runat="server"></asp:Label>
                </strong>
            </td>
        </tr>
    </table>
    <table class="nav-justified" style="width: 63%; height: 130px">
        <tr style="color: #000000">
            <td class="text-center" style="width: 161px"><strong>&nbsp;&nbsp;</strong></td>
            <td class="text-center" rowspan="2" style="width: 31px"><strong><span style="background-color: #FFFFFF">DELITOS:</span></strong></td>
        </tr>
        <tr>
            <td style="width: 161px; height: 22px;"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; INGRESOS&nbsp;</strong></td>
        </tr>
        <tr>
            <td style="width: 161px">
        <asp:GridView ID="grvIngresos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowCommand="grvIngresos_RowCommand" Width="382px">
            <Columns>
                <asp:BoundField DataField="estado" HeaderText="ESTADO" />
                <asp:BoundField DataField="fecIngreso" DataFormatString="{0:d}" HeaderText="FEC. INGRESO" />
                <asp:BoundField DataField="fecSalida" DataFormatString="{0:d}" HeaderText="FEC. SALIDA" />
                <asp:BoundField DataField="codCelda" HeaderText="CELDA" />
                <asp:ButtonField CommandName="delitos" Text="ver" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
            </td>
            <td style="width: 31px">
                <asp:GridView ID="grvDelitos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="nomDelito" HeaderText="Delito" />
                        <asp:BoundField DataField="participacion" HeaderText="Participacion" />
                    </Columns>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <p>
        <asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

