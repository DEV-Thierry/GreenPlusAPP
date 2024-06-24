using GreenPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlus.ViewModels
{
    class UsuarioVM : Utilities.ViewModelBase
    {
        private readonly Usuario user;

        public string Tipo
        {
            get { return user.tipo; }
            set { user.tipo = value; OnPropertyChanged(); }
        }

        public string Nome
        {
            get { return user.nome; }
            set { user.nome = value; OnPropertyChanged(); }
        }

        public string CPF
        {
            get { return user.cpf; }
            set { user.cpf = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get { return user.email; }
            set { user.email = value; OnPropertyChanged(); }
        }

        public string Contato
        {
            get { return user.contato; }
            set { user.contato = value; OnPropertyChanged(); }
        }

        public string Grupos
        {
            get { return user.grupos; }
            set { user.grupos = value; OnPropertyChanged(); }
        }

        public string Login
        {
            get { return user.login; }
            set { user.login = value; OnPropertyChanged(); }
        }

        public string Senha
        {
            get { return user.senha; }
            set { user.senha = value; OnPropertyChanged(); }
        }

        public UsuarioVM()
        {
            user = new Usuario();
            Tipo = "";
            Nome = "";
            CPF = "";
            Email = "";
            Contato = "";
            Grupos = "";
            Login = "";
            Senha = "";
        }
    }
}
