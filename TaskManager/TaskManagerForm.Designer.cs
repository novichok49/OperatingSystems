
namespace TaskManager
{
    partial class TaskManagerForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.MenuHighlight, System.Drawing.Color.Empty, null);
            this.timerTicks = new System.Windows.Forms.Timer(this.components);
            this.buttonChangeAlg = new System.Windows.Forms.Button();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.listProcess = new System.Windows.Forms.ListView();
            this.listHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHeaderMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHeaderHealth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerTicks
            // 
            this.timerTicks.Interval = 1000;
            this.timerTicks.Tick += new System.EventHandler(this.timerTicks_Tick);
            // 
            // buttonChangeAlg
            // 
            this.buttonChangeAlg.Location = new System.Drawing.Point(437, 151);
            this.buttonChangeAlg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeAlg.Name = "buttonChangeAlg";
            this.buttonChangeAlg.Size = new System.Drawing.Size(89, 65);
            this.buttonChangeAlg.TabIndex = 0;
            this.buttonChangeAlg.Text = "Изменить алгоритм планирования";
            this.buttonChangeAlg.UseVisualStyleBackColor = true;
            this.buttonChangeAlg.Click += new System.EventHandler(this.buttonChangeAlg_Click);
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Location = new System.Drawing.Point(437, 220);
            this.buttonAddProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(89, 65);
            this.buttonAddProcess.TabIndex = 1;
            this.buttonAddProcess.Text = "Добавить процесс";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.buttonAddProcess_Click);
            // 
            // listProcess
            // 
            this.listProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listHeaderName,
            this.listHeaderId,
            this.listHeaderMemory,
            this.listHeaderHealth,
            this.listHeaderTime});
            this.listProcess.HideSelection = false;
            this.listProcess.Location = new System.Drawing.Point(8, 8);
            this.listProcess.Margin = new System.Windows.Forms.Padding(2);
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(426, 278);
            this.listProcess.TabIndex = 2;
            this.listProcess.UseCompatibleStateImageBehavior = false;
            this.listProcess.View = System.Windows.Forms.View.Details;
            // 
            // listHeaderName
            // 
            this.listHeaderName.Text = "Имя";
            this.listHeaderName.Width = 108;
            // 
            // listHeaderId
            // 
            this.listHeaderId.Text = "ИД";
            this.listHeaderId.Width = 37;
            // 
            // listHeaderMemory
            // 
            this.listHeaderMemory.Text = "Память";
            this.listHeaderMemory.Width = 54;
            // 
            // listHeaderHealth
            // 
            this.listHeaderHealth.Text = "Остаток времени";
            this.listHeaderHealth.Width = 101;
            // 
            // listHeaderTime
            // 
            this.listHeaderTime.Text = "Время появления";
            this.listHeaderTime.Width = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Алгоритм FCFS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(437, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(437, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(437, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Время работы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Память:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Имя:";
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProcess);
            this.Controls.Add(this.buttonAddProcess);
            this.Controls.Add(this.buttonChangeAlg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskManagerForm";
            this.Text = "Диспетчер задач";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Timer timerTicks;
        private System.Windows.Forms.Button buttonChangeAlg;
        private System.Windows.Forms.Button buttonAddProcess;
        private System.Windows.Forms.ListView listProcess;
        private System.Windows.Forms.ColumnHeader listHeaderName;
        private System.Windows.Forms.ColumnHeader listHeaderId;
        private System.Windows.Forms.ColumnHeader listHeaderMemory;
        private System.Windows.Forms.ColumnHeader listHeaderHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader listHeaderTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}