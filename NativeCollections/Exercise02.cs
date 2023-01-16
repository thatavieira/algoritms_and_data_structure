using System;
using System.Collections;

namespace Main_Collections;

class ExerciciResolvido03ComString
{
    public static void Mostrar(ArrayList al)
    {
        Console.Writeline("Mostrar Arraylist: ");
        foreach (object o in al)
        {
            Console.Writeline(o);
        }
    }

    public static void Mostrar(Object[] vetor)
    {
        Console.WriteLine("Mostrar Object[]: ");
        foreach (object o in vetor)
        {
            Console.WriteLine(o);
        }
    }
    
    public static void Main (string[] args)
    {
        ArrayList al = new ArrayList();
        string palavra = "";

        Console.WriteLine("====INSERÇÃO====");
        for (int i = 0; i < 5; i++)
        {
            int num = Math.Abs((new Random().Next()) % 100;
            palavra = ("Palavra" + num);
            al.Add(palavra);
        }

        al.Insert(5, "João");

        Mostrar(al);

        Console.WriteLine("====MOSTRAR ELEMENTOS====");
        Console.WriteLine("ArrayList[0]: " + al[0]);
        Console.WriteLine("ArrayList[1]: " + al[1]);
        Console.WriteLine("ArrayList[2]: " + al[2]);
        Console.WriteLine("ArrayList[3]: " + al[3]);

        Console.WriteLine("====REMOÇÃO====");
        al.Remover("João");
        al.Remover(1);
        al.RemoveRange(0, 2);
        Mostrar(al);

        Console.WriteLine("====CLEAR====");
        al.Clear();
        Console.WriteLine("Capacity({0}) / Count({1})", al.Capacity, al.Count);

        Console.WriteLine("====CONTAINS====");
        for (int i = 0; i < 20; i++)
        {
            
        }
    
    {
            
        }
    }
    
}