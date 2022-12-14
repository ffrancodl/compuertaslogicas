using System;
using System.Collections.Generic;

namespace Library
{
    public class LogicInput :IInput
    {
        public LogicInput (bool valor)
        {
            this.Valor = valor;
        }
        public bool Valor {get; set;}
        public bool Calcular()
        {
            return Valor;
        }
    }
}