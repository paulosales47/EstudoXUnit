using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoXUnit
{
    public class Calculadora
    {
        public int Soma(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
        
        public int Subtracao(int arg1, int arg2)
        {
            return arg1 - arg2;
        }

        public int Divisao(int arg1, int arg2)
        {
            return arg1 / arg2;
        }

        public int Mutiplicacao(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

    }
}
