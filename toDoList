using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    private const string FilePath = "tasks.json";

    static void Main()
    {
        List<TaskItem> tasks = LoadTasks();

        while (true)
        {
            Console.WriteLine("To-Do List:");
            DisplayTasks(tasks);

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Remover Tarefa");
            Console.WriteLine("3. Sair");

            Console.Write("Escolha uma opção (1-3): ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    tasks.Add(new TaskItem { Description = descricao, IsCompleted = false });
                    break;

                case "2":
                    Console.Write("Digite o número da tarefa a ser removida: ");
                    if (int.TryParse(Console.ReadLine(), out int indice))
                    {
                        if (indice >= 0 && indice < tasks.Count)
                        {
                            tasks.RemoveAt(indice);
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida");
                    }
                    break;

                case "3":
                    SaveTasks(tasks);
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            SaveTasks(tasks);
        }
    }

    static void DisplayTasks(List<TaskItem> tasks)
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i}. [{(tasks[i].IsCompleted ? "X" : " ")}] {tasks[i].Description}");
        }
        Console.WriteLine();
    }

    static List<TaskItem> LoadTasks()
    {
        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<TaskItem>>(json);
        }
        return new List<TaskItem>();
    }

    static void SaveTasks(List<TaskItem> tasks)
    {
        string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
        File.WriteAllText(FilePath, json);
    }
}

class TaskItem
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}
