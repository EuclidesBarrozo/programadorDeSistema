using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      //hoje é uma variável do tipo DateTime que recebe a data de agora
      DateTime hoje = DateTime.Now;
      //verificar o valor da variável hoje
      Console.WriteLine(hoje);
      DateTime nascimento; 
      //Converte de string para DateTime
      DateTime.TryParse("07/22/2005 21:00:00", out nascimento);
      Console.WriteLine(nascimento);
      //subtrai duas datas a data de hoje com a data de nascimento
      //conta em dias
      int dias = Convert.ToInt32(hoje.Subtract(nascimento).Days);
      Console.WriteLine(dias);
      //Calculo para transformar dias em anos
      double anos = Convert.ToDouble(Math.Truncate(dias/365.2425));
      Console.WriteLine(anos);
      if(anos >= 18)
        Console.WriteLine("Maior de idade");
      else
        Console.WriteLine("Menor de idade");
      
      
      
    }
}