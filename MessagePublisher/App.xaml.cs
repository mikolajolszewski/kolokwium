﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MessagePublisher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// DO NOT MODIFY THIS FILE
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var d = new MyDispatcher(Dispatcher);
            object vm = new MessagesViewModel(d);
            var window = new MainWindow(vm as IMessagesViewModel);
            window.Show();
        }
    }
}
