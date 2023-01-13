//Faça um programa contendo um objeto ArrayList e que imprime sua
//capacidade (Capacity) e quantidade de elementos (Count) na tela. Em
//seguida, insira um elemento usando o método Add e repita a impressão
//===ARRAYLIST===

using System.Collections;
namespace Main_Collections;

class MainClass
{
    public void Execute()
    {
        ArrayList al = new ArrayList();
        Console.Write("AL.Capacity({0})/AL.Count({1})\n", al.Capacity, al.Count);
        al.Add(1);
        Console.Write("AL.Capacity({0})/AL.Count({1})\n", al.Capacity, al.Count);
    }
}