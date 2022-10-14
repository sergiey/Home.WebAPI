namespace TodoList.Client
{
    partial class EditItemForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.isDoneCheckBox = new System.Windows.Forms.CheckBox();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.scheduleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(27, 302);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 46);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(183, 302);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 46);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // isDoneCheckBox
            // 
            this.isDoneCheckBox.AutoSize = true;
            this.isDoneCheckBox.Location = new System.Drawing.Point(389, 244);
            this.isDoneCheckBox.Name = "isDoneCheckBox";
            this.isDoneCheckBox.Size = new System.Drawing.Size(104, 36);
            this.isDoneCheckBox.TabIndex = 2;
            this.isDoneCheckBox.Text = "Done";
            this.isDoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(27, 26);
            this.taskTextBox.Multiline = true;
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(483, 190);
            this.taskTextBox.TabIndex = 3;
            // 
            // scheduleDateTimePicker
            // 
            this.scheduleDateTimePicker.Location = new System.Drawing.Point(27, 240);
            this.scheduleDateTimePicker.Name = "scheduleDateTimePicker";
            this.scheduleDateTimePicker.Size = new System.Drawing.Size(306, 39);
            this.scheduleDateTimePicker.TabIndex = 4;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 374);
            this.Controls.Add(this.scheduleDateTimePicker);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.isDoneCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Name = "EditItemForm";
            this.Text = "NewOrEditItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveButton;
        private Button cancelButton;
        private CheckBox isDoneCheckBox;
        private TextBox taskTextBox;
        private DateTimePicker scheduleDateTimePicker;
    }
}