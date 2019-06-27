<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="VisitaConsultas.aspx.cs" Inherits="Consultas_VisitaConsultas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table border="2">
        <caption>
            <strong><span style="font-size: 14pt; " class="style1">LISTADO DE VISITAS</span></strong></caption>
        <tr>
            <td style="width: 117px; height: 35px;">
                <table style="width: 687px">
                    <tr>
                        <td style="height: 25px;" colspan="5">
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" 
                    NavigateUrl="~/Consultas/Consultas.aspx" Width="448px">Retornar al Menu de Consultas</asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 27px;" colspan="5">
                            <strong>
                            <asp:Label ID="Label3" runat="server" Text="Visitas Encontradas :      " style="background-color: #FFFFFF"></asp:Label>
                            <asp:Label ID="Label4" runat="server" style="color: #0000FF"></asp:Label>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px; background-color: #006666;" colspan="5">
                            <strong>
                            <asp:Label ID="Label7" runat="server" style="color: #FFFFFF; background-color: #006666" Text="FILTRAR POR FECHAS  :"></asp:Label>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 149px; height: 25px;">
                            <strong>
                            <asp:Label ID="label1" runat="server" Text="Fecha Inicial" style="background-color: #FFFFFF"></asp:Label>
                            </strong>
                        </td>
                        <td style="width: 100px; height: 25px;">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 139px; text-align: center; height: 25px;">
                            <strong>
                            <asp:Label ID="Label2" runat="server" Text="Fecha Final" style="background-color: #FFFFFF"></asp:Label>
                            </strong>
                        </td>
                        <td style="width: 100px; text-align: center; height: 25px;">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnFiltrar" runat="server" Text="Consultar" 
                                Width="200px" OnClick="btnFiltrar_Click"  />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="background-color: #006666">
                <strong>
                <asp:Label ID="Label6" runat="server" style="color: #FFFFFF; background-color: #006666" Text="BUSCAR POR DNI :"></asp:Label>
                </strong></td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td>
                <strong>
                <asp:Label ID="Label5" runat="server" Text="Estado de Consulta : "></asp:Label>
                </strong>
                <asp:Label ID="lblMensaje" runat="server" Width="487px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 117px">
                <asp:GridView ID="gvVisitas" runat="server" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="848px" 
                    onrowcommand="gvVisitas_RowCommand" AutoGenerateColumns="False">
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="apepreso" HeaderText="Apellido Preso" />
                        <asp:BoundField DataField="nomPreso" HeaderText="Nombre Preso" />
                        <asp:BoundField DataField="nomVisitante" HeaderText="Nombre Visitante" />
                        <asp:BoundField DataField="apeVisitante" HeaderText="Apellido Visitante" />
                        <asp:BoundField DataField="dniVisitante" HeaderText="DNI Visitante" />
                        <asp:BoundField DataField="fecVisita" DataFormatString="{0:d}" HeaderText="Fecha Visita" />
                        <asp:BoundField DataField="motVisita" HeaderText="Motivo" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
            </td>
        </tr>
        </table>
</asp:Content>

