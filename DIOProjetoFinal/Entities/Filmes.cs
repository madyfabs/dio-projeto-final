using DIOProjetoFinal.Enums;
using System;

namespace DIOProjetoFinal.Entities
{
    public class Filmes : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Filmes(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string dados = "";

            dados += "Gênero: " + this.Genero + Environment.NewLine;
            dados += "Título: " + this.Titulo + Environment.NewLine;
            dados += "Descrição: " + this.Descricao + Environment.NewLine;
            dados += "Ano de Início: " + this.Ano + Environment.NewLine;
            dados += "Disponível: " + this.Excluido;

            return dados;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

    }
}
