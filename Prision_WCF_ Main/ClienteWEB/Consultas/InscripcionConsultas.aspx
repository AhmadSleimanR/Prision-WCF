<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InscripcionConsultas.aspx.cs" Inherits="Consultas_InscripcionConsultas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table border="2">
        <caption>
            <span style="font-size: 14pt; " class="style1">
            <strong><span style="background-color: #FFFFFF">LISTADO DE </span></strong>I<span style="font-weight: bold; background-color: #FFFFFF">NSCRIPCIONES</span></span></caption>
        <tr>
            <td style="width: 68px; height: 35px;">
                <table style="width: 632px; height: 131px;">
                    <tr>
                        <td style="height: 25px;" colspan="5">
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" 
                    NavigateUrl="~/Consultas/Consultas.aspx" Width="448px" Height="20px">Retornar al Menu de Consultas</asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px;" colspan="5">
                            <strong>
                            <asp:Label ID="Label4" runat="server" Text="Resultados Encontrados  :  "></asp:Label>
                            </strong>
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px;" colspan="5">
                            <asp:Label ID="Label13" runat="server" Text="Estado de Consulta : "></asp:Label>
                <asp:Label ID="lblMensaje" runat="server" Width="436px" Height="20px" style="margin-bottom: 0px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px;" colspan="5">
                            <strong>
                            <asp:Label ID="Label14" runat="server" style="color: #CC0000" Text="FILTRAR POR FECHAS :"></asp:Label>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 25px; background-color: #006666;">
                            <strong>
                            <asp:Label ID="Label3" runat="server" Text="Fecha Inicial :" style="background-color: #006666; color: #FFFFFF;"></asp:Label>
                            </strong>
                        </td>
                        <td style="height: 25px; background-color: #006666;">
                            <asp:TextBox ID="txtIni" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 100px; text-align: center; height: 25px; background-color: #006666;">
                            <strong>
                            <asp:Label ID="Label2" runat="server" Text="Fecha Final :" style="background-color: #006666; color: #FFFFFF;"></asp:Label>
                            </strong>
                        </td>
                        <td style="width: 100px; text-align: center; height: 25px; background-color: #006666;">
                            <asp:TextBox ID="txtFin" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 36px; background-color: #006666;">
                            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px;" colspan="2">
                            <strong>
                            <asp:Label ID="Label15" runat="server" style="color: #CC0000" Text="FILTRAR POR  DNI :"></asp:Label>
                            </strong>
                        </td>
                        <td style="height: 25px;" class="text-left" colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="height: 25px; background-color: #006666;" colspan="2">
                            <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="81px" />
                        </td>
                        <td style="height: 25px; background-color: #006666;" class="text-left" colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="height: 25px;" colspan="2">
                            <strong>
                            <asp:Label ID="Label12" runat="server" Text="Buscar Por  Programa :"></asp:Label>
                            </strong>&nbsp;
                        </td>
                        <td style="height: 25px;" class="text-left" colspan="3">
                            <strong>
                            <asp:DropDownList ID="cboProgramas" runat="server" Height="16px" Width="142px" style="font-weight: bold">
                            </asp:DropDownList>
                            </strong>
                            </td>
                        <td></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 68px; height: 201px;">
                <asp:GridView ID="gvInscripciones" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="623px">
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="apePreso" HeaderText="Apellido" />
                        <asp:BoundField DataField="apePreso" HeaderText="Nombre" />
                        <asp:BoundField DataField="nomPrograma" HeaderText="Programa" />
                        <asp:BoundField DataField="fecIni" DataFormatString="{0:d}" HeaderText="Fecha Inicio" />
                        <asp:BoundField DataField="fecFin" DataFormatString="{0:d}" HeaderText="Fecha Fin" />
                        <asp:BoundField DataField="desPrograma" HeaderText="Descripcion Programa" />
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

