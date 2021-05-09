using System;

public static class Program
{
	public static void Main()
	{
		char[] mensagemCodificada = new char[] { 'm', 'I', 'm', 'r', 'm', 'e', 'm', 'i', ' ', 'm', 'a', 'm', 'o', ' ', 'm', 'b', 'm', 'a', 'm', 'n', 'm', 'c', 'm', 'o','m', ' ', 'h','m','o','m','j','m','e','m' };

		Console.WriteLine(RetornaMensagemDecodificada(mensagemCodificada));
	}

	public static char[] RetornaMensagemDecodificada(char[] mensagemCodificada)
	{
		char[] mensagemDecodificada = new char[mensagemCodificada.Length];  // cria um novo vetor de char com o mesmo tamanho da mensagem codificada

		for(int i=0; i<mensagemCodificada.Length; i++) // percorre a mensagem codificada inteira
        {
			if (mensagemCodificada[i].Equals('m')) // se ele encontrar a letra 'm', o programa não faz nada
			{

			}
			else {
				mensagemDecodificada[i] = mensagemCodificada[i]; // se a letra não for 'm', ele salva aquela letra na posição i do mensagemDecodificada 
			}
        }

		return mensagemDecodificada; //


	}
}
