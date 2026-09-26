namespace task_tracker
{
    partial class FrmTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDados = new DataGridView();
            btnDeleteTask = new Button();
            btnEditTask = new Button();
            btnCallAddTask = new Button();
            btnAllTasks = new Button();
            lblTaskTracker = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(10, 64);
            dgvDados.Margin = new Padding(3, 2, 3, 2);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 51;
            dgvDados.Size = new Size(472, 141);
            dgvDados.TabIndex = 12;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(399, 298);
            btnDeleteTask.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(82, 22);
            btnDeleteTask.TabIndex = 11;
            btnDeleteTask.Text = "delete";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnEditTask
            // 
            btnEditTask.Location = new Point(270, 298);
            btnEditTask.Margin = new Padding(3, 2, 3, 2);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(82, 22);
            btnEditTask.TabIndex = 10;
            btnEditTask.Text = "edit";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // btnCallAddTask
            // 
            btnCallAddTask.Location = new Point(140, 298);
            btnCallAddTask.Margin = new Padding(3, 2, 3, 2);
            btnCallAddTask.Name = "btnCallAddTask";
            btnCallAddTask.Size = new Size(82, 22);
            btnCallAddTask.TabIndex = 9;
            btnCallAddTask.Text = "add";
            btnCallAddTask.UseVisualStyleBackColor = true;
            btnCallAddTask.Click += btnCallAddTask_Click;
            // 
            // btnAllTasks
            // 
            btnAllTasks.Location = new Point(10, 298);
            btnAllTasks.Margin = new Padding(3, 2, 3, 2);
            btnAllTasks.Name = "btnAllTasks";
            btnAllTasks.Size = new Size(82, 22);
            btnAllTasks.TabIndex = 8;
            btnAllTasks.Text = "all-task";
            btnAllTasks.UseVisualStyleBackColor = true;
            btnAllTasks.Click += btnAllTasks_Click;
            // 
            // lblTaskTracker
            // 
            lblTaskTracker.AutoSize = true;
            lblTaskTracker.Location = new Point(203, 17);
            lblTaskTracker.Name = "lblTaskTracker";
            lblTaskTracker.Size = new Size(69, 15);
            lblTaskTracker.TabIndex = 7;
            lblTaskTracker.Text = "task-tracker";
            // 
            // FrmTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 338);
            Controls.Add(dgvDados);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnEditTask);
            Controls.Add(btnCallAddTask);
            Controls.Add(btnAllTasks);
            Controls.Add(lblTaskTracker);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmTaskForm";
            Text = "FrmTaskForm";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDados;
        private Button btnDeleteTask;
        private Button btnEditTask;
        private Button btnCallAddTask;
        private Button btnAllTasks;
        private Label lblTaskTracker;
    }
}