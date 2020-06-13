using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class Painel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select count(id)
                                  from usuario ";

                Conexao.Conectar();
                string quantidade = Convert.ToString(cmd.ExecuteScalar());

                cmd.CommandText = @"select count(id)
                                   from produtos";

                string quantidadeP = Convert.ToString(cmd.ExecuteScalar());

                cmd.CommandText = @"select nivel 
                                    from usuario
                                    where nivel = 'I'";

                string sta = Convert.ToString(cmd.ExecuteScalar());

               

                lblCadastrados.Text = quantidade;
                lblProdutos.Text = quantidadeP;

    

                lblNome.Text = Session["Nome"].ToString();
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }

       

        }


    }
}