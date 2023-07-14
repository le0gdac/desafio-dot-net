using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string login = TxtLogin.Text;
            string senha = TxtSenha.Text;
            {
                //Verifica se os campos foram preenchidos.
                if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(senha))
                {
                    LblObrigatorio.ForeColor = Color.Red;
                    LblObrigatorio.Text = "O Login e a Senha são obrigatórios";
                    return;
                }
                if (string.IsNullOrEmpty(login))
                {
                    LblObrigatorio.ForeColor = Color.Red;
                    LblObrigatorio.Text = "O Login é obrigatório";
                    return;
                }
                if (string.IsNullOrEmpty (senha))
                {
                    LblObrigatorio.ForeColor = Color.Red;
                    LblObrigatorio.Text = "A Senha é obrigatória";
                    return;
                }

                //Abre o Lançamento de Notas caso os campos obrigatórios tenham sido preenchidos.
                if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
                {
                    FrmNotas janelanotas = new FrmNotas();
                    janelanotas.ShowDialog();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
