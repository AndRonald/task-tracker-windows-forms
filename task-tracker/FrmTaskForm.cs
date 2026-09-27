using static System.Net.Mime.MediaTypeNames;

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
            btnAllTasks.PerformClick();
        }

        private async void btnAllTasks_Click(object sender, EventArgs e)
        {
            try
            {
                var tasks = await _api.GetAllTasks();

                if (tasks != null && tasks.Count > 0)
                {
                    dgvDados.DataSource = tasks;
                    FormatedGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not complete operation: {ex.Message}");
            }
        }

        private async void btnEditTask_Click(object sender, EventArgs e)
        {
            if (InputBox(out int taskCode))
            {
                try
                {
                    var task = await _api.GetTaskById(taskCode);

                    if (task.Id > 0)
                    {
                        var form = new FrmEditTask(task, _api);
                        form.ShowDialog();
                        btnAllTasks.PerformClick();
                    }
                    else
                        MessageBox.Show("Task does not exist!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not complete operation: {ex.Message}");
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

        private async void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var task = await _api.GetTaskById(Convert.ToInt32(dgvDados["Id", e.RowIndex].Value));

                if (task.Id > 0)
                {
                    var callEditForm = new FrmEditTask(task, _api);
                    callEditForm.ShowDialog();
                    btnAllTasks.PerformClick();
                }
                else
                    MessageBox.Show("Task does not exist!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not complete operation: {ex.Message}");
            }
        }
    }
}
