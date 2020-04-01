using System.Data;
using System.Data.SqlClient;

namespace LojaCL {
    class Class1 {

        private static string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Klaubert\\Desktop\\c#\\Loja2-master\\DbLoja2mdf.mdf;Integrated Security=True;Connect Timeout=30";
        private static SqlConnection con = null;

        public static SqlConnection obterConexao() {
            con = new SqlConnection(str);

            if (con.State == ConnectionState.Open) {
                con.Close();
            }
            try {
                con.Open();
            } catch (SqlException sqle) {
                string message = sqle.Message;
                con = null;

            }
            return con;
        }
        public static void fecharConexao() {

            if (con != null) {
                con.Close();
            }
        }
    }
}
