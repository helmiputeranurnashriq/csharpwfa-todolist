namespace Todo_List
{
    partial class todoForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.descInput = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.todoListView = new System.Windows.Forms.DataGridView();
            this.completeChkBox = new System.Windows.Forms.CheckBox();
            this.urgentChkBox = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.todoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(732, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "ToDo List";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Task";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Description";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(102, 92);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(531, 20);
            this.textInput.TabIndex = 3;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(102, 150);
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(531, 20);
            this.descInput.TabIndex = 4;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(397, 278);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(123, 35);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(76, 278);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(123, 35);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(234, 278);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(123, 35);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(557, 278);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(123, 35);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // todoListView
            // 
            this.todoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todoListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.todoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoListView.Location = new System.Drawing.Point(32, 332);
            this.todoListView.Name = "todoListView";
            this.todoListView.Size = new System.Drawing.Size(691, 164);
            this.todoListView.TabIndex = 9;
            // 
            // completeChkBox
            // 
            this.completeChkBox.AutoSize = true;
            this.completeChkBox.Location = new System.Drawing.Point(557, 191);
            this.completeChkBox.Name = "completeChkBox";
            this.completeChkBox.Size = new System.Drawing.Size(76, 17);
            this.completeChkBox.TabIndex = 10;
            this.completeChkBox.Text = "Complete?";
            this.completeChkBox.UseVisualStyleBackColor = true;
            this.completeChkBox.CheckedChanged += new System.EventHandler(this.completeChkBox_CheckedChanged);
            // 
            // urgentChkBox
            // 
            this.urgentChkBox.AutoSize = true;
            this.urgentChkBox.Location = new System.Drawing.Point(557, 229);
            this.urgentChkBox.Name = "urgentChkBox";
            this.urgentChkBox.Size = new System.Drawing.Size(73, 17);
            this.urgentChkBox.TabIndex = 11;
            this.urgentChkBox.Text = "Is urgent?";
            this.urgentChkBox.UseVisualStyleBackColor = true;
            this.urgentChkBox.CheckedChanged += new System.EventHandler(this.urgentChkBox_CheckedChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(102, 208);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(230, 20);
            this.datePicker.TabIndex = 12;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Due Date and Time";
            // 
            // todoForm
            // 
            this.ClientSize = new System.Drawing.Size(757, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.urgentChkBox);
            this.Controls.Add(this.completeChkBox);
            this.Controls.Add(this.todoListView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.descInput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "todoForm";
            this.Load += new System.EventHandler(this.todoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox descInput;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView todoListView;
        private System.Windows.Forms.CheckBox completeChkBox;
        private System.Windows.Forms.CheckBox urgentChkBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
    }
}

