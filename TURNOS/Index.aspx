<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TURNOS.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            background-color: #FFFFFF;
        }
        .auto-style8 {
            text-align: justify;
        }
        .auto-style10 {
        text-align: justify;
        font-size: 18pt;
        background-color: #FFFFFF;
    }
        .auto-style11 {
            text-align: center;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <div class="auto-style8">
        </div>

        <div class="auto-style11">

    <asp:Table ID="Table1" runat="server" Height="20px" Width="820px" CssClass="auto-style10" CaptionAlign="Bottom" HorizontalAlign="Center">

        <asp:TableFooterRow>
            <asp:TableHeaderCell HorizontalAlign="Center">
                <p>
                    Cliente
                </p>
                <br />
                <br />

                 <img src="images/turno3.jpg" alt="image" />
            </asp:TableHeaderCell>

            <asp:TableHeaderCell HorizontalAlign="Center">
                <p>
                    Turno
                </p>
                 <img src="images/Solicitud-de-Turno.jpg" alt="image" />
            </asp:TableHeaderCell>

           
        </asp:TableFooterRow>

    </asp:Table>
    


        </div>
    


</asp:Content>
