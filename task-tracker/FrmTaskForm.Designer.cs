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
            dgvDados.Location = new Point(11, 85);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 51;
            dgvDados.Size = new Size(641, 188);
            dgvDados.TabIndex = 12;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            // 
            // btnEditTask
            // 
            btnEditTask.BackColor = SystemColors.Info;
            btnEditTask.Location = new Point(536, 324);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(117, 46);
            btnEditTask.TabIndex = 10;
            btnEditTask.Text = "EDIT TASK";
            btnEditTask.UseVisualStyleBackColor = false;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // btnCallAddTask
            // 
            btnCallAddTask.BackColor = Color.PaleGreen;
            btnCallAddTask.Location = new Point(274, 324);
            btnCallAddTask.Name = "btnCallAddTask";
            btnCallAddTask.Size = new Size(117, 46);
            btnCallAddTask.TabIndex = 9;
            btnCallAddTask.Text = "CREATE TASK";
            btnCallAddTask.UseVisualStyleBackColor = false;
            btnCallAddTask.Click += btnCallAddTask_Click;
            // 
            // btnAllTasks
            // 
            btnAllTasks.BackColor = SystemColors.ActiveCaption;
            btnAllTasks.Location = new Point(12, 324);
            btnAllTasks.Name = "btnAllTasks";
            btnAllTasks.Size = new Size(117, 46);
            btnAllTasks.TabIndex = 8;
            btnAllTasks.Text = "TASKS";
            btnAllTasks.UseVisualStyleBackColor = false;
            btnAllTasks.Click += btnAllTasks_Click;
            // 
            // lblTaskTracker
            // 
            lblTaskTracker.AutoSize = true;
            lblTaskTracker.Font = new Font("Consolas", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTaskTracker.Location = new Point(280, 23);
            lblTaskTracker.Name = "lblTaskTracker";
            lblTaskTracker.Size = new Size(104, 18);
            lblTaskTracker.TabIndex = 7;
            lblTaskTracker.Text = "TASK TRACKER";
            lblTaskTracker.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 386);
            Controls.Add(dgvDados);
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
        private Button btnEditTask;
        private Button btnCallAddTask;
        private Button btnAllTasks;
        private Label lblTaskTracker;
    }
}