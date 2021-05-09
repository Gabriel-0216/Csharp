using System;

public class Program
{
    public static void Main()
    {
        char[] primeiraSequencia = new char[] { 'A', 'B', 'X', 'O' };
        char[] segundaSequencia = new char[] { 'X', 'P', 'T', 'O', 'A', 'B', 'X', 'O', 'V', 'B', 'X', 'G', 'H', 'O', 'A', 'B', 'X', 'A', 'B', 'X', 'A', 'B', 'X', 'O', 'O', 'P', 'T', 'V', 'B'};


        foreach (var entry in (ComparaSequencias(primeiraSequencia, segundaSequencia)))
        {
            Console.WriteLine(entry);
        }
    }

    public static int[] ComparaSequencias(char[] primeiraSequencia, char[] segundaSequencia)
    {
        // Código da solução aqui.
        // 
        int vezes; // qtde de vezes que as letras da primeira sequencia sao encontradas na segunda sequencia
        int aux; // recebe a posição da primeira letra da segunda seq
        int aux2; // recebe a posiçao da primeira letra da primeira seq
        int[] posicoes = new int[5];
        int tamanho = 0;


        for (int i = 0; i < segundaSequencia.Length; i++)  // percorre o segundo char inteiro
        {
            int varAux = 0;
            vezes = 0;
            aux = 0;
            aux2 = 0;
            if (segundaSequencia[i].Equals(primeiraSequencia[varAux]))
            { // quando ele encontra a letra 'A' na segunda sequencia ele entra nessa condicional
                aux = i; // variavel auxiliar recebe o valor onde a letra A foi encontrada
                varAux = aux2; // varAux2 recebe o valor de aux2=0,
                for (int j = 0; j < primeiraSequencia.Length; j++)
                {
                    if (segundaSequencia[aux].Equals(primeiraSequencia[varAux]))
                    { // se ele encontrar a da posição 0 da primeira sequencia na segunda sequencia, ele entra nessa condicional, e assim sucessivamente
                        vezes++;
                        aux++;
                        varAux++;   // incrementa as variaveis auxiliares pra continuar o teste.
                    }
                }
            }

            if (vezes == 4) // se ele percorrer o loop de confirmação pelo menos 4 vezes (tamanho da primeira sequencia) ele armazena o valor de i (onde a primeira letra da primeiraSeq foi encontrada na segundaSeq)
            {
                posicoes[tamanho] = i;
                tamanho++;
            }
            else
            {

            }


        }

        return posicoes;


    }
}
