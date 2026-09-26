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

namespace task_tracker
{
    public partial class FrmAddTask : Form
    {
        private readonly AccessApiService.AccessApiService _api;
        private readonly HttpClient _client;
        public FrmAddTask(AccessApiService.AccessApiService accessApi, HttpClient http)
        {
            InitializeComponent();
            LoadStatusWithDescription();
            _api = accessApi;
            _client = http;
        }

        private void LoadStatusWithDescription()
        {
            foreach (Status status in EnumExtensions.EnumToList<Status>())
            {
                cmbTaskStatus.Items.Add(EnumExtensions.GetDescription(status));
            }
            cmbTaskStatus.SelectedIndex = 0;
        }

        private async void btnAddTask_Click(object sender, EventArgs e)
        {
            Entities.Task task = await _api.CreateTask(new Entities.Task 
                                       {
                                          Description = txtDescriptionTask.Text,
                                          Status = (Status)cmbTaskStatus.SelectedIndex,
                                          CreatedAt = DateTime.Now,
                                          UpdatedAt = DateTime.Now,
                                       });

            if (task != null)
                MessageBox.Show("Adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ocorreu um erro, não foi possível completar sua tarefa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //bool result = _taskRepository.AddTask(task);

            //if (!result)
            //    MessageBox.Show("Não foi possível concluir a operação",
            //        "Erro",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);


        }
    }
}
