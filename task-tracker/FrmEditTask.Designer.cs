namespace task_tracker
{
    partial class FrmEditTask
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
            label2 = new Label();
            cmbTaskStatus = new ComboBox();
            btnUpdateTask = new Button();
            txtDescriptionTask = new TextBox();
            label1 = new Label();
            btnDeleteTask = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 149);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 9;
            label2.Text = "task status";
            // 
            // cmbTaskStatus
            // 
            cmbTaskStatus.FormattingEnabled = true;
            cmbTaskStatus.Location = new Point(12, 172);
            cmbTaskStatus.Name = "cmbTaskStatus";
            cmbTaskStatus.Size = new Size(151, 28);
            cmbTaskStatus.TabIndex = 8;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.BackColor = SystemColors.Info;
            btnUpdateTask.Location = new Point(12, 278);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(109, 29);
            btnUpdateTask.TabIndex = 7;
            btnUpdateTask.Text = "UPDATE";
            btnUpdateTask.UseVisualStyleBackColor = false;
            btnUpdateTask.Click += btnUpdateTask_Click;
            // 
            // txtDescriptionTask
            // 
            txtDescriptionTask.Location = new Point(12, 32);
            txtDescriptionTask.Multiline = true;
            txtDescriptionTask.Name = "txtDescriptionTask";
            txtDescriptionTask.Size = new Size(452, 103);
            txtDescriptionTask.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 5;
            label1.Text = "describe your task";
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.IndianRed;
            btnDeleteTask.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteTask.Location = new Point(370, 278);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(94, 29);
            btnDeleteTask.TabIndex = 12;
            btnDeleteTask.Text = "DELETE";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // FrmEditTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 319);
            Controls.Add(btnDeleteTask);
            Controls.Add(label2);
            Controls.Add(cmbTaskStatus);
            Controls.Add(btnUpdateTask);
            Controls.Add(txtDescriptionTask);
            Controls.Add(label1);
            Name = "FrmEditTask";
            Text = "FrmEditTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cmbTaskStatus;
        private Button btnUpdateTask;
        private TextBox txtDescriptionTask;
        private Label label1;
        private Button btnDeleteTask;
    }
}