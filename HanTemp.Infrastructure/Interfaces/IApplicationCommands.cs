using Prism.Commands;

namespace HanTemp.Infrastructure.Interfaces
{
    public interface IApplicationCommands
    {
        CompositeCommand ShowCommand { get; }
        CompositeCommand NavigateCommand { get; }
    }
}
