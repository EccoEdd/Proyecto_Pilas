using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pilas
{
    class Pila
    {
        private char[] Elementos { get; set; }
        private string Posfija { get; set; }
        private int Top { get; set; }

        public Pila()
        {
            Elementos = new char[20];
            Top = 0;
            Posfija = "";
            Console.WriteLine("Escriba su Expresion");
        }

        public string ConversionInToPos(string expresion)
        {
            for (int i = 0; i < expresion.Length; ++i)
            {
                char c = expresion[i];

                if (char.IsLetterOrDigit(c))
                    Posfija += c;

                else if (c == '(')
                    Push(c);
                
                else if (c == ')')
                {
                    while (Top > 0 && Elementos[Top] != '(')
                    {
                        Posfija += Pop();
                        Top--;
                    }

                    if (Top > 0 && Elementos[Top] == ')')
                        return "No valido";
                    else
                        Top--;
                }
                else
                {
                    while (Top > 0 && Jerarquia(c) <= Jerarquia(Elementos[Top]))
                    {
                        Posfija += Pop();
                        Top--;
                    }

                    Push(c);
                }
            }
            while (Top > 0)
            {
                Posfija += Pop();
                Top--;
            }
            return Posfija;
        }

        private void Push(char elemento)
        {
            if (Top < Elementos.Length)
            {
                Top++;
                Elementos[Top] = elemento;
            }
            else
                Console.WriteLine("Espacio Insuficiente");
        }

        private char Pop()
        {
            return Elementos[Top];
        }

        internal static int Jerarquia(char ch)
        {
            switch (ch)
            {
                case '+':case '-':  return 1;
                case '*':case '/':  return 2;
                case '^':           return 3;
            }
            return -1;
        }

    }
}
