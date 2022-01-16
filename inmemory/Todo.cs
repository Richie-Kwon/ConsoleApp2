using System.Collections.Generic;
using System.Dynamic;

namespace inmemory
{
    public class Todo
    {
        public int Id { get; set; }

        public static Title {
            get;
            set;
        }

        public bool IsDone { get; set; }
    }

    public class Title
    {
    }

    public interface ITodoRepositoryInMemory
    {
        void Add(Todo model);
        List <Todo> GetAlll();
    }
    
    public class TodoRepositoryInMomory : ITodoRepositoryInMemory
    {
        private ITodoRepositoryInMemory _todoRepositoryInMemoryImplementation;
 
    }
}