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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TaskDetails : Page
    {
        private ZTask zTask;
        private string assignedTo;
        private string assignedBy;

        UserManager userManager = UserManager.GetUserManager();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            zTask = (ZTask)e.Parameter;
            assignedTo = userManager.GetUser(zTask.AssignedTo).UserName;
            assignedBy = userManager.GetUser(zTask.AssignedBy).UserName;

        }
        public TaskDetails()
        {
            this.InitializeComponent();
        }
    }
}
