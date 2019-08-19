using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        //Declare a list of task
        ListOfTask myTaskList = new ListOfTask();

        public Form1()
        {
            InitializeComponent();
            //Add codes to set the configurations for listview
            //set ListView controll to display as a VIEW
            LvTask.View = View.Details;
            //Set ListView control to be selected an e3ntire row instad of single item on ListView
            LvTask.FullRowSelect = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Write code to respond to respond to the "click event"
            //ad a new task to the list
            //1: Get task ID and task description

            int id = Convert.ToInt32(tx_taskID.Text);
            string task = tx_taskDescription.Text;

            //2: Backend: Build a new Task object and add it to the list of tasks
            Task newTask = new Task(id, task);//Create a newTask object
            myTaskList.add(newTask);

            //3: FrontEnd: Add and display new task to the ListView
            //Create an array of 2 elements: "id" and "task description"
            string[] taskInfo = {id.ToString(), task};

            //create an ListViewItem object
            ListViewItem item = new ListViewItem(taskInfo);

            //Add this ListViewItem object to the ListView control/element
            LvTask.Items.Add(item);

            //Clear task id and description on text box
            tx_taskID.Text = "";
            tx_taskDescription.Text = "";

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Write codes to respond to event: clicking the update button
            //1: Retrieve the selected row (task) on ListVeiw Control.
            string id = tx_taskID.Text;//Get id = first column
            string taskDescription = tx_taskDescription.Text;//Get task description = second column
            //2: Backend: Update the selected task on MyTaskList
            //Buld the updateTask object
            Task updateTask = new Task(Convert.ToInt32(id), taskDescription);
            //update Task
            myTaskList.update(updateTask);//call to execute the update() method in the ListOfTask class.
            //3: Frontend: Update ListView Control
            LvTask.SelectedItems[0].SubItems[0].Text = tx_taskID.Text;
            LvTask.SelectedItems[0].SubItems[1].Text = tx_taskDescription.Text;

            tx_taskID.Text = "";
            tx_taskDescription.Text = "";
        }

        private void LvTask_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //When users click a row on ListView control by using Mouse
            //Retrieve selected task info and fill in the textboxes: id and description
            tx_taskID.Text = LvTask.SelectedItems[0].SubItems[0].Text;
            tx_taskDescription.Text = LvTask.SelectedItems[0].SubItems[1].Text;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
         
            string title = "DELETE";
            string message = "Are you sure you weant to delte this task?";

            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //check the answe: Yes or No
            if (result == DialogResult.Yes)
            {
                string id = LvTask.SelectedItems[0].SubItems[0].Text;
                string taskDecription = LvTask.SelectedItems[0].SubItems[1].Text;

                Task deletedTask = new Task(Convert.ToInt32(id), taskDecription);

                myTaskList.delete(deletedTask);

                LvTask.Items.RemoveAt(LvTask.SelectedIndices[0]);

                tx_taskID.Text = "";
                tx_taskDescription.Text = "";
            }
        }
    }
}
