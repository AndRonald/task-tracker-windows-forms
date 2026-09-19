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
            button4 = new Button();
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
            dgvDados.Location = new Point(12, 86);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 51;
            dgvDados.Size = new Size(540, 188);
            dgvDados.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(456, 398);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnEditTask
            // 
            btnEditTask.Location = new Point(308, 398);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(94, 29);
            btnEditTask.TabIndex = 10;
            btnEditTask.Text = "edit";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // btnCallAddTask
            // 
            btnCallAddTask.Location = new Point(160, 398);
            btnCallAddTask.Name = "btnCallAddTask";
            btnCallAddTask.Size = new Size(94, 29);
            btnCallAddTask.TabIndex = 9;
            btnCallAddTask.Text = "add";
            btnCallAddTask.UseVisualStyleBackColor = true;
            btnCallAddTask.Click += btnCallAddTask_Click;
            // 
            // btnAllTasks
            // 
            btnAllTasks.Location = new Point(12, 398);
            btnAllTasks.Name = "btnAllTasks";
            btnAllTasks.Size = new Size(94, 29);
            btnAllTasks.TabIndex = 8;
            btnAllTasks.Text = "all-task";
            btnAllTasks.UseVisualStyleBackColor = true;
            btnAllTasks.Click += btnAllTasks_Click;
            // 
            // lblTaskTracker
            // 
            lblTaskTracker.AutoSize = true;
            lblTaskTracker.Location = new Point(232, 23);
            lblTaskTracker.Name = "lblTaskTracker";
            lblTaskTracker.Size = new Size(86, 20);
            lblTaskTracker.TabIndex = 7;
            lblTaskTracker.Text = "task-tracker";
            // 
            // FrmTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(dgvDados);
            Controls.Add(button4);
            Controls.Add(btnEditTask);
            Controls.Add(btnCallAddTask);
            Controls.Add(btnAllTasks);
            Controls.Add(lblTaskTracker);
            Name = "FrmTaskForm";
            Text = "FrmTaskForm";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDados;
        private Button button4;
        private Button btnEditTask;
        private Button btnCallAddTask;
        private Button btnAllTasks;
        private Label lblTaskTracker;
    }
}