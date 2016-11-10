namespace CA_1
{
    partial class Lab1_5a
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
            this.tb_input = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.btn_fromFile = new System.Windows.Forms.Button();
            this.btn_execute = new System.Windows.Forms.Button();
            this.btn_task = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(7, 27);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.ReadOnly = true;
            this.tb_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_input.Size = new System.Drawing.Size(400, 300);
            this.tb_input.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(413, 27);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.Size = new System.Drawing.Size(400, 300);
            this.tb_output.TabIndex = 2;
            // 
            // btn_fromFile
            // 
            this.btn_fromFile.Location = new System.Drawing.Point(7, 343);
            this.btn_fromFile.Name = "btn_fromFile";
            this.btn_fromFile.Size = new System.Drawing.Size(74, 34);
            this.btn_fromFile.TabIndex = 3;
            this.btn_fromFile.Text = "Считать из файла";
            this.btn_fromFile.UseVisualStyleBackColor = true;
            this.btn_fromFile.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(413, 343);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(80, 34);
            this.btn_execute.TabIndex = 4;
            this.btn_execute.Text = "Выполнить";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.TaskToolStripMenuItem_Click);
            // 
            // btn_task
            // 
            this.btn_task.Location = new System.Drawing.Point(499, 343);
            this.btn_task.Name = "btn_task";
            this.btn_task.Size = new System.Drawing.Size(81, 34);
            this.btn_task.TabIndex = 5;
            this.btn_task.Text = "Условие";
            this.btn_task.UseVisualStyleBackColor = true;
            this.btn_task.Click += new System.EventHandler(this.TaskToDoToolStripMenuItem_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(87, 343);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(78, 34);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(171, 343);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 34);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.DeleteСловоToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Словарь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Результат:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(257, 343);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 34);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // Lab1_5a
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(820, 459);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_task);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.btn_fromFile);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lab1_5a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Слово и словарь";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab1_5a_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button btn_fromFile;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Button btn_task;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
    }
}

