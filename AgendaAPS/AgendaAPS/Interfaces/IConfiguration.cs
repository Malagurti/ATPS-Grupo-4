using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace AgendaAPS.Interfaces
{
    public interface IConfiguration
    {
        string DiretorioDataBase { get; }

        ISQLitePlatform Platform{get;}
    }
}
