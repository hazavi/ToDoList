using System;
using System.Collections.Generic;

namespace ToDoList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<string> todos = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("TODO list!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add a todo");
                Console.WriteLine("2. View all todos");
                Console.WriteLine("3. Mark a todo as completed");
                Console.WriteLine("4. Exit");

                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTodo();
                        break;
                    case "2":
                        ViewTodos();
                        break;
                    case "3":
                        MarkTodoAsCompleted();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddTodo()
        {
            Console.WriteLine("Enter the todo item:");
            string todo = Console.ReadLine();
            todos.Add(todo);
            Console.WriteLine("Todo added successfully!");
        }

        static void ViewTodos()
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No todos found.");
            }
            else
            {
                Console.WriteLine("Your todos:");
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }
        }

        static void MarkTodoAsCompleted()
        {
            Console.WriteLine("Enter the index of the todo to mark as completed:");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todos.Count)
            {
                todos.RemoveAt(index - 1);
                Console.WriteLine("Todo marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid index. Please try again.");
            }
        }
    }
    
}