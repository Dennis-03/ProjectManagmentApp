using ProjectManagmentApp.View;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjectManagmentApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Hamburger_button_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }


        private void Navigation_menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Tasks_menu.IsSelected)
            {
                MainRenderFrame.Navigate(typeof(TaskView));
            }
            if (MyTasks_menu.IsSelected)
            {
                MainRenderFrame.Navigate(typeof(MyTasksView));
            }
            if (CreateTask_menu.IsSelected)
            {
                MainRenderFrame.Navigate(typeof(CreateTaskView));
            }
        }
    }
}
