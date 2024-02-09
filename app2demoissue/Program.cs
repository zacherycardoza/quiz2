namespace app2demoissue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TodoItem> todoList = new List<TodoItem>
        {
            new TodoItem { Id = 1, Task = "Complete quiz#1", Completed = false },
            new TodoItem { Id = 2, Task = "Study for exam", Completed = false }
        };

           
            Console.WriteLine("Current TodoItems:");
            DisplayTodoItems(todoList);

           
            AddTodoItem(todoList, new TodoItem { Id = 3, Task = "Complete quiz#2", Completed = false });

         
            Console.WriteLine("\nUpdated TodoItems:");
            DisplayTodoItems(todoList);
        }

        static void AddTodoItem(List<TodoItem> todoList, TodoItem newItem)
        {
           
            todoList.Add(newItem);
        }

        static void DisplayTodoItems(List<TodoItem> todoList)
        {
            foreach (var item in todoList)
            {
                Console.WriteLine($"[{item.Id}] {item.Task} - Completed: {item.Completed}");
            }
        }
    }

}