using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using AgendaAPS.Interfaces;
using AgendaAPS.ViewModel;
using System.Linq;

namespace AgendaAPS.Model
{
    public class ConexaoSqlite : IDisposable
    {
        private SQLiteConnection _conexao;

        public void Conexao()
        {
            var config = DependencyService.Get<IConfiguration>();
            _conexao = new SQLiteConnection(config.Platform, System.IO.Path.Combine(config.DiretorioDataBase, "Desejos.db"));
            _conexao.CreateTable<Desejo>();
        }
        public void Add (Desejo desejo)
        {
            _conexao.Insert(desejo);
        }

        public void Update(Desejo desejo)
        {
            _conexao.Update(desejo); 
        }
        public void Delete(Desejo desejo)
        {
            _conexao.Delete(desejo);
        }
        public Desejo GetId(int id)
        {
            return _conexao.Table<Desejo>().FirstOrDefault(Xamarin => Xamarin.Id == id);
        }
        
        public IEnumerable<Desejo> GetAll()
        {
            return _conexao.Table<Desejo>();
        }
        public void Dispose()
        {
            _conexao.Dispose();
        }
    }
}
