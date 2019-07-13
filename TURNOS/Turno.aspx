<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Turno.aspx.cs" Inherits="TURNOS.Turno" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style10 {
            height: 29px;
        }
    </style>
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
                <dx:ASPxGridView ID="gvTurno" runat="server" AutoGenerateColumns="False" EnableCallBacks="False" EnableTheming="True" KeyFieldName="Turno" OnCustomButtonCallback="gvCliente_CustomButtonCallback" Theme="Office2010Blue" Width="98%">
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
                        <dx:GridViewDataColumn Caption="id" FieldName="id" Name="id" VisibleIndex="1" Width="100">
                        </dx:GridViewDataColumn>
                        <dx:GridViewDataTextColumn Caption="modulo" FieldName="modulo" Name="modulo" VisibleIndex="2" Width="50" Visible ="true">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="nombre" FieldName="nombre" Name="nombre" VisibleIndex="3" Width="50" Visible ="true">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="fecha" FieldName="fecha" Name="fecha" VisibleIndex="4" Width="50" Visible ="true">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="estado" FieldName="estado" Name="estado" VisibleIndex="5" Width="50" Visible ="true">
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




    <dx:ASPxPopupControl ID="pcTurno" runat="server"  AllowDragging="True" Height="128px"
            Width="614px" Modal="True" PopupHorizontalAlign="WindowCenter"
            PopupVerticalAlign="WindowCenter"
            CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua"
           SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css"
            HeaderText="Crear Turno" Theme="Office2010Blue" > 
            <ContentStyle VerticalAlign="Top">
            </ContentStyle>
            <ContentCollection>
                 <dx:PopupControlContentControl ID="PopupControlContentControl5" runat="server" >
                      <dx:ASPxRoundPanel ID="ASPxRoundPanel" runat="server" Width="605px"
                    CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua"
                    GroupBoxCaptionOffsetY="-28px" HeaderText="Turno" Height="170px"
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
                                            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Modulo">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxComboBox ID="cmbModulo" runat="server" DropDownStyle="DropDown" Height="16px" ShowShadow="False" TextFormatString="{0} ({1})" Theme="Office2010Blue" ValueField="Criterio" Width="183px">
                                                <Columns>
                                                    <dx:ListBoxColumn Caption="Criterio" FieldName="Criterio" Name="Criterio" Width="60px">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn Caption="Descripcion" FieldName="Descripcion" Name="Descripcion">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                                <ValidationSettings>
                                                    <ErrorFrameStyle ImageSpacing="4px">
                                                        <ErrorTextPaddings PaddingLeft="4px" />
                                                    </ErrorFrameStyle>
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="lblContraseña" runat="server" Text="Nombre">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxComboBox ID="cmbNombre" runat="server" DropDownStyle="DropDown" Height="16px" ShowShadow="False" TextFormatString="{0} ({1})" Theme="Office2010Blue" ValueField="Criterio" Width="277px">
                                                <Columns>
                                                    <dx:ListBoxColumn Caption="Criterio" FieldName="Criterio" Name="Criterio" Width="60px">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn Caption="Descripcion" FieldName="Descripcion" Name="Descripcion">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                                <ValidationSettings>
                                                    <ErrorFrameStyle ImageSpacing="4px">
                                                        <ErrorTextPaddings PaddingLeft="4px" />
                                                    </ErrorFrameStyle>
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Fecha">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxDateEdit ID="dateFecha" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                                                DisplayFormatString="yyyy/MM/dd" EditFormat="Custom" Height="16px" ShowShadow="False" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                Theme="Office2010Blue" Width="117px">
                                                <CalendarProperties>
                                                    <HeaderStyle Spacing="1px" />
                                                    <FooterStyle Spacing="17px" />
                                                </CalendarProperties>
                                                <DropDownButton>
                                                    <Image>
                                                        <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                    </Image>
                                                </DropDownButton>
                                                <ValidationSettings>
                                                    <ErrorFrameStyle ImageSpacing="4px">
                                                        <ErrorTextPaddings PaddingLeft="4px" />
                                                    </ErrorFrameStyle>
                                                </ValidationSettings>
                                            </dx:ASPxDateEdit>

                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Estado">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td>
                                             <dx:ASPxComboBox ID="cmbEstado" runat="server" DropDownStyle="DropDown" Height="16px" ShowShadow="False" TextFormatString="{0} ({1})" 
                                                Theme="Office2010Blue" ValueField="Criterio" Width="126px">
                                                <Columns>
                                                    <dx:ListBoxColumn Caption="Criterio" FieldName="Criterio" Name="Criterio" Width="60px">
                                                    </dx:ListBoxColumn>
                                                    <dx:ListBoxColumn Caption="Descripcion" FieldName="Descripcion" Name="Descripcion">
                                                    </dx:ListBoxColumn>
                                                </Columns>
                                                <ValidationSettings>
                                                    <ErrorFrameStyle ImageSpacing="4px">
                                                        <ErrorTextPaddings PaddingLeft="4px" />
                                                    </ErrorFrameStyle>
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
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
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style10">
                                        </td>
                                        <td class="auto-style10">
                                        </td>
                                        <td class="auto-style10">
                                        </td>
                                        <td class="auto-style10">
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
