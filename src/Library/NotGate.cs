using System;
using System.Linq;

namespace Library
{
    public class NotGate : Gate
    {
        public NotGate (string Name) : base (Name)
        {

        }
        public override bool Calcular()
        {
            if (Entrada.Count != 1)
            {
                throw new NumeroEntradasException ("No tiene 1 entrada");
            }
            return !Entrada.First().Value.Calcular();
        }
        
    } 
}