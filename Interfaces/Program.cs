using System;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface "new" lenemez!
            IPersonManager personManager = new PersonelManager();

            IPersonManager StudentManager = new StudentManager();

            ProjectManager ProjectManager = new ProjectManager();
            ProjectManager.Add(personManager);
            ProjectManager.Add(StudentManager);
        }
    }
    interface IPersonManager //unimplemented operation
    {
        void Add();
        void Update();
    }
    class PersonelManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel added");
        }

        public void Update()
        {
            Console.WriteLine("Personel updated");
        }
    }
    class StudentManager : IPersonManager
    {        
        public void Add()
        {
            Console.WriteLine("Student added");
        }

        public void Update()
        {
            Console.WriteLine("Student updated");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}