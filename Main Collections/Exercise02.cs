//Faça um programa que leia 5 números inteiros, os adicione em um
//ArrayList e calcule a média deles. Em seguida, mostre na tela aqueles
//que forem maiores que a média. Seu programa terá duas estruturas
//de repetição sendo a primeira, um for; e a segunda, um foreach


using System.Collections;
namespace Main_Collections;

class MediaNumeros
{
    public void Execute()
    {
        ArrayList al = new ArrayList();
        double media = 0;
        for (int i = 0; i < 5; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            al.Add(valor);
            media += valor;
        }

        media /= 5;
        foreach (object o in al)
        {
            if ((int)o > media)
            {
                Console.WriteLine(o);

            }
        }
    }
}