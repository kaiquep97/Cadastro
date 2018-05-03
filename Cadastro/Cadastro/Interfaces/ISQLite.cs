using SQLite;

namespace Cadastro.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
