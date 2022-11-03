namespace TodoList.Client
{
    partial class TodoListForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IsDoneColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TodoTaskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduledTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 598);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newButton);
            this.flowLayoutPanel1.Controls.Add(this.editButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 541);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(908, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(3, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(150, 46);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(159, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 46);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(315, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 46);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsDoneColumn,
            this.TodoTaskColumn,
            this.ScheduledTimeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(908, 532);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // IsDoneColumn
            // 
            this.IsDoneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsDoneColumn.DataPropertyName = "IsDone";
            this.IsDoneColumn.FillWeight = 10F;
            this.IsDoneColumn.HeaderText = "Is Done";
            this.IsDoneColumn.MinimumWidth = 120;
            this.IsDoneColumn.Name = "IsDoneColumn";
            this.IsDoneColumn.ReadOnly = true;
            this.IsDoneColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsDoneColumn.Width = 150;
            // 
            // TodoTaskColumn
            // 
            this.TodoTaskColumn.DataPropertyName = "TodoTask";
            this.TodoTaskColumn.FillWeight = 16.99714F;
            this.TodoTaskColumn.HeaderText = "Task";
            this.TodoTaskColumn.MinimumWidth = 10;
            this.TodoTaskColumn.Name = "TodoTaskColumn";
            this.TodoTaskColumn.ReadOnly = true;
            this.TodoTaskColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ScheduledTimeColumn
            // 
            this.ScheduledTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ScheduledTimeColumn.DataPropertyName = "ScheduledTime";
            this.ScheduledTimeColumn.FillWeight = 10F;
            this.ScheduledTimeColumn.HeaderText = "Scheduled Time";
            this.ScheduledTimeColumn.MinimumWidth = 300;
            this.ScheduledTimeColumn.Name = "ScheduledTimeColumn";
            this.ScheduledTimeColumn.ReadOnly = true;
            this.ScheduledTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduledTimeColumn.Width = 300;
            // 
            // TodoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TodoListForm";
            this.Text = "TodoListForm";
            this.Load += new System.EventHandler(this.TodoListForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn IsDoneColumn;
        private DataGridViewTextBoxColumn TodoTaskColumn;
        private DataGridViewTextBoxColumn ScheduledTimeColumn;
    }
}