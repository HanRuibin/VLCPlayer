using Prism.Events;
using HanTemp.Infrastructure.Models;

namespace HanTemp.Infrastructure.Events
{
    public class AddPlayListEvent:PubSubEvent<PlayListModel>
    {
    }
}
