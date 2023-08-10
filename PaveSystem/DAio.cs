using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaveSystem
{
    class DAio
    {
        //HCB5-1616-DTS01 编号1-4  
        //HCB5-3200-DXX   编号5
        //HCB5-0604-A1601 编号6-9
        // 数字量模块 96个输入 64个输出
        // 模拟量模块 24个输入 没有输出

        short rtn;

        public DAio() 
        {
            rtn = GTN.mc.GTN_ExtModuleInit(Pave.CORE , Pave.Method);
            if (rtn == 0) 
            {
                MessageBox.Show("初始化扩展模块成功");
            }
            else 
            {
                MessageBox.Show("初始化扩展模块失败");
            }
        }

        /// <summary>
        /// 按位设置 DO 输出值
        /// </summary>
        /// <param name="doIndex">输出DO索引，从1开始。</param>
        /// <param name="value">输出值，0：设置输出为低电平， 1：设置输出为高电平。</param>
        public void SetDoBit(short doIndex, short value) 
        {
            rtn =GTN.mc.GTN_SetExtDoBit(Pave.CORE, doIndex, value);
            if (rtn == 0)
            {
                MessageBox.Show("设置第" + doIndex +  "路的DO为" + value + "成功");
            }
            else
            {
                MessageBox.Show("设置第" + doIndex +  "路的DO为" + value + "失败" + "rtn = " + rtn);
            }
        }


        //设置 DO 输出值，可以按位设置(GTN_SetExtDoBit)，也可以直接设置32位(GTN_SetExtDo)
        //因为有64个数字输出，所以直接用GTN_SetExtDo
        //
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doIndex">输出DO的起始索引，从1开始</param>
        /// <param name="value">0：设置输出为低电平，1：设置输出为高电平。</param>
        /// <param name="mask">0：表示无数字量输出操作，1：表示有数字量输出操作</param>
        public void SetDo(short doIndex, int value, int mask) 
        {
            rtn = GTN.mc.GTN_SetExtDo(Pave.CORE, doIndex, value, mask);
            short endIndex = (short)(doIndex + 31);
            if (rtn == 0) 
            {
                MessageBox.Show("设置第" + doIndex + "路至" + endIndex + "路的DO为" + value + "成功");
            }
            else 
            {
                MessageBox.Show("设置第" + doIndex + "路至" + endIndex + "路的DO为" + value + "失败" + "rtn = " + rtn);
            }
        }
        /// <summary>
        /// 读取 DO 输出值
        /// 输出 do 的数值（以 diIndex 为起始索引连续 32 路 DO 输入）
        /// 备注：读取的用户设置值，而不是实际硬件输出值
        /// 0：输出为低电平， 1：输出为高电平。
        /// </summary>
        /// <param name="doIndex"></param>
        /// <returns></returns>
        public int GetDo(short doIndex) 
        {
            int pValue;
            short endIndex = (short)(doIndex + 31);
            rtn = GTN.mc.GTN_GetExtDo(Pave.CORE, doIndex, out pValue);
            if (rtn == 0)
            {
                MessageBox.Show("读取第" + doIndex + "路至" + endIndex + "路的DO为" + pValue + "成功");
            }
            else
            {
                MessageBox.Show("读取第" + doIndex + "路至" + endIndex + "路的DO为" + pValue + "失败" + "rtn = " + rtn);
            }
            return pValue;
        }

        public int GetDoBit(short doIndex)
        {
            short pValue;
            rtn = GTN.mc.GTN_GetExtDoBit(Pave.CORE, doIndex, out pValue);
            if (rtn == 0)
            {
                MessageBox.Show("读取第" + doIndex +  "路的DO为" + pValue + "成功");
            }
            else
            {
                MessageBox.Show("读取第" + doIndex +  "路的DO为" + pValue + "失败" + "rtn = " + rtn);
            }
            return pValue;
        }

        /// <summary>
        /// 读取输入 DI 数值
        /// </summary>
        /// <param name="diIndex">输入 DI 起始索引，从 1 开始。</param>
        /// <returns></returns>
        public int GetDi(short diIndex)
        {
            int pValue;
            short endIndex = (short)(diIndex + 31);
            rtn = GTN.mc.GTN_GetExtDi(Pave.CORE, diIndex,out pValue);
            if (rtn == 0)
            {
                MessageBox.Show("读取第" + diIndex + "路至" + endIndex + "路的DI为" + pValue + "成功");
            }
            else
            {
                MessageBox.Show("读取第" + diIndex + "路至" + endIndex + "路的DI为" + pValue + "失败" + "rtn = " + rtn);
            }
            return pValue;
        }
        public int GetDiBit(short diIndex)
        {
            short pValue;
            rtn = GTN.mc.GTN_GetExtDiBit(Pave.CORE, diIndex, out pValue);
            if (rtn == 0)
            {
                MessageBox.Show("读取第" + diIndex + "路的DI为" + pValue + "成功");
            }
            else
            {
                MessageBox.Show("读取第" + diIndex +  "路的DI为" + pValue + "失败" + "rtn = " + rtn);
            }
            return pValue;
        }
        /// <summary>
        /// 设置模拟量输出
        /// </summary>
        /// <param name="aoIndex"></param>
        public void SetAo(short aoIndex ,double aoValue)
        {
            //最后1代表读取电压个数
            rtn = GTN.mc.GTN_SetExtAo(Pave.CORE, aoIndex, ref aoValue, 1);
            if (rtn == 0)
            {
                MessageBox.Show("设置第" + aoIndex + "路的AO为" + aoValue + "成功");
            }
            else
            {
                MessageBox.Show("设置第" + aoIndex + "路的AO为" + aoValue + "失败" + "rtn = " + rtn);
            }
        }
        /// <summary>
        /// 读取模拟量输出电压
        /// </summary>
        /// <param name="aoIndex"></param>
        /// <returns></returns>
        public double GetAo(short aoIndex) 
        {
            double pValue;
            //最后1代表读取通道的总数
            rtn = GTN.mc.GTN_GetExtAo(Pave.CORE, aoIndex, out pValue, 1);
            if (rtn == 0)
            {
                MessageBox.Show("读取第" + aoIndex + "路的AO为" + pValue + "成功");
            }
            else
            {
                MessageBox.Show("读取第" + aoIndex + "路的AO为" + pValue + "失败" + "rtn = " + rtn);
            }
            return pValue;
        }

        public double GetAi(short aiIndex)
        {
            double pValue;
            //最后1代表读取通道的总数
            GTN.mc.GTN_GetExtAi(Pave.CORE, aiIndex, out pValue, 1);
            if (rtn == 0)
            {
                MessageBox.Show("读取第" + aiIndex + "路的AI为" + pValue + "成功");
            }
            else
            {
                MessageBox.Show("读取第" + aiIndex + "路的AI为" + pValue + "失败" + "rtn = " + rtn);
            }
            return pValue;
        }
    }
}
