<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="IngresoConsultas.aspx.cs" Inherits="Consultas_IngresoConsultas" %>

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
	<table class="nav-justified">
        <tr>
            <td style="background-color: black"><strong>
                <asp:Label ID="Label4" runat="server" style="color: #FF3300; background-color: black" Text="BUSCAR POR FECHAS :"></asp:Label>
                </strong> </td>
            <td style="width: 141px; background-color: black;">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 187px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="color: #FFFFFF; background-color: #003366">FECHA INICIAL </td>
            <td style="width: 141px; background-color: #003366;">
                <asp:TextBox ID="txtIni" runat="server" CssClass="input-sm"></asp:TextBox>
            </td>
            <td style="background-color: #003366"><span style="color: #FFFFFF">F</span><span style="color: #FFFFCC">ECHA FINAL</span></td>
            <td style="width: 187px; background-color: #003366;">
                <asp:TextBox ID="txtFin" runat="server" CssClass="input-sm"></asp:TextBox>
            </td>
            <td style="background-color: #003366">
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" style="height: 26px" Text="Consultar" CssClass="btn-primary" />
            </td>
        </tr>
        <tr>
            <td style="height: 22px; background-color: black"><strong>
                <asp:Label ID="Label5" runat="server" style="color: #FF3300; background-color: black" Text="BUSCAR POR DNI : "></asp:Label>
                </strong> </td>
            <td style="width: 141px; height: 22px;">
            </td>
            <td style="height: 22px"></td>
            <td style="width: 187px; height: 22px;">
            </td>
            <td style="height: 22px">
            </td>
        </tr>
        <tr>
            <td style="background-color: #003366">
                <asp:Label ID="Label6" runat="server" style="color: #FFFFFF" Text="Ingrese DNI  : "></asp:Label>
            </td>
            <td style="width: 141px; background-color: #003366;">
                <asp:TextBox ID="txtDNI" runat="server" style="color: #000000; text-decoration: underline" CssClass="input-sm"></asp:TextBox>
            </td>
            <td style="background-color: #003366">
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" style="color: #FFFFFF" Text="Buscar" Width="105px" CssClass="btn-primary" />
            </td>
            <td style="width: 187px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p>
        <asp:Label ID="label" runat="server" style="color: #FFFFFF" Text="Resultados Encontrados : "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="color: #FFFFFF" Text="  Label"></asp:Label>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label3" runat="server" style="color: #FFFFFF" Text="Estado de Consulta :"></asp:Label>
        <asp:Label ID="lblMensaje" runat="server" style="color: #FFFFFF" Text=" "></asp:Label>
    </p>
                <asp:GridView ID="grvDelitos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="table-hover">
                    <Columns>
                        <asp:BoundField DataField="nomDelito" HeaderText="Delito" />
                        <asp:BoundField DataField="participacion" HeaderText="Participacion" />
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
                <asp:GridView ID="grvIngresos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCommand="grvIngresos_RowCommand" Width="456px" CssClass="table-hover">
                    <Columns>
                        <asp:BoundField DataField="dniPreso" HeaderText="DNI" />
                        <asp:BoundField DataField="nomPreso" HeaderText="Nombre" />
                        <asp:BoundField DataField="apePreso" HeaderText="Apellido" />
                        <asp:BoundField DataField="disPreso" HeaderText="Distrito" />
                        <asp:BoundField DataField="fecIngreso" DataFormatString="{0:d}" HeaderText="Fecha Ingreso" />
                        <asp:BoundField DataField="fecSalida" DataFormatString="{0:d}" HeaderText="Fecha Salida" />
                        <asp:BoundField DataField="codCelda" HeaderText="Celda" />
                        <asp:BoundField DataField="estado" HeaderText="Estado" />
                        <asp:ButtonField CommandName="detalles" HeaderText="Detalles" Text="detalles" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
    <table class="nav-justified">
        <tr>
            <td style="width: 525px">
                &nbsp;</td>
        </tr>
        </table>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

