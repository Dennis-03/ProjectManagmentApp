﻿using ProjectManagmentApp.Constants;
using ProjectManagmentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Data
{
    class TaskManager
    {
        private static readonly TaskManager _instance = new TaskManager();
        private TaskManager()
        {
        }
        public static TaskManager GetTaskManager()
        {
            return _instance;
        }

        private List<ZTask> TaskList = new List<ZTask>();

        public void AddTask(string taskString,string description, PriorityEnum priority, uint assignedTo, uint assignedBy, DateTime assignedDate, DateTime dueDate)
        {
            ZTask addTask = new ZTask
            {
                TaskName = taskString,
                Description=description,
                AssignedTo = assignedTo,
                AssignedBy = assignedBy,
                AssignedDate = assignedDate,
                DueDate = dueDate,
                Priority = priority
            };

            TaskList.Add(addTask);
        }
        public List<ZTask> ListAllTasks()
        {
            return TaskList;
        }


        public ZTask GetZTask(long Id)
        {
            foreach (var task in TaskList)
            {
                if (task.Id == Id)
                {
                    return task;
                }
            }
            return null;
        }

        public void UpdateTask(ZTask updateTask)
        {
            foreach (var task in TaskList)
            {
                if (task.Id == updateTask.Id)
                {
                    task.Priority = updateTask.Priority;
                    task.AssignedTo = updateTask.AssignedTo;
                    task.AssignedDate = updateTask.AssignedDate;
                    task.TaskName = updateTask.TaskName;
                    task.DueDate = updateTask.DueDate;
                    task.Comment = updateTask.Comment;
                }
            }
        }

        public void DeleteTask(long taskId)
        {
            TaskList.RemoveAll(task => task.Id == taskId);
        }
    }
}
