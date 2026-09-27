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
            _api = api;
            LoadData();
        }
        private void LoadData()
        {
            var statusList = EnumExtensions.EnumToList<Status>();
            foreach (Status status in statusList)
            {
                cmbTaskStatus.Items.Add(EnumExtensions.GetDescription(status));
            }
            cmbTaskStatus.SelectedIndex = statusList.IndexOf(_task.Status);
            txtDescriptionTask.Text = _task.Description;
        }
        private async void btnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                _task = new Entities.Task()
                {
                    Id = _task.Id,
                    Description = txtDescriptionTask.Text,
                    Status = (Status)cmbTaskStatus.SelectedIndex,
                    CreatedAt = _task.CreatedAt,
                    UpdatedAt = DateTime.Now
                };

                await _api.UpdateTask(_task.Id, _task);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Could not complete operation: {ex.Message}");
            }
        }
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _api?.DeleteTask(_task.Id);
                    this.Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Could not complete operation: {ex.Message}");
            }
        }
    }
}
