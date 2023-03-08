using System.Runtime.CompilerServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //Faça um programa que insira um caractere informado, antes de cada consoante de uma string.

        char a;
        string frasealt;


        Console.WriteLine("Insira um caractere: ");
        a = char.Parse(Console.ReadLine());
        Console.WriteLine("Digite uma texto: ");
        string frase = Console.ReadLine();
        char[] frasefinal = InserirCaractere(frase, a);

        Console.WriteLine(frasefinal);

        char[] InserirCaractere(string frasealt, char caract)
        {
            frasealt.ToLower();
            int cont = 0;
            char[] fraseaux = new char[frasealt.Length*2];
            for(int i = 0; i < frasealt.Length; i++)
            {
                if ((frasealt[i] != 'a') && (frasealt[i] != 'e') && (frasealt[i] != 'i') && (frasealt[i] != 'o') && (frasealt[i] != 'u'))
                {
                    fraseaux[cont + 1] = frasealt[i];
                    fraseaux[cont] = caract;
                    cont += 2;
                }
                else
                {
                    fraseaux[cont] = frasealt[i];
                    cont++;
                }
            }
            return fraseaux;
        }
        

    }
}
