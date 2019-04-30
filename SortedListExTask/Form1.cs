using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedListExTask
{
    public struct Task
    {
        public string Date;
        public string TaskName;

    }
    public partial class Form1 : Form
    {
        public Task task = new Task();
        public List<Task> allTasks = new List<Task>();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void loadTasks()
        {
            //value member stuff?

            lstTasks.Items.Clear();
            foreach (var t in allTasks)
            {
                lstTasks.Items.Add(task.Date);

            }
            

            //lstTasks.DisplayMember = "Date";
            //lstTasks.DataSource = allTasks;
            //lstTasks.ValueMember = "TaskName";



        }
        private void printTaskName(int? ordinal = null)
        {
            var t = allTasks[ordinal.GetValueOrDefault()];
            lblTaskDetails.Text = t.TaskName;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            task.Date = dtpTaskDate.Value.ToString();
            task.TaskName = txtTask.Text.Trim();
            allTasks.Add(task);
            loadTasks();

           //foreach(var t in allTasks)
           // {
           //     MessageBox.Show($"{task.Date} {task.TaskName}");
           // }
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            printTaskName(lstTasks.SelectedIndex);
        }
    }
}
