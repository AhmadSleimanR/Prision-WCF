<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Consultas.aspx.cs" Inherits="Consultas_Consultas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
        <tr>
            <td width ="180px">
                <asp:Image ID="Image1" runat="server" Height="281px" 
                    ImageUrl="~/Imagenes/consulta.jpg" Width="310px" />
            </td>
            <td>
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="Inbox" Height="133px" 
                    Width="224px">
                    <HoverNodeStyle Font-Underline="True" />
                    <Nodes>
                        <asp:TreeNode NavigateUrl="~/Consultas/PresoConsultas.aspx" Text="Preso" 
                            Value="Preso"></asp:TreeNode>
                        <asp:TreeNode Text="Ingreso" Value="Ingreso" NavigateUrl="~/Consultas/IngresoConsultas.aspx"></asp:TreeNode>
                        <asp:TreeNode Text="Visita" Value="Visita" NavigateUrl="~/Consultas/VisitaConsultas.aspx"></asp:TreeNode>
                        <asp:TreeNode Text="Inscripcion" Value="Inscripcion" NavigateUrl="~/Consultas/InscripcionConsultas.aspx"></asp:TreeNode>
                         
                    </Nodes>
                    <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                        HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" 
                        VerticalPadding="0px" />
                </asp:TreeView>
            </td>
        </tr>
    </table>
</asp:Content>

