using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Classes
{
    public class ComparaFilmes : IComparaFilmes
    {
        public Filme Vencedor(Filme f1, Filme f2)
        {
            if (f1.Nota > f2.Nota)
                return f1;

            else if (f2.Nota > f1.Nota)
                return f2;
            else
            {
                var Resultado = new List<Filme>();
                Resultado.Add(f1);
                Resultado.Add(f2);

                return Resultado.OrderBy(x => x.Titulo).FirstOrDefault();
            }

        }
    }
}
