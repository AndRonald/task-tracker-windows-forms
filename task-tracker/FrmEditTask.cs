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
        public FrmEditTask(Entities.Task task)
        {
            InitializeComponent();
            _task = task;
            LoadData();
            LoadStatusWithDescription(_task);
        }

        private void LoadStatusWithDescription(Entities.Task _task)
        {
            var statuses = EnumExtensions.EnumToList<Status>(); 
            foreach (Status status in statuses)
            {
                cmbTaskStatus.Items.Add(EnumExtensions.GetDescription(status));
            }
            cmbTaskStatus.SelectedIndex = statuses.IndexOf(_task.Status);
        }

        public void LoadData() 
        {
            txtDescriptionTask.Text = _task.Description;
        }
    }
}
