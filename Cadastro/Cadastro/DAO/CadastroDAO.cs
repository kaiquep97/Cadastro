using System;
using System.Collections.Generic;
using Cadastro.Interfaces;
using SQLite;
using Xamarin.Forms;

namespace Cadastro.DAO
{
    public class CadastroDAO:IDisposable
    {
        private SQLiteConnection connection;

        public CadastroDAO()
        {
            this.connection = DependencyService.Get<ISQLite>().GetConnection();
            this.connection.CreateTable<Models.Cadastro>();
        }
        public void Dispose()
        {
            this.connection.Dispose();
        }

        public void Insert(Models.Cadastro cadastro)
        {
            this.connection.Insert(cadastro);
        }
        public IList<Models.Cadastro> GetCadastros()
        {
            return this.connection.Table<Models.Cadastro>().ToList();
        }
    }
}
