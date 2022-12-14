using System;
using System.Collections.Generic;
using Library;

public class Program
{
    public static void Main(string[]args)
    {

        LogicInput l1 = new LogicInput(false);
        LogicInput l2 = new LogicInput(true);
        AndGate and = new AndGate("And");
        OrGate or = new OrGate("Or");
        NotGate not = new NotGate("Not");
        and.AgregarEntrada("A", l1);
        and.AgregarEntrada("B", l2);
        or.AgregarEntrada("A", l1);
        or.AgregarEntrada("B", and);
        not.AgregarEntrada("A", or);
        Console.WriteLine(or.Calcular());
    }
}