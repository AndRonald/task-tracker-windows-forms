namespace task_tracker
{
    partial class FrmAddTask
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
            label1 = new Label();
            txtDescriptionTask = new TextBox();
            btnAddTask = new Button();
            cmbTaskStatus = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "describe your task";
            // 
            // txtDescriptionTask
            // 
            txtDescriptionTask.Location = new Point(12, 85);
            txtDescriptionTask.Multiline = true;
            txtDescriptionTask.Name = "txtDescriptionTask";
            txtDescriptionTask.Size = new Size(354, 102);
            txtDescriptionTask.TabIndex = 1;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(142, 347);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "add";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // cmbTaskStatus
            // 
            cmbTaskStatus.FormattingEnabled = true;
            cmbTaskStatus.Location = new Point(12, 238);
            cmbTaskStatus.Name = "cmbTaskStatus";
            cmbTaskStatus.Size = new Size(151, 28);
            cmbTaskStatus.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 202);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "task status";
            // 
            // FrmAddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(label2);
            Controls.Add(cmbTaskStatus);
            Controls.Add(btnAddTask);
            Controls.Add(txtDescriptionTask);
            Controls.Add(label1);
            Name = "FrmAddTask";
            Text = "FrmAddTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescriptionTask;
        private Button btnAddTask;
        private ComboBox cmbTaskStatus;
        private Label label2;
    }
}