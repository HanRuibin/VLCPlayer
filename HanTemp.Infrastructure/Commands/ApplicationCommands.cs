using Prism.Commands;

namespace HanTemp.Infrastructure.Commands
{
    /// <summary>
    /// static command 可以在xaml中直接绑定
    /// </summary>
    public static class ApplicationCommands
    {
        public static CompositeCommand ShowCommand { get; set; } = new CompositeCommand();
        public static CompositeCommand NavigateCommand { set; get; } = new CompositeCommand();
    }
    public class ApplicationCommandsProxy : Interfaces.IApplicationCommands
    {
        public CompositeCommand ShowCommand
        {
            get
            {
                return ApplicationCommands.ShowCommand;
            }
        }
        public CompositeCommand NavigateCommand
        {
            get { return ApplicationCommands.NavigateCommand; }
        }
    }
}
