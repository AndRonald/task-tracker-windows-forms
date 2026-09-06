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
            dataGridView1 = new DataGridView();
            button4 = new Button();
            lblEditTask = new Button();
            btnCallAddTask = new Button();
            button1 = new Button();
            lblTaskTracker = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(540, 188);
            dataGridView1.TabIndex = 12;
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
            // lblEditTask
            // 
            lblEditTask.Location = new Point(308, 398);
            lblEditTask.Name = "lblEditTask";
            lblEditTask.Size = new Size(94, 29);
            lblEditTask.TabIndex = 10;
            lblEditTask.Text = "edit";
            lblEditTask.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Location = new Point(12, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "all-task";
            button1.UseVisualStyleBackColor = true;
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
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(lblEditTask);
            Controls.Add(btnCallAddTask);
            Controls.Add(button1);
            Controls.Add(lblTaskTracker);
            Name = "FrmTaskForm";
            Text = "FrmTaskForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button4;
        private Button lblEditTask;
        private Button btnCallAddTask;
        private Button button1;
        private Label lblTaskTracker;
    }
}