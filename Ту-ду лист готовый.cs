using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace To_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = taskTextBox.Text;
            if
                (!string.IsNullOrWhiteSpace(task)) //Если строка не нулевая или не только с пробелами - задача добавляется в лист, поле очищается
            {
                taskListBox.Items.Add(task);
                taskTextBox.Clear();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex != -1) //Для удаления нужно выбрать удаляеме действие
            {
                string selectedTask = taskListBox.SelectedItem?.ToString();  // Добавлена проверка на null
                if (!string.IsNullOrEmpty(selectedTask))
                {
                    taskListBox.Items.Remove(selectedTask); //Удаляем


                }
            }
        }

        private void SaveTasksToFile()
        {
            string filePath = "tasks.txt"; // Путь к файлу, в который будем сохранять задачи

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string task in taskListBox.Items)
                {
                    writer.WriteLine(task); // Записываем каждую задачу в новую строку файла
                }
            }

            MessageBox.Show("Список задач сохранен в файл.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveTasksToFile();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
