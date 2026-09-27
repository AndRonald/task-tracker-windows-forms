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
            try
            {
                var task = await _api.CreateTask(new Entities.Task
                {
                    Description = txtDescriptionTask.Text,
                    Status = (Status)cmbTaskStatus.SelectedIndex,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });

                if (task.Id > 0)
                    MessageBox.Show("To added task with success!", "success");
                else
                    MessageBox.Show("Could not complete operation", "fail");

                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Could not complete operation: {ex.Message}");
            }
        }
    }
}
