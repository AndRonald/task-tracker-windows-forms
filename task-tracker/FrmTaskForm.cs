using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_tracker.Entities;
using task_tracker.Json;

namespace task_tracker
{
    public partial class FrmTaskForm : Form
    {
        private readonly TaskRepository _taskRepository;
        public FrmTaskForm()
        {
            InitializeComponent();
            _taskRepository = new TaskRepository();
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
            var addTask = new FrmAddTask();
            addTask.ShowDialog();
        }

        private void btnAllTasks_Click(object sender, EventArgs e)
        {
            try
            {
                List<task_tracker.Entities.Task> tasks = _taskRepository.AllTaks();
                dgvDados.DataSource = tasks;
                FormatedGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when trying to recover tasks: " + ex.Message);
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if(InputBox(out int taskCode))
            {
                try 
                {
                    var task = _taskRepository.GetTaskById(taskCode);

                    if (task is not null)
                    {
                        var form = new FrmEditTask(task);
                        form.ShowDialog();
                    }
                       
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error trying update task" + ex.Message);
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
