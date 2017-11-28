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
using System.Threading.Tasks;
using AgendaAPS.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(AgendaAPS.Droid.Share))]
namespace AgendaAPS.Droid
{
    public class Share: IShare
    {
        private readonly Context _context;

        public Share()
        {
            _context = Application.Context;
        }

        public Task Show(string title, string message)
        {
            var contentType = "text/plain";
            var intent = new Intent(Intent.ActionSend);

            intent.SetType(contentType);
            intent.PutExtra(Intent.ExtraText, message ?? string.Empty);
            intent.PutExtra(Intent.ExtraSubject, title ?? string.Empty);

            var chooserIntent = Intent.CreateChooser(intent, title ?? string.Empty);
            chooserIntent.SetFlags(ActivityFlags.ClearTop);
            chooserIntent.SetFlags(ActivityFlags.NewTask);
            _context.StartActivity(chooserIntent);

            return Task.FromResult(true);

        }
    }
}