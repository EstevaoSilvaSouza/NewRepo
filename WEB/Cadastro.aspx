<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WEB.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Cadastro Painel</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-wrapper animsition">
        <div class="page-content--bge1">
            <div class="container">
                <div class="login-wrap">
                    <div class="login-content">
                        <div class="login-logo">
                            <a href="#">
                                <img src="images/icon/logo.png" alt="CoolAdmin">
                            </a>
                        </div>
                        <div class="login-form">
                            <div class="form-group">
                                <label>Usuario</label>
                                <asp:RequiredFieldValidator ID="rfdLogin" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtLogin"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtLogin" runat="server" Text="Usuario" placeholder="Usuario" CssClass="au-input au-input--full"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Nome</label>
                                <asp:RequiredFieldValidator ID="rfdNome" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtNome" runat="server" Text="Nome" CssClass="au-input au-input--full" placeholder="Nome"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Senha</label>
                                <asp:RequiredFieldValidator ID="rfdSenha" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtSenha"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtSenha" runat="server" CssClass="au-input au-input--full" placeholder="Senha" TextMode="Password"></asp:TextBox>
                            </div>
                            <br />
                            <label>Nivel:</label>
                            <asp:RequiredFieldValidator ID="rfdNivel" ControlToValidate="ddNivel" ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                            <asp:DropDownList ID="ddNivel" runat="server" CssClass="form-control">
                                <asp:ListItem Selected="True" Value=""></asp:ListItem>
                                <asp:ListItem Value="A">Administrador</asp:ListItem>
                                <asp:ListItem Value="O">Operador</asp:ListItem>
                            </asp:DropDownList>
                         

                                <asp:Label ID="lblSucesso" CssClass="badge badge-pill badge-success" runat="server" Text=""></asp:Label>
                            <br />
                            <asp:Button ID="btnCadastrar" runat="server" CssClass="au-btn au-btn--block au-btn--green m-b-20" Text="Cadastrar-se" OnClick="btnCadastrar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
