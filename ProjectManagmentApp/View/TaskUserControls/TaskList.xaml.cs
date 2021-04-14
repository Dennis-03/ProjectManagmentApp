using Gremlin.Net.Process.Traversal;
using ProjectManagmentApp.Data;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ProjectManagmentApp.View.TaskUserControls
{
    public sealed partial class TaskList : UserControl
    {
        public Model.ZTask ZTask { get { return this.DataContext as Model.ZTask; } }

        //UserManager userManager = UserManager.GetUserManager();
        public TaskList()
        {
            this.InitializeComponent();
            //private string assignedTo = userManager.GetUser(ZTaskList.Id);
            this.DataContextChanged += (s, e) => Bindings.Update();
        }
    }
}
