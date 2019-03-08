using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userToDoText=null; int i = 0; List<string> userList = new List<string>(); string storeText;

            try
            {
               userToDoText  = File.ReadAllText(@"F:\Codium\Todo.txt");
                if (!string.IsNullOrEmpty(userToDoText)) Console.WriteLine("Previous ToDo list:" + userToDoText);
                else throw new Exception("No list");
            }
            catch (Exception e)
            {
                Console.WriteLine("Welcome!! \n Add Todo List");
            }
            Console.WriteLine("Press 1 to add and 2 to remove:");
            var userdec = Console.ReadLine();

            if (userdec == "1")
            {
                Console.WriteLine("Enter Todo list:");
                var userinput = Console.ReadLine();
                while (!string.IsNullOrEmpty(userinput))
                {
                    i = 1;
                    userList.Add(userinput);
                    userinput = Console.ReadLine();
                }

                if (i != 0)
                {
                    var newTodoList = string.Join("$", userList);
                    File.AppendAllLines(@"F:\Codium\Todo.txt", new[] { newTodoList });
                }

            }

            else if (userdec == "2")
            {
                File.WriteAllLines(@"F:\Codium\Todo.txt", new[] { "" });
            }

            else Console.WriteLine("Invalid Command");

        }
    }
}
