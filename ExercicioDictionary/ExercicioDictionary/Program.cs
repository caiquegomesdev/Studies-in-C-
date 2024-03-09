using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file full path: ");
        string filePath = Console.ReadLine();

        Dictionary<string, int> candidateVotes = new Dictionary<string, int>();

        try
        {
            // Lê as linhas do arquivo e processa cada registro
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string candidateName = parts[0].Trim();
                    int votes = int.Parse(parts[1]);

                    // Atualiza o total de votos para cada candidato
                    if (candidateVotes.ContainsKey(candidateName))
                        candidateVotes[candidateName] += votes;
                    else
                        candidateVotes[candidateName] = votes;
                }
            }

            // Exibe o relatório consolidado
            foreach (var kvp in candidateVotes)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
