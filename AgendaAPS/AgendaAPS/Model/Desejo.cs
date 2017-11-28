using System;
using SQLite.Net.Attributes;

namespace AgendaAPS.ViewModel
{
    public class Desejo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Produto { get; set; }
        public string Categoria { get; set; }
        public string Loja { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}