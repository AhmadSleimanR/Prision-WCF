<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PresoConsultas.aspx.cs" Inherits="Consultas_PresoConsultas" %>

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
		text-align: center;
		width: 161px;
		height: 22px;
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
                    <asp:TextBox ID="txtDNI" runat="server" CssClass="input-sm"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 21px">
                    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" Width="117px" CssClass="btn-primary" />
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
            <td>&nbsp;&nbsp;<strong><asp:Label ID="lblNombre" runat="server" ForeColor="White"></asp:Label>
                </strong>
            </td>
            <td>
                <strong>
                <asp:Label ID="lblDistrito" runat="server" ForeColor="White"></asp:Label>
                </strong>
            </td>
        </tr>
    </table>
    <table class="nav-justified" style="width: 63%; height: 130px">
        <tr style="color: #000000">
            <td class="auto-style1"><strong>&nbsp;&nbsp;</strong></td>
            <td class="text-center" rowspan="2" style="width: 31px"><strong><span style="color: white">DELITOS:</span></strong></td>
        </tr>
        <tr>
            <td style="color:white;width: 161px; height: 22px;"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; INGRESOS&nbsp;</strong></td>
        </tr>
        <tr>
            <td style="width: 161px">
        <asp:GridView ID="grvIngresos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowCommand="grvIngresos_RowCommand" Width="382px" CssClass="table-hover">
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
                <asp:GridView ID="grvDelitos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" CssClass="table-hover">
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
        <asp:Label ID="lblMensaje" runat="server" ForeColor="White"></asp:Label>
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

