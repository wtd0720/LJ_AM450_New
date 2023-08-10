using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaveSystem
{
    class Status
    {
        short sRtn;

        bool bFlagAlarm = false;        // 伺服报警标志
        bool bFlagMError = false;       // 跟随误差越限标志
        bool bFlagPosLimit = false;     // 正限位触发标志
        bool bFlagNegLimit = false;     // 负限位触发标志
        bool bFlagSmoothStop = false;   // 平滑停止标志
        bool bFlagAbruptStop = false;   // 急停标志
        bool bFlagServoOn = false;      // 伺服使能标志
        bool bFlagMotion = false;		// 规划器运动标志
        int iAxisSts;                   // 轴状态

        uint uiClock;                   // 控制器时钟       
        public bool GetServoStatus(short axis)
        {
            // 读取轴状态 
            sRtn = GTN.mc.GTN_GetSts(Pave.CORE, axis, out iAxisSts, 1, out uiClock);
            // commandhandler("GTN_GetSts", sRtn);
            // 伺服报警标志
            if ((iAxisSts & 0x2) != 0)
            {
                bFlagAlarm = true;
                return false;
                //  MessageBox.Show("伺服报警");
            }
            else
            {
                bFlagAlarm = false;
                return true;
                //  MessageBox.Show("伺服正常");
            }
           /* // 跟随误差越限标志
            if ((iAxisSts & 0x10) != 0)
            {
                bFlagMError = true;
                //  MessageBox.Show("运动出错");
            }
            else
            {
                bFlagMError = false;
                //  MessageBox.Show("运动正常");
            }
            // 正向限位
            if ((iAxisSts & 0x20) != 0)
            {
                bFlagPosLimit = true;
                //  MessageBox.Show("正限位触发");
            }
            else
            {
                bFlagPosLimit = false;
                //  MessageBox.Show("正限位未触发");
            }
            // 负向限位
            if ((iAxisSts & 0x40) != 0)
            {
                bFlagNegLimit = true;
                //  MessageBox.Show("负限位触发");
            }
            else
            {
                bFlagNegLimit = false;
                //  MessageBox.Show("负限位未触发");
            }
            // 平滑停止
            if ((iAxisSts & 0x80) != 0)
            {
                bFlagSmoothStop = true;
                //  MessageBox.Show("平滑停止触发");
            }
            else
            {
                bFlagSmoothStop = false;
                // MessageBox.Show("平滑停止未触发");
            }
            // 急停标志
            if ((iAxisSts & 0x100) != 0)
            {
                bFlagAbruptStop = true;
                //  MessageBox.Show("急停触发");
            }
            else
            {
                bFlagAbruptStop = false;
                //  MessageBox.Show("急停未触发");
            }
            // 伺服使能标志
            if ((iAxisSts & 0x200) != 0)
            {
                bFlagServoOn = true;
                //  MessageBox.Show("伺服使能");
            }
            else
            {
                bFlagServoOn = false;
                //  MessageBox.Show("伺服关闭");
            }
            // 规划器正在运动标志
            if ((iAxisSts & 0x400) != 0)
            {
                bFlagMotion = true;
                //  MessageBox.Show("规划器正在运动");
            }
            else
            {
                bFlagMotion = false;
                //  MessageBox.Show("规划器已停止");
            }*/
        }
        void commandhandler(string command, short error)
        {
            if (error != 0)
            {
                MessageBox.Show(command + " = " + error.ToString());
            }
        }

        public double GetPosition(short axis) 
        {
            double dPrfPos;
            GTN.mc.GTN_GetPrfPos(Pave.CORE, axis, out dPrfPos, 1, out uiClock);
            return dPrfPos;
        }

        public double GetSpeed(short axis) 
        {
            double dPrfVel;
            GTN.mc.GTN_GetPrfVel(Pave.CORE, axis, out dPrfVel, 1, out uiClock);
            return dPrfVel;
        }

        public double GetLightPosition(short axis) 
        {
            double dPrfLightPos;
            GTN.mc.GTN_GetEncPos(Pave.CORE, axis, out dPrfLightPos, 1, out uiClock);
            return dPrfLightPos;
        }
        public short GetTorque(short axis) 
        {
            short atlTorque;
            GTN.mc.GTN_GetAtlTorque(Pave.CORE, axis, out atlTorque);
            return atlTorque;
        }
        public int GetClock()
        {
            uint pClock;
            uint pLoop;
            GTN.mc.GTN_GetClock(Pave.CORE, out pClock, out pLoop);
            return MillisecondsToSeconds(Convert.ToInt32(pClock));
        }
        public int MillisecondsToSeconds(int milliseconds)
        {
            int seconds = milliseconds / 1000;
            return seconds;
            
        }
    }
}
