<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InscripcionConsultas.aspx.cs" Inherits="Consultas_InscripcionConsultas" %>

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
	<table border="2">
        <caption>
            <span style="font-size: 14pt; " class="style1">
            <strong><span style="background-color: black; color: white">LISTADO DE </span></strong><span style="font-weight: bold; background-color: black; color: white">INSCRIPCIONES</span></span></caption>
        <tr>
            <td style="width: 68px; height: 35px;">
                <table style="margin: auto; width: 632px; height: 131px;">
                    <tr>
                        <td style="height: 25px;" colspan="5">
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" 
                    NavigateUrl="~/Consultas/Consultas.aspx" Width="448px" Height="20px">Retornar al Menu de Consultas</asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px;" colspan="5">
                            <strong>
                            <asp:Label ID="Label4" style="color: white" runat="server" Text="Resultados Encontrados  :  "></asp:Label>
                            </strong>
                            <asp:Label ID="Label5" style="color: white" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px;" colspan="5">
                            <asp:Label ID="Label13" style="color: white" runat="server" Text="Estado de Consulta : "></asp:Label>
                <asp:Label ID="lblMensaje" runat="server" Width="436px" Height="20px" style="margin-bottom: 0px; color: white"></asp:Label>
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
                            <asp:TextBox ID="txtIni" runat="server" CssClass="input-sm"></asp:TextBox>
                        </td>
                        <td style="width: 100px; text-align: center; height: 25px; background-color: #006666;">
                            <strong>
                            <asp:Label ID="Label2" runat="server" Text="Fecha Final :" style="background-color: #006666; color: #FFFFFF;"></asp:Label>
                            </strong>
                        </td>
                        <td style="width: 100px; text-align: center; height: 25px; background-color: #006666;">
                            <asp:TextBox ID="txtFin" runat="server" CssClass="input-sm"></asp:TextBox>
                        </td>
                        <td style="width: 36px; background-color: #006666;">
                            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" CssClass="btn-primary" />
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
                            <asp:TextBox ID="txtDNI" runat="server" CssClass="input-sm"></asp:TextBox>
                            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="81px" CssClass="btn-primary" />
                        </td>
                        <td style="height: 25px; background-color: #006666;" class="text-left" colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="height: 25px;" colspan="2">
                            <strong>
                            <asp:Label ID="Label12" runat="server" style="color: white" Text="Buscar Por  Programa :"></asp:Label>
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
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="623px" CssClass="table-hover">
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

