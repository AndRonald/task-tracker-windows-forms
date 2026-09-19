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
            btnAddTask = new Button();
            txtDescriptionTask = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 215);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 9;
            label2.Text = "task status";
            // 
            // cmbTaskStatus
            // 
            cmbTaskStatus.FormattingEnabled = true;
            cmbTaskStatus.Location = new Point(11, 251);
            cmbTaskStatus.Name = "cmbTaskStatus";
            cmbTaskStatus.Size = new Size(151, 28);
            cmbTaskStatus.TabIndex = 8;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(141, 360);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "add";
            btnAddTask.UseVisualStyleBackColor = true;
            // 
            // txtDescriptionTask
            // 
            txtDescriptionTask.Location = new Point(11, 98);
            txtDescriptionTask.Multiline = true;
            txtDescriptionTask.Name = "txtDescriptionTask";
            txtDescriptionTask.Size = new Size(354, 102);
            txtDescriptionTask.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 5;
            label1.Text = "describe your task";
            // 
            // FrmEditTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(label2);
            Controls.Add(cmbTaskStatus);
            Controls.Add(btnAddTask);
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
        private Button btnAddTask;
        private TextBox txtDescriptionTask;
        private Label label1;
    }
}