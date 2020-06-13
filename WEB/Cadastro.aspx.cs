using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            var senhaEncriptada = BCrypt.Net.BCrypt.HashPassword(txtSenha.Text);
            

            try
            {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"insert into usuario (nome,login,senha,nivel) 
                                        values
                                    (@nome, @login, @senha,@nivel )";

                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("login", txtLogin.Text);
                cmd.Parameters.AddWithValue("senha", senhaEncriptada);
                cmd.Parameters.AddWithValue("nivel", ddNivel.Text);

                Conexao.Conectar();
                cmd.ExecuteNonQuery();
                Response.Redirect("Default.aspx");

            }
            catch (Exception ex)
            {
                lblSucesso.Text = "Falha" + ex.Message;

            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}