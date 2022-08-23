using MVVMTemplate.Infrastructure.Commands.Base;
using System.Windows;

namespace MVVMTemplate.Infrastructure.Commands.App
{
    class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
