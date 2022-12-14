using System;
using System.Linq;

namespace Library
{
    public class AndGate : Gate
    {
        public AndGate (string Name) : base (Name)
        {

        }
        public override bool Calcular()
        {
            if (Entrada.Count != 2)
            {
                throw new NumeroEntradasException ("No tiene 2 entradas");
            }
        bool respuesta = true;
        foreach (var element in Entrada)
        {
            respuesta &= element.Value.Calcular();
        }
        return respuesta;
        }
    } 
}