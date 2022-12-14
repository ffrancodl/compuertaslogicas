using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public abstract class Gate :IInput
    {
        public Gate (string name)
        {
            this.Name = name;
            this.Entrada = new Dictionary <IInput, string>(); 
        }
        public string Name {get; set;}

        public Dictionary <IInput, string> Entrada {get; set;}

        public void AgregarEntrada(string name, IInput valor)
        {
            Entrada.Add(valor, name);
        }
        public abstract bool Calcular();
    }
}