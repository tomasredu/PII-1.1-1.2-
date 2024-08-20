using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejs1_2
{
    public interface IColeccion
    {
        bool estaVacia();
        object? extraer();
        object? primero();
        bool agregar(object obj);
    }
}
