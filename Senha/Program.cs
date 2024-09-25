﻿using System;

class Program
{
	static void Main()
	{
		{
			Console.WriteLine("Digite o tamanho da senha que deseja gerar:");
			if (!int.TryParse(Console.ReadLine(), out int tamanhosenha))
			{
				Console.WriteLine("insira um valor valido");
			}

			string senha = GerarSenha(tamanhosenha);
			Console.WriteLine("Senha gerada: " + senha);
		}

		static string GerarSenha(int tamanho)
		{
			string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%¨&*";
			Random random = new Random();
			string senha = "";
			for (int i = 0; i < tamanho; i++)
			{
				int senha1 = random.Next(caracteres.Length);
				senha += caracteres[senha1];
			}

			return senha;
		}
	}
}