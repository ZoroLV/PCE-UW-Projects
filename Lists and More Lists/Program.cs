using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_and_More_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            foreach (var name in users.Where(x => x.Password == "hello")) // #1
            {
                Console.WriteLine(name);
                Console.WriteLine(" ");
            }

            users.RemoveAll(x => x.Name.ToLower() == x.Password); // #2

            var First = users.First(x => x.Password == "hello"); // #3
            users.Remove(First);

            users.ForEach(u => Console.WriteLine("User: {0} Password: {1}", u.Name, u.Password)); // #4

        }
    }
}
