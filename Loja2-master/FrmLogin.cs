using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LojaCL {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e) {

        }

        private void BtnSair_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void BtnLogar_Click(object sender, EventArgs e) {
            SqlConnection con = Class1.obterConexao();
            string usu = " select login,senha from usuario where login=@login and senha=@senha";
            SqlCommand cmd = new SqlCommand(usu, con);
            cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = txtLogin.Text.Trim();
            cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = txtSenha.Text.Trim();
            Class1.obterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataReader usuario = cmd.ExecuteReader();
            if (usuario.HasRows) {
                this.Hide();
                FrmPrincipal pri = new FrmPrincipal();
                pri.Show();
                Class1.fecharConexao();
            } else {
                MessageBox.Show("Login ou Senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                Class1.fecharConexao();
            }
        }
    }
}
