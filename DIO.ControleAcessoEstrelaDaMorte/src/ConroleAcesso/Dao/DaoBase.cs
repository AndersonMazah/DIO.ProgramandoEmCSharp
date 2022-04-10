
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ConroleAcesso.Dao
{
    public abstract class DaoBase: IDisposable
    {
        protected readonly SqlConnection con;

        protected DaoBase()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-053T257V\SQLEXPRESS;Initial Catalog=EstrelaDaMorte;Integrated Security=True;Connect Timeout=30");
        }

        protected async Task Insert(string comando)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            await cmd.ExecuteNonQueryAsync();
            con.Close();
        }

        protected async Task Select(string comando, Action<SqlDataReader> tratamentoLeitura)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            SqlDataReader dr = await cmd.ExecuteReaderAsync();
            tratamentoLeitura(dr);
            con.Close();
        }

        public void Dispose()
        {
            con?.Close();
            con?.Dispose();
        }
    }
}
