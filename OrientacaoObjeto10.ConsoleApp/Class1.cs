using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto10.ConsoleApp
{
    internal class Aluno
    {
        public double n1, n2, p1, p2;
        public double Media()
        {
            double ValorMedia = (n1 * p1 + n2 * p2) / (p1 + p2);
            return ValorMedia;
        }
    }
}
