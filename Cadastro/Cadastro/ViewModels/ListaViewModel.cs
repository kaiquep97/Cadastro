using Cadastro.DAO;
using Cadastro.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Cadastro.ViewModels
{
    public class ListaViewModel
    {
        public ObservableCollection<Models.Cadastro> Cadastros { get; set; }

        public ListaViewModel()
        {
            using (var dao = new CadastroDAO())
            {
                var cad = dao.GetCadastros();

                Cadastros = new ObservableCollection<Models.Cadastro>();

                foreach(var item in cad)
                {
                    Cadastros.Add(item);
                }
            }
        }

        public bool GeraRelatorio()
        {
            try
            {
                var cad = GetCadastros();

                StringBuilder sb = new StringBuilder();
                sb.Append("NOME;TELEFONE;EMAIL;CPF;RG;REGIÃO;RENDA;COMPOSICAO RENDA FAMILIAR\n");

                foreach (var item in cad)
                {
                    sb.Append($"{item.ToString()}\n");
                }

                return DependencyService.Get<IFile>().SaveFile(sb.ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }

        private IList<Models.Cadastro> GetCadastros()
        {
            using (var dao = new CadastroDAO())
            {
                return dao.GetCadastros();
            }
        }
    }
}
