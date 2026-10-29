using System;

					
public class Program
{
	public static void Main()
	{
		String nome;
		Double altura;
		Double peso;
		Double imc;
		
		Console.WriteLine("Insira seu Nome");
		nome = Console.ReadLine();
		Console.WriteLine("Insira sua Altura");
		altura = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Insira seu Peso");
		peso = Convert.ToDouble(Console.ReadLine());
		
		imc = peso / (altura * altura);
		
		Console.WriteLine("Olá " + nome);
		Console.WriteLine("Sua altura é: " + altura);
		Console.WriteLine("Seu peso é: " + peso);
		Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));
		if ( imc < 18.5){
			Console.WriteLine("Baixo Peso");
		}
		else if (imc >= 18.5 && imc <= 24.99){
			Console.WriteLine("Normal");
		}
		else if (imc >= 25 && imc <= 29.99){
			Console.WriteLine("SobrePeso");
		}
		else if (imc >= 30) {
			Console.WriteLine("Obesidade");
		}
	}
}
	
