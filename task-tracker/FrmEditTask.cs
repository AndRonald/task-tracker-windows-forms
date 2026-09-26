using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_tracker.Entities.Enums;

namespace task_tracker
{
    public partial class FrmEditTask : Form
    {
        private Entities.Task _task;
        private readonly AccessApiService.AccessApiService _api;

        public FrmEditTask(Entities.Task task, AccessApiService.AccessApiService api)
        {
            InitializeComponent();
            _task = task;
            LoadData();
            LoadStatusWithDescription(_task);
            _api = api;
        }
        private void LoadStatusWithDescription(Entities.Task _task)
        {
            var statuses = EnumExtensions.EnumToList<Status>();
            foreach (Status status in statuses)
            {
                cmbTaskStatus.Items.Add(EnumExtensions.GetDescription(status));
            }
            //cmbTaskStatus.SelectedIndex = statuses.IndexOf(_task.Status);
            cmbTaskStatus.Text = _task.Status.ToString();
        }
        public void LoadData()
        {
            txtDescriptionTask.Text = _task.Description;
            //cmbTaskStatus.Text = _task.Status.ToString();
        }
        private async void btnAddTask_Click(object sender, EventArgs e)
        {
            _task = new Entities.Task()
            {
                Id = _task.Id,
                Description = txtDescriptionTask.Text,
                Status = (Status)cmbTaskStatus.SelectedIndex,
                CreatedAt = _task.CreatedAt,
                UpdatedAt = DateTime.UtcNow
            };

            await _api.UpdateTask(_task.Id, _task);
            this.Close();
        }
    }
}
