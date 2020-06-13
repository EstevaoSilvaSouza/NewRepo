using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                cmd.Connection = Conexao.Connection;

                cmd.CommandText = @"select senha
                                  from usuario
                                  where login = @login";

                cmd.Parameters.AddWithValue("login", usuario);
                Conexao.Conectar();

                string senhaEncriptada = Convert.ToString(cmd.ExecuteScalar());

                if (string.IsNullOrEmpty(senhaEncriptada))
                {
                    throw new Exception("Usuario ou senha Inválido");

                }

                if(BCrypt.Net.BCrypt.Verify (senha, senhaEncriptada))
                {
                    cmd.CommandText = @"select nivel , nome
                                      from usuario
                                      where login = @usuario";

                    cmd.Parameters.AddWithValue("usuario", usuario);
                    string nivel = Convert.ToString(cmd.ExecuteScalar());

                    cmd.CommandText = @"select nome
                                      from usuario
                                      where login = @usuario";

                    string nome = Convert.ToString(cmd.ExecuteScalar());

                    // gravar session
                    Session["Perfil"] = nivel;
                    Session["Nome"] = nome;

                    FormsAuthentication.RedirectFromLoginPage(nivel, false);
                    

                }
                else
                {
                    throw new Exception("Uusario ou senha Invalido");

                }


            }
            catch(Exception ex)
            {
                lblErro.Text = ex.Message;

            }
            finally
            {
                Conexao.Desconectar();
            }
            



        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }
    }
}