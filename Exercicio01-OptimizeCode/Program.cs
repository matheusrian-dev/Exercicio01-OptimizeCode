using System;
using System.Collections.Generic;
using System.Linq;

public class Teste
{
    // Main Method
    static public void Main(String[] args)
    {
        Dictionary<char, int> result = new Dictionary<char, int>();
        result = (Dictionary<char, int>) Exercise.GetCharacterCount("John Doe");
        result.ToList().ForEach(x => Console.WriteLine("'" + x.Key + "': " + x.Value));
    }
}

public class Exercise
{
    // TODO: fix this method - remove boxing & unboxing, and return correct result
    public static object GetCharacterCount(string name)
    {
        string n = name.Replace(" ", string.Empty); //remove espaços entre palavras
        Dictionary<char, int> result = new Dictionary<char, int>();
        for (int i = 0; i < n.Length; i++)
        {
            var c = Char.ToLower(n[i]); 
            if (result.ContainsKey(c)) 
            {
                result[c] += 1; //caso o caractere já esteja no Dictionary, soma 1 ao contador da mesma
            }
            else
            {
                result[c] = 1; //caso não encontre, adiciona o caractere e inicia o contador
            }
        }
        return result;
    }
}

