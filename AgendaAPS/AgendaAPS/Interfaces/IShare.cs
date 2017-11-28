using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAPS.Interfaces
{
    public interface IShare
    {
        Task Show(string Title, string Message);
    }
}
