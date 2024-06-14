using GreenPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlus.ViewModels
{
    class ProdutoVM : Utilities.ViewModelBase
    {
        private readonly Produto produto;

        public string Nome
        {
            get { return produto.NomePop; }
            set { produto.NomePop = value; OnPropertyChanged(); }
        }

        public string NomeC
        {
            get { return produto.NomeCien; }
            set { produto.NomeCien = value; OnPropertyChanged(); }  
        }

        public string Catego
        {
            get { return produto.Categoria; }
            set { produto.Categoria = value; OnPropertyChanged(); }
        }

        public string Class
        {
            get { return produto.Classificacao; }
            set { produto.Classificacao = value; OnPropertyChanged(); }
        }

        public int Tempo
        {
            get { return produto.TempoEstimado; }
            set { produto.TempoEstimado = value; OnPropertyChanged(); }
        }

        public int Temperatura
        {
            get { return produto.Temperatura; }
            set { produto.Temperatura = value; OnPropertyChanged(); }
        }

        public string solo
        {
            get { return produto.Solo; }
            set { produto.Solo = value; OnPropertyChanged(); }
        }

        public int Irrigar
        {
            get { return produto.Irrigação; }
            set { produto.Irrigação = value; OnPropertyChanged(); }
        }

        public ProdutoVM()
        {
            produto = new Produto();
            Nome = " ";
            NomeC = " ";
            Catego = " ";
            Class = " ";
            Tempo = 0;
            Temperatura = 0;
            solo = " ";
            Irrigar = 0;
        }
    }
}
