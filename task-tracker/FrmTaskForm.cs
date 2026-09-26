namespace task_tracker
{
    public partial class FrmTaskForm : Form
    {
        private readonly task_tracker.AccessApiService.AccessApiService _api;
        private readonly HttpClient _httpClient;
        public FrmTaskForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _api = new task_tracker.AccessApiService.AccessApiService(_httpClient);
        }

        private void FormatedGrid()
        {
            if (dgvDados.DataSource != null && dgvDados.Columns.Contains("Id"))
            {
                var colId = dgvDados.Columns["Id"];
                colId.Width = 100;
            }
        }

        private void btnCallAddTask_Click(object sender, EventArgs e)
        {
            var callFrmAddTask = new FrmAddTask(_api, _httpClient);
            callFrmAddTask.ShowDialog();
        }

        private async void btnAllTasks_Click(object sender, EventArgs e)
        {
            try
            {
                List<Entities.Task> tasks = await _api.GetAllTasks();
                dgvDados.DataSource = tasks;
                FormatedGrid();

                //List<task_tracker.Entities.Task> tasks = 
                //dgvDados.DataSource = tasks;
                //FormatedGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when trying to recover tasks: " + ex.Message);
            }
        }

        private async void btnEditTask_Click(object sender, EventArgs e)
        {
            if (InputBox(out int taskCode))
            {
                try
                {
                    Entities.Task task = await _api.GetTaskById(taskCode);

                    if (task is not null)
                    {
                        var form = new FrmEditTask(task, _api);
                        form.ShowDialog();
                    }
                    btnAllTasks.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error trying update task" + ex.Message);
                }
            }
        }
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if(InputBox(out int taskCode)) 
            {
                try
                {
                    var task = _api.GetTaskById(taskCode);

                    if (task is not null)
                        _api?.DeleteTask(task.Id);
                    else
                        MessageBox.Show("Tarefa não encontrada", "NotFound"); 
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error trying delete task " + ex.Message);
                }
            }
        }

        private bool InputBox(out int code)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("please, write code of task", "input", "1");

            if (int.TryParse(result, out code))
            {
                return true;
            }

            code = -1;
            return false;
        }
    }
}
