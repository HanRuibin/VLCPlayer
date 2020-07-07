using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HimalayaMeidiaPlayer.Utilitys
{
    public class AutoSizeFormClass
    {

        public struct controlRect
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
        }
        public List<controlRect> oldCtrl = new List<controlRect>();
        int ctrlNo = 0;//1;
        public void controllInitializeSize(Control mForm)
        {
            controlRect cR;
            cR.Left = mForm.Left;
            cR.Top = mForm.Top;
            cR.Width = mForm.Width;
            cR.Height = mForm.Height;
            oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可
            AddControl(mForm);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                              //this.WindowState = (System.Windows.Forms.FormWindowState)(2);//记录完控件的初始位置和大小后，再最大化
                              //0 - Normalize , 1 - Minimize,2- Maximize
        }
        private void AddControl(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {  //**放在这里，是先记录控件的子控件，后记录控件本身

                controlRect objCtrl;
                objCtrl.Left = c.Left;
                objCtrl.Top = c.Top;
                objCtrl.Width = c.Width;
                objCtrl.Height = c.Height;
                oldCtrl.Add(objCtrl);

                if (c.Controls.Count > 0)
                    AddControl(c);
            }
        }



        public void controlAutoSize(Control mForm)
        {
            if (ctrlNo == 0)
            {
                controlRect cR;

                cR.Left = 0; cR.Top = 0; cR.Width = mForm.PreferredSize.Width; cR.Height = mForm.PreferredSize.Height;


                oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可
                AddControl(mForm);//窗体内其余控件可能嵌套其它控件(比如panel),故单独抽出以便递归调用
            }
            float wScale = (float)mForm.Width / (float)oldCtrl[0].Width;//新旧窗体之间的比例，与最早的旧窗体
            float hScale = (float)mForm.Height / (float)oldCtrl[0].Height;//.Height;
            ctrlNo = 1;//进入=1，第0个为窗体本身,窗体内的控件,从序号1开始
            AutoScaleControl(mForm, wScale, hScale);
        }
        private void AutoScaleControl(Control ctl, float wScale, float hScale)
        {
            int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
            //int ctrlNo = 1;//第1个是窗体自身的 Left,Top,Width,Height，所以窗体控件从ctrlNo=1开始
            foreach (Control c in ctl.Controls)
            {
                if (!(c is Button)&&!(c is Label))
                {
                    //**放在这里，是先缩放控件的子控件，后缩放控件本身
                    //if (c.Controls.Count > 0)
                    //   AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                    ctrLeft0 = oldCtrl[ctrlNo].Left;
                    ctrTop0 = oldCtrl[ctrlNo].Top;
                    ctrWidth0 = oldCtrl[ctrlNo].Width;
                    ctrHeight0 = oldCtrl[ctrlNo].Height;

                    c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体，所以不能加 + wLeft1
                    c.Top = (int)((ctrTop0) * hScale);//
                    c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 (int)(c.Width * w);
                    c.Height = (int)(ctrHeight0 * hScale);//
                    ctrlNo++;//累加序号
                    //**放在这里，是先缩放控件本身，后缩放控件的子控件
                    if (c.Controls.Count > 0)
                        AutoScaleControl(c, wScale, hScale);
                }
                
            }
        }
    }
}
