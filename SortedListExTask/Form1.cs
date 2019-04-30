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
    
    public partial class Form1 : Form
    {
       
        public SortedList<DateTime, string> allTasks = new SortedList<DateTime, string>();
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            
            allTasks.Add(dtpTaskDate.Value, txtTask.Text.Trim());
            lstTasks.Items.Add(dtpTaskDate.Value);
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTaskDetails.Text = allTasks[Convert.ToDateTime(lstTasks.SelectedItem)];
        }
    }
}
