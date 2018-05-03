using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cadastro.ViewModels
{
    public class CadastroViewModel
    {

        #region Variaveis
        private Cadastro.Models.Cadastro cadastro;

        public string Nome
        {
            get { return cadastro.Nome; }
            set { cadastro.Nome = value; }
        }
        public string Telefone
        {
            get { return cadastro.Telefone; }
            set { cadastro.Telefone = value; }
        }
        public string Email
        {
            get { return cadastro.Email; }
            set { cadastro.Email = value; }
        }
        public string CPF
        {
            get { return cadastro.CPF; }
            set { cadastro.CPF = value; }
        }
        public string RG
        {
            get { return cadastro.RG; }
            set { cadastro.RG = value; }
        }
        public string Regiao
        {
            get { return cadastro.Regiao; }
            set { cadastro.Regiao = value; }
        }
        public string Renda
        {
            get { return cadastro.Renda; }
            set { cadastro.Renda = value; }
        }
        public string RendaFamiliar
        {
            get { return cadastro.RendaFamiliar; }
            set { cadastro.RendaFamiliar = value; }
        }

        public ICommand OkCommand { get; set; }

        #endregion

        public CadastroViewModel()
        {
            cadastro = new Models.Cadastro();

            OkCommand = new Command(()=> {
                if (ValidaCampos()) {
                    using (var dao = new DAO.CadastroDAO())
                    {
                        dao.Insert(this.cadastro);
                    }
                    MessagingCenter.Send<string>("", "OkButton");
                }
            });
        }

        private bool ValidaCampos()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                MessagingCenter.Send<string>("Nome deve ser preenchido.", "Mensagem");
                return false;
            }
            if(Telefone.Trim().Replace(" ","").Length < 10)
            {
                MessagingCenter.Send<string>("O numero precisa conter DDD+Numero", "Mensagem");
                return false;
            }

            return true;
        }
    }
}
