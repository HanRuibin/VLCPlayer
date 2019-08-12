using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanTemp.Infrastructure.Interfaces
{
    public interface IFlyoutService
    {
        void ShowFlyout(string obj);
        bool CanShowFlyout(string obj);
    }
}
