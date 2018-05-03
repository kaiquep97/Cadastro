using System.IO;
using Cadastro.Droid;
using Cadastro.Interfaces;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace Cadastro.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var caminhoDB = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, "Cadastro.db3");
            return new SQLiteConnection(caminhoDB);
        }
    }
}