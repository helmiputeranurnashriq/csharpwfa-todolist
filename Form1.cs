using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class todoForm : Form
    {
        public todoForm()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;
        bool isCompleted = false;
        bool isUrgent = false;

        private void todoForm_Load(object sender, EventArgs e)
        {
            //Create columns
            todoList.Columns.Add("Task Name");
            todoList.Columns.Add("Description");
            todoList.Columns.Add("is Complete?");
            todoList.Columns.Add("is Urgent?");
            todoList.Columns.Add("Due Date");


            //Pass datasource to datagridview
            todoListView.DataSource = todoList;

            saveBtn.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)

        {
            if (isEditing)
            {
                todoList.Rows[todoListView.CurrentCell.RowIndex]["Task Name"] = textInput.Text;
                todoList.Rows[todoListView.CurrentCell.RowIndex]["Description"] = descInput.Text;
                todoList.Rows[todoListView.CurrentCell.RowIndex]["is Complete?"] = completeChkBox.Checked;
                todoList.Rows[todoListView.CurrentCell.RowIndex]["is Urgent?"] = urgentChkBox.Checked;
                todoList.Rows[todoListView.CurrentCell.RowIndex]["Due Date"] = datePicker.Text;
            }
            else {

               todoList.Rows.Add(textInput.Text, descInput.Text, isCompleted, isUrgent, datePicker.Text);

            }
            //Clear Textbox

            textInput.Text = "";
            descInput.Text = "";
            completeChkBox.Checked = false;
            urgentChkBox.Checked = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            isCompleted = false;
            isUrgent = false;
            textInput.Text = "";
            descInput.Text = "";
            completeChkBox.Checked = isCompleted; 
            urgentChkBox.Checked = isUrgent;
  
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            textInput.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descInput.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
            urgentChkBox.Checked = Convert.ToBoolean(todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[3].ToString());
            datePicker.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[4].ToString();
            completeChkBox.Checked = Convert.ToBoolean(todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[2].ToString());

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[todoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex);
            }
        }

        private void completeChkBox_CheckedChanged(object sender, EventArgs e)
        {
            isCompleted = true;
        }

        private void urgentChkBox_CheckedChanged(object sender, EventArgs e)
        {
            isUrgent =true;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {    
            if (string.IsNullOrWhiteSpace(textInput.Text))
            {
                saveBtn.Enabled = false;
            }

            saveBtn.Enabled = true;
        }
    }
}
