using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxCNxMediaPlayerDCOMForActiveXLib;

namespace HimalayaMeidiaPlayer.BLL
{
    public class PlayerActions
    {
        private AxCNxMediaPlayer Player { get; set; }
        public PlayerActions(AxCNxMediaPlayer player)
        {
            this.Player = player;
        }
        public bool Open(string path)
        {
            try
            {
                Player.Close();
                Player.Open(path, 0, 0);
                Player.PlayFromTo(0, 1);
                //Player.Pause();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
