using ProjectManagmentApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class TaskData : UserControl
    {
        private SolidColorBrush Zbrush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        public ZTask zTask
        {
            get { return (ZTask)GetValue(zTaskProperty); }
            set { SetValue(zTaskProperty, value); }
        }
        public static readonly DependencyProperty zTaskProperty = DependencyProperty.Register("zTask", typeof(ZTask), typeof(TaskData), null);

        public string AssignedTo
        {
            get { return (string)GetValue(AssignedToProperty); }
            set { SetValue(AssignedToProperty, value); }
        }
        public static readonly DependencyProperty AssignedToProperty = DependencyProperty.Register("AssignedTo", typeof(string), typeof(TaskData), null);

        public string AssignedBy
        {
            get { return (string)GetValue(AssignedByProperty); }
            set { SetValue(AssignedByProperty, value); }
        }
        public static readonly DependencyProperty AssignedByProperty = DependencyProperty.Register("AssignedBy", typeof(string), typeof(TaskData), null);

        public SolidColorBrush PriorityColor
        {
            get { return (SolidColorBrush)GetValue(PriorityColorProperty); }
            set { SetValue(PriorityColorProperty, value); }
        }
        public static readonly DependencyProperty PriorityColorProperty = DependencyProperty.Register("PriorityColor", typeof(SolidColorBrush), typeof(TaskData), null);

        public TaskData()
        {
            this.InitializeComponent();
        }
    }
}
