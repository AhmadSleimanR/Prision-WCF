<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="VisitaConsultas.aspx.cs" Inherits="Consultas_VisitaConsultas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
	<style>

        body{
            background-color:black;
        }


        .vertical .carousel-inner {
            height: 100%;
        }

        .carousel.vertical .item {
            -webkit-transition: 0.6s ease-in-out top  ;
            -moz-transition: 0.6s ease-in-out top  ;
            -ms-transition: 0.6s ease-in-out top  ;
            -o-transition: 0.6s ease-in-out top  ;
            transition: 0.6s ease-in-out top ;
             left: 0;
        }
      

        .carousel.vertical .active {
            top: 0;
           
        }

        .carousel.vertical .next {
            top: 100%;
      
        }

        .carousel.vertical .prev {
            top: -100%;
       
        }

            .carousel.vertical .next.left,
            .carousel.vertical .prev.right {
                top: 0;
            }

        .carousel.vertical .active.left {
            top: -100%;

        }

        .carousel.vertical .active.right {
            top: 100%;
            
        }

        
    	.auto-style1 {
			height: 33px;
		}

        
    </style>

	<div id="myCarousel" class="carousel slide vertical" data-ride="carousel" style="overflow: hidden">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <!-- Wrapper for slides -->
        <div class="carousel-inner">
            <div class="item active">
                <img src="../Images/bg1real.png" alt="" style="width: 100%;">
            </div>

            <div class="item">
                <img src="../Images/bg2real.png" alt="" style="width: 100%;">
            </div>
            <div class="item">
                <img src="../Images/bg3real.png" alt="" style="width: 100%;">
            </div>
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" data-target="#myCarousel" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" data-target="#myCarousel" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

	<table border="2">
        <caption>
            <strong><span style="color:white;font-size: 14pt; " class="style1">LISTADO DE VISITAS</span></strong></caption>
        <tr>
            <td style="width: 117px; height: 35px;">
                <table style="width: 687px">
                    <tr>
                        <td style="height: 27px;" colspan="5">
                            <strong>
                            <asp:Label ID="Label3" runat="server" Text="Visitas Encontradas :      " style="color:white;background-color: black"></asp:Label>
                            <asp:Label ID="Label4" runat="server" style="color: white" ForeColor="White"></asp:Label>
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
                            <asp:Label ID="label1" runat="server" Text="Fecha Inicial" style="color:white;background-color: black"></asp:Label>
                            </strong>
                        </td>
                        <td style="width: 100px; height: 25px;">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="input-sm"></asp:TextBox>
                        </td>
                        <td style="width: 139px; text-align: center; height: 25px;">
                            <strong>
                            <asp:Label ID="Label2" runat="server" Text="Fecha Final" style="color:white;background-color: black"></asp:Label>
                            </strong>
                        </td>
                        <td style="width: 100px; text-align: center; height: 25px;">
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="input-sm"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnFiltrar" runat="server" Text="Consultar" 
                                Width="200px" OnClick="btnFiltrar_Click" CssClass="btn-primary"  />
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
            <td class="auto-style1">
                &nbsp;&nbsp;
                <asp:TextBox ID="txtDNI" runat="server" CssClass="input-sm"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" CssClass="btn-primary" />
            </td>
        </tr>
        <tr>
            <td>
                <strong>
                <asp:Label ID="Label5" runat="server" style="color:white;" Text="Estado de Consulta : "></asp:Label>
                </strong>
                <asp:Label ID="lblMensaje" runat="server" Width="487px" ForeColor="White"></asp:Label>
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
                    onrowcommand="gvVisitas_RowCommand" AutoGenerateColumns="False" CssClass="table-hover" OnSelectedIndexChanged="gvVisitas_SelectedIndexChanged">
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

