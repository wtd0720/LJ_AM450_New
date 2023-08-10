using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaveSystem
{
    public class Pave
    {
        public const short LFDJ = 0;          //落粉电机
        public const short GDDJ = 1;          //刮刀电机
        public const short HSSJZ = 2;         //活塞升降主
        public const short HSSJC = 3;         //活塞升降从
        public const short DYCPYDJ = 4;       //打印仓平移电机

        short sRtn;
        public const short CORE = 1;         //内核, 正整数
        public const short Method = 1;       //扩展模块检测模式, 默认值为1, 自动检测扩展模块类型，并根据扩展模块类型自动映射输入输出资源;                                     

        public Pave()
        {
            Connect(0, 1); 
        }

        ~Pave()
        {
            DisConnect();
        }
    
        public bool Connect(short channel, short param)
        {
            // 打开运动控制器
            try
            {
                sRtn = GTN.mc.GTN_Open(channel, param);
                if (sRtn == 0)
                {
                    MessageBox.Show("连接成功");
                    short bRtn;
                    bRtn = GTN.mc.GTN_Reset(CORE);
                    if (bRtn == 0)
                    {
                        MessageBox.Show("复位成功");                      
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("GTN_Reset = " + bRtn.ToString());
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("GTN_Open = " + sRtn.ToString());
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        public void DisConnect()
        {
            // 关闭运动控制器         
            sRtn = GTN.mc.GTN_Close();
            commandhandler("GTN_Close", sRtn);
        }
        /// <summary>
        /// 按键按下启动正向运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="vel"></param>
        /// <param name="acc"></param>
        /// <param name="dec"></param>
        /// <param name="smooth"></param>
        public void MoveForwardDown(short axis, double vel, double acc, double dec, double smooth)
        {
            GTN.mc.TJogPrm jog;
            jog.acc = acc; //加速度,正数
            jog.dec = dec; //减速度，正数，未设置减速度时，默认减速度和加速度相同
            jog.smooth = smooth; //平滑系数。取值范围：[0, 1)。平滑系数的数值越大，加减速过程越平稳。
            sRtn = GTN.mc.GTN_PrfJog(CORE, axis); // 设置为Jog运动模式
            commandhandler("GTN_PrfJog", sRtn);
            sRtn = GTN.mc.GTN_SetJogPrm(CORE, axis, ref jog); // 设置Jog运动参数
            commandhandler("GTN_SetJogPrm", sRtn);
            sRtn = GTN.mc.GTN_SetVel(CORE, axis, vel);  // 设置目标速度
            commandhandler("GTN_SetVel", sRtn);
            sRtn = GTN.mc.GTN_Update(CORE, 1 << (axis - 1));    // 更新轴运动
            commandhandler("GTN_Update", sRtn);
        }
        /// <summary>
        /// 按键抬起停止正向运功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MoveForwardUp(short axis)
        {
            sRtn = GTN.mc.GTN_Stop(CORE, 1 << (axis - 1), 0);   // 平滑停止
            commandhandler("GTN_Stop", sRtn);
        }
        /// <summary>
        /// 按键按下启动负向运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="vel"></param>
        /// <param name="acc"></param>
        /// <param name="dec"></param>
        /// <param name="smooth"></param>
        public void MoveBackDown(short axis, double vel, double acc, double dec, double smooth)
        {
            GTN.mc.TJogPrm jog;
            jog.acc = acc;
            jog.dec = dec;
            jog.smooth = smooth;
            sRtn = GTN.mc.GTN_PrfJog(CORE, axis); // 设置为Jog运动模式
            commandhandler("GTN_PrfJog", sRtn);
            sRtn = GTN.mc.GTN_SetJogPrm(CORE, axis, ref jog); // 设置Jog运动参数
            commandhandler("GTN_SetJogPrm", sRtn);
            sRtn = GTN.mc.GTN_SetVel(CORE, axis, -vel);  // 设置目标速度
            commandhandler("GTN_SetVel", sRtn);
            sRtn = GTN.mc.GTN_Update(CORE, 1 << (axis - 1));    // 更新轴运动
            commandhandler("GTN_Update", sRtn);
        }
        /// <summary>
        /// 按键抬起停止负向运功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MoveBackUp(short axis)
        {
            sRtn = GTN.mc.GTN_Stop(CORE, 1 << (axis - 1), 0);   // 平滑停止
            commandhandler("GTN_Stop", sRtn);
        }
        /// <summary>
        /// 定速定长运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="vel"></param>
        /// <param name="pos"></param>
        /// <param name="acc"></param>
        /// <param name="dec"></param>
        /// <param name="smoothTime"></param>
        public void MotionWorkRunVL(short axis, double vel, int pos, double acc, double dec, short smoothTime)
        {
            GTN.mc.TTrapPrm trap;
            trap.acc = acc;
            trap.dec = dec;
            trap.smoothTime = smoothTime;
            trap.velStart = 0;
            sRtn = GTN.mc.GTN_PrfTrap(CORE, axis); // 设置为点位运动模式
            commandhandler("GTN_PrfTrap", sRtn);
            sRtn = GTN.mc.GTN_SetTrapPrm(CORE, axis, ref trap); // 设置点位运动参数
            commandhandler("GTN_SetTrapPrm", sRtn);
            sRtn = GTN.mc.GTN_SetVel(CORE, axis, vel);  // 设置目标速度
            commandhandler("GTN_SetVel", sRtn);
            sRtn = GTN.mc.GTN_SetPos(CORE, axis, pos);  // 设置目标位置
            commandhandler("GTN_SetPos", sRtn);
            sRtn = GTN.mc.GTN_Update(CORE, 1 << (axis - 1));    // 更新轴运动
            commandhandler("GTN_Update", sRtn);
        }
        /// <summary>
        /// 停止运动
        /// </summary>
        /// <param name="axis"></param>
        public void StopMovement(short axis)
        {
            sRtn = GTN.mc.GTN_Stop(CORE, 1 << (axis - 1), 0);   // 平滑停止
            commandhandler("GTN_Stop", sRtn);
        }
        /// <summary>
        /// 回零
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="count"></param>
        public void ReturnToZero(short axis, short count)
        {
            sRtn = GTN.mc.GTN_ZeroPos(CORE, axis, count);//若为1和8， 则把1-8轴的位置回零
            commandhandler("GTN_ZeroPos", sRtn);
        }
        /// <summary>
        /// 该函数检测某条GT指令的执行结果
        /// </summary>
        /// <param name="command">command为指令名称</param>
        /// <param name="error">error为指令执行返回值</param>
        void commandhandler(string command, short error)
        {
            if (error != 0)
            {
                MessageBox.Show(command + " = " + error.ToString());
            }
        }
    }
}
