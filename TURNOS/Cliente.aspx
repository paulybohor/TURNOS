<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="TURNOS.Cliente" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <dx:ASPxRoundPanel runat="server" ShowCollapseButton="true" Width="817px">
        <PanelCollection>
            <dx:PanelContent runat="server">
     <table>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
         <tr>
            <td>
            </td>
            <td>
                <dx:ASPxButton ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" Theme="Office2010Blue">
                </dx:ASPxButton>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td colspan="2" class="text-center">
                <dx:ASPxGridView ID="gvCliente" runat="server" AutoGenerateColumns="False" EnableCallBacks="False" EnableTheming="True" KeyFieldName="Cliente" OnCustomButtonCallback="gvCliente_CustomButtonCallback" Theme="Office2010Blue" Width="98%">
                    <Settings ShowFilterRow="True" ShowFilterRowMenu="True" />
                    <SettingsBehavior AllowFocusedRow="True" AllowMultiSelection="False" ProcessSelectionChangedOnServer="True" />
                    <SettingsLoadingPanel ImagePosition="Top" />
                    <StylesEditors>
                        <CalendarHeader Spacing="1px">
                        </CalendarHeader>
                        <ProgressBar Height="25px">
                        </ProgressBar>
                    </StylesEditors>
                    <Columns>
                        <dx:GridViewCommandColumn ShowInCustomizationForm="True" VisibleIndex="0" Width="60px">
                            <CustomButtons>
                                <dx:GridViewCommandColumnCustomButton ID="Modificar" Text="Modificar">
                                </dx:GridViewCommandColumnCustomButton>
                                <dx:GridViewCommandColumnCustomButton ID="Eliminar" Text="Eliminar">
                                </dx:GridViewCommandColumnCustomButton>
                            </CustomButtons>
                        </dx:GridViewCommandColumn>
                        <dx:GridViewDataColumn Caption="cod_cli" FieldName="cod_cli" Name="cod_cli" VisibleIndex="1" Width="100">
                        </dx:GridViewDataColumn>
                        <dx:GridViewDataTextColumn Caption="cedula" FieldName="cedula" Name="cedua" VisibleIndex="2" Width="50" Visible ="true">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="nombre" FieldName="nombre" Name="nombre" VisibleIndex="3" Width="50" Visible ="true">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="telefono" FieldName="telefono" Name="telefono" VisibleIndex="4" Width="50" Visible ="true">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="correo" FieldName="correo" Name="correo" VisibleIndex="5" Width="50" Visible ="true">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="celular" FieldName="celular" Name="celular" VisibleIndex="6" Width="50" Visible ="true">
                        </dx:GridViewDataTextColumn>

                        
                    </Columns>
                </dx:ASPxGridView>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>

            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>




    <dx:ASPxPopupControl ID="pcCliente" runat="server"  AllowDragging="True" Height="128px"
            Width="614px" Modal="True" PopupHorizontalAlign="WindowCenter"
            PopupVerticalAlign="WindowCenter"
            CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua"
           SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css"
            HeaderText="Crear Cliente" Theme="Office2010Blue" > 
            <ContentStyle VerticalAlign="Top">
            </ContentStyle>
            <ContentCollection>
                 <dx:PopupControlContentControl ID="PopupControlContentControl5" runat="server" >
                      <dx:ASPxRoundPanel ID="ASPxRoundPanel" runat="server" Width="605px"
                    CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua"
                    GroupBoxCaptionOffsetY="-28px" HeaderText="Cliente" Height="170px"
                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" Theme="Office2010Blue">
                    <ContentPaddings Padding="14px" />
                     <ContentPaddings Padding="14px"></ContentPaddings>
                        <PanelCollection>
                            <dx:PanelContent ID="PanelContent" runat="server">
          
                                <table>
                                    <tr>
                                        <td colspan="2">
                                            <dx:ASPxLabel ID="lblError1" runat="server" ForeColor="#CC0000">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <dx:ASPxLabel ID="lblCedula" runat="server" Text="Cedula / Pasaporte">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxTextBox ID="txtCedula" runat="server" Width="170px" Theme="Office2010Blue">
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="lblNombre" runat="server" Text="Nombre">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxTextBox ID="txtNombre" runat="server" Width="170px" Theme="Office2010Blue">
                                            </dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <dx:ASPxLabel ID="lblTelefono" runat="server" Text="Telefono">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxTextBox ID="txtTelefono" runat="server" Theme="Office2010Blue" Width="170px">
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="lblCorreo" runat="server" Text="Correo">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxTextBox ID="txtCorreo" runat="server" Theme="Office2010Blue" Width="260px">
                                            </dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="lblCelular" runat="server" Text="Celular">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxTextBox ID="txtCelular" runat="server" Width="170px" Theme="Office2010Blue">
                                            </dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                        <td class="text-right">
                                            <dx:ASPxButton ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" style="height: 21px" Theme="Office2010Blue">
                                            </dx:ASPxButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxLabel ID="lblCodigo" runat="server" Visible="False">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
     

      
                            </dx:PanelContent>
                        </PanelCollection>
                     </dx:ASPxRoundPanel>
                </dx:PopupControlContentControl>
            </ContentCollection>
   </dx:ASPxPopupControl>







</asp:Content>
