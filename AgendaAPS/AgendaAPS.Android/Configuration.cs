using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AgendaAPS.Interfaces;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency(typeof(AgendaAPS.Droid.Configuration))]

namespace AgendaAPS.Droid
{
    public class Configuration: IConfiguration
    {
        public Configuration() { }

        private string _diretorioDataBase;
        public string DiretorioDataBase
        {
            get
            {
                if (String.IsNullOrEmpty(_diretorioDataBase))
                {
                    _diretorioDataBase = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return _diretorioDataBase;
            }


        

        }
        private ISQLitePlatform _platform;

        public ISQLitePlatform Platform
        {
            get
            {
                if (_platform == null)
                {
                    _platform = new SQLitePlatformAndroid();
                }
                return _platform;

            }
        }
        
    }
}