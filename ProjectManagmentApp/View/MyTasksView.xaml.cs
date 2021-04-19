using ProjectManagmentApp.Data;
using ProjectManagmentApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjectManagmentApp.View
{

    public sealed partial class MyTasksView : Page
    {
        TaskManager taskManager = TaskManager.GetTaskManager();

        private List<ZTask> inCompleteTaskList;
        private List<ZTask> completedTaskList;

        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

        public MyTasksView()
        {
            long userId = (long)localSettings.Values["Id"];
            this.InitializeComponent();
            inCompleteTaskList = new List<ZTask>(taskManager.GetUserTasks(userId));
            completedTaskList = new List<ZTask>(taskManager.GetUserCompletedTasks(userId));
        }

        private void TaskList_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
