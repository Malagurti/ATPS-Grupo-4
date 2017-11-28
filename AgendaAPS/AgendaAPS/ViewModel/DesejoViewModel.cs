using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using AgendaAPS.Model;
using AgendaAPS.Interfaces;

namespace AgendaAPS.ViewModel
{
    public class DesejoViewModel: BaseViewModel
    {
        private ConexaoSqlite _conexao;

        public IEnumerable<Desejo> Desejo { get { return _desejo; } set { SetProperty(ref _desejo, value); } } 

        public IEnumerable<Desejo> _desejo { get; set; }

        //public Desejo _desejo { get; set; }

        public Desejo desejo{ get { return _desejo; } set { SetProperty(ref _desejo, value); } } 

        public Command ButtonCommand { get; set; }

        public Command Share { get; set; }

        public int Id { get; set; }
        private int _codigo;

        public void IniciaDados()
        {
            Desejo = _conexao.GetAll();
            Desejo = new Desejo();
            Desejo.Data = DateTime.Now;
        }

        public int codigo
        {
            get { return _codigo; }
            set { SetProperty(ref _codigo, value); }
        }
        private string _produto;

        public string Produto
        {
            get { return _produto; }
            set { SetProperty(ref _produto, value); }
        }

        private string _categoria;

        public string Categoria
        {
            get { return _categoria; }
            set { SetProperty(ref _produto, value); }
        }

        private string _loja;

        public string Loja
        {
            get { return _loja; }
            set { SetProperty(ref _loja, value); }
        }

        private double _preco;

        public double  Preco
        {
            get { return _preco; }
            set { SetProperty(ref _preco, value); }
        }
        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { SetProperty(ref _descricao, value); }
        }

        public DesejoViewModel()
        {
            _conexao = new ConexaoSqlite();
            IniciaDados();
            ButtonCommand = new Command(ExecuteButton, CanExecuteButton);
            Share = new Command(ShareCommand);
        }
        void ShareCommand()
        {
            var share = DependencyService.Get<IShare>();
            var texto = String.Format("Descrição: {0}, Preço: {1}, Produto: {2}, Loja: {3} ", Desejo.Descricao, Desejo.Preco, Desejo.Produto, Desejo.Loja);
            share.Show("Deseja Realmente Compartilhar seu desejo?", texto);
        }
    }
}