using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RelaycommandExample
{
    class MainwindowViewModel
    {
        private ICommand _command;

        public ICommand Command
        {
            get
            {
                return _command ?? (_command = new RelayCommand(
                   x =>
                   {
                       DoStuff();
                   }));
            }

        }

        private static void DoStuff()
        {
            MessageBox.Show("Responding to button click event...");
        }
    }
}
