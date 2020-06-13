<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-wrapper animsition">
        <div class="page-content--bge5">
            <div class="container">
                <div class="login-wrap">
                    <div class="login-content">
                        <div class="login-logo">
                            <a href="#">
                                <img src="images/icon/logo.png" alt="PagLogin">
                            </a>
                        </div>
                        <div class="login-form">
                            <div class="form-group">
                                <label>Usuario</label>
                                <asp:TextBox ID="txtUsuario" runat="server" CssClass="au-input au-input--full" placeholder="Usuario" autofocus=""></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Senha</label>

                                <asp:TextBox ID="txtSenha" runat="server" CssClass="au-input au-input--full" placeholder="Senha" TextMode="Password"></asp:TextBox>
                            </div>
                            <asp:Label ID="lblErro" runat="server" Text="" CssClass="text text-center"></asp:Label>
                            <asp:Button ID="btnEntrar" CssClass="au-btn au-btn--block au-btn--green m-b-20" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
                            <div class="social-login-content">
                                <div class="social-button">
                                    <asp:Button  ID="BtnCadastro" runat="server" CssClass="au-btn au-btn--block au-btn--blue m-b-20" Text="Cadastre-se" OnClick="BtnCadastro_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
