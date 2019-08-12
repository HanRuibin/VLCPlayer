using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vlc.DotNet.Wpf;

namespace HanTemp.Infrastructure.Interfaces
{
    public interface IVLCPlayer
    {
        void Open(string path);
        VlcControl VlcControl { get; set; }
    }
}
