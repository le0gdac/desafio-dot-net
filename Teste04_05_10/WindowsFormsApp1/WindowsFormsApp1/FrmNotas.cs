using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=LEONARDO; integrated security=SSPI; initial catalog=INFO_ALUNOS");
        SqlCommand comando = new SqlCommand();
        SqlDataReader reader;

        private void LblNomeAluno_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNomeAluno_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos foram preenchidos e entrega a respectiva mensagem.
            if (string.IsNullOrEmpty(TxtNomeAluno.Text))
            {
                LblNomeObrigatorio.ForeColor = Color.Red;
                LblNomeObrigatorio.Text = "O Nome é obrigatório.";
                LblNomeObrigatorio.Visible = true;
                LblSituacao.ForeColor = Color.Gray;
                LblSituacao.Text = "Nota não enviada";
            }
            else
            {
                LblNomeObrigatorio.Visible = false;
            }

            if (string.IsNullOrEmpty(TxtNotaUm.Text))
            {
                LblNotaUmObrigatoria.ForeColor = Color.Red;
                LblNotaUmObrigatoria.Text = "A Nota é obrigatória.";
                LblNotaUmObrigatoria.Visible = true;
                LblSituacao.ForeColor = Color.Gray;
                LblSituacao.Text = "Nota não enviada";
            }
            else
            {
                LblNotaUmObrigatoria.Visible = false;
            }

            if (string.IsNullOrEmpty(TxtNotaDois.Text))
            {
                LblNotaDoisObrigatoria.ForeColor = Color.Red;
                LblNotaDoisObrigatoria.Text = "A Nota é obrigatória.";
                LblNotaDoisObrigatoria.Visible = true;
                LblSituacao.ForeColor = Color.Gray;
                LblSituacao.Text = "Nota não enviada";
            }
            else
            {
                LblNotaDoisObrigatoria.Visible = false;
            }


            //Extrai os valores e converte para números e exibe a situação do Aluno.
            double notaUm, notaDois, media;
            if (double.TryParse(TxtNotaUm.Text, out notaUm) && double.TryParse(TxtNotaDois.Text, out notaDois))
            {
                media = (notaUm + notaDois) / 2;
                if (media >= 6.5)
                {
                    LblSituacao.ForeColor = Color.Green;
                    LblSituacao.Text = "Aprovado";
                }
                else
                {
                    LblSituacao.ForeColor = Color.Red;
                    LblSituacao.Text = "Reprovado!";
                }
            }

            try
            {
                conexao.Open();
                string strSQL = "insert into ALUNOS (NOME, NOTA_SEMESTRE_1, NOTA_SEMESTRE_2) VALUES (@nome, @notasemestre1, @notasemestre2)";
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = TxtNomeAluno.Text;
                comando.Parameters.Add("@notasemestre1", SqlDbType.Decimal).Value = decimal.Parse(TxtNotaUm.Text.Replace(".", ","));
                comando.Parameters.Add("@notasemestre2", SqlDbType.Decimal).Value = decimal.Parse(TxtNotaDois.Text.Replace(".", ","));

                comando.Connection = conexao;
                comando.CommandText = strSQL;

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrados com Sucesso!", "Dados Cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa os campos
                TxtNomeAluno.Text = string.Empty;
                TxtNotaUm.Text = string.Empty;
                TxtNotaDois.Text = string.Empty;
                LblNomeObrigatorio.Visible = false;
                LblNotaUmObrigatoria.Visible = false;
                LblNotaDoisObrigatoria.Visible = false;
                LblSituacao.Text = string.Empty;

                comando.Parameters.Clear(); //Limpa os parametros
                conexao.Close(); //Fecha conexão

            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                conexao.Close(); //Fecha conexão
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa os campos
            TxtNomeAluno.Text = string.Empty;
            TxtNotaUm.Text = string.Empty;
            TxtNotaDois.Text = string.Empty;
            LblNomeObrigatorio.Visible = false;
            LblNotaUmObrigatoria.Visible = false;
            LblNotaDoisObrigatoria.Visible = false;
            LblSituacao.Text = string.Empty;
        }

        private void TxtNotaUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNotaUm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de escrever letras no campo das nota 1
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void TxtNotaDois_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de escrever letras no campo das nota 2
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
