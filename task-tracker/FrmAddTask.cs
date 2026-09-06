using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_tracker.Entities.Enums;
using task_tracker.Json;

namespace task_tracker
{
    public partial class FrmAddTask : Form
    {
        private readonly TaskRepository _taskRepository = new TaskRepository();
        public FrmAddTask()
        {
            InitializeComponent();
            LoadStatusWithDescription();
        }

        private void LoadStatusWithDescription()
        {
            foreach (Status status in EnumExtensions.EnumToList<Status>())
            {
                cmbTaskStatus.Items.Add(EnumExtensions.GetDescription(status));
            }
            cmbTaskStatus.SelectedIndex = 0;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var task = new task_tracker.Entities.Task()
            {
                Description = txtDescriptionTask.SelectedText,
                Status = (Status)cmbTaskStatus.SelectedIndex,
                CreatedAt = DateTime.Now,
                UpdateAt = DateTime.Now,
            };

            bool result = _taskRepository.AddTask(task);

            if (!result)
                MessageBox.Show("Não foi possível concluir a operação",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            MessageBox.Show("Adicionado com sucesso",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
