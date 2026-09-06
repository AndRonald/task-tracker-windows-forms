using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Nodes;

namespace task_tracker.Json
{
    public class TaskRepository
    {
        private readonly string _archive = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                                        "Dados",
                                                        "task.json");

        
        public List<task_tracker.Entities.Task> AllTaks() 
        {
            if (!File.Exists(_archive))
                return new List<task_tracker.Entities.Task>();

            string json = File.ReadAllText(_archive);

            if (string.IsNullOrEmpty(json))
                return new List<task_tracker.Entities.Task>();

            return JsonConvert.DeserializeObject<List<task_tracker.Entities.Task>>(json) ?? new List<task_tracker.Entities.Task>();
        }

        private void Save(List<task_tracker.Entities.Task> task) 
        {
            string json = JsonConvert.SerializeObject(
                task,
                Formatting.Indented
            );

            File.WriteAllText(_archive, json);
        }

        public bool AddTask(task_tracker.Entities.Task task) 
        {
            var tasks = AllTaks();

            task.Id = tasks.Count == 0 
                ? 1 
                : tasks.Max(x => x.Id) + 1;

            tasks.Add(task);

            Save(tasks);

            var teste = tasks.Where(x => x.Id == task.Id).First();

            if (teste != null)
                return true;

            return false;
        }
    }
}
