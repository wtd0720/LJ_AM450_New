using System;
using System.Runtime.InteropServices;

namespace GTN
{ 
	/*-----------------------------------------------------------*/
	/*ԭgts.cs����������ָ��                                      */
	/*-----------------------------------------------------------*/
    public class mc
    {
        /*-----------------------------------------------------------*/
        /* Channel of Command                                        */
        /*-----------------------------------------------------------*/
        public const short CHANNEL_HOST = 0;
        public const short CHANNEL_UART = 1;
        public const short CHANNEL_SIM = 2;
        public const short CHANNEL_ETHER = 3;
        public const short CHANNEL_RS232 = 4;
        public const short CHANNEL_PCIE = 5;
        public const short CHANNEL_RINGNET = 6;
        /*-----------------------------------------------------------*/
        /* Error Code                                                */
        /*-----------------------------------------------------------*/

        public const short CMD_SUCCESS = 0;

        public const short CMD_ERROR_READ_LEN = -2;                 /* read data length error */
        public const short CMD_ERROR_READ_CHECKSUM = -3;            /* checksum error */

        public const short CMD_ERROR_WRITE_BLOCK = -4;              /* write pci fail */
        public const short CMD_ERROR_READ_BLOCK = -5;               /* read pci fail */

        public const short CMD_ERROR_OPEN = -6;                     /* error to open device */
        public const short CMD_ERROR_CLOSE = -6;                    /* error to close device */
        public const short CMD_ERROR_DSP_BUSY = -7;                 /* DSP busy */

        public const short CMD_LOCK_ERROR = -8;                     /* multi-thread lock error */
        public const short CMD_DMA_ERROR = -9;                      /* dma transmission error */    
        public const short CMD_COMM_ERROR = -10;                    /* pcie comm error */
        public const short CMD_LOAD_RINGNET_DLL_ERROR = -11;        /* load ringnet dll error */
        public const short CMD_RINGNET_STIME_ERROR = -12;           /* load ringnet dll error */

        public const short CMD_RINGNET_ENC0_ERROR = -13;            /* core1 encoder initial error */
		public const short CMD_RINGNET_ENC1_ERROR = -14;            /* core2 encoder initial error */

        public const short CMD_LOAD_RINGNET_ERROR = -17;             /* ringnet API load error */
        public const short CMD_MCVERSION_MATCH_ERROR = -15;          /* dll error,need to update dll */
		public const short CMD_LOCK_NULL = -20;                      /* multithreading open handle error */
        public const short CMD_MCVERSION_MATCH_WARNING = 15;         /* dll error,without some functions */
        public const short CMD_DSPVERSION_MATCH_WARNING = 16;        /* dsp is too old */

		public const short CMD_FILE_MATCH_WARNING = 17;              /* config file format or data error */

        public const short CMD_ERROR_EXECUTE = 1;
        public const short CMD_ERROR_VERSION_NOT_MATCH = 3;
        public const short CMD_ERROR_PARAMETER= 7;
        public const short CMD_ERROR_UNKNOWN = 8;                    /* unspported command */

        public const short MC_NONE  = -1;

        public const short MC_LIMIT_POSITIVE = 0;
        public const short MC_LIMIT_NEGATIVE = 1;
        public const short MC_ALARM  = 2;
        public const short MC_HOME  = 3;
        public const short MC_GPI = 4;
        public const short MC_ARRIVE = 5;
        public const short MC_EGPI0 = 6;
//      public const short MC_EGPI1 = 7;
//      public const short MC_EGPI2 = 8;
        public const short MC_MPG = 9;

        public const short MC_ENABLE = 10;
        public const short MC_CLEAR = 11;
        public const short MC_GPO  = 12;
//      public const short MC_EGPO0 = 13;
//      public const short MC_EGPO1 = 14;
        public const short MC_AU_ADC = 17;
        public const short MC_HSO = 18;
        public const short MC_AU_DAC = 19;

        public const short MC_DAC = 20;
        public const short MC_STEP  = 21;
        public const short MC_PULSE = 22;
        public const short MC_ENCODER = 23;
        public const short MC_ADC = 24;

        public const short MC_AU_ENCODER = 26;

        public const short MC_ABS_ENCODER = 29;

        public const short MC_AXIS = 30;
        public const short MC_PROFILE = 31;
        public const short MC_CONTROL = 32;

        public const short MC_TRIGGER = 40;

        public const short MC_AU_TRIGGER = 44;

        public const short MC_TERMINAL = 50;
        public const short MC_MPG_ENCODER = 53;
        public const short MC_EXT_MODULE = 60;
        public const short MC_EXT_DI = 61;
        public const short MC_EXT_DO = 62;
        public const short MC_EXT_AI = 63;
        public const short MC_EXT_AO = 64;

        public const short MC_SCAN_CRD  = 70;
        public const short MC_LASER	= 71;
        public const short MC_LASER_AO = 72;

        public const short MC_POS_COMPARE = 80;

        public const short MC_WATCH_VAR = 200;
        public const short MC_WATCH_EVENT = 201;
        public struct TVersion
        {
            public short year;
            public short month;
            public short day;
            public short version;
            public short user;
            public short reserve1;
            public short reserve2;
            public short chip;
         } 
        public const short CORE_MODE_TIMER = 0;
        public const short CORE_MODE_SYNCH = 1;
        public const short CORE_MODE_EXTERNAL =	2;

        public const short CORE_TASK_DEFAULT = 0;
        public const short CORE_TASK_DLM = 1;

        public const short SKIP_MODULE_SCAN	= 0x001;
        public const short SKIP_MODULE_POS_COMPARE = 0x002;
        public const short SKIP_MODULE_CRD = 0x004;

        public const short SKIP_MODULE_PLC = 0x010;
        public const short SKIP_MODULE_DLM = 0x020;

        public const short SKIP_MODULE_AXIS_CALCULATE = 0x100;

        public const short SKIP_MODULE_WATCH = 0x800;

        public enum ETimeElapse
        {
	        TIME_ELAPSE_PROFILE = 1000,

	        TIME_ELAPSE_HOST_COMMAND_EXECUTE = 1220,
	        TIME_ELAPSE_ETHER_COMMAND_EXECUTE,

	        TIME_ELAPSE_PROFILE_CALCULATE = 6000,

	        TIME_ELAPSE_SCAN = 18000,

	        TIME_ELAPSE_AXIS_CHECK = 20000,
	        TIME_ELAPSE_AXIS_CALCULATE,

	        TIME_ELAPSE_ENCODER = 30000,

	        TIME_ELAPSE_DI = 31000,

	        TIME_ELAPSE_DO = 32000,

	        TIME_ELAPSE_AI = 33000,

	        TIME_ELAPSE_AO = 34000,

	        TIME_ELAPSE_TRIGGER = 38000,

	        TIME_ELAPSE_CONTROL = 40000,

	        TIME_ELAPSE_WATCH = 52000,

	        TIME_ELAPSE_TERMINAL = 53000,
            TIME_ELAPSE_TERMINALDET = 54000,
       } 
       
        public struct TPid
        {
	            public double kp;
	            public double ki;
	            public double kd;
	            public double kvff;
	            public double kaff;
	            public Int32   IntegralLimit;
	            public Int32   derivativeLimit;
	            public short  limit;
         }
        /*-----------------------------------------------------------*/
        /* Basic function                                            */
        /*-----------------------------------------------------------*/
        [DllImport("gts.dll")]
        public static extern short GT_SetCardNo(short index);
        [DllImport("gts.dll")]
        public static extern short GT_GetCardNo(out short index);
        [DllImport("gts.dll")]
        public static extern short GT_Open(short channel,short param);
        [DllImport("gts.dll")]
        public static extern short GT_Close();
        [DllImport("gts.dll")]
        public static extern short GT_SetCore(short core);
        [DllImport("gts.dll")]
        public static extern short GT_GetCore(out short pCore);
        [DllImport("gts.dll")]
        public static extern short GT_GetVersion(out System.IntPtr pVersion);
        [DllImport("gts.dll")]
        public static extern short GT_GetVersionEx(short type,out TVersion pVersion);
        [DllImport("gts.dll")]
        public static extern short GT_Reset();
        [DllImport("gts.dll")]
        public static extern short GT_GetClock(out UInt32 pClock, out UInt32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_GetClockHighPrecision(out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_ClearTime(ETimeElapse item);
        [DllImport("gts.dll")]
        public static extern short GT_GetTime(ETimeElapse item, out UInt32 pTime, out UInt32 pTimeMax, out UInt32 pValue);
        [DllImport("gts.dll")]
        public static extern short GT_GetSts(short axis, out Int32 pSts, short count, out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_ClrSts(short axis,short count);
        [DllImport("gts.dll")]
        public static extern short GT_AxisOn(short axis);
        [DllImport("gts.dll")]
        public static extern short GT_AxisOff(short axis);
        [DllImport("gts.dll")]
        public static extern short GT_MultiAxisOn(UInt32 mask);
        [DllImport("gts.dll")]
        public static extern short GT_MultiAxisOff(UInt32 mask);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisOnDelayTime(ushort ms);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisOnDelayTime(out ushort pMs);
        [DllImport("gts.dll")]
        public static extern short GT_Stop(Int32 mask, Int32 option);
        [DllImport("gts.dll")]
        public static extern short GT_SetPrfPos(short profile, Int32 prfPos);
        [DllImport("gts.dll")]
        public static extern short GT_SynchAxisPos(Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GT_ZeroPos(short axis,short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetLimitStatus(short axis,out short pLimitPositive,out short pLimitNegative);
        [DllImport("gts.dll")]
        public static extern short GT_SetSoftLimitMode(short axis,short mode);
        [DllImport("gts.dll")]
        public static extern short GT_GetSoftLimitMode(short axis,out short pMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetSoftLimit(short axis, Int32 positive, Int32 negative);
        [DllImport("gts.dll")]
        public static extern short GT_GetSoftLimit(short axis, out Int32 pPositive, out Int32 pNegative);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisBand(short axis, Int32 band, Int32 time);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisBand(short axis, out Int32 pBand, out Int32 pTime);
        [DllImport("gts.dll")]
        public static extern short GT_GetPrfPos(short profile, out double Value, short count, out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetPrfVel(short profile,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetPrfAcc(short profile,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetPrfMode(short profile, out Int32 pValue, short count, out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisPrfPos(short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisPrfPosCompensate(short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisPrfVel(short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisPrfAcc(short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisEncPos(short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisEncVel(short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisEncAcc(short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisError(short axis,out double pValue, short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_SetControlFilter(short control,short index);
        [DllImport("gts.dll")]
        public static extern short GT_GetControlFilter(short control,out short pIndex);
        [DllImport("gts.dll")]
        public static extern short GT_SetControlSuperimposed(short control,short superimposedType,short superimposedIndex);
        [DllImport("gts.dll")]
        public static extern short GT_GetControlSuperimposed(short control,out short pSuperimposedType,out short pSuperimposedIndex);
        [DllImport("gts.dll")]
        public static extern short GT_SetPid(short control,short index,ref TPid pPid);
        [DllImport("gts.dll")]
        public static extern short GT_GetPid(short control,short index,out TPid pPid);
        [DllImport("gts.dll")]
        public static extern short GT_SetKvffFilter(short control,short index,short kvffFilterExp,double accMax);
        [DllImport("gts.dll")]
        public static extern short GT_GetKvffFilter(short control,short index,out short pKvffFilterExp,out double pAccMax);
        [DllImport("gts.dll")]
        public static extern short GT_Delay(ushort ms);
        [DllImport("gts.dll")]
        public static extern short GT_DelayHighPrecision(ushort profile);
        
        [DllImport("gts.dll")]
        public static extern short GTN_Open(short channel,short param);
        [DllImport("gts.dll")]
        public static extern short GTN_OpenRingNet(short channel,short param,string pFile,short index,Int32 count);
        [DllImport("gts.dll")]
        public static extern short GTN_Close();
        [DllImport("gts.dll")]
        public static extern short GTN_GetChannel(out short pChannel);
        [DllImport("gts.dll")]
        public static extern short GTN_GetVersion(short core,out string pVersion);
        [DllImport("gts.dll")]
        public static extern short GTN_GetVersionEx(short core,short type,out TVersion pVersion);
        [DllImport("gts.dll")]
        public static extern short GTN_SetVersion(short core,short type,ref TVersion pVersion);
        [DllImport("gts.dll")]
        public static extern short GTN_Reset(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_GetClock(short core, out UInt32 pClock, out UInt32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetClockHighPrecision(short core,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearTime(short core,ETimeElapse item);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTime(short core, ETimeElapse item, out UInt32 pTime, out UInt32 pTimeMax, out UInt32 pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCoreMode(short core,short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCoreMode(short core,out short pMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCoreShare(short core,short type,short index,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCoreShare(short core,short type,out short pIndex,out short pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCoreTask(short core,short task);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCoreTask(short core,out short pTask);
        [DllImport("gts.dll")]
        public static extern short GTN_GetResMax(short core,short type,out short pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_SetResCount(short core,short type,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetResCount(short core,short type,out short pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetSts(short core,short axis,out Int32 pSts,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_ClrSts(short core,short axis,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_AxisOn(short core,short axis);
        [DllImport("gts.dll")]
        public static extern short GTN_AxisOff(short core,short axis);
        [DllImport("gts.dll")]
        public static extern short GTN_MultiAxisOn(short core,UInt32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_MultiAxisOff(short core, UInt32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisOnDelayTime(short core,ushort delayTime);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisOnDelayTime(short core,out ushort pDelayTime);
        [DllImport("gts.dll")]
        public static extern short GTN_Stop(short core, Int32 mask, Int32 option);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPrfPos(short core, short profile, Int32 prfPos);
        [DllImport("gts.dll")]
        public static extern short GTN_SynchAxisPos(short core, Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_ZeroPos(short core,short axis,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetLimitStatus(short core,short axis,out short pLimitPositive,out short pLimitNegative);
        [DllImport("gts.dll")]
        public static extern short GTN_SetSoftLimitMode(short core,short axis,short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetSoftLimitMode(short core,short axis,out short pMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetSoftLimit(short core, short axis, Int32 positive, Int32 negative);
        [DllImport("gts.dll")]
        public static extern short GTN_GetSoftLimit(short core, short axis, out Int32 pPositive, out Int32 pNegative);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisBand(short core, short axis, Int32 band, Int32 time);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisBand(short core, short axis, out Int32 pBand, out Int32 pTime);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPrfPos(short core,short profile,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPrfVel(short core,short profile,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPrfAcc(short core,short profile,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPrfMode(short core,short profile,out Int32 pValue, short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisPrfPos(short core,short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisPrfPosCompensate(short core,short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisPrfVel(short core,short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisPrfAcc(short core,short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisEncPos(short core,short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisEncVel(short core,short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisEncAcc(short core,short axis,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisError(short core,short axis,out double pValue, short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_SetControlFilter(short core,short control,short index);
        [DllImport("gts.dll")]
        public static extern short GTN_GetControlFilter(short core,short control,out short pIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_SetControlSuperimposed(short core,short control,short superimposedType,short superimposedIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_GetControlSuperimposed(short core,short control,out short pSuperimposedType,out short pSuperimposedIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPid(short core,short control,short index,ref TPid pPid);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPid(short core,short control,short index,out TPid pPid);
        [DllImport("gts.dll")]
        public static extern short GTN_SetKvffFilter(short core,short control,short index,short kvffFilterExp,double accMax);
        [DllImport("gts.dll")]
        public static extern short GTN_GetKvffFilter(short core,short control,short index,out short pKvffFilterExp,out double pAccMax);
        [DllImport("gts.dll")]
        public static extern short GTN_Delay(short core,ushort ms);
        [DllImport("gts.dll")]
        public static extern short GTN_DelayHighPrecision(short core,ushort profile);

        public const short STEP_DIR  = 0;
        public const short STEP_PULSE = 1;
        public const short STEP_ORTHOGONAL = 2;

        [DllImport("gts.dll")]
        public static extern short GT_LoadConfig(string pFile);
        [DllImport("gts.dll")]
        public static extern short GT_AlarmOff(short axis);
        [DllImport("gts.dll")]
        public static extern short GT_AlarmOn(short axis);
        [DllImport("gts.dll")]
        public static extern short GT_LmtsOn(short axis,short limitType);
        [DllImport("gts.dll")]
        public static extern short GT_LmtsOff(short axis,short limitType);
        [DllImport("gts.dll")]
        public static extern short GT_StepDir(short step);
        [DllImport("gts.dll")]
        public static extern short GT_StepPulse(short step);
        [DllImport("gts.dll")]
        public static extern short GT_StepOrthogonal(short step);
        [DllImport("gts.dll")]
        public static extern short GT_SetMtrBias(short dac,short bias);
        [DllImport("gts.dll")]
        public static extern short GT_GetMtrBias(short dac,out short pBias);
        [DllImport("gts.dll")]
        public static extern short GT_SetMtrLmt(short dac,short limit);
        [DllImport("gts.dll")]
        public static extern short GT_GetMtrLmt(short dac,out short pLimit);
        [DllImport("gts.dll")]
        public static extern short GT_EncOn(short encoder);
        [DllImport("gts.dll")]
        public static extern short GT_EncOff(short encoder);
        [DllImport("gts.dll")]
        public static extern short GT_SetPosErr(short control,Int32 error);
        [DllImport("gts.dll")]
        public static extern short GT_GetPosErr(short control, out Int32 pError);
        [DllImport("gts.dll")]
        public static extern short GT_SetStopDec(short profile,double decSmoothStop,double decAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_GetStopDec(short profile,out double pDecSmoothStop,out double pDecAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_CtrlMode(short axis,short mode);
        [DllImport("gts.dll")]
        public static extern short GT_SetStopIo(short axis,short stopType,short inputType,short inputIndex);
        [DllImport("gts.dll")]
        public static extern short GT_SetAdcFilterPrm(short adc,double k);
        [DllImport("gts.dll")]
        public static extern short GT_GetAdcFilterPrm(short adc,out double pk);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisPrfVelFilter(short axis,short filterNumExp);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisPrfVelFilter(short axis,out short pFilterNumExp);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisEncVelFilter(short axis,short filterNumExp);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisEncVelFilter(short axis,out short pFilterNumExp);
        [DllImport("gts.dll")]
        public static extern short GT_SetProfileScale(short i, Int32 alpha, Int32 beta);
        [DllImport("gts.dll")]
        public static extern short GT_GetProfileScale(short i, out Int32 pAlhpa, out Int32 pBeta);
        [DllImport("gts.dll")]
        public static extern short GT_SetEncoderScale(short i, Int32 alpha, Int32 beta);
        [DllImport("gts.dll")]
        public static extern short GT_GetEncoderScale(short i, out Int32 pAlhpa, out Int32 pBeta);
        
        
        [DllImport("gts.dll")]
        public static extern short GTN_LoadConfig(short core,string pFile);
        [DllImport("gts.dll")]
        public static extern short GTN_AlarmOn(short core,short axis);
        [DllImport("gts.dll")]
        public static extern short GTN_AlarmOff(short core,short axis);
        [DllImport("gts.dll")]
        public static extern short GTN_LmtsOn(short core,short axis,short limitType);
        [DllImport("gts.dll")]
        public static extern short GTN_LmtsOff(short core,short axis,short limitType);
        [DllImport("gts.dll")]
        public static extern short GTN_StepDir(short core,short step);
        [DllImport("gts.dll")]
        public static extern short GTN_StepPulse(short core,short step);
        [DllImport("gts.dll")]
        public static extern short GTN_StepOrthogonal(short core,short step);
        [DllImport("gts.dll")]
        public static extern short GTN_SetMtrBias(short core,short dac,short bias);
        [DllImport("gts.dll")]
        public static extern short GTN_GetMtrBias(short core,short dac,out short pBias);
        [DllImport("gts.dll")]
        public static extern short GTN_SetMtrLmt(short core,short dac,short limit);
        [DllImport("gts.dll")]
        public static extern short GTN_GetMtrLmt(short core,short dac,out short pLimit);
        [DllImport("gts.dll")]
        public static extern short GTN_SetSense(short core,short dataType,short dataIndex,short value);
        [DllImport("gts.dll")]
        public static extern short GTN_GetSense(short core,short dataType,short dataIndex,out short pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_EncOn(short core,short encoder);
        [DllImport("gts.dll")]
        public static extern short GTN_EncOff(short core,short encoder);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPosErr(short core, short control, Int32 error);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosErr(short core, short control, out Int32 pError);
        [DllImport("gts.dll")]
        public static extern short GTN_SetStopDec(short core,short profile,double decSmoothStop,double decAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetStopDec(short core,short profile,out double pDecSmoothStop,out double pDecAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GTN_CtrlMode(short core,short axis,short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetStopIo(short core,short axis,short stopType,short inputType,short inputIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAdcFilterPrm(short core,short adc,double k);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAdcFilterPrm(short core,short adc,out double pk);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisPrfVelFilter(short core,short axis,short filterNumExp);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisPrfVelFilter(short core,short axis,out short pFilterNumExp);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisEncVelFilter(short core,short axis,short filterNumExp);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisEncVelFilter(short core,short axis,out short pFilterNumExp);
        [DllImport("gts.dll")]
        public static extern short GTN_SetProfileScale(short core, short i, Int32 alpha, Int32 beta);
        [DllImport("gts.dll")]
        public static extern short GTN_GetProfileScale(short core, short i, out Int32 pAlhpa, out Int32 pBeta);
        [DllImport("gts.dll")]
        public static extern short GTN_SetEncoderScale(short core, short i, Int32 alpha, Int32 beta);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEncoderScale(short core, short i, out Int32 pAlhpa, out Int32 pBeta);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAuEncoderScale(short core, short i, Int32 alpha, Int32 beta);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAuEncoderScale(short core, short i, out Int32 pAlhpa, out Int32 pBeta);
        
        /*-----------------------------------------------------------*/
        /* Capture and Triggr                                        */
        /*-----------------------------------------------------------*/
        public const short CAPTURE_HOME = 1;
        public const short CAPTURE_INDEX = 2;
        public const short CAPTURE_PROBE = 3;
        public const short CAPTURE_HSIO0 = 6;
        public const short CAPTURE_HSIO1 = 7;

        public struct TTrigger
        {
            public short encoder;
            public short probeType;
            public short probeIndex;
            public short sense;
            public Int32 offset;
            public UInt32 loop;
            public short windowOnly;
            public Int32 firstPosition;
            public Int32 lastPosition;
        }
        public struct TTriggerEx
        {
            public short latchType;
            public short latchIndex;
            public short probeType;
            public short probeIndex;
            public short sense;
            public Int32 offset;
            public UInt32 loop;
            public short windowOnly;
            public Int32 firstPosition;
            public Int32 lastPosition;
        }
        public struct TTriggerAlign
        {
            public short encoder;
            public short probeType;
            public short probeIndex;
            public short sense;
            public Int32 offset;
            public UInt32 loop;
            public short windowOnly;
            public short pad2;
            public Int32 firstPosition;
            public Int32 lastPosition;
        }

        public struct TTriggerStatus
        {
            public short execute;
            public short done;
            public Int32 position;
        }

        public struct TTriggerStatusEx
        {
            public short execute;
            public short done;
            public Int32 position;
            public UInt32 clock;
            public UInt32 loopCount;
        }
        [DllImport("gts.dll")]
        public static extern short GT_SetTrigger(short i,ref TTrigger pTrigger);
        [DllImport("gts.dll")]
        public static extern short GT_GetTrigger(short i,out TTrigger pTrigger);
        [DllImport("gts.dll")]
        public static extern short GT_GetTriggerStatus(short i,out TTriggerStatus pTriggerStatus,short count);
        [DllImport("gts.dll")]
        public static extern short GT_ClearTriggerStatus(short i);
        [DllImport("gts.dll")]
        public static extern short GT_SetCaptureMode(short encoder,short mode);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureMode(short encoder,out short pMode,short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureStatus(short encoder, out short pStatus, out Int32 pValue, short count, out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_SetCaptureSense(short encoder,short mode,short sense);
        [DllImport("gts.dll")]
        public static extern short GT_ClearCaptureStatus(short encoder);
        [DllImport("gts.dll")]
        public static extern short GT_SetCaptureRepeat(short encoder,short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureRepeatStatus(short encoder,out short pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureRepeatPos(short encoder, out Int32 pValue, short startNum, short count);
        [DllImport("gts.dll")]
        public static extern short GT_SetCaptureRepeatFifoMode(short encoder, short mode);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureRepeatFifoMode(short encoder, out short pMode);

        [DllImport("gts.dll")]
        public static extern short GTN_SetAuTrigger(short core, short i, ref TTriggerEx pTrigger);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAuTrigger(short core, short i, out TTriggerEx pTrigger);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearAuTriggerStatus(short core, short i);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAuTriggerStatus(short core, short i, out TTriggerStatusEx pTriggerStatusEx, short count);



        [DllImport("gts.dll")]
        public static extern short GTN_SetTrigger(short core,short i,ref TTrigger pTrigger);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTrigger(short core,short i,out TTrigger pTrigger);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTriggerEx(short core, short i, ref TTriggerEx pTrigger);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTriggerEx(short core, short i,out TTriggerEx pTrigger);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTriggerStatus(short core,short i,out TTriggerStatus pTriggerStatus,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTriggerStatusEx(short core,short i,out TTriggerStatusEx pTriggerStatusEx,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearTriggerStatus(short core,short i);
        [DllImport("gts.dll")]
        public static extern short GTN_DisableTrigger(short core, short i);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCaptureMode(short core,short encoder,short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCaptureMode(short core,short encoder,out short pMode,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCaptureStatus(short core,short encoder,out short pStatus,out Int32 pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCaptureSense(short core,short encoder,short mode,short sense);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearCaptureStatus(short core,short encoder);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCaptureRepeat(short core,short encoder,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCaptureRepeatStatus(short core,short encoder,out short pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCaptureRepeatPos(short core, short encoder, out Int32 pValue, short startNum, short count);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCaptureRepeatFifoMode(short core, short encoder, short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCaptureRepeatFifoMode(short core, short encoder, out short pMode);

        
        public struct TLatchValueInfo
        {
	        public short fifoFull;
	        public short pad1_1;
	        public short pad1_2;
	        public short pad1_3;
	        public double pad2_1;
	        public double pad2_2;
        };

        public struct TTriggerPrm
        {
	        public short latchType;
	        public short latchIndex;
	        public short probeType;
	        public short probeIndex;
	        public short sense;
	        public short loopType;
	        public Int32  offset;
	        public UInt32 loop;
	        public short windowOnly;
	        public short pad1;
	        public Int32 firstPosition;
	        public Int32 lastPosition;
	        public short fifoMode;
	        public short pad2_1;
	        public short pad2_2;
	        public short pad2_3;
	        public double pad3;
        };

        [DllImport("gts.dll")]
        public static extern short  GTN_SetTriggerPrm(short core,short i,ref TTriggerPrm pTriggerPrm);
        [DllImport("gts.dll")]
        public static extern short  GTN_GetTriggerPrm(short core,short i,out TTriggerPrm pTriggerPrm);
        [DllImport("gts.dll")]
        public static extern short  GTN_GetTriggerLatchValue(short core,short i,Int32 count,out Int32 pValue,out Int32 pCount,ref TLatchValueInfo pInfo);

        public const short TRIGGER_DELTA_MODE_DEFAULT = 0;
        public const short TRIGGER_DELTA_CHECKPOINT_MODE_AUTO = 0;
        public const short TRIGGER_DELTA_CHECKPOINT_MODE_MANUAL = 1;
        public struct TCheckpoint
        {
	        public short mode;
            public Int32 offset;
	        public short fifoIndex;
            public UInt32 crossCount;
	        public short fifoDataCount;
	        public short dataReady;
            public Int32 data;
	        public short dataIndex;
        } 
        public struct TTriggerDeltaPrm
        {
	        public short mode;
	        public short dir;
	        public short triggerIndex0;
            public short triggerIndex1;
        } 

        public struct TTriggerDeltaInfo
        {
	        public short enable;
	        public short checkpointCount;
	        public short fifoDataCount;
	        public short lostCount;
        }
        [DllImport("gts.dll")]
        public static extern short GT_ClearTriggerDelta(short index,short mode);
        [DllImport("gts.dll")]
        public static extern short GT_AddTriggerDeltaCheckpoint(short index, short mode, Int32 offset, short fifo, ref short pIndex);
        [DllImport("gts.dll")]
        public static extern short GT_ReadTriggerDeltaCheckpointData(short index, short checkpointIndex, out Int32 pBuf, short count, out short pReadCount);
        [DllImport("gts.dll")]
        public static extern short GT_WriteTriggerDeltaCheckpointData(short index, short checkpointIndex, ref Int32 pBuf, short count, ref short pWriteCount);
        [DllImport("gts.dll")]
        public static extern short GT_SetTriggerDeltaPrm(short index,ref TTriggerDeltaPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetTriggerDeltaPrm(short index,out TTriggerDeltaPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetTriggerDeltaCheckpoint(short index,short checkpointIndex,out TCheckpoint pCheckpoint);
        [DllImport("gts.dll")]
        public static extern short GT_GetTriggerDeltaInfo(short index,out TTriggerDeltaInfo pTriggerDelta);
        [DllImport("gts.dll")]
        public static extern short GT_TriggerDeltaOn(short index);
        [DllImport("gts.dll")]
        public static extern short GT_TriggerDeltaOff(short index);

        [DllImport("gts.dll")]
        public static extern short GTN_ClearTriggerDelta(short core,short index,short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_AddTriggerDeltaCheckpoint(short core, short index, short mode, Int32 offset, short fifo, ref short pIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_ReadTriggerDeltaCheckpointData(short core, short index, short checkpointIndex, out Int32 pBuf, short count, out short pReadCount);
        [DllImport("gts.dll")]
        public static extern short GTN_WriteTriggerDeltaCheckpointData(short core, short index, short checkpointIndex, ref Int32 pBuf, short count, ref short pWriteCount);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTriggerDeltaPrm(short core,short index,ref TTriggerDeltaPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTriggerDeltaPrm(short core,short index,out TTriggerDeltaPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTriggerDeltaCheckpoint(short core,short index,short checkpointIndex,out TCheckpoint pCheckpoint);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTriggerDeltaInfo(short core,short index,out TTriggerDeltaInfo pTriggerDelta);
        [DllImport("gts.dll")]
        public static extern short GTN_TriggerDeltaOn(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GTN_TriggerDeltaOff(short core,short index);

        [DllImport("gts.dll")]
        public static extern short GT_LinkCaptureOffset(short encoder, short source);
        [DllImport("gts.dll")]
        public static extern short GT_SetCaptureOffset(short encoder, ref Int32 pOffset, short count, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureOffset(short encoder, out Int32 pOffset, out short pCount, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureOffsetStatus(short encoder, out short pCount, out Int32 pLoop, out Int32 pCapturePos);

        [DllImport("gts.dll")]
        public static extern short GT_SetCaptureEncoder(short trigger, short encoder);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureWidth(short trigger, out short pWidth, short count);

        [DllImport("gts.dll")]
        public static extern short GTN_LinkCaptureOffset(short core, short encoder, short source);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCaptureOffset(short core, short encoder, ref Int32 pOffset, short count, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCaptureOffset(short core, short encoder, out Int32 pOffset, out short pCount, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCaptureOffsetStatus(short core, short encoder, out short pCount, out Int32 pLoop, out Int32 pCapturePos);

        /*-----------------------------------------------------------*/
        /* Basic Motion                                              */
        /*-----------------------------------------------------------*/

        public struct TTrapPrm
        {
	        public double acc;
	        public double dec;
	        public double velStart;
	        public short  smoothTime;
        } 
        [DllImport("gts.dll")]
        public static extern short GT_Update(Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GT_SetPos(short profile, Int32 pos);
        [DllImport("gts.dll")]
        public static extern short GT_GetPos(short profile, out Int32 pPos);
        [DllImport("gts.dll")]
        public static extern short GT_SetVel(short profile,double vel);
        [DllImport("gts.dll")]
        public static extern short GT_GetVel(short profile,out double pVel);
        [DllImport("gts.dll")]

        public static extern short GT_PrfTrap(short profile);
        [DllImport("gts.dll")]
        public static extern short GT_SetTrapPrm(short profile,ref TTrapPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetTrapPrm(short profile,out TTrapPrm pPrm);
        [DllImport("gts.dll")]

        public static extern short GTN_Update(short core, Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPos(short core, short profile, Int32 pos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPos(short core, short profile, out Int32 pPos);
        [DllImport("gts.dll")]
        public static extern short GTN_SetVel(short core,short profile,double vel);
        [DllImport("gts.dll")]
        public static extern short GTN_GetVel(short core,short profile,out double pVel);
        [DllImport("gts.dll")]

        public static extern short GTN_PrfTrap(short core,short profile);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTrapPrm(short core,short profile,ref TTrapPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTrapPrm(short core,short profile,out TTrapPrm pPrm);
        

        public struct TJogPrm
        {
	        public double acc;
	        public double dec;
	        public double smooth;
        }
        [DllImport("gts.dll")]
        public static extern short GT_PrfJog(short profile);
        [DllImport("gts.dll")]
        public static extern short GT_SetJogPrm(short profile,ref TJogPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetJogPrm(short profile,out TJogPrm pPrm);
        [DllImport("gts.dll")]

        public static extern short GTN_PrfJog(short core,short profile);
        [DllImport("gts.dll")]
        public static extern short GTN_SetJogPrm(short core,short profile,ref TJogPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetJogPrm(short core,short profile,out TJogPrm pPrm);

        public const short PT_MODE_STATIC = 0;
        public const short PT_MODE_DYNAMIC = 1;

        public const short PT_SEGMENT_NORMAL = 0;
        public const short PT_SEGMENT_EVEN = 1;
        public const short PT_SEGMENT_STOP = 2;

        public struct TPtInfo 
        {
	        public double prfPos;
            public Int32 loop;
	        public short mode;
	        public short fifoUse;
	        public short fifoPlace;
	        public short segmentNumber;
            public UInt32 segmentReceive1;
            public UInt32 segmentReceive2;
            public UInt32 segmentExecute1;
            public UInt32 segmentExecute2;
            public UInt32 bufferReceive1;
            public UInt32 bufferReceive2;
            public UInt32 bufferExecute1;
            public UInt32 bufferExecute2;
        } 
        [DllImport("gts.dll")]
        public static extern short GT_PrfPt(short profile,short mode);
        [DllImport("gts.dll")]
        public static extern short GT_SetPtLoop(short profile, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GT_GetPtLoop(short profile, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_PtSpace(short profile,out short pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_PtSpaceEx(short profile,out short pSpace,out short pListSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_PtData(short profile, double pos, Int32 time, short type);
        [DllImport("gts.dll")]
        public static extern short GT_PtClear(short profile,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_PtStart(Int32 mask, Int32 option);
        [DllImport("gts.dll")]
        public static extern short GT_SetPtMemory(short profile,short memory);
        [DllImport("gts.dll")]
        public static extern short GT_GetPtMemory(short profile,out short pMemory);
        [DllImport("gts.dll")]
        public static extern short GT_SetPtPrecisionMode(short profile,short precisionMode);
        [DllImport("gts.dll")]
        public static extern short GT_GetPtPrecisionMode(short profile,out short pPrecisionMode);
        [DllImport("gts.dll")]
        public static extern short GT_GetPtInfo(short profile,out TPtInfo pPtInfo);
        [DllImport("gts.dll")]
        public static extern short GT_SetPtLink(short profile,short fifo,short list);
        [DllImport("gts.dll")]
        public static extern short GT_GetPtLink(short profile,short fifo,out short pList);
        [DllImport("gts.dll")]
        public static extern short GT_PtDoBit(short profile,short doType,short index,short value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_PtAo(short profile,short aoType,short index,double value,short fifo);
        //[DllImport("gts.dll")]
        //public static extern short GTN_PosCurrFeedForward(short core,short profile,double pos,Int32 time,short torque,short type,short fifo);
       
        [DllImport("gts.dll")]
        public static extern short GTN_PrfPt(short core,short profile,short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPtLoop(short core, short profile, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPtLoop(short core, short profile, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GTN_PtSpace(short core,short profile,out short pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_PtSpaceEx(short core,short profile,out short pSpace,out short pListSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_PtData(short core,short profile,double pos,Int32 time,short type,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_PtClear(short core,short profile,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_PtStart(short core, Int32 mask, Int32 option);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPtMemory(short core,short profile,short memory);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPtMemory(short core,short profile,out short pMemory);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPtPrecisionMode(short core,short profile,short precisionMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPtPrecisionMode(short core,short profile,out short pPrecisionMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPtInfo(short core,short profile,out TPtInfo pPtInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPtLink(short core,short profile,short fifo,short list);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPtLink(short core,short profile,short fifo,out short pList);
        [DllImport("gts.dll")]
        public static extern short GTN_PtDoBit(short core,short profile,short doType,short index,short value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_PtAo(short core,short profile,short aoType,short index,double value,short fifo);



        public struct TPvtTableMovePrm
        {	
	        public short tableId;
            public Int32 distance;					
	        public double vm;						
	        public double am;						
	        public double jm;						
	        public double time;					
        } 
        [DllImport("gts.dll")]
        public static extern short GT_PrfPvt(short profile);
        [DllImport("gts.dll")]
        public static extern short GT_SetPvtLoop(short profile, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GT_GetPvtLoop(short profile, out Int32 pLoopCount, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_PvtStatus(short profile,out short pTableId,out double pTime,short count);
        [DllImport("gts.dll")]
        public static extern short GT_PvtStart(Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableSelect(short profile,short tableId);
        
        
        [DllImport("gts.dll")]
        public static extern short GT_PvtTable(short tableId, Int32 count, ref double pTime, ref double pPos, ref double pVel);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableEx(short tableId, Int32 count, ref double pTime, ref double pPos, ref double pVelBegin, ref double pVelEnd);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableComplete(short tableId, Int32 count, ref double pTime, ref double pPos, ref double pA, ref double pB, ref double pC, double velBegin, double velEnd);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTablePercent(short tableId, Int32 count, ref double pTime, ref double pPos, ref double pPercent, double velBegin);
        [DllImport("gts.dll")]
        public static extern short GT_PvtPercentCalculate(Int32 n, ref double pTime, ref double pPos, ref double pPercent, double velBegin, ref double pVel);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableContinuousEx(short tableId,Int32 n,ref double pPos,ref double pVel,ref double pAccPercent,ref double pDecPercent,ref double pVelMax,ref double pAcc,ref double pDec,double timeBegin);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableContinuous(short tableId, Int32 count, ref double pPos, ref double pVel, ref double pPercent, ref double pVelMax, ref double pAcc, ref double pDec, double timeBegin);
        [DllImport("gts.dll")]
        public static extern short GT_PvtContinuousCalculate(Int32 n, ref double pPos, ref double pVel, ref double pPercent, ref double pVelMax, ref double pAcc, ref double pDec, ref double pTime);


        [DllImport("gts.dll")]
        public static extern short GT_PvtTableMove(short tableId, Int32 distance, double vm, double am, double jm, ref double pTime);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableMove2(short tableId,  Int32 distance,double vm,double am,double jm,ref double pTime);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableMovePercent(short tableId, Int32 distance, double vm, double acc, double pa1, double pa2, double dec, double pd1, double pd2, ref double pVel, ref double pAcc, ref double pDec, ref double pTime);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableMovePercentEx(short tableId, Int32 distance, double vm,
	    double acc,double pa1,double pa2,double ma,
	    double dec,double pd1,double pd2,double md,
	    ref double pVel,ref double pAcc,ref double pDec,ref double pTime);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableMoveTogether(short tableCount,ref TPvtTableMovePrm pPvtTableMovePrm);
        
        [DllImport("gts.dll")]
        public static extern short GTN_PrfPvt(short core,short profile);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPvtLoop(short core, short profile, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPvtLoop(short core, short profile, out Int32 pLoopCount, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtStatus(short core,short profile,out short pTableId,out double pTime,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtStart(short core, Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableSelect(short core,short profile,short tableId);
        [DllImport("gts.dll")]

        public static extern short GTN_PvtTable(short core, short tableId, Int32 count, ref double pTime, ref double pPos, ref double pVel);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableEx(short core, short tableId, Int32 count, ref double pTime, ref double pPos, ref double pVelBegin, ref double pVelEnd);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableComplete(short core, short tableId, Int32 count, ref double pTime, ref double pPos, ref double pA, ref double pB, ref double pC, double velBegin, double velEnd);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTablePercent(short core, short tableId, Int32 count, ref double pTime, ref double pPos, ref double pPercent, double velBegin);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtPercentCalculate(short core, Int32 n, ref double pTime, ref double pPos, ref double pPercent, double velBegin, ref double pVel);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableContinuous(short core, short tableId, Int32 count, ref double pPos, ref double pVel, ref double pPercent, ref double pVelMax, ref double pAcc, ref double pDec, double timeBegin);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtContinuousCalculate(short core, Int32 n, ref double pPos, ref double pVel, ref double pPercent, ref double pVelMax, ref double pAcc, ref double pDec, ref double pTime);
       
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableMove(short core, short tableId, Int32 distance, double vm, double am, double jm, ref double pTime);
       [DllImport("gts.dll")]
        public static extern short GTN_PvtTableMove2(short core, short tableId, Int32 distance, double vm, double am, double jm, ref double pTime);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableMovePercent(short core, short tableId, Int32 distance, double vm,
	    double acc,double pa1,double pa2,
	    double dec,double pd1,double pd2,
	    ref double pVel,ref double pAcc,ref double pDec,ref double pTime);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableMovePercentEx(short core, short tableId, Int32 distance, double vm,
	    double acc,double pa1,double pa2,double ma,
	    double dec,double pd1,double pd2,double md,
	    ref double pVel,ref double pAcc,ref double pDec,ref double pTime);
        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableMoveTogether(short core,short tableCount,ref TPvtTableMovePrm pPvtTableMovePrm);
        public const short GEAR_MASTER_ENCODER = 1;
        public const short GEAR_MASTER_PROFILE = 2;
        public const short GEAR_MASTER_AXIS = 3;
        public const short GEAR_MASTER_AU_ENCODER  = 4;

        public const short GEAR_MASTER_ENCODER_OTHER = 101;
        public const short GEAR_MASTER_AXIS_OTHER = 103;

        public const short GEAR_EVENT_START = 1;
        public const short GEAR_EVENT_PASS = 2;
        public const short GEAR_EVENT_AREA = 5;
        [DllImport("gts.dll")]
        public static extern short GT_PrfGear(short profile,short dir);
        [DllImport("gts.dll")]
        public static extern short GT_SetGearMaster(short profile,short masterIndex,short masterType,short masterItem);
        [DllImport("gts.dll")]
        public static extern short GT_GetGearMaster(short profile,out short  pMasterIndex,out short  pMasterType,out short  pMasterItem);
        [DllImport("gts.dll")]
        public static extern short GT_SetGearRatio(short profile, Int32 masterEven, Int32 slaveEven, Int32 masterSlope);
        [DllImport("gts.dll")]
        public static extern short GT_GetGearRatio(short profile, out Int32 pMasterEven, out Int32 pSlaveEven, out Int32 pMasterSlope);
        [DllImport("gts.dll")]
        public static extern short GT_GearStart(Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GT_SetGearEvent(short profile, short gearevent, Int32 startPara0, Int32 startPara1);
        [DllImport("gts.dll")]
        public static extern short GT_GetGearEvent(short profile, out short pEvent, out Int32 pStartPara0, out Int32 pStartPara1);
        [DllImport("gts.dll")]


        public static extern short GTN_PrfGear(short core,short profile,short dir);
        [DllImport("gts.dll")]
        public static extern short GTN_SetGearMaster(short core,short profile,short masterIndex,short masterType,short masterItem);
        [DllImport("gts.dll")]
        public static extern short GTN_GetGearMaster(short core,short profile,out short  pMasterIndex,out short  pMasterType,out short  pMasterItem);
        [DllImport("gts.dll")]
        public static extern short GTN_SetGearRatio(short core, short profile, Int32 masterEven, Int32 slaveEven, Int32 masterSlope);
        [DllImport("gts.dll")]
        public static extern short GTN_GetGearRatio(short core, short profile, out Int32 pMasterEven, out Int32 pSlaveEven, out Int32 pMasterSlope);
        [DllImport("gts.dll")]
        public static extern short GTN_GearStart(short core, Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_SetGearEvent(short core, short profile, short gearevent, Int32 startPara0, Int32 startPara1);
        [DllImport("gts.dll")]
        public static extern short GTN_GetGearEvent(short core, short profile, out short pEvent, out Int32 pStartPara0, out Int32 pStartPara1);
        
        public const short FOLLOW_SWITCH_SEGMENT = 1;
        public const short FOLLOW_SWITCH_TABLE = 2;

        public const short FOLLOW_MASTER_ENCODER = 1;
        public const short FOLLOW_MASTER_PROFILE = 2;
        public const short FOLLOW_MASTER_AXIS = 3;
        public const short FOLLOW_MASTER_AU_ENCODER = 4;

        public const short FOLLOW_MASTER_ENCODER_OTHER = 101;
        public const short FOLLOW_MASTER_AXIS_OTHER = 103;

        public const short FOLLOW_EVENT_START = 1;
        public const short FOLLOW_EVENT_PASS = 2;

        public const short FOLLOW_SEGMENT_NORMAL = 0;
        public const short FOLLOW_SEGMENT_EVEN = 1;
        public const short FOLLOW_SEGMENT_STOP = 2;
        public const short FOLLOW_SEGMENT_CONTINUE = 3;
        [DllImport("gts.dll")]
        public static extern short GT_PrfFollow(short profile,short dir);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowMaster(short profile,short masterIndex,short masterType,short masterItem);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowMaster(short profile,out short  pMasterIndex,out short  pMasterType,out short  pMasterItem);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowLoop(short profile, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowLoop(short profile, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowEvent(short profile, short followevent, short masterDir, Int32 pos);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowEvent(short profile, out short pEvent, out short pMasterDir, out Int32 pPos);
        [DllImport("gts.dll")]
        public static extern short GT_FollowSpace(short profile,out short  pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowData(short profile, Int32 masterSegment, double slaveSegment, short type, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowClear(short profile,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowStart(Int32 mask, Int32 option);
        [DllImport("gts.dll")]
        public static extern short GT_FollowSwitch(Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowMemory(short profile,short memory);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowMemory(short profile,out short  pMemory);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowStatus(short profile,out short  pFifoNum,out short  pSwitchStatus);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowPhasing(short profile,short profilePhasing);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowPhasing(short profile,out short  pProfilePhasing);
        [DllImport("gts.dll")]


        public static extern short GT_PrfFollowEx(short profile,short dir);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowMasterEx(short profile,short masterIndex,short masterType,short masterItem);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowMasterEx(short profile,out short  pMasterIndex,out short  pMasterType,out short  pMasterItem);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowLoopEx(short profile, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowLoopEx(short profile, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowEventEx(short profile, short followevent, short masterDir, Int32 pos);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowEventEx(short profile, out short pEvent, out short pMasterDir, out Int32 pPos);
        [DllImport("gts.dll")]
        public static extern short GT_FollowSpaceEx(short profile,out short  pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowDataPercentEx(short profile,double masterSegment,double slaveSegment,short type,short percent,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowClearEx(short profile,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowStartEx(Int32 mask, Int32 option);
        [DllImport("gts.dll")]
        public static extern short GT_FollowSwitchEx(Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowMemoryEx(short profile,short memory);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowMemoryEx(short profile,out short  pMemory);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowStatusEx(short profile,out short  pFifoNum,out short  pSwitchStatus);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowPhasingEx(short profile,short profilePhasing);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowPhasingEx(short profile,out short  pProfilePhasing);
        [DllImport("gts.dll")]
        public static extern short GT_FollowSwitchNowEx(short profile,short method,short buffer,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowDataPercent2Ex(short profile,double masterSegment,double slaveSegment,double velBeginRatio,double velEndRatio,short percent,out short  pPercent1,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowDataPercent2Ex(double masterPos,double v1,double v2,double p,double p1,out double pSlavePos);
        [DllImport("gts.dll")]
        public static extern short GT_FollowDoBitEx(short profile,short doType,short index,short value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowDelayEx(short profile, UInt32 delayTime, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowDiBitEx(short profile, short diType, short index, short value, UInt32 time, short fifo);
        
        
        [DllImport("gts.dll")]
        public static extern short GTN_PrfFollow(short core,short profile,short dir);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowMaster(short core,short profile,short masterIndex,short masterType,short masterItem);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowMaster(short core,short profile,out short  pMasterIndex,out short  pMasterType,out short  pMasterItem);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowLoop(short core, short profile, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowLoop(short core, short profile, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowEvent(short core, short profile, short followevent, short masterDir, Int32 pos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowEvent(short core, short profile, out short pEvent, out short pMasterDir, out Int32 pPos);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowSpace(short core,short profile,out short  pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowData(short core, short profile, Int32 masterSegment, double slaveSegment, short type, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowClear(short core,short profile,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowStart(short core, Int32 mask, Int32 option);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowSwitch(short core,Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowMemory(short core,short profile,short memory);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowMemory(short core,short profile,out short  pMemory);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowStatus(short core,short profile,out short  pFifoNum,out short  pSwitchStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowPhasing(short core,short profile,short profilePhasing);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowPhasing(short core,short profile,out short  pProfilePhasing);
        [DllImport("gts.dll")]

        public static extern short GTN_PrfFollowEx(short core,short profile,short dir);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowMasterEx(short core,short profile,short masterIndex,short masterType,short masterItem);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowMasterEx(short core,short profile,out short  pMasterIndex,out short  pMasterType,out short  pMasterItem);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowLoopEx(short core, short profile, Int32 loop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowLoopEx(short core, short profile, out Int32 pLoop);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowEventEx(short core, short profile, short followevent, short masterDir, Int32 pos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowEventEx(short core, short profile, out short pEvent, out short pMasterDir, out Int32 pPos);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowSpaceEx(short core,short profile,out short  pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowDataPercentEx(short core,short profile,double masterSegment,double slaveSegment,short type,short percent,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowClearEx(short core,short profile,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowStartEx(short core, Int32 mask, Int32 option);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowSwitchEx(short core, Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowMemoryEx(short core,short profile,short memory);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowMemoryEx(short core,short profile,out short  pMemory);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowStatusEx(short core,short profile,out short  pFifoNum,out short  pSwitchStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowPhasingEx(short core,short profile,short profilePhasing);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowPhasingEx(short core,short profile,out short  pProfilePhasing);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowSwitchNowEx(short core,short profile,short method,short buffer,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowDataPercent2Ex(short core,short profile,double masterSegment,double slaveSegment,double velBeginRatio,double velEndRatio,short percent,out short  pPercent1,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFollowDataPercent2Ex(short core,double masterPos,double v1,double v2,double p,double p1,out double pSlavePos);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowDoBitEx(short core,short profile,short doType,short index,short value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowDelayEx(short core,short profile,UInt32 delayTime,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_FollowDiBitEx(short core,short profile,short diType,short index,short value,UInt32 time,short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_SetFollowVirtualSeg(short profile, short segment, short axis, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowVirtualSeg(short profile, out short pSegment, out short pAxis, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_GetFollowVirtualErr(short profile, out double pVirtualErr);
        [DllImport("gts.dll")]
        public static extern short GT_ClearFollowVirtualErr(short profile);


        public struct TMoveAbsolutePrm
        {
	        public Int32 pos;
	        public double vel;
	        public double acc;
	        public double dec;
	        public short percent;
        } 
        [DllImport("gts.dll")]
        public static extern short GT_MoveAbsolute(short profile,ref TMoveAbsolutePrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetMoveAbsolute(short profile,out TMoveAbsolutePrm pPrm);
        [DllImport("gts.dll")]

        public static extern short GTN_MoveAbsolute(short core,short profile,ref TMoveAbsolutePrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetMoveAbsolute(short core,short profile,out TMoveAbsolutePrm pPrm);


        public struct  TTransformOrthogonal
        {
	        public short source;
	        public short enable;
	        public short x;
	        public short y;
	        public double theta;
        } 
        [DllImport("gts.dll")]
        public static extern short GT_SetTransformOrthogonal(short index,ref TTransformOrthogonal pOrthogonal);
        [DllImport("gts.dll")]
        public static extern short GT_GetTransformOrthogonal(short index,out TTransformOrthogonal pOrthogonal);
        [DllImport("gts.dll")]
        public static extern short GT_GetTransformOrthogonalPosition(short index,out double pPositionX,out double pPositionY);
        
        [DllImport("gts.dll")]
        public static extern short GTN_SetTransformOrthogonal(short core,short index,ref TTransformOrthogonal pOrthogonal);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTransformOrthogonal(short core,short index,out TTransformOrthogonal pOrthogonal);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTransformOrthogonalPosition(short core,short index,out double pPositionX,out double pPositionY);
		
        /*-----------------------------------------------------------*/
        /* Comp                                                      */
        /*-----------------------------------------------------------*/  
		public struct TCoordTransformPrm
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public double[] translateion;	                      //��������ϵ���ԭʼ����ϵ��ƽ��
			public double theta;	                              //��������ϵ���ԭʼ����ϵ����ת
		}

		public struct TCoordSyncCompPrm
		{
			public short enable;	                              //�Ƿ�ʹ������ϵת������
			public short refType;	                              //�ο����ͣ���������ΪMC_CRD��MC_GROUP��MC_PROFILE��
			public short crd;	                                  //����ο�����ΪMC_CRD��д������ϵ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public short[] refIndex;	                           //�ο���ţ�ָ������ϵ�е�ĳ�����ᣬ����profile��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public double[] offset;	                               //������X2��Y2�����Բο�����ϵX1��Y1����ƫ��
			public TCoordTransformPrm refTrans;	                   //�ο���������ϵ���ԭ����ϵ��ƽ�ƺ���ת
			public TCoordTransformPrm syncTrans;	               //ͬ����������ϵ���ԭ����ϵ��ƽ�ƺ���ת
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public short[] reserve1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public double[] reserve2;
		}

		public struct TPrfComp
		{
			public short type;	                    //�������ͣ�����ͬ��������
			public short index;	                    //һ������������ͬ������֧�����������������ϵ����������ʾ�ڼ���ͬ������
			public short subIndex;	                //���������������һ��ͬ�������ĵ�һ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
			public short[] reserve1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public double[] reserve2;
		}
		[DllImport("gts.dll")]
		public static extern short GTN_PrfComp(short core,short profile,ref TPrfComp pComp);
		[DllImport("gts.dll")]
		public static extern short GTN_PrfCompEnable(short core,short profile,short enable,short enableType);
		[DllImport("gts.dll")]
		public static extern short GTN_BufPrfCompEnable(short core,short crd,short fifo,short profile,short enable,short enableType);
		[DllImport("gts.dll")]
		public static extern short GTN_SetCoordSyncCompPrm(short core,short index,ref TCoordSyncCompPrm pPrm);
		[DllImport("gts.dll")]
		public static extern short GTN_GetCoordSyncCompPrm(short core,short index,out TCoordSyncCompPrm pPrm);
		[DllImport("gts.dll")]
		public static extern short GTN_GetCoordSyncCompValue(short core,short index,double x,double y,out double pCompX,out double pCompY);
				
        /*-----------------------------------------------------------*/
        /* Home                                                      */
        /*-----------------------------------------------------------*/
        public const short HOME_STAGE_IDLE = 0;
        public const short HOME_STAGE_START	= 1;

        public const short HOME_STAGE_SEARCH_LIMIT = 10;
        public const short HOME_STAGE_SEARCH_LIMIT_STOP	= 11;

        public const short HOME_STAGE_SEARCH_LIMIT_ESCAPE = 13;

        public const short HOME_STAGE_SEARCH_LIMIT_RETURN = 15;
        public const short HOME_STAGE_SEARCH_LIMIT_RETURN_STOP = 16;

        public const short HOME_STAGE_SEARCH_HOME = 20;

        public const short HOME_STAGE_SEARCH_HOME_RETURN = 25;

        public const short HOME_STAGE_SEARCH_INDEX = 30;

        public const short HOME_STAGE_SEARCH_GPI = 40;

        public const short HOME_STAGE_SEARCH_GPI_RETURN = 45;

        public const short HOME_STAGE_GO_HOME = 80;

        public const short HOME_STAGE_END = 100;

        public const short HOME_ERROR_NONE = 0;
        public const short HOME_ERROR_NOT_TRAP_MODE = 1;
        public const short HOME_ERROR_DISABLE = 2;
        public const short HOME_ERROR_ALARM = 3;
        public const short HOME_ERROR_STOP = 4;
        public const short HOME_ERROR_STAGE = 5;
        public const short HOME_ERROR_HOME_MODE	= 6;
        public const short HOME_ERROR_SET_CAPTURE_HOME = 7;
        public const short HOME_ERROR_NO_HOME = 8;
        public const short HOME_ERROR_SET_CAPTURE_INDEX	= 9;
        public const short HOME_ERROR_NO_INDEX = 10;

        public const short HOME_MODE_LIMIT = 10;
        public const short HOME_MODE_LIMIT_HOME	= 11;
        public const short HOME_MODE_LIMIT_INDEX = 12;
        public const short HOME_MODE_LIMIT_HOME_INDEX = 13;

        public const short HOME_MODE_HOME = 20;

        public const short HOME_MODE_HOME_INDEX	= 22;

        public const short HOME_MODE_INDEX = 30;

        public struct THomePrm
        {
	        public short mode;						// ����ģʽ
	        public short moveDir;					// ������������ʱ���˶�����
	        public short indexDir;					// ����Index��������
	        public short edge;						// ���ò�����
	        public short triggerIndex;				// �������ô�����
	        public short pad10;					    // ����1
            public short pad11;					    // ����1
            public short pad12;					    // ����1
	        public double velHigh;					// Home�����ٶ�
	        public double velLow;					// Index�����ٶ�
	        public double acc;
	        public double dec;
	        public short smoothTime;
	        public short pad20;					    // ����2
            public short pad21;					    // ����2
            public short pad22;					    // ����2
	        public Int32 homeOffset;				// ԭ��ƫ��
	        public Int32 searchHomeDistance;		// Home����������룬Ϊ0��ʾ������
	        public Int32 searchIndexDistance;		// Index����������룬Ϊ0��ʾ������
	        public Int32 escapeStep;				// ���벽��
	        public Int32 pad31;					    // ����3
            public Int32 pad32;					    // ����3
        } 

        public struct THomeStatus
        {
	        public short run;
	        public short stage;
	        public short error;
	        public short pad1;
	        public Int32 capturePos;
	        public Int32 targetPos;
        } 
        [DllImport("gts.dll")]
        public static extern short GT_GoHome(short axis,ref THomePrm pHomePrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetHomePrm(short profile,out THomePrm pHomePrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetHomeStatus(short profile,out THomeStatus pHomeStatus);
        [DllImport("gts.dll")]

        public static extern short GTN_GoHome(short core,short axis,ref THomePrm pHomePrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetHomePrm(short core,short axis,out THomePrm pHomePrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetHomeStatus(short core,short axis,out THomeStatus pHomeStatus);

        [DllImport("gts.dll")]
        public static extern short GT_HandwheelInit(short mode);
        [DllImport("gts.dll")]
        public static extern short GT_SetHandwheelStopDec(short slave, double decSmoothStop, double decAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_StartHandwheel(short slave, short master, short masterEven, short slaveEven, short intervalTime, double acc, double dec, double vel, short stopWaitTime);
        [DllImport("gts.dll")]
        public static extern short GT_EndHandwheel(short slave);

        [DllImport("gts.dll")]
        public static extern short GTN_HandwheelInit(short core, short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetHandwheelStopDec(short core, short slave, double decSmoothStop, double decAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GTN_StartHandwheel(short core, short slave, short master, short masterEven, short slaveEven, short intervalTime, double acc, double dec, double vel, short stopWaitTime);
        [DllImport("gts.dll")]
        public static extern short GTN_EndHandwheel(short core, short slave);

        /*-----------------------------------------------------------*/
        /* PLC                                                       */
        /*-----------------------------------------------------------*/
        public const short PLC_THREAD_MAX =	32;
        public const short PLC_PAGE_MAX	= 32;
        public const short PLC_LOCAL_VAR_MAX = 1024;
        public const short PLC_ACCESS_VAR_COUNT_MAX = 8;

        public const short PLC_TIMER_TT	= 0;
        public const short PLC_TIMER_TF	= 1;
        public const short PLC_TIMER_TTF = 2;

        public const short PLC_COUNTER_EQ = 0;
        public const short PLC_COUNTER_LE = 1;
        public const short PLC_COUNTER_GE = 2;

        public const short PLC_COUNTER_EDGE_UP = 0;
        public const short PLC_COUNTER_EDGE_DOWN = 1;
        public const short PLC_COUNTER_EDGE_UP_DOWN = 2;

        public const short PLC_FLANK_UP	= 0;
        public const short PLC_FLANK_DOWN = 1;
        public const short PLC_FLANK_UP_DOWN = 2;

        public enum EPlcBind
        {
	        PLC_BIND_NONE,
	        PLC_BIND_DI,
	        PLC_BIND_DO,
	        PLC_BIND_TIMER,
	        PLC_BIND_COUNTER,
	        PLC_BIND_FLANK,
	        PLC_BIND_SRFF,
        } 

        public struct TVarInfo
        {
	        public short id;
	        public short dataType;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public String name;
        } 

        public struct TBindDi
        {
	        public short diType;
	        public short index;
	        public short reverse;
        } 

        public struct TBindDo
        {
	        public short doType;
	        public short index;
	        public short reverse;
        } 

        public struct TBindTimer
        {
	        public short timerType;
	        public Int32 delay;
	        public short inputVarId;
        } 

        public struct TBindCounter
        {
	        public short counterType;
	        public short edge;
	        public Int32 init;
	        public Int32 target;
	        public Int32 begin;
	        public Int32 end;
	        public short dir;
	        public Int32 unit;
	        public short inputVarId;
	        public short resetVarId;
        } 

        public struct TBindFlank
        {
	        public short flankType;
	        public short inputVarId;
        } 

        public struct TBindSrff
        {
	        public short setVarId;
	        public short resetVarId;
        } 

        public struct TCompileInfo
        {
	       public string pFileName;
	       public short  pLineNo;
	       public string pMessage;
        } 

        public struct TThreadSts
        {
	        public short  run;
	        public short  error;
	        public double result;
	        public short  line;
        } 

        [DllImport("gts.dll")]
        public static extern short GT_Compile(string pFileName,out TCompileInfo pWrongInfo);
        [DllImport("gts.dll")]
        public static extern short GT_Download(string pFileName);
        [DllImport("gts.dll")]
        public static extern short GT_GetFunId(string pFunName,out short  pFunId);
        [DllImport("gts.dll")]
        public static extern short GT_GetVarId(string pFunName,string pVarName,out TVarInfo pVarInfo);
        [DllImport("gts.dll")]
        public static extern short GT_Bind(short thread,short funId,short page);
        [DllImport("gts.dll")]
        public static extern short GT_RunThread(short thread);
        [DllImport("gts.dll")]
        public static extern short GT_RunThreadPeriod(short thread,short ms,short priority);
        
        [DllImport("gts.dll")]
        public static extern short GT_StopThread(short thread);
        [DllImport("gts.dll")]
        public static extern short GT_PauseThread(short thread);
        [DllImport("gts.dll")]
        public static extern short GT_GetThreadSts(short thread,out TThreadSts pThreadSts);
        [DllImport("gts.dll")]
        public static extern short GT_GetThreadTime(short thread,out short  pPeriod,out double pExecuteTime,out double pExecuteTimeMax);
        [DllImport("gts.dll")]
        public static extern short GT_SetVarValue(short page,ref TVarInfo pVarInfo,out double pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetVarValue(short page,ref TVarInfo pVarInfo,out double pValue,short count);
        
        [DllImport("gts.dll")]
        public static extern short GT_UnbindVar(short thread);
        [DllImport("gts.dll")]
        public static extern short GT_BindDi(short thread,ref TVarInfo pVarInfo,ref TBindDi pBindDi);
        [DllImport("gts.dll")]
        public static extern short GT_BindDo(short thread,ref TVarInfo pVarInfo,ref TBindDo pBindDo);
        [DllImport("gts.dll")]
        public static extern short GT_BindTimer(short thread,ref TVarInfo pVarInfo,ref TBindTimer pBindTimer);
        [DllImport("gts.dll")]
        public static extern short GT_BindCounter(short thread,ref TVarInfo pVarInfo,ref TBindCounter pBindCounter);
        [DllImport("gts.dll")]
        public static extern short GT_BindFlank(short thread,ref TVarInfo pVarInfo,ref TBindFlank pBindFlank);
        [DllImport("gts.dll")]
        public static extern short GT_BindSrff(short thread,ref TVarInfo pVarInfo,ref TBindSrff pBindSrff);
        
        [DllImport("gts.dll")]
        public static extern short GT_GetBindDi(out TVarInfo pVarInfo,out TBindDi pBindDi);
        [DllImport("gts.dll")]
        public static extern short GT_GetBindDo(out TVarInfo pVarInfo,out TBindDo pBindDo);
        [DllImport("gts.dll")]
        public static extern short GT_GetBindTimer(out TVarInfo pVarInfo,out TBindTimer pBindTimer,out Int32  pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetBindCounter(out TVarInfo pVarInfo,out TBindCounter pBindCounter,out Int32  pUnitCount,out Int32  pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetBindFlank(out TVarInfo pVarInfo,out TBindFlank pBindFlank);
        [DllImport("gts.dll")]
        public static extern short GT_GetBindSrff(out TVarInfo pVarInfo,out TBindSrff pBindSrff);

        [DllImport("gts.dll")]
        public static extern short GTN_Compile(string pFileName,ref TCompileInfo pWrongInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_Download(short core,string pFileName);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFunId(string pFunName,out short  pFunId);
        [DllImport("gts.dll")]
        public static extern short GTN_GetVarId(string pFunName,string pVarName,out TVarInfo pVarInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_Bind(short core,short thread,short funId,short page);
        [DllImport("gts.dll")]
        public static extern short GTN_RunThread(short core,short thread);
        [DllImport("gts.dll")]
        public static extern short GTN_RunThreadPeriod(short core,short thread,short ms,short priority);
        [DllImport("gts.dll")]
        public static extern short GTN_StopThread(short core,short thread);
        [DllImport("gts.dll")]
        public static extern short GTN_PauseThread(short core,short thread);
        [DllImport("gts.dll")]
        public static extern short GTN_GetThreadSts(short core,short thread,out TThreadSts pThreadSts);
        [DllImport("gts.dll")]
        public static extern short GTN_GetThreadTime(short core,short thread,out short  pPeriod,out double pExecuteTime,out double pExecuteTimeMax);
        [DllImport("gts.dll")]
        public static extern short GTN_SetVarValue(short core,short page,ref TVarInfo pVarInfo,ref double pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetVarValue(short core, short page, ref TVarInfo pVarInfo, out double pValue, short count);
        [DllImport("gts.dll")]

        public static extern short GTN_UnbindVar(short core,short thread);
        [DllImport("gts.dll")]
        public static extern short GTN_BindDi(short core,short thread,ref TVarInfo pVarInfo,ref TBindDi pBindDi);
        [DllImport("gts.dll")]
        public static extern short GTN_BindDo(short core,short thread,ref TVarInfo pVarInfo,ref TBindDo pBindDo);
        [DllImport("gts.dll")]
        public static extern short GTN_BindTimer(short core,short thread,ref TVarInfo pVarInfo,ref TBindTimer pBindTimer);
        [DllImport("gts.dll")]
        public static extern short GTN_BindCounter(short core,short thread,ref TVarInfo pVarInfo,ref TBindCounter pBindCounter);
        [DllImport("gts.dll")]
        public static extern short GTN_BindFlank(short core,short thread,ref TVarInfo pVarInfo,ref TBindFlank pBindFlank);
        [DllImport("gts.dll")]
        public static extern short GTN_BindSrff(short core,short thread,ref TVarInfo pVarInfo,ref TBindSrff pBindSrff);
        [DllImport("gts.dll")]

        public static extern short GTN_GetBindDi(short core,out TVarInfo pVarInfo,out TBindDi pBindDi);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindDo(short core,out TVarInfo pVarInfo,out TBindDo pBindDo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindTimer(short core,out TVarInfo pVarInfo,out TBindTimer pBindTimer,out Int32  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindCounter(short core,out TVarInfo pVarInfo,out TBindCounter pBindCounter,out Int32  pUnitCount,out Int32  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindFlank(short core,out TVarInfo pVarInfo,out TBindFlank pBindFlank);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindSrff(short core,out TVarInfo pVarInfo,out TBindSrff pBindSrff);
        [DllImport("gts.dll")]

        public static extern short GTN_GetBindDiCount(short core,short thread,out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindDoCount(short core,short thread,out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindTimerCount(short core,short thread,out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindCounterCount(short core,short thread,out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindFlankCount(short core,short thread,out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindSrffCount(short core,short thread,out short  pCount);
        [DllImport("gts.dll")]

        public static extern short GTN_GetBindDiInfo(short core,short thread,short index,out short  pVar,out TBindDi pBindDi);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindDoInfo(short core,short thread,short index,out short  pVar,out TBindDo pBindDo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindTimerInfo(short core,short thread,short index,out short  pVar,out TBindTimer pBindTimer);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindCounterInfo(short core,short thread,short index,out short  pVar,out TBindCounter pBindCounter);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindFlankInfo(short core,short thread,short index,out short  pVar,out TBindFlank pBindFlank);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBindSrffInfo(short core,short thread,short index,out short  pVar,out TBindSrff pBindSrff);

        public struct TThreadStatus
        {
            public short link;
            public UInt32 address;
            public short size;
            public UInt32 page;
            public short delay;
            public short priority;
            public short ptr;
            public short status;
            public short error;
            public short result1;
            public short result2;
            public short result3;
            public short result4;
            public short resultType;
            public short breakpoint;
            public short period;
            public short count;
            public short function;
        } 

        [DllImport("gts.dll")]
        public static extern short GT_ClearPlc();
        [DllImport("gts.dll")]
        public static extern short GT_LoadPlc(short id,short returnType);
        [DllImport("gts.dll")]
        public static extern short GT_LoadPlcCommand(short id,short count,ref short pData);
        [DllImport("gts.dll")]
        public static extern short GT_StepThread(short thread);
        [DllImport("gts.dll")]
        public static extern short GT_RunThreadToBreakpoint(short thread,short line);
        [DllImport("gts.dll")]
        public static extern short GT_GetThread(short thread,out TThreadStatus pThread);

        [DllImport("gts.dll")]
        public static extern short GTN_StepThread(short core,short thread);
        /*-----------------------------------------------------------*/
        /* Interpolation                                             */
        /*-----------------------------------------------------------*/

        public const short INTERPOLATION_AXIS_MAX = 8;

        public const short CRD_OPERATION_DATA_EXT_MAX = 2;


        public const short CRD_BUFFER_MODE_DYNAMIC_DEFAULT = 0;
        public const short CRD_BUFFER_MODE_DYNAMIC_KEEP = 1;
        public const short CRD_BUFFER_MODE_STATIC_INPUT = 11;
        public const short CRD_BUFFER_MODE_STATIC_READY = 12;
        public const short CRD_BUFFER_MODE_STATIC_START  = 1;

        public const short INTERPOLATION_CIRCLE_PLAT_XY = 0;
        public const short INTERPOLATION_CIRCLE_PLAT_YZ = 1;
        public const short INTERPOLATION_CIRCLE_PLAT_ZX = 2;

        public const short INTERPOLATION_HELIX_CIRCLE_XY_LINE_Z = 0;
        public const short INTERPOLATION_HELIX_CIRCLE_YZ_LINE_X = 1;
        public const short INTERPOLATION_HELIX_CIRCLE_ZX_LINE_Y = 2;
        public const short INTERPOLATION_CIRCLE_DIR_CW = 0;
        public const short INTERPOLATION_CIRCLE_DIR_CCW = 1;

        public struct TCrdPrm
        {
	        public short dimension;                              // ����ϵά��
	        public short profile1;                               // ����profile��������
            public short profile2;                               // ����profile��������
            public short profile3;                               // ����profile��������
            public short profile4;                               // ����profile��������
            public short profile5;                               // ����profile��������
            public short profile6;                               // ����profile��������
            public short profile7;                               // ����profile��������
            public short profile8;                               // ����profile��������
	        public double synVelMax;                             // ���ϳ��ٶ�
	        public double synAccMax;                             // ���ϳɼ��ٶ�
	        public short evenTime;                               // ��С����ʱ��
	        public short setOriginFlag;                          // ����ԭ������ֵ��־,0:Ĭ�ϵ�ǰ�滮λ��Ϊԭ��λ��;1:�û�ָ��ԭ��λ��
	        public Int32 originPos1;                             // �û�ָ����ԭ��λ��
            public Int32 originPos2;                             // �û�ָ����ԭ��λ��
            public Int32 originPos3;                             // �û�ָ����ԭ��λ��
            public Int32 originPos4;                             // �û�ָ����ԭ��λ��
            public Int32 originPos5;                             // �û�ָ����ԭ��λ��
            public Int32 originPos6;                             // �û�ָ����ԭ��λ��
            public Int32 originPos7;                             // �û�ָ����ԭ��λ��
            public Int32 originPos8;                             // �û�ָ����ԭ��λ��
        }

        public struct TCrdBufOperation
        {
	        public short flag;                                   // ��־�ò岹���Ƿ���IO����ʱ
	        public ushort delay;                                 // ��ʱʱ��
	        public short doType;                                 // ������IO������,0:�����IO
            public ushort doMask;                                // ������IO�������������
            public ushort doValue;                               // ������IO�����ֵ
            public ushort dataExt1;                              // ����������չ����
            public ushort dataExt2;                              // ����������չ����
        }
         
        public struct TCrdData
        {
	        public short motionType;                             // �˶�����,0:ֱ�߲岹,1:Բ���岹
	        public short circlePlat;                             // Բ���岹��ƽ��
	        public Int32 pos1;                                   // ��ǰ�θ����յ�λ��
            public Int32 pos2;                                   // ��ǰ�θ����յ�λ��
            public Int32 pos3;                                   // ��ǰ�θ����յ�λ��
            public Int32 pos4;                                   // ��ǰ�θ����յ�λ��
            public Int32 pos5;                                   // ��ǰ�θ����յ�λ��
            public Int32 pos6;                                   // ��ǰ�θ����յ�λ��
            public Int32 pos7;                                   // ��ǰ�θ����յ�λ��
            public Int32 pos8;                                   // ��ǰ�θ����յ�λ��
	        public double radius;                                // Բ���岹�İ뾶
	        public short circleDir;                              // Բ����ת����,0:˳ʱ��;1:��ʱ��
	        public double center1;                               // Բ���岹��Բ������
            public double center2;                               // Բ���岹��Բ������
            public double center3;                               // Բ���岹��Բ������
            public double vel;                                   // ��ǰ�κϳ�Ŀ���ٶ�
	        public double acc;                                   // ��ǰ�κϳɼ��ٶ�
	        public short velEndZero;                             // ��־��ǰ�ε��յ��ٶ��Ƿ�ǿ��Ϊ0,0:��ǿ��Ϊ0;1:ǿ��Ϊ0
	        public TCrdBufOperation operation;                   // ��������ʱ��IO�ṹ��

	        public double cos1;                                  // ��ǰ�θ����Ӧ������ֵ
            public double cos2;                                  // ��ǰ�θ����Ӧ������ֵ
            public double cos3;                                  // ��ǰ�θ����Ӧ������ֵ
            public double cos4;                                  // ��ǰ�θ����Ӧ������ֵ
            public double cos5;                                  // ��ǰ�θ����Ӧ������ֵ
            public double cos6;                                  // ��ǰ�θ����Ӧ������ֵ
            public double cos7;                                  // ��ǰ�θ����Ӧ������ֵ
            public double cos8;                                  // ��ǰ�θ����Ӧ������ֵ
	        public double velEnd;                                // ��ǰ�κϳ��յ��ٶ�
	        public double velEndAdjust;                          // �����յ��ٶ�ʱ�õ��ı���(ǰհģ��)
	        public double r;                                     // ��ǰ�κϳ�λ����
        }

        public struct  TCrdTime
        {
	        public double time;
	        public Int32 segmentUsed;
	        public Int32 segmentHead;
	        public Int32 segmentTail;
        }

        public struct TBufFollowMaster
        {
            public short crdAxis;
            public short masterIndex;
            public short masterType;
        }

        public struct TBufFollowEventCross
        {
            public Int32 masterPos;
            public Int32 pad;
        }

        public struct TBufFollowEventTrigger
        {
            public short triggerIndex;
            public Int32 triggerOffset;
            public Int32 pad;
        }

        public struct TCrdFollowPrm 
        {
            public double velRatioMax;
            public double accRatioMax;
            public Int32 masterLead;
            public Int32 masterEven;
            public Int32 slaveEven;
            public short dir;
            public short smoothPercent;
            public short synchAlign;
        }

        public struct TCrdFollowStatus
        {
            public short stage;
            public double slavePos;
            public double slaveVel;
            public Int32 masterFrameWidth;
            public Int32 masterFrameIndex;
            public UInt32 loopCount;
        }
        [DllImport("gts.dll")]
        public static extern short GT_SetCrdPrm(short crd,ref TCrdPrm pCrdPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdPrm(short crd,out TCrdPrm pCrdPrm);
        [DllImport("gts.dll")]
        public static extern short GT_CrdSpace(short crd,out Int32  pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_CrdData(short crd,IntPtr pCrdData, short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_LnXY(short crd,Int32 x,Int32 y,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYOverride2(short crd,Int32 x,Int32 y,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYWN(short crd,Int32 x,Int32 y,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYOverride2WN(short crd,Int32 x,Int32 y,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_LnXYG0(short crd,Int32 x,Int32 y,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYG0Override2(short crd,Int32 x,Int32 y,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYG0WN(short crd,Int32 x,Int32 y,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYG0Override2WN(short crd,Int32 x,Int32 y,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_LnXYZ(short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZOverride2(short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZWN(short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZOverride2WN(short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_LnXYZG0(short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZG0Override2(short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZG0WN(short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZG0Override2WN(short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_LnXYZA(short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAOverride2(short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAWN(short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAOverride2WN(short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_LnXYZAG0(short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAG0Override2(short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAG0WN(short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAG0Override2WN(short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_LnXYZACUVW(short crd,ref Int32  pPos,short posMask,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZACUVWWN(short crd,ref Int32  pPos,short posMask,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZACUVWOverride2(short crd,ref Int32  pPos,short posMask,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZACUVWOverride2WN(short crd,ref Int32  pPos,short posMask,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_ArcXYR(short crd,Int32 x,Int32 y,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYROverride2(short crd,Int32 x,Int32 y,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYRWN(short crd,Int32 x,Int32 y,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYROverride2WN(short crd,Int32 x,Int32 y,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_ArcXYC(short crd,Int32 x,Int32 y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYCOverride2(short crd,Int32 x,Int32 y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYCWN(short crd,Int32 x,Int32 y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYCOverride2WN(short crd,Int32 x,Int32 y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_ArcYZR(short crd,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZROverride2(short crd,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZRWN(short crd,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZROverride2WN(short crd,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_ArcYZC(short crd,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZCOverride2(short crd,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZCWN(short crd,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZCOverride2WN(short crd,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_ArcZXR(short crd,Int32 z,Int32 x,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXROverride2(short crd,Int32 z,Int32 x,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXRWN(short crd,Int32 z,Int32 x,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXROverride2WN(short crd,Int32 z,Int32 x,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_ArcZXC(short crd,Int32 z,Int32 x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXCOverride2(short crd,Int32 z,Int32 x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXCWN(short crd,Int32 z,Int32 x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXCOverride2WN(short crd,Int32 z,Int32 x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_HelixXYRZ(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYRZOverride2(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYRZWN(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYRZOverride2WN(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_HelixXYCZ(short crd,Int32 x,Int32 y,Int32 z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYCZOverride2(short crd,Int32 x,Int32 y,Int32 z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYCZWN(short crd,Int32 x,Int32 y,Int32 z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYCZOverride2WN(short crd,Int32 x,Int32 y,Int32 z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_HelixYZRX(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZRXOverride2(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZRXWN(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZRXOverride2WN(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_HelixYZCX(short crd,Int32 x,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZCXOverride2(short crd,Int32 x,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZCXWN(short crd,Int32 x,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZCXOverride2WN(short crd,Int32 x,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_HelixZXRY(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXRYOverride2(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXRYWN(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXRYOverride2WN(short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_HelixZXCY(short crd,Int32 x,Int32 y,Int32 z,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXCYOverride2(short crd,Int32 x,Int32 y,Int32 z,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXCYWN(short crd,Int32 x,Int32 y,Int32 z,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXCYOverride2WN(short crd,Int32 x,Int32 y,Int32 z,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GT_BufIO(short crd,UInt32 doType,UInt32 doMask,UInt32 doValue,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufDelay(short crd,UInt32 delayTime,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufDA(short crd,short chn,short daValue,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufIOWN(short crd, Int16 doType, Int16 doMask, Int16 doValue, Int32 segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufDelayWN(short crd,Int16 delayTime,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufDAWN(short crd, short chn, short daValue, Int32 segNum, short fifo);  
        [DllImport("gts.dll")]
        public static extern short GT_BufLmtsOn(short crd,short axis,short limitType,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufLmtsOff(short crd,short axis,short limitType,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufSetStopIo(short crd,short axis,short stopType,short inputType,short inputIndex,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufMove(short crd,short moveAxis,Int32 pos,double vel,double acc,short modal,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufGear(short crd,short gearAxis,Int32 pos,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufGearPercent(short crd,short gearAxis,Int32 pos,short accPercent,short decPercent,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufStopMotion(short crd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufStopMotionWN(short crd, Int32 segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufSetVarValue(short crd,short pageId,ref TVarInfo pVarInfo,double value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufJumpNextSeg(short crd,short axis,short limitType,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufSynchPrfPos(short crd,short encoder,short profile,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufVirtualToActual(short crd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_CrdStart(short mask,short option);
        [DllImport("gts.dll")]
        public static extern short GT_CrdStartStep(short mask,short option);
        [DllImport("gts.dll")]
        public static extern short GT_CrdStepMode(short mask,short option);
        [DllImport("gts.dll")]
        public static extern short GT_SetOverride(short crd,double synVelRatio);
        [DllImport("gts.dll")]
        public static extern short GT_SetOverride2(short crd,double synVelRatio);
        [DllImport("gts.dll")]
        public static extern short GT_InitLookAhead(short crd,short fifo,double T,double accMax,short n,ref TCrdData pLookAheadBuf);
        [DllImport("gts.dll")]
        public static extern short GT_GetLookAheadSpace(short crd,out Int32  pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetLookAheadSegCount(short crd,out Int32  pSegCount,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_CrdClear(short crd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_CrdStatus(short crd,out short  pRun,out Int32  pSegment,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_SetUserSegNum(short crd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetUserSegNum(short crd,out Int32  pSegment,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetUserSegNumWN(short crd,out Int32  pSegment,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetRemainderSegNum(short crd,out Int32  pSegment,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_SetCrdStopDec(short crd,double decSmoothStop,double decAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdStopDec(short crd,out double pDecSmoothStop,out double pDecAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_SetCrdLmtStopMode(short crd,short lmtStopMode);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdLmtStopMode(short crd,out short  pLmtStopMode);
        [DllImport("gts.dll")]
        public static extern short GT_GetUserTargetVel(short crd,out double pTargetVel);
        [DllImport("gts.dll")]
        public static extern short GT_GetSegTargetPos(short crd,out Int32  pTargetPos);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdPos(short crd,out double pPos);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdVel(short crd,out double pSynVel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserOn(short crd,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserOff(short crd,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserPrfCmd(short crd,double laserPower,short fifo,short channel);
        [DllImport("gts.dll")]

        public static extern short GT_SetG0Mode(short crd,short mode);
        [DllImport("gts.dll")]
        public static extern short GT_GetG0Mode(short crd,out short  pMode);
        [DllImport("gts.dll")]

        public static extern short GT_SetCrdMapBase(short crd,short Mapbase);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdMapBase(short crd,out short  pBase);
        [DllImport("gts.dll")]
        public static extern short GT_SetCrdBufferMode(short crd,  short bufferMode,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdBufferMode(short crd,out short  pBufferMode,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdSegmentTime(short crd,Int32 segmentIndex,out double pSegmentTime,out Int32  pSegmentNumber,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdTime(short crd,out TCrdTime pTime,short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowMaster(short crd, ref TBufFollowMaster pBufFollowMaster, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowEventCross(short crd, ref TBufFollowEventCross pEventCross, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowEventTrigger(short crd, ref TBufFollowEventTrigger pEventTrigger, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowStart(short crd, Int32 masterSegment, Int32 slaveSegment, Int32 masterFrameWidth, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowNext(short crd, Int32 width, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowReturn(short crd, double vel, double acc, short smoothPercent, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowMode(short crd, short source, short fifo, short channel, double startPower);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowRatio(short crd, double ratio, double minPower, double maxPower, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowOff(short crd, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowSpline(short crd, short tableId, double minPower, double maxPower, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowTable(short crd, short tableId, double minPower, double maxPower, short fifo, short channel);


        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdPrm(short core, short crd, ref TCrdPrm pCrdPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdPrm(short core,short crd,out TCrdPrm pCrdPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdSpace(short core,short crd,out Int32  pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdData(short core, short crd, IntPtr pCrdData, short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_LnXY(short core,short crd,Int32 x,Int32 y,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYOverride2(short core,short crd,Int32 x,Int32 y,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYWN(short core,short crd,Int32 x,Int32 y,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYOverride2WN(short core,short crd,Int32 x,Int32 y,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_LnXYG0(short core,short crd,Int32 x,Int32 y,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYG0Override2(short core,short crd,Int32 x,Int32 y,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYG0WN(short core,short crd,Int32 x,Int32 y,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYG0Override2WN(short core,short crd,Int32 x,Int32 y,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_LnXYZ(short core,short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZOverride2(short core,short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZWN(short core,short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZOverride2WN(short core,short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_LnXYZG0(short core,short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZG0Override2(short core,short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZG0WN(short core,short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZG0Override2WN(short core,short crd,Int32 x,Int32 y,Int32 z,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_LnXYZA(short core,short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZAOverride2(short core,short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZAWN(short core,short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZAOverride2WN(short core,short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_LnXYZAG0(short core,short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZAG0Override2(short core,short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZAG0WN(short core,short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZAG0Override2WN(short core,short crd,Int32 x,Int32 y,Int32 z,Int32 a,double synVel,double synAcc,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_LnXYZACUVW(short core,short crd,ref Int32  pPos,short posMask,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZACUVWOverride2(short core,short crd,ref Int32  pPos,short posMask,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZACUVWWN(short core,short crd,ref Int32  pPos,short posMask,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_LnXYZACUVWOverride2WN(short core,short crd,ref Int32  pPos,short posMask,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_ArcXYR(short core,short crd,Int32 x,Int32 y,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYROverride2(short core,short crd,Int32 x,Int32 y,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYRWN(short core,short crd,Int32 x,Int32 y,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYROverride2WN(short core,short crd,Int32 x,Int32 y,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_ArcXYC(short core,short crd,Int32 x,Int32 y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYCOverride2(short core,short crd,Int32 x,Int32 y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYCWN(short core,short crd,Int32 x,Int32 y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYCOverride2WN(short core,short crd,Int32 x,Int32 y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_ArcYZR(short core,short crd,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcYZROverride2(short core,short crd,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcYZRWN(short core,short crd,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcYZROverride2WN(short core,short crd,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_ArcYZC(short core,short crd,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcYZCOverride2(short core,short crd,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcYZCWN(short core,short crd,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcYZCOverride2WN(short core,short crd,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_ArcZXR(short core,short crd,Int32 z,Int32 x,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcZXROverride2(short core,short crd,Int32 z,Int32 x,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcZXRWN(short core,short crd,Int32 z,Int32 x,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcZXROverride2WN(short core,short crd,Int32 z,Int32 x,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_ArcZXC(short core,short crd,Int32 z,Int32 x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcZXCOverride2(short core,short crd,Int32 z,Int32 x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcZXCWN(short core,short crd,Int32 z,Int32 x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcZXCOverride2WN(short core,short crd,Int32 z,Int32 x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_HelixXYRZ(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixXYRZOverride2(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixXYRZWN(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixXYRZOverride2WN(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_HelixXYCZ(short core,short crd,Int32 x,Int32 y,Int32 z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixXYCZOverride2(short core,short crd,Int32 x,Int32 y,Int32 z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixXYCZWN(short core,short crd,Int32 x,Int32 y,Int32 z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixXYCZOverride2WN(short core,short crd,Int32 x,Int32 y,Int32 z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_HelixYZRX(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixYZRXOverride2(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixYZRXWN(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixYZRXOverride2WN(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_HelixYZCX(short core,short crd,Int32 x,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixYZCXOverride2(short core,short crd,Int32 x,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixYZCXWN(short core,short crd,Int32 x,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixYZCXOverride2WN(short core,short crd,Int32 x,Int32 y,Int32 z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_HelixZXRY(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixZXRYOverride2(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixZXRYWN(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixZXRYOverride2WN(short core,short crd,Int32 x,Int32 y,Int32 z,double radius,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_HelixZXCY(short core,short crd,Int32 x,Int32 y,Int32 z,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixZXCYOverride2(short core,short crd,Int32 x,Int32 y,Int32 z,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixZXCYWN(short core,short crd,Int32 x,Int32 y,Int32 z,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_HelixZXCYOverride2WN(short core,short crd,Int32 x,Int32 y,Int32 z,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,double velEnd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]

        public static extern short GTN_BufIO(short core,short crd,short doType,ushort doMask,ushort doValue,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDelay(short core,short crd,ushort delayTime,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDA(short core,short crd,short chn,short daValue,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufIOWN(short core, short crd, Int16 doType, Int16 doMask, Int16 doValue, Int32 segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDelayWN(short core,short crd,Int16 delayTime,Int32 segNum,short fifo=0);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDAWN(short core,short crd,short chn,short daValue,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLmtsOn(short core, short crd, short axis, short limitType, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLmtsOff(short core,short crd,short axis,short limitType,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufSetStopIo(short core,short crd,short axis,short stopType,short inputType,short inputIndex,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufMove(short core,short crd,short moveAxis,Int32 pos,double vel,double acc,short modal,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufGear(short core,short crd,short gearAxis,Int32 pos,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufGearPercent(short core,short crd,short gearAxis,Int32 pos,short accPercent,short decPercent,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufStopMotion(short core,short crd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufSetVarValue(short core,short crd,short pageId,ref TVarInfo pVarInfo,double value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufJumpNextSeg(short core,short crd,short axis,short limitType,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufSynchPrfPos(short core,short crd,short encoder,short profile,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufVirtualToActual(short core,short crd,short fifo);
        
        
        [DllImport("gts.dll")]
        public static extern short GTN_CrdStart(short core,short mask,short option);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdStartStep(short core,short mask,short option);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdStepMode(short core,short mask,short option);
        [DllImport("gts.dll")]
        public static extern short GTN_SetOverride(short core,short crd,double synVelRatio);
        [DllImport("gts.dll")]
        public static extern short GTN_SetOverride2(short core,short crd,double synVelRatio);
        [DllImport("gts.dll")]
        public static extern short GTN_InitLookAhead(short core,short crd,short fifo,double T,double accMax,short n,ref TCrdData pLookAheadBuf);
        [DllImport("gts.dll")]
        public static extern short GTN_GetLookAheadSpace(short core,short crd,out Int32  pSpace,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetLookAheadSegCount(short core,short crd,out Int32  pSegCount,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdClear(short core,short crd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdStatus(short core,short crd,out short  pRun,out Int32  pSegment,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetUserSegNum(short core,short crd,Int32 segNum,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetUserSegNum(short core,short crd,out Int32  pSegment,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetUserSegNumWN(short core,short crd,out Int32  pSegment,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetRemainderSegNum(short core,short crd,out Int32  pSegment,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdStopDec(short core,short crd,double decSmoothStop,double decAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdStopDec(short core,short crd,out double pDecSmoothStop,out double pDecAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdLmtStopMode(short core,short crd,short lmtStopMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdLmtStopMode(short core,short crd,out short  pLmtStopMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetUserTargetVel(short core,short crd,out double pTargetVel);
        [DllImport("gts.dll")]
        public static extern short GTN_GetSegTargetPos(short core,short crd,out Int32  pTargetPos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdPos(short core,short crd,out double pPos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdVel(short core,short crd,out double pSynVel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserOn(short core,short crd,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserOff(short core,short crd,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserPrfCmd(short core,short crd,double laserPower,short fifo,short channel);
        
        
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserFollowMode(short core, short crd, short source, short fifo, short channel, double startPower);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserFollowRatio(short core, short crd, double ratio, double minPower, double maxPower, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserFollowOff(short core, short crd, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserFollowSpline(short core, short crd, short tableId, double minPower, double maxPower, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserFollowTable(short core, short crd, short tableId, double minPower, double maxPower, short fifo, short channel);

        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowMaster(short core, short crd, ref TBufFollowMaster pBufFollowMaster, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowEventCross(short core, short crd, ref TBufFollowEventCross pEventCross, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowEventTrigger(short core, short crd, ref TBufFollowEventTrigger pEventTrigger, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowStart(short core, short crd, Int32 masterSegment, Int32 slaveSegment, Int32 masterFrameWidth, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowNext(short core, short crd, Int32 width, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowReturn(short core, short crd, double vel, double acc, short smoothPercent, short fifo);


        [DllImport("gts.dll")]
        public static extern short GTN_SetG0Mode(short core, short crd, short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetG0Mode(short core,short crd,out short  pMode);
        [DllImport("gts.dll")]

        public static extern short GTN_SetCrdMapBase(short core,short crd,short Mapbase);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdMapBase(short core,short crd,out short  pBase);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdBufferMode(short core,short crd,  short bufferMode,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdBufferMode(short core,short crd,out short  pBufferMode,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdSegmentTime(short core,short crd,Int32 segmentIndex,out double pSegmentTime,out Int32  pSegmentNumber,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdTime(short core,short crd,out TCrdTime pTime,short fifo);
       
        [DllImport("gts.dll")]
        public static extern short GT_GetCmdCount(short crd,out short  pResult,short fifo);

        /*-----------------------------------------------------------*/
        /* Compensate                                                */
        /*-----------------------------------------------------------*/

        [DllImport("gts.dll")]
        public static extern short GT_SetBacklash(short axis,Int32 value,double changeValue,Int32 dir);
        [DllImport("gts.dll")]
        public static extern short GT_GetBacklash(short axis,out Int32  pValue,out double pChangeValue,out Int32  pDir);
        [DllImport("gts.dll")]
        public static extern short GT_SetLeadScrewComp(short axis,short n,Int32 startPos,Int32 lenPos,ref Int32  pPositive,ref Int32  pNegative);
        [DllImport("gts.dll")]
        public static extern short GT_SetLeadScrewCompEx(short axis,short n,Int32 startPos,Int32 lenPos,ref Int32 pPositive,ref Int32 pNegative,double compChangeValue);
        [DllImport("gts.dll")]
        public static extern short GT_EnableLeadScrewComp(short axis,short mode);
        [DllImport("gts.dll")]
        public static extern short GT_SetLeadScrewCrossComp(short axis,short n,Int32 startPos,Int32 lenPos,ref Int32  pPositive,ref Int32  pNegative,short link);
        [DllImport("gts.dll")]
        public static extern short GT_EnableLeadScrewCrossComp(short axis,short mode);
        [DllImport("gts.dll")]
        public static extern short GT_GetCompensate(short axis,out double pPitchError,out double pCrossError,out double pBacklashError,out double pEncPos,out double pPrfPos);
        
        
        [DllImport("gts.dll")]
        public static extern short GTN_SetBacklash(short core,short axis,Int32 value,double changeValue,Int32 dir);
        [DllImport("gts.dll")]
        public static extern short GTN_GetBacklash(short core,short axis,out Int32  pValue,out double pChangeValue,out Int32  pDir);
        [DllImport("gts.dll")]
        public static extern short GTN_SetLeadScrewComp(short core,short axis,short n,Int32 startPos,Int32 lenPos,ref Int32  pPositive,ref Int32  pNegative);
        [DllImport("gts.dll")]
        public static extern short GTN_EnableLeadScrewComp(short core,short axis,short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetLeadScrewCrossComp(short core,short axis,short n,Int32 startPos,Int32 lenPos,ref Int32  pPositive,out Int32  pNegative,short link);
        [DllImport("gts.dll")]
        public static extern short GTN_EnableLeadScrewCrossComp(short core,short axis,short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCompensate(short core,short axis,out double pPitchError,out double pCrossError,out double pBacklashError,ref double pEncPos,ref double pPrfPos);
        
        
        public struct TLeadScrewPrm
        {
	        public short n;
	        public Int32 startPos;
	        public Int32 lenPos;
	        public Int32  pCompPos;
	        public Int32  pCompNeg;
        } 
       
        
        [DllImport("gts.dll")]
        public static extern short GT_SetLeadScrewTable(short axis,ref TLeadScrewPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_EnableLeadScrewTable(short axis,Int32 error);
        [DllImport("gts.dll")]
        public static extern short GT_DisableLeadScrewTable(short axis);
        [DllImport("gts.dll")]
        public static extern short GT_GetLeadScrewTablePrfPosCount(Int32 encPos,out TLeadScrewPrm pPrm,out short  pCountPositive,out short  pCountNegative);
        [DllImport("gts.dll")]
        public static extern short GT_GetLeadScrewTablePrfPosPositive(Int32 encPos,out TLeadScrewPrm pPrm,short index,out Int32  pPrfPosPositive);
        [DllImport("gts.dll")]
        public static extern short GT_GetLeadScrewTablePrfPosNegative(Int32 encPos,out TLeadScrewPrm pPrm,short index,out Int32  pPrfPosNegative);
        [DllImport("gts.dll")]

        public static extern short GTN_SetLeadScrewTable(short core,short axis,ref TLeadScrewPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_EnableLeadScrewTable(short core,short axis,Int32 error);
        [DllImport("gts.dll")]
        public static extern short GTN_DisableLeadScrewTable(short core,short axis);
        [DllImport("gts.dll")]
        public static extern short GTN_GetLeadScrewTablePrfPosCount(short core,Int32 encPos,out TLeadScrewPrm pPrm,out short  pCountPositive,out short  pCountNegative);
        [DllImport("gts.dll")]
        public static extern short GTN_GetLeadScrewTablePrfPosPositive(short core,Int32 encPos,out TLeadScrewPrm pPrm,short index,out Int32  pPrfPosPositive);
        [DllImport("gts.dll")]
        public static extern short GTN_GetLeadScrewTablePrfPosNegative(short core,Int32 encPos,out TLeadScrewPrm pPrm,short index,out Int32  pPrfPosNegative);


        public struct TCompensate2DTable
        {
	        public short count1;                                // ��������������СֵΪ2
            public short count2;                                // ��������������СֵΪ2
	        public Int32 posBegin1;                             // ���λ��
            public Int32 posBegin2;                             // ���λ��
	        public Int32 step1;                                 // ����
            public Int32 step2;                                 // ����
        } 

        public struct TCompensate2D
        {
	        public short enable;                                // 2D����ʹ�ܱ�־
	        public short tableIndex;                            // ��ʹ�õ�2D������
	        public short axisType1;                             // ���������
            public short axisType2;                             // ���������
	        public short axisIndex1;                            // ���������
            public short axisIndex2;                            // ���������
        } 
        [DllImport("gts.dll")]
        public static extern short GT_SetCompensate2DTable(short tableIndex,ref TCompensate2DTable pTable,ref Int32  pData,short extend);
        [DllImport("gts.dll")]
        public static extern short GT_GetCompensate2DTable(short tableIndex,out TCompensate2DTable pTable,out short  pExtend);
        [DllImport("gts.dll")]
        public static extern short GT_SetCompensate2D(short axis,ref TCompensate2D pComp2d);
        [DllImport("gts.dll")]
        public static extern short GT_GetCompensate2D(short axis,out TCompensate2D pComp2d);
        [DllImport("gts.dll")]
        public static extern short GT_GetCompensate2DValue(short axis,out double pValue);
       
        [DllImport("gts.dll")]
        public static extern short GTN_SetCompensate2DTable(short core,short tableIndex,ref TCompensate2DTable pTable,ref Int32  pData,short extend);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCompensate2DTable(short core,short tableIndex,out TCompensate2DTable pTable,out short  pExtend);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCompensate2D(short core,short axis,ref TCompensate2D pComp2d);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCompensate2D(short core,short axis,out TCompensate2D pComp2d);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCompensate2DValue(short core,short axis,out double pValue);

        /*-----------------------------------------------------------*/
        /* IO and Encoder                                            */
        /*-----------------------------------------------------------*/

        [DllImport("gts.dll")]
        public static extern short GT_SetDo(short doType,Int32 value);
        [DllImport("gts.dll")]
        public static extern short GT_SetDoBit(short doType,short doIndex,short value);
        [DllImport("gts.dll")]
        public static extern short GT_GetDo(short doType,out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GT_SetDoBitReverse(short doType,short doIndex,short value,short reverseTime);
        [DllImport("gts.dll")]
        public static extern short GT_GetDi(short diType,out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GT_GetDiReverseCount(short diType,short diIndex,out UInt32 pReverseCount,short count);
        [DllImport("gts.dll")]
        public static extern short GT_SetDiReverseCount(short diType,short diIndex,ref UInt32 pReverseCount,short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetDiRaw(short diType,out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GT_GetDiEx(short diType,out Int32  pValue,short count);
        
        
        [DllImport("gts.dll")]
        public static extern short GT_SetDac(short dac,ref short  pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetDac(short dac,out short  pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAdc(short adc,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAdcValue(short adc,out short  pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAuAdc(short adc,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAuAdcValue(short adc,out short pValue,short count,out UInt32 pClock);

        
        [DllImport("gts.dll")]
        public static extern short GT_SetEncPos(short encoder,Int32 encPos);
        [DllImport("gts.dll")]
        public static extern short GT_GetEncPos(short encoder,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetEncPosPre(short encoder,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetEncVel(short encoder,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetEncVelEx(short encoder, out double pValue, short count, out UInt32 pClock);
        
        
        [DllImport("gts.dll")]
        public static extern short GT_SetPlsPos(short encoder,Int32 encPos);
        [DllImport("gts.dll")]
        public static extern short GT_GetPlsPos(short pulse,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetPlsVel(short pulse,out double pValue,short count,out UInt32 pClock);
       
        
        [DllImport("gts.dll")]
        public static extern short GT_SetAuEncPos(short encoder,Int32 encPos);
        [DllImport("gts.dll")]
        public static extern short GT_GetAuEncPos(short encoder,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAuEncVel(short encoder,out double pValue,short count,out UInt32 pClock);
        
        
        [DllImport("gts.dll")]
        public static extern short GTN_SetDo(short core,short doType,Int32 value);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDoEx(short core, short doType, ref Int32 pValue, short count);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDoBit(short core,short doType,short doIndex,short value);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDo(short core,short doType,out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDoBitReverse(short core,short doType,short doIndex,short value,short reverseTime);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDi(short core,short diType,out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDiReverseCount(short core,short diType,short diIndex,out UInt32 pReverseCount,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDiReverseCount(short core,short diType,short diIndex,ref UInt32 pReverseCount,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDiRaw(short core,short diType,out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDiEx(short core,short diType,out Int32  pValue,short count);
       
        
        [DllImport("gts.dll")]
        public static extern short GTN_WriteAo(short core,Int32 aoType,short aoIndex,ref double pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDac(short core,short dac,ref short  pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDac(short core,short dac,out short  pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAuDac(short core,short dac,ref short pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAuDac(short core, short dac, out short pValue, short count, out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAdc(short core,short adc,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAdcValue(short core,short adc,out short  pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAuAdc(short core,short adc,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAuAdcValue(short core,short adc,out short pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEncLineNum(short core,short encoder,out Int32 pLineNum,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEncType(short core, short encoder, out short pType, short count, out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_SetEncPos(short core,short encoder,Int32 encPos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEncPos(short core,short encoder,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEncPosPre(short core,short encoder,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEncVel(short core,short encoder,out double pValue,short count,out UInt32 pClock);
      
        
        [DllImport("gts.dll")]
        public static extern short GTN_SetPlsPos(short core,short encoder,Int32 encPos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPlsPos(short core,short pulse,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPlsVel(short core,short pulse,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]

        public static extern short GTN_SetAuEncPos(short core,short encoder,Int32 encPos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAuEncPos(short core,short encoder,out double pValue,short count,out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAuEncVel(short core,short encoder,out double pValue,short count,out UInt32 pClock);
      
        
        [DllImport("gts.dll")]
        public static extern short GTN_GetAbsEncPos(short core,short encoder,out Int32  pValue,short mode,short param);

        [DllImport("gts.dll")]
        public static extern short GTN_InitFPGAEncoder(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFPGAEncoder(short core, short enable, Int32 intervalTime, short reverseMask);
        [DllImport("gts.dll")]
        public static extern short GTN_GetFPGAEncoder(short core, out Int32 pDataChn1, out Int32 pDataChn2, out Int32 pDataChn3, out Int32 pDataChn4, out Int32 pCount, out Int32 pOverFlowFlag);

        /*-----------------------------------------------------------*/
        /* ExtModule                                                 */
        /*-----------------------------------------------------------*/
        [DllImport("gts.dll")]
        public static extern short GTN_ExtModuleInit(short core,short method);
        [DllImport("gts.dll")]
        public static extern short GTN_SetILinkManuMode(short core, short station);
        [DllImport("gts.dll")]
        public static extern short GTN_GetILinkManuId(short core, short station, short autoId, out short manuId);
        [DllImport("gts.dll")]
        public static extern short GTN_GetILinkAutoId(short core, short station, short manuId, out short autoId);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtDoBit(short core,short doIndex,short value);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtDoBit(short core, short doIndex, out short pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtDo(short core,short doIndex,Int32 value,Int32 mask);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtDo(short core,short doIndex,out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtDiBit(short core,short diIndex,out short pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtDi(short core,short diIndex,out Int32 pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtAoValue(short core,short index,out short pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtAiValue(short core,short index,out short pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtAo(short core,short index,ref double pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtAo(short core,short index,out double pValue,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtAi(short core,short index,out double pValue,short count);

        [DllImport("gts.dll")]
        public static extern short GTN_SetILinkDo(short core,short station,short module,ushort data,ushort mask);
        [DllImport("gts.dll")]
        public static extern short GTN_GetILinkDi(short core,short station,short module,ushort data);
        [DllImport("gts.dll")]
        public static extern short GTN_SetILinkAo(short core,short station,short module,short channel,short data);
        [DllImport("gts.dll")]
        public static extern short GTN_GetILinkAi(short core,short station,short module,short channel,out short data);

        /*-----------------------------------------------------------*/
        /* Pos Compare                                               */
        /*-----------------------------------------------------------*/
        public const short POS_COMPARE_MODE_FIFO = 0;
        public const short POS_COMPARE_MODE_LINEAR = 1;
        public const short POS_COMPARE_MODE_EQUIDISTANT = 2;

        public const short POS_COMPARE_OUTPUT_PULSE = 0;
        public const short POS_COMPARE_OUTPUT_LEVEL = 1;

        public const short POS_COMPARE_SOURCE_ENCODER = 0;
        public const short POS_COMPARE_SOURCE_PULSE = 1;


        public struct TPosCompareMode
        {
	        public short mode;                       
	        public short dimension;                  
	        public short sourceMode;                 
	        public short sourceX;                    
	        public short sourceY;                    
	        public short outputMode;                
	        public short outputCounter;              
	        public ushort outputPulseWidth;  
            public ushort errorBand;         
        } 

        public struct TPosCompareLinear
        {
	        public UInt32 count;
            public ushort hso;
            public ushort gpo;

	        public Int32 startPos;
	        public Int32 interval;
        } 

        public struct TPosCompareLinear2D
        {
	        public UInt32 count;
            public ushort hso;
            public ushort gpo;

	        public Int32 startPosX;
	        public Int32 startPosY;
	        public Int32 intervalX;
	        public Int32 intervalY;
        } 


        public struct TPosCompareData
        {
	        public Int32 pos;
            public ushort hso;
            public ushort gpo;
	        public UInt32 segmentNumber;
        } 

        public struct TPosCompareData2D
        {
	        public Int32 posX;
	        public Int32 posY;
            public ushort hso;
            public ushort gpo;
	        public UInt32 segmentNumber;
        } 

        public struct TPosCompareStatus
        {
            public ushort mode;      
            public ushort run;
            public ushort space;
	        public UInt32 pulseCount;
            public ushort hso;
            public ushort gpo;
	        public UInt32 segmentNumber;
        } 

        public struct TPosCompareInfo
        {
            public ushort config;
            public ushort fifoEmpty;
            public ushort head;
            public ushort tail;
	        public UInt32 commandReceive;
	        public UInt32 commandSend;
	        public Int32 posX;
	        public Int32 posY;
        } 
        
        public struct TPosComparePsoPrm
        {
            public UInt32 count;
            public Int16 hso;
            public UInt16 gpo;
            public Int32 startPosX;
            public Int32 startPosY;
            public Int32 syncPos;
            public Int32 time;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 20)]
            public short[] reserve;
        }


        public struct TPosCompareContinueMode
        {
            public short mode;
            public Int16 count;
            public short highLevel;
            public short lowLevel;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public short[] reserve;
        }
		
		public struct THsoPulsePrm
		{
			public short mode;          // 0���������1����Ĭ�����������2�����յ�ǰָ��������Ϣ���
			public short timeScale;     // ʱ�侫�ȣ�0��1us��1:0.1us
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public short[] pad1;
			public double pulseWidth;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public double[] pad2;
		};
		
		public struct TPosComparePulse
		{
			public short outputMode;
			public short level;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public short[] reserve1;
			public double highLevelTime;
			public double lowLevelTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public double[] reserve2;
		};
		
		public struct  TPosComparePulseStatus
		{
			public Int32 count;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public short[] reserve1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public double[] reserve2;
		};


        [DllImport("gts.dll")]
        public static extern short GT_PosCompareStart(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GT_PosCompareStop(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GT_PosCompareClear(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GT_PosCompareStatus(short core,short index,out TPosCompareStatus pStatus);
        [DllImport("gts.dll")]
        public static extern short GT_PosCompareData(short core,short index,ref TPosCompareData pData);
        [DllImport("gts.dll")]
        public static extern short GT_PosCompareData2D(short core,short index,ref TPosCompareData2D pData);
		[DllImport("gts.dll")]
		public static extern short GTN_PosComparePulse(short core,short index,short outputMode,short level,UInt16 outputPulseWidth);
		[DllImport("gts.dll")]
		public static extern short GTN_SetPosComparePulseCount(short core,short index,Int32 count);
		[DllImport("gts.dll")]
		public static extern short GTN_PosComparePulseEx(short core,short index,ref TPosComparePulse pPosComparePulse);
		[DllImport("gts.dll")]
		public static extern short GTN_GetPosComparePulseStatus(short core,short index,out TPosComparePulseStatus pPosComparePulseStatus);
		[DllImport("gts.dll")]
        public static extern short GT_SetPosCompareMode(short core,short index,ref TPosCompareMode pMode);
        [DllImport("gts.dll")]
        public static extern short GT_GetPosCompareMode(short core,short index,out TPosCompareMode pMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetPosCompareLinear(short core,short index,ref TPosCompareLinear pLinear);
        [DllImport("gts.dll")]
        public static extern short GT_GetPosCompareLinear(short core,short index,out TPosCompareLinear pLinear);
        [DllImport("gts.dll")]
        public static extern short GT_SetPosCompareLinear2D(short core,short index,ref TPosCompareLinear2D pLinear);
        [DllImport("gts.dll")]
        public static extern short GT_GetPosCompareLinear2D(short core,short index,out TPosCompareLinear2D pLinear);
        [DllImport("gts.dll")]
        public static extern short GT_PosCompareInfo(short core,short index,out TPosCompareInfo pInfo);
        [DllImport("gts.dll")]
        public static extern short GT_SetPosComparePsoPrm(short core, short index, ref TPosComparePsoPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetPosComparePsoPrm(short core, short index, out TPosComparePsoPrm pPrm);

        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareStart(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareStop(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareClear(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareStatus(short core,short index,out TPosCompareStatus pStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareData(short core,short index,ref TPosCompareData pData);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareData2D(short core,short index,ref TPosCompareData2D pData);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPosCompareMode(short core,short index,ref TPosCompareMode pMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosCompareMode(short core,short index,out TPosCompareMode pMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPosCompareContinueMode(short core,short index,ref TPosCompareContinueMode pMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosCompareContinueMode(short core,short index,out TPosCompareContinueMode pMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPosCompareLinear(short core,short index,ref TPosCompareLinear pLinear);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosCompareLinear(short core,short index,out TPosCompareLinear pLinear);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPosCompareLinear2D(short core,short index,ref TPosCompareLinear2D pLinear);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosCompareLinear2D(short core,short index,out TPosCompareLinear2D pLinear);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareInfo(short core,short index,out TPosCompareInfo pInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareHsOn(short core,short index,short link,Int16 threshold);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareHsOff(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCompareSpace(short core,short index,out Int16 pSpace);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPosComparePsoPrm(short core,short index,ref TPosComparePsoPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosComparePsoPrm(short core,short index,out TPosComparePsoPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPosCompareStartLevel(short core,short index,short type,short startLevel);

		[DllImport("gts.dll")]
		public static extern short GTN_SetHsoPulsePrm(short core,short station,short hsoIndex,ref THsoPulsePrm pPem,short hsoCount);
		[DllImport("gts.dll")]
		public static extern short GTN_GetHsoPulsePrm(short core,short station,short hsoIndex,out THsoPulsePrm pPem,short hsoCount);

        public const short COMPARE_SEND_DATA_MAX = 30;
        public const short COMPARE_DATA_MAX = 4096;
        public const Int32 COMPARE_STEP_MAX = 0x1fff;
        public const Int32 COMPARE_MAX_NUM = 0x3fffffff;

        [DllImport("gts.dll")]
        public static extern short GT_ComparePulse(short level, short outputType, short time);
        [DllImport("gts.dll")]
        public static extern short GT_CompareStop();
        [DllImport("gts.dll")]
        public static extern short GT_CompareStatus(out short pStatus, out Int32 pCount);
        [DllImport("gts.dll")]
        public static extern short GT_CompareData(short encoder, short source, short pulseType, short startLevel, short time,
            ref Int32 pBuf1, short count1, ref Int32 pBuf2, short count2);
        [DllImport("gts.dll")]
        public static extern short GT_CompareLinear(short encoder, short channel, Int32 startPos, Int32 repeatTimes, Int32 interval, short time, short source);


        /*-----------------------------------------------------------*/
        /* Laser and Scan                                            */
        /*-----------------------------------------------------------*/
        public const short FIFO_MODE_STATIC = 0;
        public const short FIFO_MODE_DYNAMIC = 1;

        public const short SCAN_STATUS_WAIT = 0;
        public const short SCAN_STATUS_RUN = 1;
        public const short SCAN_STATUS_DONE = 2;

        public struct TScanInit
        {
	        public int lookAheadNum;             //ǰհ����
	        public double time;                  //ʱ�䳣��
	        public double radiusRatio;           //�������Ƶ��ڲ���
        }

        public struct TScanInfo
        {
	        public UInt32 segmentNumber;
            public ushort commandNumber;
            public ushort prfVel;
            public ushort fifoEmpty;
            public ushort head;
            public ushort tail;
	        public UInt32 commandReceive;
	        public UInt32 commandSend;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 6)]
	        public UInt32[] reserve;

        }

        public struct TScanPosSuperposeParameter
        {
            public short enable;
            public short superposeSrc;
            public short superposeAxisX;
            public short superposeAxisY;
            public double xCoefficient;
            public double yCoefficient;
			public double xVelCoefficient;
			public double yVelCoefficient;
        }

        public struct TLaserInfo
        {
            public ushort hso;
            public ushort powerMode;
            public ushort power;
            public ushort powerMax;
            public ushort powerMin;
            public ushort frequency;
            public ushort pulseWidth;
        } 
        public struct TLaserPowerPrm
        {
            public short n;
            public double startVel;
            public double power;
        }

        public struct TLaserPowerTable
        {
            public short n;
            public double startVel;
            public double velStep;
            public double power;
        }
        //typedef struct
        //{
        //    short corrX[65][65];
        //    short corrY[65][65];
        //}TScanCorrectionTableData;

        [DllImport("gts.dll")]
        public static extern short GT_LaserAo(short value,Int16 laserChannel);
        [DllImport("gts.dll")]
        public static extern short GT_SetHSIOOpt(Int16 value,short channel);
        [DllImport("gts.dll")]
        public static extern short GT_GetHSIOOpt(ref Int16 pValue,short channel);
        [DllImport("gts.dll")]
        public static extern short GT_SetLaserMode(Int16 laserMode);
        [DllImport("gts.dll")]
        public static extern short GT_LaserPowerMode(short laserPowerMode,double maxValue,double minValue,short laserChannel,short delayMode);
        [DllImport("gts.dll")]
        public static extern short GT_LaserPrfCmd(double power,Int16 laserChannel);
        [DllImport("gts.dll")]
        public static extern short GT_LaserOutFrq(double outFrq,Int16 laserChannel);
        [DllImport("gts.dll")]
        public static extern short GT_SetPulseWidth(Int16 width1,Int16 laserChannel);
        [DllImport("gts.dll")]
        public static extern short GT_SetLevelDelay(Int16 highLevelDelay, Int16 lowLevelDelay, Int16 laserChannel);
        [DllImport("gts.dll")]
        public static extern short GT_LaserInfo(out TLaserInfo pLaserInfo,short crd);

        [DllImport("gts.dll")]
        public static extern short GTN_ScanInit(short core, ref TScanInit pScanInit, double jumpAcc, double markAcc, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanCrdDataEnd(short core, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_SetScanLaserLink(short core, short link, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_GetScanLaserLink(short core, out short pLink, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_SetScanMode(short core, short mode, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_GetScanMode(short core, out short pMode, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearScanStatus(short core, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanGetCrdPos(short core, out short pPos, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanJump(short core, short x, short y, double vel, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanJumpPoint(short core, short x, short y, double vel, Int32 motionDelayTime, Int32 laserDelayTime, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanTimeJump(short core, short x, short y, ushort time, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanTimeJumpPoint(short core, short x, short y, ushort time, Int32 motionDelayTime, Int32 laserDelayTime, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanMark(short core, short x, short y, double vel, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanTimeMark(short core, short x, short y, ushort time, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufLaserPrfCmd(short core, double laserPower, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufIO(short core, ushort doType, ushort doMask, ushort doValue, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufDelay(short core, Int32 time, short crd);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufDA(short core, ushort chn, short value, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufAO(short core,Int16 chn,double voltage,short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufLaserDelay(short core, short laserOnDelay, short laserOffDelay, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufLaserOutFrq(short core, double outFrq, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufSetPulseWidth(short core, ushort width, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufLaserOn(short core, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufLaserOff(short core, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanBufStop(short core, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanLaserIntervalOnList(short core, Int32 time, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_SetScanDelayTime(short core, ushort maxJumpDelay, ushort markDelay, ushort multiMarkDelayConst, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_SetScanDelayMode(short core, short multiMarkDelayMode, ushort multiMarkLaserOffDelay, ushort minJumpDelay, ushort jumpDelayLengthLimit, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanStop(short core, short stopType, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanCrdSpace(short core, out short pSpace, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanCrdStart(short core, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanCrdClear(short core, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanCrdStatus(short core, out short pRun, out short pStatus, short scan);
        
        
        [DllImport("gts.dll")]
        public static extern short GTN_SetScanPosSuperposeParameter(short core,short crd,TScanPosSuperposeParameter param);
        //[DllImport("gts.dll")]
        //public static extern short GTN_ScanSetCorrectionTable(short core,short crd,ref TScanCorrectionTableData pParam);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanCorrectionOn(short core,short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanCorrectionOff(short core,short scan);
        //[DllImport("gts.dll")]
        //public static extern short GTN_ScanGenerateCorrectionTable(short core,double paraX,double paraY,short rangeX,short rangeY,ref TScanCorrectionTableData pParam);

        [DllImport("gts.dll")]
        public static extern short GTN_LaserOn(short core,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_LaserOff(short core,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_LaserOnStatus(short core,out ushort pValue,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_LaserPowerMode(short core,short laserPowerMode,double maxValue,double minValue,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_LaserPrfCmd(short core,double power,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_LaserOutFrq(short core,double outFrq,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPulseWidth(short core,ushort width,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_SetLevelDelay(short core,UInt32 highLevelDelay,UInt32 lowLevelDelay,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_LaserInfo(short core,out TLaserInfo pLaserInfo,short channel);

        [DllImport("gts.dll")]
        public static extern short GTN_ScanInfo(short core,ref TScanInfo pScanInfo,short crd);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanHsOn(short core,short crd,short link,Int16 threshold);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanHsOff(short core,short crd);
        

        [DllImport("gts.dll")]
        public static extern short GTN_ScanLaserOn(short core,short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanLaserOff(short core,short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanLaserOnStatus(short core,out Int16 pValue,short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanSetLaserMode(short core,Int16 laserMode, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanLaserPowerMode(short core,short laserPowerMode,double maxValue,double minValue, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanLaserPrfCmd(short core,double power, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanLaserOutFrq(short core,double outFrq, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanSetPulseWidth(short core,Int16 width, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanSetLevelDelay(short core, Int16 highLevelDelay, Int16 lowLevelDelay, short scan);
        [DllImport("gts.dll")]
        public static extern short GTN_ScanLaserInfo(short core,ref TLaserInfo pLaserInfo, short scan);


        /*-----------------------------------------------------------*/
        /* DLM                                                       */
        /*-----------------------------------------------------------*/
        public const short DLM_FUNCTION_EVENT = 0;
        public const short DLM_FUNCTION_TIMER = 1;
        public const short DLM_FUNCTION_BACKGROUND = 2;
        public const short DLM_FUNCTION_COMMAND	= 3;

        public const short DLM_FUNCTION_PROCEDURE = 7;

        public const short DLM_FUNCTION_PROFILE_EVENT = 8;
        public const short DLM_FUNCTION_PROFILE	= 9;
        public const short DLM_FUNCTION_PROFILE_SUPERIMPOSED = 10;
        public const short DLM_FUNCTION_PROFILE_FILTER = 11;

        public const short DLM_FUNCTION_SERVO_EVENT = 16;
        public const short DLM_FUNCTION_SERVO = 17;
        public const short DLM_FUNCTION_SERVO_SUPERIMPOSED = 18;
        public const short DLM_FUNCTION_SERVO_FILTER = 19;

        public const short DLM_LOAD_MODE_NONE = 0;
        public const short DLM_LOAD_MODE_COMMAND = 1;
        public const short DLM_LOAD_MODE_BOOT = 2;
        public const short DLM_LOAD_MODE_RUN = 3;

        public struct TDlmStatus
        {
	        public Int32 version;
	        public Int32 date;
	        public short enable;
	        public Int32 function;
        } 

        public struct TDlmFunction
        {
	        public short function;
	        public short enable;
	        public Int32 value;
        } 
        [DllImport("gts.dll")]
        public static extern short GT_LoadDlm(Int32 vender,Int32 module,string fileName,out short  pId);
        [DllImport("gts.dll")]
        public static extern short GT_ProgramDlm(short id,short loadMode);
        [DllImport("gts.dll")]
        public static extern short GT_GetDlmLoadMode(short id,out short  pLoadMode);
        [DllImport("gts.dll")]
        public static extern short GT_RunDlm(short id);
        [DllImport("gts.dll")]
        public static extern short GT_StopDlm(short id);
        [DllImport("gts.dll")]
        public static extern short GT_GetDlmStatus(short id,out TDlmStatus pStatus);
        [DllImport("gts.dll")]
        public static extern short GT_SetDlmFunction(short id,ref TDlmFunction pFunction);
        [DllImport("gts.dll")]
        public static extern short GT_GetDlmFunction(short id,out TDlmFunction pFunction);
        
        
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandInit(short code,Int32 index);
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandAdd16(short value);
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandAdd32(Int32 value);
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandAddFloat(float value);
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandAddDouble(double value);
        [DllImport("gts.dll")]
        public static extern short GT_SendDlmCommand(short id,out short  pReturnValue);
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandGet16(out short  pValue);
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandGet32(out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandGetFloat(out float pValue);
        [DllImport("gts.dll")]
        public static extern short GT_DlmCommandGetDouble(out double pValue);
        [DllImport("gts.dll")]


        public static extern short GTN_LoadDlm(short core,Int32 vender,Int32 module,string fileName,out short  pId);
        [DllImport("gts.dll")]
        public static extern short GTN_ProgramDlm(short core,short id,short loadMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDlmLoadMode(short core,short id,out short  pLoadMode);
        [DllImport("gts.dll")]
        public static extern short GTN_RunDlm(short core,short id);
        [DllImport("gts.dll")]
        public static extern short GTN_StopDlm(short core,short id);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDlmStatus(short core,short id,out TDlmStatus pStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDlmFunction(short core,short id,ref TDlmFunction pFunction);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDlmFunction(short core,short id,out TDlmFunction pFunction);
        [DllImport("gts.dll")]


        public static extern short GTN_DlmCommandInit(short core,short code,Int32 index);
        [DllImport("gts.dll")]
        public static extern short GTN_DlmCommandAdd16(short core,short value);
        [DllImport("gts.dll")]
        public static extern short GTN_DlmCommandAdd32(short core,Int32 value);
        [DllImport("gts.dll")]
        public static extern short GTN_DlmCommandAddFloat(short core,float value);
        [DllImport("gts.dll")]
        public static extern short GTN_DlmCommandAddDouble(short core,double value);
        [DllImport("gts.dll")]
        public static extern short GTN_SendDlmCommand(short core,short id,out short  pReturnValue);
        [DllImport("gts.dll")]
        public static extern short GTN_DlmCommandGet16(short core,out short  pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_DlmCommandGet32(short core,out Int32  pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_DlmCommandGetFloat(short core,ref float pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_DlmCommandGetDouble(short core,out double pValue);

        /*-----------------------------------------------------------*/
        /* Event-Task                                                */
        /*-----------------------------------------------------------*/
        public const short TASK_SET_DO_BIT = 0x1101;
        public const short TASK_SET_DAC	= 0x1120;

        public const short TASK_STOP = 0x1303;

        public const short TASK_UPDATE_POS = 0x2002;
        public const short TASK_UPDATE_VEL = 0x2004;

        public const short TASK_PT_START = 0x2306;
        public const short TASK_PVT_START = 0x2346;
        public const short TASK_MOVE_ABSOLUTE = 0x2500;

        public const short TASK_GEAR_START = 0x3005;

        public const short TASK_FOLLOW_START = 0x310A;
        public const short TASK_FOLLOW_SWITCH = 0x310B;

        public const short TASK_CRD_START = 0x4004;
        public const short TASK_SCAN_START = 0x4102;

        public const short TASK_SET_DO_BIT_MODE_NONE = 0;
        public const short TASK_SET_DO_BIT_MODE_TIME = 10;
        public const short TASK_SET_DO_BIT_MODE_DISTANCE = 20;

        public struct TWatchVar
        {
            public Int16 type;
            public Int16 index;
            public Int16 id;
        }

        public struct   TTaskSetDoBit
        {
	        public short doType;
	        public short doIndex;
	        public short doValue;
	        public short mode;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 8)]
	        public Int32[] parameter;
        } 

        public struct  TTaskSetDac
        {
	        public short dac;
	        public short value;
        } 

        public struct  TTaskStop
        {
	        public Int32 mask;
	        public Int32 option;
        } 

        public struct  TTaskFifoOperation
        {
	        public short type;
	        public short index;
	        public short operation;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 20)]
	        public short[] data;
        } 

        public struct  TTaskUpdatePos
        {
	        public short profile;
	        public Int32 pos;
        }

        public struct TTaskUpdateDistance
        {
            public short profile;
            public short triggerIndex;
            public Int32 distance;
        } 
        public struct  TTaskUpdateVel
        {
	        public short profile;
	        public double vel;
        } 

        public struct  TTaskPtStart
        {
	        public Int32 mask;
	        public Int32 option;
        } 

        public struct  TTaskPvtStart
        {
	        public Int32 mask;
        } 

        public struct  TTaskGearStart
        {
	        public Int32 mask;
        } 

        public struct TTaskFollowStart
        {
	        public Int32 mask;
	        public Int32 option;
        } 

        public struct TTaskFollowSwitch
        {
	      public Int32 mask;
        } 

        public struct  TTaskMoveAbsolute
        {
	        public short profile;
	        public Int32 pos;
	        public double vel;
	        public double acc;
	        public double dec;
	        public short percent;
        } 

        public struct  TTaskCrdStart
        {
	        public short mask;
	        public short option;
        } 

        public struct  TTaskScanStart
        {
	        public short core;
	        public short index;
	        public short count;
        } 

        public struct  TEvent
        {
	        public UInt32 loop;
	        public TWatchVar var;
            public ushort condition;
	        public double value;
        } 
        [DllImport("gts.dll")]
        public static extern short GT_ClearEvent();
        [DllImport("gts.dll")]
        public static extern short GT_ClearTask();
        [DllImport("gts.dll")]
        public static extern short GT_ClearEventTaskLink();
        [DllImport("gts.dll")]
        public static extern short GT_AddTask(short taskType, IntPtr pTaskData, out short pTaskIndex);
        [DllImport("gts.dll")]
        public static extern short GT_AddEvent(ref TEvent pEvent,out short  pEventIndex);
        [DllImport("gts.dll")]
        public static extern short GT_AddEventTaskLink(short eventIndex,short taskIndex,out short  pLinkIndex);
        [DllImport("gts.dll")]
        public static extern short GT_GetEventCount(out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetEvent(short eventIndex,out TEvent pEvent);
        [DllImport("gts.dll")]
        public static extern short GT_GetEventLoop(short eventIndex,out UInt32 pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetTaskCount(out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetEventTaskLinkCount(out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetEventTaskLink(short linkIndex,out short  pEventIndex,out short  pTaskIndex);
        [DllImport("gts.dll")]
        public static extern short GT_EventOn(short eventIndex,short count);
        [DllImport("gts.dll")]
        public static extern short GT_EventOff(short eventIndex,short count);
       
        [DllImport("gts.dll")]
        public static extern short GTN_ClearEvent(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearTask(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearEventTaskLink(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_AddTask(short core,short taskType, IntPtr pTaskData, out short pTaskIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_AddEvent(short core,ref TEvent pEvent,out short  pEventIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_AddEventTaskLink(short core,short eventIndex,short taskIndex,out short  pLinkIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEventCount(short core,out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEvent(short core,short eventIndex,out TEvent pEvent);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEventLoop(short core,short eventIndex,out UInt32 pEventLoop);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTaskCount(short core,out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEventTaskLinkCount(short core,out short  pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetEventTaskLink(short core,short linkIndex,out short  pEventIndex,out short  pTaskIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_EventOn(short core,short eventIndex,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_EventOff(short core,short eventIndex,short count);
       
        /*--------- -------------------------------------------------*/
        /* Gantry                                                    */
        /*-----------------------------------------------------------*/
        public const short GANTRY_MODE_NONE = -1;
        public const short GANTRY_MODE_OPEN_LOOP_GANTRY = 1;
        public const short GANTRY_MODE_DECOUPLE_POSITION_LOOP = 2;

        [DllImport("gts.dll")]
        public static extern short GT_SetGantryMode(short group, short master, short slave, short mode, Int32 syncErrorLimit);
        [DllImport("gts.dll")]
        public static extern short GT_GetGantryMode(short group, out short pMaster, out short pSlave, out short pMode, out Int32 pSyncErrorLimit);
        [DllImport("gts.dll")]
        public static extern short GT_SetGantryPid(short group, ref TPid pGantryPid, ref TPid pYawPid);
        [DllImport("gts.dll")]
        public static extern short GT_GetGantryPid(short group, out TPid pGantryPid, out TPid pYawPid);
        [DllImport("gts.dll")]
        public static extern short GT_GantryAxisOn(short group);
        [DllImport("gts.dll")]
        public static extern short GT_GantryAxisOff(short group);

        [DllImport("gts.dll")]
        public static extern short GTN_SetGantryMode(short core, short group, short master, short slave, short mode, Int32 syncErrorLimit);
        [DllImport("gts.dll")]
        public static extern short GTN_GetGantryMode(short core, short group,out short pMaster,out short pSlave,out short pMode, out Int32 pSyncErrorLimit);
        [DllImport("gts.dll")]
        public static extern short GTN_SetGantryPid(short core, short group, ref TPid pGantryPid, ref TPid pYawPid);
        [DllImport("gts.dll")]
        public static extern short GTN_GetGantryPid(short core, short group, out TPid pGantryPid,out TPid pYawPid);
        [DllImport("gts.dll")]
        public static extern short GTN_GantryAxisOn(short core, short group);
        [DllImport("gts.dll")]
        public static extern short GTN_GantryAxisOff(short core, short group);


        public struct TSecondOrderFilterPara
        {
            public short active;

            public double a0;
            public double a1;
            public double a2;

            public double b1;
            public double b2;
        }

        public const short TYPE_CONTROL_OUTPUT_FILTER = 1;
        public const short TYPE_YAW_CONTROL_OUTPUT_FILTER = 2;
        public const short FILTER_COUNT_MAX = 2;


        [DllImport("gts.dll")]
        public static extern short GT_SetSecondOrderFilterPara(short control, short type, short index, ref TSecondOrderFilterPara pFilterPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetSecondOrderFilterPara(short control, short type, short index, out TSecondOrderFilterPara pFilterPrm);

        [DllImport("gts.dll")]
        public static extern short GTN_SetSecondOrderFilterPara(short core, short control, short type, short index, ref TSecondOrderFilterPara pFilterPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetSecondOrderFilterPara(short core, short control, short type, short index, out TSecondOrderFilterPara pFilterPrm);

        public struct OCA_CTRL_GEN
        {
            public short s16Gain;
            public short s16Offset;
            public double dFrq;
            public Int32 u32RunPeriod;
            public short u16SigType;
        }
        
        public struct TExcitationPara
        {
            public short gain;
            public short offset;
            public short frq;		// hz
            public double runTime;	// s
        }

        public struct TExcitationTrpPara
        {
            public double vel;
            public double acc;
            public double dec;
            public double runTime;	// s
        }


        public const short NO_EXCIT = 0xff;
        public const short OPEN_LOOP_EXCIT = 1;
        public const short SIGNAL_TYPE_STEP = 3;
        public const short SIGNAL_TYPE_SIN = 0x10;
        public const short SIGNAL_TYPE_TRAP = 0x11;
        public const short SIGNAL_TYPE_NOTHING = 0xFF;
        
        [DllImport("gts.dll")]
        public static extern short GT_SetGenerator(ref OCA_CTRL_GEN pGenStr);
        [DllImport("gts.dll")]
        public static extern short GT_GetGenerator(out OCA_CTRL_GEN pGenStr);
        [DllImport("gts.dll")]
        public static extern short GT_StepResponse(short control,short gain, double time);
        [DllImport("gts.dll")]
        public static extern short GT_SetExctLoopMode(short control,short exciteLoopMode);
        [DllImport("gts.dll")]
        public static extern short GT_GetExctLoopMode(short control,out short pExciteLoopMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetExcitation(short axis,short objectValue,short type,short pParameter);

        [DllImport("gts.dll")]
        public static extern short GTN_SetGenerator(short core,ref OCA_CTRL_GEN pGenStr);
       [DllImport("gts.dll")]
        public static extern short GTN_StepResponse(short core,short control,short gain,double time);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExctLoopMode(short core,short control,short exciteLoopMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExctLoopMode(short core,short control,out short pExciteLoopMode);

        [DllImport("gts.dll")]
        public static extern short GTN_SetExcitation(short core,short axis,short objectValue,short type,short pParameter);

        /*-----------------------------------------------------------*/
        /* DMA                                                       */
        /*-----------------------------------------------------------*/
        [DllImport("gts.dll")]
        public static extern short GT_CrdHsOn(short crd,short fifo,short link,Int16 threshold,short lookAheadInMc);
        [DllImport("gts.dll")]
        public static extern short GT_CrdHsOff(short crd,short fifo);

        [DllImport("gts.dll")]
        public static extern short GTN_CrdHsOn(short core, short crd, short fifo, short link, Int16 threshold, short lookAheadInMc);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdHsOff(short core,short crd,short fifo);

        /*-----------------------------------------------------------*/
        /* Others                                                    */
        /*-----------------------------------------------------------*/
        [DllImport("gts.dll")]
        public static extern short GTN_SetRetainValue(short core, UInt32 address, short count, ref short pData);
        [DllImport("gts.dll")]
        public static extern short GTN_GetRetainValue(short core, UInt32 address, short count, out short pData);


        [DllImport("gts.dll")]
        public static extern short GTN_SetGPIOConfig(short core, short effectiveLevel, short direction);
        [DllImport("gts.dll")]
        public static extern short GTN_SetPrfTorque(short core, short axis, short prfTorque);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAtlTorque(short core, short axis, out short atlTorque);
        [DllImport("gts.dll")]
        public static extern short GTN_PosCurrFeedForward(short core, short profile, double pos, Int32 gtime, short torque, short gtype, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetMotionMode(short core, short axis, short motionMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetMotionMode(short core, short axis, out short motionMode);

        [DllImport("gts.dll")]
        public static extern short GTN_SetProfileTime(short core, Int32 profileTime, Int32 delay, Int32 stepCoef);
        [DllImport("gts.dll")]
        public static extern short GTN_GetProfileTime(short core, out Int32 pProfileTime, out Int32 pDelay, out Int32 pStepCoef);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCoreTime(short core, Int32 profileTime, Int32 delay, Int32 stepCoef);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCoreTime(short core, out Int32 pProfileTime, out Int32 pDelay, out Int32 pStepCoef);

        public struct TControlInfo
        {
            public double refPos;
            public double refPosFilter;
            public double refPosFilter2;
            public double cntPos;
            public double cntPosFilter;

            public double error;
            public double refVel;
            public double refAcc;

            public short value;
            public short valueFilter;

            public short offset;
        }
        
        public struct TCommandCount
        {
	        public UInt32 notify;
	        public UInt32 receive;
	        public UInt32 execute;
	        public UInt32 retry;
	        public UInt32 receiveError;
            public UInt32 echo;
        }

        
        [DllImport("gts.dll")]
        public static extern short GT_ClearCommandCount();
        [DllImport("gts.dll")]
        public static extern short GT_GetCommandCount(out TCommandCount pCommandCount);
        [DllImport("gts.dll")]
        public static extern short GT_SetServoTime(Int32 servoTime, Int32 delay, Int32 stepCoef);
        [DllImport("gts.dll")]
        public static extern short GT_GetServoTime(out Int32 pServoTime, out Int32 pDelay, out Int32 pStepCoef);
        [DllImport("gts.dll")]
        public static extern short GT_GetControlInfo(short control, out TControlInfo pControlInfo);

        [DllImport("gts.dll")]
        public static extern short GTN_ClearCommandCount(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCommandCount(short core,out TCommandCount pCommandCount);
        [DllImport("gts.dll")]
        public static extern short GTN_SetServoTime(short core, Int32 servoTime, Int32 delay, Int32 stepCoef);
        [DllImport("gts.dll")]
        public static extern short GTN_GetServoTime(short core, out Int32 pServoTime, out Int32 pDelay, out Int32 pStepCoef);
        [DllImport("gts.dll")]
        public static extern short GTN_GetControlInfo(short core, short control, out TControlInfo pControlInfo);

        [DllImport("gts.dll")]
        public static extern short GT_SetLongVar(short index, Int32 value);
        [DllImport("gts.dll")]
        public static extern short GT_GetLongVar(short index, out Int32 pValue);
        [DllImport("gts.dll")]
        public static extern short GT_SetDoubleVar(short index, double value);
        [DllImport("gts.dll")]
        public static extern short GT_GetDoubleVar(short index, out double pValue);

        [DllImport("gts.dll")]
        public static extern short GT_GetBufWaitDiStatus(short crd, out short pDiType, out Int16 pDiIndex, out Int16 pLevel, out short pContinueTime, out Int32 pOverTime, out short pFlagMode, out Int32 pSegNum, out short pEnable, out Int32 pCount, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetBufWaitLongVarStatus(short crd, out short pIndex, out Int32 pValue, out short pFlagMode, out Int32 pSegNum, out short pEnable, out short pStatus, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ClearBufWaitStatus(short crd, short fifo);
        
        [DllImport("gts.dll")]
        public static extern short GT_BufWaitDi(short crd, short diType, Int16 diIndex, Int16 level, short continueTime, Int32 overTime, short flagMode, Int32 segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufWaitLongVar(short crd, short index, Int32 value, Int32 overTime, short flagMode, Int32 segNum, short fifo);


        [DllImport("gts.dll")]
        public static extern short GTN_SetLongVar(short core, short index, Int32 value);
        [DllImport("gts.dll")]
        public static extern short GTN_GetLongVar(short core, short index, out Int32 pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDoubleVar(short core, short index, double value);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDoubleVar(short core, short index, out double pValue);

        
        [DllImport("gts.dll")]
        public static extern short GTN_GetBufWaitDiStatus(short core,short crd,out short pDiType,out Int16 pDiIndex,out Int16 pLevel, out Int16 pContinueTime,out Int32 pOverTime,out short pFlagMode,out Int32 pSegNum,out short pEnable,out Int32 pCount,short fifo);
        [DllImport("gts.dll")]
         public static extern short GTN_GetBufWaitLongVarStatus(short core,short crd,out short pIndex,out Int32 pValue,out short pFlagMode,out Int32 pSegNum,out short pEnable,out short pStatus,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearBufWaitStatus(short core,short crd,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufWaitDi(short core, short crd, short diType, Int16 diIndex, Int16 level, short continueTime, Int32 overTime, short flagMode, Int32 segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufWaitLongVar(short core, short crd, short index, Int32 value, Int32 overTime, short flagMode, Int32 segNum, short fifo);

        
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisMotionSmooth(short axis,double time,double k);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisMotionSmooth(short axis,out double pTime,out double pK);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisMotionSmooth(short core,short axis,double time,double k);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisMotionSmooth(short core,short axis,out double pTime,out double pK);

        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisPrediction(short core, short axis, short mode, short enable, ref double pCoef, short count1, short count2);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisPrediction(short core, short axis, out short pMode, out short pEnable,out double pCoef,out short pCount1,out short pCount2);

        [DllImport("gts.dll")]
        public static extern short GT_BufDoBit(short crd,Int16 doType,Int16 index,short value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDoBit(short core,short crd,Int16 doType,Int16 index,short value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDoBitDelay(short core, short crd, Int16 doType, Int16 index, short value, Int32 delayTime, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_SetCrdJerk(short crd,double jerkMax);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdJerk(short crd,out double pJerkMax);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdJerk(short core,short crd,double jerkMax);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdJerk(short core,short crd,out double pJerkMax);
        [DllImport("gts.dll")]
        public static extern short GT_SetCrdJerkTime(short crd,double jerkTime,double coef);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdJerkTime(short crd,out double pJerkTime,out double pCoef);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdJerkTime(short core,short crd,double jerkTime,double coef);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdJerkTime(short core,short crd,out double pJerkTime,out double pCoef);

        public struct TCrdSmooth
        {
            public short percent;
            public short accStartPercent;
            public short decEndPercent;
            public double reserve;
        }

        [DllImport("gts.dll")]
        public static extern short GT_SetCrdSmooth(short crd, ref TCrdSmooth pCrdSmooth);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdSmooth(short crd, out TCrdSmooth pCrdSmooth);
        [DllImport("gts.dll")]
        public static extern short GT_SetCrdSmoothTime(short crd, short smoothType, ref double pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdSmoothTime(short crd, out short pSmoothType, ref double pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdSmooth(short core, short crd, ref TCrdSmooth pCrdSmooth);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdSmooth(short core, short crd, out TCrdSmooth pCrdSmooth);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdSmoothTime(short core, short crd, short smoothType, ref double pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdSmoothTime(short core, short crd, out short pSmoothType, out double pPrm);

        //////////////////////////////////////////////////////////////////////////
        //Standard Home
        //////////////////////////////////////////////////////////////////////////
        
        public const short STANDARD_HOME_STAGE_IDLE = 0;                    //δ������ԭ��
        public const short STANDARD_HOME_STAGE_START = 1;                   //������ԭ��
        public const short STANDARD_HOME_STAGE_SEARCH_HOME = 20;            //��������Home
        public const short STANDARD_HOME_STAGE_SEARCH_INDEX   = 30;         //��������Index
        public const short STANDARD_HOME_STAGE_GO_HOME = 80;                //�����˶���ԭ��
        public const short STANDARD_HOME_STAGE_END = 100;                   //��ԭ�����
        public const short STANDARD_HOME_STAGE_START_CHECK = -1;            //������ԭ��ǰ�Լ�
        public const short STANDARD_HOME_STAGE_CHECKING = -2;               //�Լ���

        public const short STANDARD_HOME_ERROR_NONE = 0;                    //δ��������
        public const short STANDARD_HOME_ERROR_DISABLE = 10;                //ִ�л�ԭ�����δʹ��
        public const short STANDARD_HOME_ERROR_ALARM = 20;                  //ִ�л�ԭ����ᱨ��
        public const short STANDARD_HOME_ERROR_STOP = 30;                   //δ��ɻ�ԭ�㣬��ֹͣ�˶�
        public const short STANDARD_HOME_ERROR_ON_LIMIT = 40;               //��������λ�޷�����
        public const short STANDARD_HOME_ERROR_NO_HOME = 50;                //δ�ҵ�Home
        public const short STANDARD_HOME_ERROR_NO_INDEX = 60;               //δ�ҵ�Index
        public const short STANDARD_HOME_ERROR_NO_LIMIT = 70;               //δ�ҵ���λ
        public const short STANDARD_HOME_ERROR_ENCODER_DIR_SCALE = -1;      //�滮����������������෴���ߵ�����һ��
        
        public struct TStandardHomePrm
        {
            public short mode;		                              // ��ԭ��ģʽȡֵ��Χ1~36
            public double highSpeed;                              // ����Home���ٶȣ���λpulse/ms
            public double lowSpeed;	                              // ����Index���ٶȣ���λpulse/ms
            public double acc;		                              // ������ٶȣ���λpulse/ms^2
            public Int32 offset;                                  // ����ƫ��������λpulse
            public short check;                                   // �Ƿ������Լ칦�ܣ�1-���ã�����ֵ-������
            public short autoZeroPos;                             // ��������Ƿ��Զ����㣬1-�Զ����㣬����ֵ-������
            public Int32 motorStopDelay;                          // �����λ��ʱ����λ����������
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short pad1;	                                  // ����������Ҫ���ã�
        }
        
        public struct TStandardHomeStatus
        {
	        public short run;           // �����ڽ��л�ԭ�㣬0����ֹͣ�˶���1-���ڻ�ԭ��
	        public short stage;         // ��ԭ���˶��Ľ׶�
	        public short error;         // ��ԭ����̵ķ����Ĵ���
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] pad1;        // �������޾��庬�壩
            public Int32 capturePos;    // ����Home��Indexʱ�̵ı�����λ��
	        public Int32 targetPos;     // ��Ҫ�˶�����Ŀ��λ�ã�ԭ��λ�û���ԭ��λ��+ƫ��������������Limitʱ��������Home��Indexʱ�����õ���������Ϊ0����ô��ֵ��ʾΪ805306368
        }

        [DllImport("gts.dll")]
        public static extern short GT_ExecuteStandardHome(short axis, ref TStandardHomePrm pHomePrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetStandardHomePrm(short axis, out TStandardHomePrm pHomePrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetStandardHomeStatus(short axis, out TStandardHomeStatus pHomeStatus);

        [DllImport("gts.dll")]
        public static extern short GTN_ExecuteStandardHome(short core, short axis, ref TStandardHomePrm pHomePrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetStandardHomePrm(short core, short axis, out TStandardHomePrm pHomePrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetStandardHomeStatus(short core, short axis, out TStandardHomeStatus pHomeStatus);

        public struct TLaserOnOffCount
        {
            public UInt32 onCount;
            public UInt32 offCount;
            public UInt32 onCountInFpga;
            public UInt32 offCountInFpga;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public UInt32[] pad;
        }

        [DllImport("gts.dll")]
        public static extern short GTN_GetLaserOnOffCount(short core, short channel, out TLaserOnOffCount pLaserCount);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearLaserOnOffCount(short core, short channel);

        [DllImport("gts.dll")]
        public static extern short GTN_BufPosComparePsoPrm(short core, short crd, short index, ref TPosComparePsoPrm pPrm, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_SetAxisInputShaping(short axis,short enable,short count,double k);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisInputShaping(short core,short axis,short enable,short count,double k);

        [DllImport("gts.dll")]
        public static extern short GT_SetGantrySynchErrorCompensate2DTable(short tableIndex,ref TCompensate2DTable pTable,ref Int32 pData,short extend);
        [DllImport("gts.dll")]
        public static extern short GT_GetGantrySynchErrorCompensate2DTable(short tableIndex,out TCompensate2DTable pTable,out short pExtend);
        [DllImport("gts.dll")]
        public static extern short GT_SetGantrySynchErrorCompensate2D(short group,ref TCompensate2D pComp2d);
        [DllImport("gts.dll")]
        public static extern short GT_GetGantrySynchErrorCompensate2D(short group,out TCompensate2D pComp2d);
        [DllImport("gts.dll")]
        public static extern short GT_GetGantrySynchErrorCompensate2DValue(short group,out double pValue);

        [DllImport("gts.dll")]
        public static extern short GTN_SetGantrySynchErrorCompensate2DTable(short core,short tableIndex,ref TCompensate2DTable pTable,ref Int32 pData,short extend);
        [DllImport("gts.dll")]
        public static extern short GTN_SetGantrySynchErrorCompensate2D(short core,short group,ref TCompensate2D pComp2d);

        public struct TLaserFollowPrm
        {
            public short laserFollowMode;
            public double maxFrq;
            public double minFrq;
            public double maxDuty;
            public double minDuty;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public short[] pad1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public double[] pad2;
        };
        [DllImport("gts.dll")]
        public static extern short GTN_SetLaserFollowMode(short core, ref TLaserFollowPrm pPrm, short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_SetLaserFollowTable(short core,short tableId,Int32 n,ref double pVel,ref double pPower,short channel);
        [DllImport("gts.dll")]
        public static extern short GT_LaserFollowOff(short crd,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_LaserFollowOff(short core,short crd,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_SetLaserOnOffSmooth(short core,short crd,short fifo,short channel,short mask);

        public struct TBufWaitDiStatusEx
        {
	        public short type;
	        public short enable;
	        public short flagMode;
	        public short diType;
	        public short diIndex;
	        public short diValue;
	        public ushort continueTime;
	        public ushort trigDelay;
	        public UInt32 overTime;
	        public UInt32 counter;
	        public Int32 longVar;
	        public Int32 segNum;
	        public short stop;
	        public short overTimeStop;
	        public short pad11;
	        public short pad12;
        };
        [DllImport("gts.dll")]
        public static extern short GTN_GetBufWaitDiStatusEx(short core,short crd,short fifo,out TBufWaitDiStatusEx pStatus);

        [DllImport("gts.dll")]
        public static extern short GTN_SetPosCompareFifoMode(short core, short index, short mode, short enable);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosCompareFifoMode(short core,short index,out short pMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosCompareLatchValue(short core,short index,Int32 count,out Int32 pDataX,out Int32 pDataY,out Int32 pCount,out TLatchValueInfo pInfo);
        
        public struct TTaskMoveEscape
        {
	        public UInt32 profileMask;
	        public Int32 offset;
	        public double vel;
	        public double acc;
        };

        public struct TEventStatus
        {
	        public short eventHit;
	        public short pad11;
	        public short pad12;
	        public short pad13;
	        public Int32 pad21;
	        public Int32 pad22;
	        public double pad31;
	        public double pad32;
        };

        public struct TaskStatus
        {
	        public short start;
	        public short execute;
	        public short pad11;
	        public short pad12;
	        public Int32 pad21;
	        public Int32 pad22;
	        public double pad31;
	        public double pad32;
        };
                
        [DllImport("gts.dll")]
        public static extern short GTN_GetEventStatus(short core,short index,out TEventStatus pStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTaskStatus(short core,short index,out TaskStatus pStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTriggerMoveEscape(short core,short trigger,ref TTaskMoveEscape pPrm);

        [DllImport("gts.dll")]
        public static extern short GTN_BufPosCompareStart(short core, short crd, short fifo, short index);
        [DllImport("gts.dll")]
        public static extern short GTN_BufPosCompareStop(short core, short crd, short fifo, short index);
        [DllImport("gts.dll")]
        public static extern short GTN_BufPosCompareStartEx(short core, short crd, short fifo, short index);
        [DllImport("gts.dll")]
        public static extern short GTN_BufPosCompareStopEx(short core, short crd, short fifo, short index);
       
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdHsPrm(short core,short crd,short fifo,out short pEnable,out short pLink,out UInt16 pThreshold,out short pLookAheadInMc);

        [DllImport("gts.dll")]
        public static extern short GTN_SetPrfPosEx(short core,short profile,double pos);
        [DllImport("gts.dll")]
        public static extern short GTN_SetEncPosEx(short core,short encoder,double pos);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDiBit(short core,short diType,short diIndex,out short pValue);

        public struct TMpgInfo
        {
            public double pos;
            public double vel;
            public double reserve1;
            public double reserve2;
            public Int32 di;
            public Int32 reserve1_1;
            public Int32 reserve1_2;
            public Int32 reserve1_3;
        };

        [DllImport("gts.dll")]
        public static extern short GTN_ReadMpgInfo(short core,short mpg,out TMpgInfo pMpgInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_WriteMpgPos(short core,short mpg,ref double pPos,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_ReadAuEncPos(short core,short encoder,out double pPos,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_WriteAuEncPos(short core,short encoder,ref double pPos,short count);
        [DllImport("gts.dll")]
        public static extern short GT_OpenExtMdl(string pDllName);
        [DllImport("gts.dll")]
        public static extern short GT_CloseExtMdl();
        [DllImport("gts.dll")]
        public static extern short GT_LoadExtConfig(string pFileName);
        [DllImport("gts.dll")]
        public static extern short GT_ResetExtMdl();
        [DllImport("gts.dll")]
        public static extern short GTN_DeleteEvent(short core,short eventIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_DeleteTask(short core,short taskIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_DeleteEventTaskLink(short core,short linkIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_SetEvent(short core,ref TEvent pEvent,short eventIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTask(short core,short taskType,IntPtr pTaskData,short taskIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_SetEventTaskLink(short core,short eventIndex,short taskIndex,short linkIndex);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearMcStatus(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_SetMcInfo(short core,Int32 info,Int32 index,UInt32 data);
        [DllImport("gts.dll")]
        public static extern short GTN_GetMcInfo(short core,Int32 info,Int32 index,out UInt32 cpData);
        [DllImport("gts.dll")]
        public static extern short GTN_GetRNMasterInfo(short core,out UInt16 pPhyId,out UInt16 pType,out UInt16 pInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetRNMasterInfo(short core,UInt16 phyId,UInt16 type,UInt16 info);
        [DllImport("gts.dll")]
        public static extern short GTN_RN_MltPcPduRd(short core,string pData, Byte des_id,UInt16 byte_start_offset,UInt16 byte_num);
        [DllImport("gts.dll")]
        public static extern short GTN_RN_MltPcPduRdUpdate(short core,Byte des_id);
        [DllImport("gts.dll")]
        public static extern short GTN_RN_MltPcPduWr(short core,String pData, Byte des_id, UInt16 byte_start_offset,UInt16 byte_num);
        [DllImport("gts.dll")]
        public static extern short GTN_RN_MltPcPduWrUpdate(short core,Byte des_id);

        public struct TLaserStatus
        {
            public short run;
            public short mode;
            public double power;
            public double frequency;
            public double pulseWidth;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 9)]
            public double[] pad1;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 8)]
            public short[] pad2;
        } ;
        [DllImport("gts.dll")]
        public static extern short GTN_GetLaserStatus(short core,short channel,out TLaserStatus pStatus);

        /*-----------------------------------------------------------*/
        /* �¼ܹ�                                                    */
        /*-----------------------------------------------------------*/

		public struct TListInfo
		{
			public short list;	
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
			public short[] reserve1;		
			public short modal;	
			public Int32 segNum;	
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 3)]
			public short[] reserve2;	
	        [MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
			public short[] reserve3;	
		}

        public struct  TCommandListStatus
        {
	        public short execute;
	        public short empty;
	        public short stopInfo;
	        public short reserve1;
	        public short motionDone;
	        public short commandType;
	        public short command;
	        public short direction;
	        public Int32 executeSegNum;
	        public Int32 remainderSegCount;
	        [MarshalAs(UnmanagedType.ByValArray,SizeConst = 6)]
	        public Int32[] reserve2;
        };
        
        [DllImport("gts.dll")]
        public static extern short GTN_GetCommandListSpace(short core,short list,out Int32 pSpace);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCommandListStatus(short core,short list,out TCommandListStatus pStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearCommandListData(short core,short list,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_CommandListDataEnd(short core,short list);
        [DllImport("gts.dll")]
        public static extern short GTN_StartCommandList(short core,short list,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_StartMultiCommandList(short core,UInt32 mask,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_StopCommandList(short core,short index,short stopMode,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_StopMultiCommandList(short core,UInt32 mask,short stopMode,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearCommandListStatus(short core, short list);

        public const short WAIT_TIMEOUT_MODE_INFINITY = 0;
        public const short WAIT_TIMEOUT_MODE_SKIP = 1;
        public const short WAIT_TIMEOUT_MODE_STOP = 2;
        
        public struct TWatchCondition
        {
	        public TWatchVar var;
	        public UInt16 condition;
	        public double value;
        } ;

        public struct TVarCalculate
        {
	        public UInt16 operation;
	        public UInt16 varType;
	        public UInt16 result;
	        public UInt16 lhs;
	        public UInt16 rhs;
        } ;

        public struct TVarCondition
        {
	        public short varIndex;
	        [MarshalAs(UnmanagedType.ByValArray,SizeConst = 3)]
	        public short[] reserve;
	        public TWatchCondition watchCondition;
        } ;

        public struct TWaitTimeout
        {
	        public Int32 time;				// ��ʱʱ��
	        public short mode;		        // ��ʱ�����Ϊ��0�����޵ȴ���1��������ǰ�ȴ���������ִ��ָ������2��ָֹͣ����
	        public short reserve1;
	        [MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
	        public double[] reserve2;
        } ;
        
        [DllImport("gts.dll")]
        public static extern short GTN_SetVarBoolCondition(short core,short varIndex,ref TWatchCondition pWatchCondition);
        [DllImport("gts.dll")]
        public static extern short GTN_LoadVarCalculate(short core,ref TVarCalculate pVarCalculate,short count,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_MoveTrap(short core,short profile,double pos,double vel,ref TTrapPrm pPrm,ref TListInfo pList);
        [DllImport("gts.dll")]
        public static extern short GTN_SetVarCondition(short core,ref TVarCondition pVarCondition,short count,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_WaitForCondition(short core,ref TWatchCondition pWatchCondition,short conditionCount,short operation,ref TWaitTimeout pTimeout,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetWaitForCondition(short core,short list,out TWatchCondition pWatchCondition,out short pConditionCount,out short pOperation,out TWaitTimeout pTimeout,out short pConditionResult,out short pConditionDone);
 
        public static short DIGITAL_OUTPUT_MODE_NORMAL = 0;
        public static short DIGITAL_OUTPUT_MODE_REVERSE_TIME = 10;

        public struct TDoReverseParameter
        {
	        public double time;
	        [MarshalAs(UnmanagedType.ByValArray,SizeConst = 9)]
	        public double[] reserve;
        };

        public struct TDigitalOutputModeStruct
        {
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 10)]
            public double[] data;
        };

        //������Ķ��壬���Ǵ˴��������εĴ��룬�����������������������ʱ����,��ʱ��Ӱ��ʹ��
        [StructLayout(LayoutKind.Explicit)]
        public struct TDigitalOutputMode
        {
            [FieldOffset(0)]
            public TDoReverseParameter doReverse;
            //[FieldOffset(0)]
            //[MarshalAs(UnmanagedType.ByValArray,SizeConst = 10)]
            //public double[] data;
        };

        public struct TDigitalOutputBit
        {
            public short mode;              //Do���ģʽ
            public short doType;
            public short doIndex;
            public short doValue;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
            public short[] reverse1;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
            public Int32[] reserve;
            public TDigitalOutputMode prm;
        };

        public struct TDelay
        {
            public double delayTime;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
            public short[] reserve1;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
            public Int32[] reserve2;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
            public double[] reserve3;
        };
        [DllImport("gts.dll")]
        public static extern short GTN_WriteDigitalOutputBit(short core, ref TDigitalOutputBit pDoBit,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDelay(short core, ref TDelay pDelay, ref TListInfo pListInfo);

        public struct TProfileScale
        {
            public short[]  count;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 3)]
            public short[]  reverse1;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
            public double[] alpha;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
            public double[] beta;
        };

        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisScale(short core, short profile, ref TProfileScale pScale,ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisScale(short core, short profile,out TProfileScale pScale);

        [DllImport("gts.dll")]
        public static extern short GTN_GetTrapSts(short core, short profile, out short prfsts);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearTrapSts(short core, short profile);
        
		[DllImport("gts.dll")]
		public static extern short GTN_SetMcMode(short core,short mode,short value);
		[DllImport("gts.dll")]
		public static extern short GTN_GetMcMode(short core,short mode,out short pValue);

		/*-----------------------------------------------------------*/
        /* New Watch  Code                                           */
        /*-----------------------------------------------------------*/
        [DllImport("gts.dll")]
        public static extern short GTN_LoadReadHsConfig(short core,string pFile);
        [DllImport("gts.dll")]
        public static extern short GTN_ReadHsOn(short core, short enable, short mode, double interval);

        public struct TAxisArrivePrm
        {
            public short mode;
            public short pad0;
            public Int32 band;		//�������жϵ�λ����
            public Int32 time;		//�������жϵ�λʱ��
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
            public Int32[] pad1;
        };
        [DllImport("gts.dll")]
        public static extern short GTN_GetStsEx(short core, short axis, out Int32 pSts, short count, out UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisArriveMode(short core, short axis, ref TAxisArrivePrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisArriveMode(short core, short axis, out TAxisArrivePrm pPrm);

        
        public struct TCrdStatusEx
        {
	        public short runEmpty;
	        public Int32 segUseCount;
	        public Int32 segReceiveCount;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
	        public short[] pad1;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
	        public Int32[] pad2;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
	        public double[] pad3;
        };

        [DllImport("gts.dll")]
        public static extern short GT_CrdStatusEx(short crd, out TCrdStatusEx pCrdStatus, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdStatusEx(short core, short crd, out TCrdStatusEx pCrdStatus, short fifo);

        [DllImport("gts.dll")]
        public static extern short GTN_SetCrdMPGMode(short core, short crd, short enable, short master, Int32 masterEven, Int32 slaveEven, short filterTime, short mode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCrdMPGMode(short core, short crd, out short pEnable, out short pMaster, out Int32 pMasterEven, out Int32 pSlaveEven, out short pFilterTime, out short pMode, out short pFifoEnd);
        
        public struct TMoveContinuousAbsolutePrm 
        {
	        public double pos;
	        public double vel;
	        public double velEnd;
	        public double acc;
	        public double dec;
	        public short  direction;
	        public short overrideSelect;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 2)]
	        public short[] reserve;
        } ;

        [DllImport("gts.dll")]
        public static extern short GTN_MoveContinuousAbsolute(short core, short profile, ref TMoveContinuousAbsolutePrm pPrm, ref TListInfo pListInfo, short group);

        [DllImport("gts.dll")]
        public static extern short GTN_SetReadHs(short core, short enable, short mode, short interval);
        [DllImport("gts.dll")]
        public static extern short GTN_ReadHsReadBuffer(short core, out short pData, Int32 count);

        [DllImport("gts.dll")]
        public static extern short GTN_RN_GeneralCommand(short core, short stationId, Int32 cmdId, Int32 prmSizeCount, IntPtr pPrm, Int32 resultSizeCount, IntPtr pResult);
        /*-----------------------------------------------------------*/
        /* Encrypt                                           */
        /*-----------------------------------------------------------*/
        
        public struct TEncryptOperatePrm
        {	
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 32)]
	        public Byte[] keyValue;		// ԭʼ��Կ
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 32)]
	        public Byte[] randomIn;
	        public short block;			// �ڼ���block,32bytesһ��block,����
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 32)]
	        public Byte[] data;			// ��ȡ���Ļ���д��ȥ���µ�����
	        public short sts;
        };
        [DllImport("gts.dll")]
        public static extern short GTN_WriteUserSlotDataEncrypt(short core, short slotIndex, ref TEncryptOperatePrm pWritePrm);
        [DllImport("gts.dll")]
        public static extern short GTN_ReadUserSlotDataEncrypt(short core, short slotIndex, out TEncryptOperatePrm pReadPrm);

        [DllImport("gts.dll")]
        public static extern short GTN_EncryptionFunConfig(short core, short slotIndex, ref Byte pOldKey, ref Byte pNewKey, ref Byte pUserData, out short pSts, out short pConfigured);

        
        public struct TTriggerProfilePrm 
        {
	        public short mode;	    //�˶�����,0-��λ��6-PVT������������ʱ��֧��
	        public short enable;    //�Ƿ�ʹ�ܣ�0-��ʹ�ܣ�1-ʹ��
	        public short trigger;	//trigger������ȡֵ��1��ʼ
	        public short pad1;		//����
	        public Int32 distance;	//����ʱƫ�����������ɸ�����λ������
	        public Int32 posLimit;  //���¹滮�󣬴���λ��+ƫ�������ܳ�����ֵ
	        public double vel;      //Ŀ���ٶȣ����¹滮��Ŀ���ٶȣ���λ������/ms
	        public double acc;      //��Ҫ����ʱ�ļ��ٶȣ���λ������/ms
	        public double dec;		//�˶�������ƫ�����ļ��ٶȣ���λ������/ms
	        public double percent;	//���ٶ�S������ʱ��ٷֱȣ�����60��ʾ60%
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
	        public double[] reserve;
        };

        public struct TTriggerProfileStatus
        {
	        public short mode;
	        public short enable;
	        public short execute;			//�Ƿ�ִ����,0-δִ�У�1-ִ��
	        public short status;			//ִ�й����е�״̬������Ϊ0���쳣�򷵻ش�����
	        public Int32 endPos;			//�յ�λ�ã�����+ƫ������
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 7)]
	        public Int32[] reserve;
        };

        [DllImport("gts.dll")]
        public static extern short GTN_SetTriggerProfilePrm(short core, short profile, ref TTriggerProfilePrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTriggerProfileStatus(short core, short profile, out TTriggerProfileStatus pSts);

        [DllImport("gts.dll")]
        public static extern short GTN_LmtsOnEx(short core, short axis, short limitType, short limitMode);
        [DllImport("gts.dll")]
        public static extern short GTN_LmtsOffEx(short core, short axis, short limitType, short limitMode);

        [DllImport("gts.dll")]
        public static extern short GTN_PrintLogInfo(short core, string pFileName, Int32 start, Int32 count);
        [DllImport("gts.dll")]
        public static extern short GTN_PrintMcStsInfo(short core, string pFileName, short type, short index, short count);
        [DllImport("gts.dll")]
        public static extern short GTN_PrintCommandInfo(short core, string pFileName, Int32 start, Int32 count);
        
        /*-----------------------------------------------------------*/
        /* ILC                                                       */
        /*-----------------------------------------------------------*/
        public struct TIlcResult
        {				  
	        public double ErrorMax;
	        public double ErrorAvg;
	        public double ErrorRms;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 9)]
	        public double[] pad1;
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 10)]
	        public short[]  pad2;
        };

        [DllImport("gts.dll")]
        public static extern short GTN_InitIlc(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_StartIlc(short core, short crd);
        [DllImport("gts.dll")]
        public static extern short GTN_StopIlc(short core, short crd, ref TIlcResult pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_SaveIlcFile(short core, string pIlcFile);
        [DllImport("gts.dll")]
        public static extern short GTN_LoadIlcFile(short core, short crd, string filePath);
        
        /*-----------------------------------------------------------*/
        /* MovePos                                                   */
        /*-----------------------------------------------------------*/
        public struct  TMovePosPercent
        {
	        public short value;
        };

        public struct TMovePosSmoothTime 
        {
	        public short value;
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct TMovePosUnion
        {
            [FieldOffset(0)]
	        public TMovePosPercent percent;
            [FieldOffset(1)]
	        public TMovePosSmoothTime smoothTime;
            //[FieldOffset(2)]
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            //public double[] value;
        };

        public struct TMovePosParameter 
        {
            public double pos;
            public double vel;
            public double acc;
            public double dec;
            public short direction;
            public short overrideSelect;
            public short pad;
            public short mode;
            public TMovePosUnion data;
        };

        public struct TMovePosTwoSegmentParameter 
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] pos;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] vel;
            public double acc;
            public double dec;
            public short direction;
            public short overrideSelect;
            public short pad;
            public short mode;
            public TMovePosUnion data;
        };

        public struct  TMultiMovePosParameter
        {
            public short profile;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] pad1;
            public double pos;
            public double vel;
            public double acc;
            public double dec;
            public short direction;
            public short overrideSelect;
            public short pad2;
            public short mode;
            public TMovePosUnion data;
        };

        public struct TMultiMovePosTwoSegmentParameter 
        {
            public short profile;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] pad1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] pos;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] vel;
            public double acc;
            public double dec;
            public short direction;
            public short overrideSelect;
            public short pad2;
            public short mode;
            public TMovePosUnion data;
        };
        [DllImport("gts.dll")]
        public static extern short GTN_MovePos(short core, short profile,ref TMovePosParameter pMovePos,ref TListInfo pListInfo, short group = 0);
        [DllImport("gts.dll")]
        public static extern short GTN_MovePosTwoSegment(short core, short profile, ref TMovePosTwoSegmentParameter pMovePos, ref TListInfo pListInfo, short group);

        public struct TMotionTimeRestrictDirect
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] condition;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public double[] time;
        }

        public struct TMotionTimeRestrictAttentionProfile 
        {
            public short condition;	
            public short attentionProfileCount;		
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] attentionProfile;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public short[] reserve1;
            public double settlingTime; 
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct TMotionTimeRestrictUnion
        {
            [FieldOffset(0)]
            TMotionTimeRestrictDirect direct;		// ����
            [FieldOffset(11)]
            TMotionTimeRestrictAttentionProfile attentionProfile; // �ο�����Ϣ
            //[FieldOffset(0)]
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            //public double[] data;
        };

        public struct TMotionTimeRestrict
        {
            public short profileCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] profile;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public short[] pad1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public double[] profilePos;
            public short mode;	
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] pad2; 
            public TMotionTimeRestrictUnion parameter;
        };
        [DllImport("gts.dll")]
        public static extern short GTN_SetMotionTimeRestrict(short core, short restrictIndex, ref TMotionTimeRestrict pRestrict, ref TListInfo pListInfo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetWaitForCondition(short core, short list, out TWatchCondition pWatchCondition, out short pConditionCount, short pOperation, out TWaitTimeout pTimeout, out short pConditionResult);
        /*-----------------------------------------------------------*/
        /* ����                                                      */
        /*-----------------------------------------------------------*/	
		public const short LOOP_MODE_POSITION = 0;		// λ�ñջ�
		public const short LOOP_MODE_PRESS =1;		    // ѹ���ջ�
		public const short LOOP_MODE_NONE = 2;

		public const short PRESS_PROFILE_NONE = 0;	    // ����ѹ���ջ�ģʽ�������й滮
		public const short PRESS_PROFILE_TARGET = 1;	// ����Ŀ��ѹ��ģʽ
		public const short PRESS_PROFILE_ARRAY = 2;	    // ����Ŀ��ѹ��ģʽ
		public const short PRESS_PROFILE_PERCENT = 3;
		public const short PRESS_PROFILE_TABLE = 4;

		public const short LIMIT_TYPE_PRESS	= 7;
		public const short LIMIT_TYPE_TORQUE = 8;
		public const short MC_PRESS	= 500;
		public const short MC_TORQUE = 501;

		public const short PRESS_GREATER_THAN_LIMIT = 0;
		public const short PRESS_LESS_THAN_LIMIT = 1; 

		public const short PRESS_DIR_NONE = 0;
		public const short PRESS_DIR_CROSS_POSITIVE = 1;
		public const short PRESS_DIR_CROSS_NEGATIVE = 2;
		public const short PRESS_DIR_CROSS_BOTH = 3;
		public const short PRESS_DIR_GE = 4;
		public const short PRESS_DIR_LE = 5;

		public struct TStopOffset
		{
			public Int32 distance;		// ���˾���
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] reverse;
            public double vel;			// ���ٶ�
			public double acc;			// ���˼��ٶ�
		};

		public struct TLoopMode
		{
			public short loopMode;				// ��·ģʽ
			public short pressProfileMode;		// ѹ���ջ�ģʽ����Ч
		};

		public struct TPressPrm
		{
			public short active;			// ����ʹ��
            public short reverse1;
			public Int32 scale;				// ������������1ţ��N��ת��������ĵ�����
			public short linkAxis;			// ѹ���滮�����Ǹ����������
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] reverse2;
		};

		public struct TPressTargetPrm
		{
			public double acc;				// ���ؼ��ٶ�
			public double dec;				// ���ؼ��ٶ�
			public double pressStart;		// ��������
			public short  smoothTime;		// ƽ��ʱ��
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] reverse2;
		};

		public struct TPressArrayData
		{
			public double pressTarget;		// Ŀ��ѹ��
			public Int32 pressTime;			// ����ʱ�� ms��λ
			public Int32 holdTime;			// ����ʱ��
		};

		public struct TPressArray
		{
			public short count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] reverse1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public TPressArrayData[] buffer;
			public short exit;				// �滮��ɺ��Ƿ��л���λ�ñջ�ģʽ
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] reverse2;
		};

		public struct TPressPid
		{
			public double kp;
			public double ki;
			public double kd;
			public double kvff;
			public double kaff;
			public Int32 integralLimit;
			public Int32 derivativeLimit;
			public short limitMax;					// ������������ֵ
			public short limitMin;					// �����������Сֵ
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] reverse1;
		};

		// ��·ģʽ
        [DllImport("gts.dll")]
		public static extern short GTN_SetLoopMode(short core,short axis,ref TLoopMode pMode); // ���û�·ģʽ��ѹ���ջ�����λ�ñջ���
        [DllImport("gts.dll")]
		public static extern short GTN_GetLoopMode(short core,short axis,out TLoopMode pMode); // ��ȡ��·ģʽ��ѹ���ջ�����λ�ñջ���
		// ���á���ȡ���ع�����ز���
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressPrm(short core,short pressAxis,ref TPressPrm pPressPrm);
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressPrm(short core,short pressAxis,out TPressPrm pPressPrm);
		// ����Ŀ��ѹ��
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressTarget(short core,short pressProfile,double value,ref TPressTargetPrm pPressTargetPrm);
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressTarget(short core,short pressProfile,out double pValue,out TPressTargetPrm pPressTargetPrm);
		// ����Ŀ��ѹ��
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressArray(short core,short pressProfile,ref TPressArray pPressArray);
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressArray(short core,short pressProfile,out TPressArray pPressArray);
		// ѹ����PID
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressPid(short core,short pressControl,ref TPressPid pPid);
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressPid(short core,short pressControl,out TPressPid pPid);
		// ��ȡ�滮ѹ��
        [DllImport("gts.dll")]
		public static extern short GTN_GetPrfPress(short core,short pressProfile,out double pValue,out double pValueFilter);
		// ��ȡ����ѹ��
        [DllImport("gts.dll")]
		public static extern short GTN_GetAtlPress(short core,short pressProfile,out double pValue);
		// ��ȡѹ��״̬
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressStatus(short core,short pressAxis,out Int32 pStatus);

		// ���ù滮ѹ��
        [DllImport("gts.dll")]
		public static extern short GTN_SetPrfPress(short core,short axis,double prfPressValue);
		// ����ѹ������Դ
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressFeedbackType(short core,short pressAxis,out short pFbType,out short pFbIndex);
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressFeedbackType(short core,short pressAxis,short fbType,short fbIndex);

		public struct TPressLimit
		{
			public short limit1;
			public short limit2;
			public short time;
			public short triggerCondition;          // ѹ����ͣ����������PRESS_GREATER_THAN_LIMIT,PRESS_LESS_THAN_LIMIT,
		};

		public struct TTorqueLimit
		{
			public short limit1;					// ����Limit1����time������ֹͣ
			public short limit2;					// ����Limit2����ֹͣ
			public short time;
            public short reverse;
		};
		// �������س���ֹͣ����		// ��������
        [DllImport("gts.dll")]
		public static extern short GTN_SetLimit(short core,short axis,short type,System.IntPtr pPrm);
        [DllImport("gts.dll")]
        public static extern short GTN_GetLimit(short core, short axis, short type, System.IntPtr pPrm);

		// �������ܴ�������˲���
        [DllImport("gts.dll")]
		public static extern short GTN_GetStopOffset(short core,short axis,out TStopOffset pStopOffset);
        [DllImport("gts.dll")]
		public static extern short GTN_SetStopOffset(short core,short axis,ref TStopOffset pStopOffset);

		public struct TPressAutoSwitchPrm
		{
			public short limit1;				
			public short limit2;				
			public short time;
			public short triggerCondition;     
			public short loopMode;				
			public short pressProfileMode;		
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] reverse;
		};
		// ������/λ�Զ��л�����
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressAutoSwitchPrm(short core,short pressAxis,ref TPressAutoSwitchPrm pPrm);
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressAutoSwitchPrm(short core,short pressAxis,out TPressAutoSwitchPrm pPrm);
        [DllImport("gts.dll")]
		public static extern short GTN_PressAutoSwitchEnable(short core,short pressAxis,short enable);

		// ����ѹ���ջ�ģʽ�µĹ����ռ�
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressRange(short core,short pressAxis,short centerSynch,Int32 range);
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressRange(short core,short pressAxis,out Int32 pCenterPos,out Int32 pRange);

		// ����ѹ���ջ�ģʽ��λ�ô�Խ����
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressCross(short core,short pressAxis,short dir,Int32 pos);
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressCross(short core,short pressAxis,out short pDir,out Int32 pPos);

		// ����ѹ���������
        [DllImport("gts.dll")]
		public static extern short GTN_SetPressTrigger(short core,short pressAxis,short pressThread,short triggerCondition);
		// ��ȡѹ���������
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressTrigger(short core,short pressAxis,out short pPressThread,out short pTriggerCondition);
		// ��ѹ��������
        [DllImport("gts.dll")]
		public static extern short GTN_PressTriggerOn(short core,short pressAxis);
		// �ر�ѹ��������
        [DllImport("gts.dll")]
		public static extern short GTN_PressTriggerOff(short core,short pressAxis);
		// ��ȡѹ������λ��
        [DllImport("gts.dll")]
		public static extern short GTN_GetPressTriggeredPos(short core,short pressAxis,out short pEnable,out double pCntPos,out short pTriggeredPress);
		
		/************************************************************************/
		/* ��ת�Ṧ��                                                           */
		/************************************************************************/
		public const short ROTARY_DIRECTION_SELECT_MODE_DEFAULT = 0;
		public const short ROTARY_DIRECTION_SELECT_MODE_SMART = 1;

		public struct TRotaryConfig
		{
			public short rotary;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public short[] pad;
			public double start;
			public double length;
			public double reserve;
			public double pulse;
		};

		public struct TLineAbsolutePrm
		{
			public short fifo;
			public short overrideNum;
			public short g0Mode;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
			public short[] reserve1;
			public Int32 segNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public Int32[] reserve2;
			public double vel;
			public double acc;
			public double velEnd;
			public double velLimit;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public double[] reserve3;
		};
		[DllImport("gts.dll")]
		public static extern short GTN_GetAxisPrfPosRotary(short core,short axis,out double pTheta,out double pRound,short count);
		[DllImport("gts.dll")]
		public static extern short GTN_GetProfileRotaryConfig(short core,short profile,out TRotaryConfig pConfig);
		[DllImport("gts.dll")]
		public static extern short GTN_GetPrfPosRotary(short core,short profile,out double pTheta,out double pRound,short count);
		[DllImport("gts.dll")]
		public static extern short GTN_SetCrdScale(short core,short crd,short dimension,double alpha,double beta);
		[DllImport("gts.dll")]
		public static extern short GTN_GetCrdScale(short core,short crd,short dimension,out double pAlpha,out double pBeta);
		[DllImport("gts.dll")]
		public static extern short GTN_GetCrdRotaryConfig(short core,short crd,short dimension,out TRotaryConfig pConfig);
		[DllImport("gts.dll")]
		public static extern short GTN_GetCrdPosRotary(short core,short crd,short dimension,out double pTheta,out double pRound,short count);
		[DllImport("gts.dll")]
		public static extern short GTN_GetEncoderRotaryConfig(short core,short encoder,out TRotaryConfig pConfig);
		[DllImport("gts.dll")]
		public static extern short GTN_GetEncPosRotary(short core,short encoder,out double pTheta,out double pRound,short count);
		[DllImport("gts.dll")]
		public static extern short GTN_SetAxisRotaryConfig(short core,short axis,ref TRotaryConfig pConfig);
		[DllImport("gts.dll")]
		public static extern short GTN_GetAxisRotaryConfig(short core,short axis,out TRotaryConfig pConfig);
		[DllImport("gts.dll")]
		public static extern short GTN_ZeroAxisRotaryRound(short core,short axis,short count);
		[DllImport("gts.dll")]
		public static extern short GTN_LineAbsoluteEx(short core,short crd,ref double pPos,ref short pDir,ref TLineAbsolutePrm pPrm);
		[DllImport("gts.dll")]
		public static extern short GTN_SetAxisRotaryDirectionSelectMode(short core,short axis,short mode);
		[DllImport("gts.dll")]
		public static extern short GTN_GetAxisRotaryDirectionSelectMode(short core,short axis,out short pMode);

		public struct TBufMoveAbsPrm 
		{
			public double pos;
			public double vel;
			public double acc;
			public double velMax;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public double[] reserve1;
			public short smoothTime;
			public short enableRatio;
			public short modal;
			public short fifo;
			public short dir;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public short[] reserve2;
			public Int32 segNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public Int32[] reserve3;
		};
		[DllImport("gts.dll")]
		public static extern short GTN_BufMoveAbsoluteEx(short core,short crd,short moveAxis,ref TBufMoveAbsPrm pPrm);

        /*-----------------------------------------------------------*/
        /* ����ֵ�������������                                      */
        /*-----------------------------------------------------------*/
		[DllImport("gts.dll")]
        public static extern short GTN_SetAuAbsEncMultiTurnRange(short core,short encoder,double range);
		[DllImport("gts.dll")]
        public static extern short GTN_ReadAuAbsEncPos(short core,short encoder,ref double pPos);

		[DllImport("gts.dll")]
        public static extern short GTN_SetCrdUserDataEndVelLa(short core,short crd, short crdUserDataType,double endVel);

        /*-----------------------------------------------------------*/
        /* PVTģʽ�������������                                      */
        /*-----------------------------------------------------------*/
        public const short PVT_OPERATION_TYPE_LASER_ON = 2;
        public const short PVT_OPERATION_TYPE_BUF_DA = 4;
        public const short PVT_OPERATION_TYPE_LASER_CMD = 5;
        public const short PVT_OPERATION_TYPE_LASER_FOLLOW_RATIO = 6;
        public const short PVT_OPERATION_TYPE_LASER_FOLLOW_MODE	= 25;
        public const short PVT_OPERATION_TYPE_LASER_FOLLOW_OFF = 26;
        public const short PVT_OPERATION_TYPE_BUF_DO_BIT = 94;

        public struct TPVTDoBit
        {
            public short doType;
            public short index;
            public short value;
        };

        public struct TPVTDA
        {
            public short chn;
            public short daValue;
        };

        public struct TPVTLaserSwitch
        {
            public short chn;
            public short enable;
        };

        public struct TPVTLaserPrfCmd
        {
            public short chn;
            public double power;
        };

        public struct TPVTLaserFollowRatio
        {
            public short chn;
            public double ratio;
            public double minPower;
            public double maxPower;
        };

        public struct TPVTLaserFollowOff
        {
            public short chn;
        };

        public struct TPVTLaserFollowMode
        {
            public short chn;
            public short source;
            public double startPower;
        };

        [DllImport("gts.dll")]
        public static extern short GTN_PvtTableUserData(short core, short tableId, short userDataType, double time, System.IntPtr pData);
	}
    /*-----------------------------------------------------------*/
    //ԭconfig.cs�����ù��ܣ�����������ģ��                       */
    /*-----------------------------------------------------------*/
    public class mc_cfg
    {
        /*-----------------------------------------------------------*/
        /* config of controller                                      */
        /*-----------------------------------------------------------*/
        public const short RES_LIMIT = 8;
        public const short RES_ALARM = 8;
        public const short RES_HOME = 8;
        public const short RES_GPI = 16;
        public const short RES_ARRIVE = 8;
        public const short RES_MPG = 7;

        public const short RES_ENABLE = 8;
        public const short RES_CLEAR = 8;
        public const short RES_GPO = 16;

        public const short RES_DAC = 12;
        public const short RES_STEP = 8;
        public const short RES_PULSE = 8;
        public const short RES_ENCODER = 11;
        public const short RES_LASER = 2;

        public const short AXIS_MAX = 8;
        public const short PROFILE_MAX = 8;
        public const short CONTROL_MAX = 8;

        public const short PRF_MAP_MAX = 2;
        public const short ENC_MAP_MAX = 2;

        public struct TDiConfig
        {
            public short active;
            public short reverse;
            public short filterTime;
        }

        public struct TCountConfig
        {
            public short active;
            public short reverse;
            public short filterType;

            public short captureSource;
            public short captureHomeSense;
            public short captureIndexSense;
        }

        public struct TDoConfig
        {
            public short active;
            public short axis;
            public short axisItem;
            public short reverse;
        }

        public struct TStepConfig
        {
            public short active;
            public short axis;
            public short mode;
            public short parameter;
            public short reverse;
        }

        public struct TDacConfig
        {
            public short active;
            public short control;
            public short reverse;
            public short bias;
            public short limit;
        }

        public struct TAdcConfig
        {
            public short active;
            public short reverse;
            public double a;
            public double b;
            public short filterMode;
        }

        public struct TControlConfig
        {
            public short active;
            public short axis;
            public short encoder1;
            public short encoder2;
            public Int32 errorLimit;
            public short filterType1;
            public short filterType2;
            public short filterType3;
            public short encoderSmooth;
            public short controlSmooth;
        }

        public struct TControlConfigEx
        {
            public short refType;
            public short refIndex;

            public short feedbackType;
            public short feedbackIndex;

            public Int32 errorLimit;
            public short feedbackSmooth;
            public short controlSmooth;
        }

        public struct TProfileConfig
        {
            public short active;
            public double decSmoothStop;
            public double decAbruptStop;
        }

        public struct TAxisConfig
        {
            public short active;
            public short alarmType;
            public short alarmIndex;
            public short limitPositiveType;
            public short limitPositiveIndex;
            public short limitNegativeType;
            public short limitNegativeIndex;
            public short smoothStopType;
            public short smoothStopIndex;
            public short abruptStopType;
            public short abruptStopIndex;
            public Int32 prfMap;
            public Int32 encMap;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = PRF_MAP_MAX)]
            public short[] prfMapAlpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = PRF_MAP_MAX)]
            public short[] prfMapBeta;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ENC_MAP_MAX)]
            public short[] encMapAlpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ENC_MAP_MAX)]
            public short[] encMapBeta;
        }

        public struct TMcConfig
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = PROFILE_MAX)]
            public TProfileConfig[] profile;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = AXIS_MAX)]
            public TAxisConfig[] axis;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = CONTROL_MAX)]
            public TControlConfig[] control;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_DAC)]
            public TDacConfig[] dac1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_STEP)]
            public TStepConfig[] step;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_ENCODER)]
            public TCountConfig[] encoder;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_PULSE)]
            public TCountConfig[] pulse1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_ENABLE)]
            public TDoConfig[] enable;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_CLEAR)]
            public TDoConfig[] clear;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_GPO)]
            public TDoConfig[] gpo;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_LIMIT)]
            public TDiConfig[] limitPositive;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_LIMIT)]
            public TDiConfig[] limitNegative;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_ALARM)]
            public TDiConfig[] alarm;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_HOME)]
            public TDiConfig[] home;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_GPI)]
            public TDiConfig[] gpi;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_ARRIVE)]
            public TDiConfig[] arrive;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = RES_MPG)]
            public TDiConfig[] mpg;
        }
        [DllImport("gts.dll")]
        public static extern short GT_SaveConfig(out string pFile);
        [DllImport("gts.dll")]
        public static extern short GT_SetDiConfig(short diType, short diIndex, ref TDiConfig pDi);
        [DllImport("gts.dll")]
        public static extern short GT_GetDiConfig(short diType, short diIndex, out TDiConfig pDi);
        [DllImport("gts.dll")]
        public static extern short GT_SetDoConfig(short doType, short doIndex, ref TDoConfig pDo);
        [DllImport("gts.dll")]
        public static extern short GT_GetDoConfig(short doType, short doIndex, out TDoConfig pDo);
        [DllImport("gts.dll")]
        public static extern short GT_SetStepConfig(short step, ref TStepConfig pStep);
        [DllImport("gts.dll")]
        public static extern short GT_GetStepConfig(short step, out TStepConfig pStep);
        [DllImport("gts.dll")]
        public static extern short GT_SetDacConfig(short dac, ref TDacConfig pDac);
        [DllImport("gts.dll")]
        public static extern short GT_GetDacConfig(short dac, out TDacConfig pDac);
        [DllImport("gts.dll")]
        public static extern short GT_SetAdcConfig(short adc, ref TAdcConfig pAdc);
        [DllImport("gts.dll")]
        public static extern short GT_GetAdcConfig(short adc, out TAdcConfig pAdc);
        [DllImport("gts.dll")]
        public static extern short GT_SetCountConfig(short countType, short countIndex, ref TCountConfig pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetCountConfig(short countType, short countIndex, out TCountConfig pCount);
        [DllImport("gts.dll")]
        public static extern short GT_SetControlConfig(short control, ref TControlConfig pControl);
        [DllImport("gts.dll")]
        public static extern short GT_GetControlConfig(short control, out TControlConfig pControl);
        [DllImport("gts.dll")]
        public static extern short GT_SetControlConfigEx(short control, ref TControlConfigEx pControl);
        [DllImport("gts.dll")]
        public static extern short GT_GetControlConfigEx(short control, out TControlConfigEx pControl);
        [DllImport("gts.dll")]
        public static extern short GT_SetProfileConfig(short profile, ref TProfileConfig pProfile);
        [DllImport("gts.dll")]
        public static extern short GT_GetProfileConfig(short profile, out TProfileConfig pProfile);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisConfig(short axis, ref TAxisConfig pAxis);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisConfig(short axis, out TAxisConfig pAxis);
        [DllImport("gts.dll")]
        public static extern short GT_ProfileScale(short axis, short alpha, short beta);
        [DllImport("gts.dll")]
        public static extern short GT_EncScale(short axis, short alpha, short beta);

        [DllImport("gts.dll")]
        public static extern short GT_EncSns(ushort sense);
        [DllImport("gts.dll")]
        public static extern short GT_LmtSns(ushort sense);
        [DllImport("gts.dll")]
        public static extern short GT_GpiSns(ushort sense);
        [DllImport("gts.dll")]
        public static extern short GT_SetAdcFilter(short adc, short filterTime);

        [DllImport("gts.dll")]
        public static extern short GT_GetConfigTable(short type, out short pCount);
        [DllImport("gts.dll")]
        public static extern short GT_GetConfigTableAll();

        [DllImport("gts.dll")]
        public static extern short GT_SetMcConfig(ref TMcConfig pMc);
        [DllImport("gts.dll")]
        public static extern short GT_GetMcConfig(out TMcConfig pMc);


        [DllImport("gts.dll")]
        public static extern short GT_SetMcConfigToFile(ref TMcConfig pMc, ref char pFile);
        [DllImport("gts.dll")]
        public static extern short GT_GetMcConfigFromFile(out TMcConfig pMc, out char pFile);

        [DllImport("gts.dll")]
        public static extern short GTN_SaveConfig(short core, out string pFile);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDiConfig(short core, short diType, short diIndex, ref TDiConfig pDi);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDiConfig(short core, short diType, short diIndex, out TDiConfig pDi);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDoConfig(short core, short doType, short doIndex, ref TDoConfig pDo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDoConfig(short core, short doType, short doIndex, out TDoConfig pDo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetStepConfig(short core, short step, ref TStepConfig pStep);
        [DllImport("gts.dll")]
        public static extern short GTN_GetStepConfig(short core, short step, out TStepConfig pStep);
        [DllImport("gts.dll")]
        public static extern short GTN_SetDacConfig(short core, short dac, ref TDacConfig pDac);
        [DllImport("gts.dll")]
        public static extern short GTN_GetDacConfig(short core, short dac, out TDacConfig pDac);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAdcConfig(short core, short adc, ref TAdcConfig pAdc);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAdcConfig(short core, short adc, out TAdcConfig pAdc);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCountConfig(short core, short countType, short countIndex, ref TCountConfig pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetCountConfig(short core, short countType, short countIndex, out TCountConfig pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_SetControlConfig(short core, short control, ref TControlConfig pControl);
        [DllImport("gts.dll")]
        public static extern short GTN_GetControlConfig(short core, short control, out TControlConfig pControl);
        [DllImport("gts.dll")]
        public static extern short GTN_SetControlConfigEx(short core, short control, ref TControlConfigEx pControl);
        [DllImport("gts.dll")]
        public static extern short GTN_GetControlConfigEx(short core, short control, out TControlConfigEx pControl);
        [DllImport("gts.dll")]
        public static extern short GTN_SetProfileConfig(short core, short profile, ref TProfileConfig pProfile);
        [DllImport("gts.dll")]
        public static extern short GTN_GetProfileConfig(short core, short profile, out TProfileConfig pProfile);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisConfig(short core, short axis, ref TAxisConfig pAxis);
        [DllImport("gts.dll")]
        public static extern short GTN_GetAxisConfig(short core, short axis, out TAxisConfig pAxis);
        [DllImport("gts.dll")]
        public static extern short GTN_ProfileScale(short core, short axis, short alpha, short beta);
        [DllImport("gts.dll")]
        public static extern short GTN_EncScale(short core, short axis, short alpha, short beta);
   
		/*-----------------------------------------------------------*/
        /* Config of Ext-Module                                      */
        /*-----------------------------------------------------------*/
        public struct TExtModuleStatus
        {
            public short active;
            public short checkError;
            public short linkError;
            public short packageErrorCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public short[] pad;
        }

        public struct TExtModuleType
        {
            public short type;
            public short input;
            public short output;
        }

        public struct TExtIoMap
        {
            public short station;
            public short module;
            public short index;
        }
		
		[DllImport("gts.dll")]
		public static extern short GTN_LoadExtModuleConfig(short core, string pFile);
        [DllImport("gts.dll")]
        public static extern short GTN_SaveExtModuleConfig(short core, string pFile);
        [DllImport("gts.dll")]
        public static extern short GTN_ExtModuleOn(short core, short station);
        [DllImport("gts.dll")]
        public static extern short GTN_ExtModuleOff(short core, short station);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtModuleStatus(short core, short station, out TExtModuleStatus pStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtModuleId(short core, short station, short count, ref short pId);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtModuleId(short core, short station, short count, out short pId);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtModuleReverse(short core, short station, short module, short inputCount, ref short pInputReverse, short outputCount, ref short pOutputReverse);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtModuleReverse(short core, short station, short module, short inputCount, out short pInputReverse, short outputCount, out short pOutputReverse);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtModuleCount(short core, short station, out short pCount);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtModuleType(short core, short station, short module, out TExtModuleType pModuleType);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtIoMap(short core, short type, short index, ref TExtIoMap pMap);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtIoMap(short core, short type, short index, out TExtIoMap pMap);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearExtIoMap(short core, short type);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtAoRange(short core, short index, double max, double min);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtAoRange(short core, short index, out double pMax, out double pMin);
        [DllImport("gts.dll")]
        public static extern short GTN_SetExtAiRange(short core, short index, double max, double min);
        [DllImport("gts.dll")]
        public static extern short GTN_GetExtAiRange(short core, short index, out double pMax, out double pMin);

        /*-----------------------------------------------------------*/
        /* Config of Laser and Scan                                  */
        /*-----------------------------------------------------------*/
        public struct TScanCommandMotion
        {
            public Int32 segmentNumber;
            public short x;
            public short y;
            public Int32 deltaX;
            public Int32 deltaY;
            public Int32 vel;
            public Int32 acc;
        }
        public struct TScanCommandMotionDelay
        {
            public Int32 delay;
        }

        public struct TScanCommandDo
        {
            public short doType;
            public short doMask;
            public short doValue;
        }

        public struct TScanCommandDoDelay
        {
            public Int32 delay;
        }

        public struct TScanCommandLaser
        {
            public short mask;
            public short value;
        }

        public struct TScanCommandLaserDelay
        {
            public Int32 laserOnDelay;
            public Int32 laserOffDelay;
        }

        public struct TScanCommandLaserPower
        {
            public Int32 power;
        }

        public struct TScanCommandLaserFrequency
        {
            public Int32 frequency;
        }

        public struct TScanCommandLaserPulseWidth
        {
            public Int32 pulseWidth;
        }

        public struct TScanCommandDa
        {
            public short daIndex;
            public short daValue;
        }

        public struct TScanMap
        {
            public short module;
            public short fifo;
        }

        [DllImport("gts.dll")]
        public static extern short GTN_SetScanMap(short core, short index, ref TScanMap pMap);
        [DllImport("gts.dll")]
        public static extern short GTN_GetScanMap(short core, short index, out TScanMap pMap);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearScanMap(short core);
        [DllImport("gts.dll")]
        public static extern short GTN_UpdateScanMap(short core);

        /*-----------------------------------------------------------*/
        /* Config of Position Compare                                */
        /*-----------------------------------------------------------*/
        public struct TPosCompareMap
        {
            public short module;
            public short fifo;
        }

        [DllImport("gts.dll")]
        public static extern short GTN_SetPosCompareMap(short core, short index, ref TPosCompareMap pMap);
        [DllImport("gts.dll")]
        public static extern short GTN_GetPosCompareMap(short core, short index, out TPosCompareMap pMap);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearPosCompareMap(short core);
    }
	
	/*-----------------------------------------------------------*/
	//ԭringnet.cs���͵Ȼ���������ع��ܵ�ָ��                   */
	/*-----------------------------------------------------------*/
	/*-----------------------------------------------------------*/
	/* Ringnet                                                   */
	/*-----------------------------------------------------------*/
	public class mc_ringnet
    {
    	public const short RTN_SUCCESS = 0;
        public const short RTN_MALLOC_FAIL = -100;                 /* malloc memory fail */
        public const short RTN_FREE_FAIL = -101;                   /* free memory or delete the object fail */
        public const short RTN_NULL_POINT = -102;                  /* the param point input is null */ 
        public const short RTN_ERR_ORDER = -103;                   /* call the function order is wrong, some msg isn't validable */
        public const short RTN_PCI_NULL = -104;                    /* the pci address is empty, can't access the pci device */
        public const short RTN_PARAM_OVERFLOW = -105;              /* the param input is too larget */
        public const short RTN_LINK_FAIL  = -106;                  /* the two ports both link fail */ 
        public const short RTN_IMPOSSIBLE_ERR = -107;              /* it means the system or same function work wrong */
        public const short RTN_TOPOLOGY_CONFLICT = -108;           /* the id conflict */
        public const short RTN_TOPOLOGY_ABNORMAL = -109;           /* scan the net abnormal */
        public const short RTN_STATION_ALONE = -110;               /* the device no id, it means the device id is 0xF0 */
        public const short RTN_WAIT_OBJECT_OVERTIME = -111;        /* multi thread wait for object overtime */
        public const short RTN_ACCESS_OVERFLOW = -112;             /* data[i];  i is larger than the define */
        public const short RTN_NO_STATION = -113;                  /* the station accessed not existent */
        public const short RTN_OBJECT_UNCREATED = -114;            /* the object not created yet */
        public const short RTN_PARAM_ERR = -115;                   /* the param input is wrong */
        public const short RTN_PDU_CFG_ERR = -116;                 /*Pdu DMA Cfg Err */
        public const short RTN_PCI_FPGA_ERR = -117;                /*PCI op err or FPGA op err */
        public const short RTN_CHECK_RW_ERR = -118;      	       /*data write to reg, then rd out, and check err */
        public const short RTN_REMOTE_UNEABLE = -119;              /*the device which will be ctrl by net can't be ctrl by net function */ 

        public const short RTN_NET_REQ_DATA_NUM_ZERO = -120;       /* mail op or pdu op req data num can't be 0 */
        public const short RTN_WAIT_NET_OBJECT_OVERTIME = -121;    /* net op multi thread wait for object overtime */
        public const short RTN_WAIT_NET_RESP_OVERTIME = -122;      /* Can't wait for resp */
        public const short RTN_WAIT_NET_RESP_ERR = -123;           /* wait mailbox op err */
        public const short RTN_INITIAL_ERR = -124;                 /* initial the device err */
        public const short RTN_PC_NO_READY = -125;                 /* find the station'pc isn't work */ 
        public const short RTN_STATION_NO_EXIST = -126; 
        public const short RTN_MASTER_FUNCTION = -127;             /* this funciton only used by master */

        public const short RTN_NOT_ALL_RETURN = -128;              /* the GT_RN_PtProcessData funciton fail return */
        public const short RTN_NUM_NOT_EQUAL = -129;               /* the station number of RingNet do not equal  the station number of CFG */

        public const short RTN_CHECK_STATION_ONLINE_NUM_ERR = -130;/* Check no slave */
        public const short RTN_FILE_ERR_OPEN = -131;               /* open file error */
        public const short RTN_FILE_ERR_FORMAT = -132;             /* parse file error */
        public const short RTN_FILE_ERR_MISSMATCH = -133;          /* file info is not match with the actual ones */
        public const short RTN_DMALIST_ERR_MISSMATCH = -134;       /* can't find the slave */

        public const short RTN_REQUSET_MAIL_BUS_OVERTIME = -150;   /* Requset Mail Bus Err */
        public const short RTN_INSTRCTION_ERR = -151;              /* instrctions err */
        public const short RTN_MAIL_RESP_REQ_ERR = -152;           /* RN_MailRespReq  err */
        public const short RTN_CTRL_SRC_ERR = -153;                /* the controlled source  is error */
        public const short RTN_PACKET_ERR = -154;                  /* packet is error */
        public const short RTN_STATION_ID_ERR = -155;              /* the device id is not in the right rang */
        public const short RTN_WAIT_NET_PDU_RESP_OVERTIME = -156;  /* net pdu op wait overtime */
        public const short RTN_ETHCAT_ENC_POS_ERR = -157;

        public const short RTN_IDLINK_PACKET_ERR = -200;           /* ilink master  decode err! packet_length is not match */
        public const short RTN_IDLINK_PACKET_END_ERR = -201;       /* the ending of ilink packet is not 0xFF */
        public const short RTN_IDLINK_TYPER_ERR = -202;            /* the type of ilink module is error */
        public const short RTN_IDLINK_LOST_CNT = -203;             /* the ilink module has lost connection */
        public const short RTN_IDLINK_CTRL_SRC_ERR = -204;         /* the controlled source of ilink module is error */
        public const short RTN_IDLINK_UPDATA_ERR = -205;           /* the ilink module updata error */
        public const short RTN_IDLINK_NUM_ERR = -206;              /* the ilink num larger the IDLINK_MAX_NUM(30) */
        public const short RTN_IDLINK_NUM_ZERO = -207;             /* the ilink num is zero */

        public const short RTN_NO_PACKET = 301;                    /* no valid packet */
        public const short RTN_RX_ERR_PDU_PACKET = -302;           /* ERR PDU PACKET */
        public const short RTN_STATE_MECHINE_ERR = -303; 
        public const short RTN_PCI_DSP_UN_FINISH = 304;
        public const short RTN_SEND_ALL_FAIL = -305;
        public const short RTN_STATION_CLOSE = 310;
        public const short RTN_STATION_RESP_FAIL = 311;		

        public const short RTN_UPDATA_MODAL_ERR = -330;            /* update the modal in normal way fail */

        public const short RTN_NO_MAIL_DATA = 340;                 /* There is no mail data */
        public const short RTN_NO_PDU_DATA = 341;                  /* There is no pdu data */


        public const short RTN_FILE_PARAM_NUM_ERR = -500;
        public const short RTN_FILE_PARAM_LEN_ERR = -501;
        public const short RTN_FILE_MALLOC_FAIL = -502;
        public const short RTN_FILE_FREE_FAIL = -503;
        public const short RTN_FILE_PARAM_ERR = -504;
        public const short RTN_FILE_NOT_EXSITS = 505;
        public const short RTN_FILE_CREATE_FAIL = 510;
        public const short RTN_FILE_DELETE_FAIL = 511;
        public const short RTN_FIFE_CRC_CHECK_ERR = -512;
        public const short RTN_FIFE_FUNCTION_ID_RETURN_ERR = -600;
        public const short RTN_DLL_WINCE = -800;
        public const short RTN_DLL_WIN32 = -801;
        public const short RTN_XML_STATION_ERR = -900;                  //dma config file confilit with slave type
     
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetEncPos(short encoder,out double pValue, short count, ref UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetAxisError(short axis, out double pValue, short count, ref UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetPrfMode(short axis, out Int32 pValue, short count, ref UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetAuEncPos(short encoder, out double pValue, short count, ref UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetCaptureStatus(short encoder, out short pStatus, out Int32 pValue, short count, ref UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetSts(short axis, out Int32 pSts, short count, ref UInt32 pClock);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetPowerSts(out Int32 pValue);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetEcatAxisACTArray(short axis, ref short pCur, out short pTorque, short count);
        [DllImport("gts.dll")]
        public static extern short GT_RN_PtSpaceArray(short profile, out short pSpace, short fifo, short count);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetDoEx(short doType, out Int32 pValue);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetDiEx(short diType, out Int32 pValue);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetDo(short doType, out Int32 pValue);
        [DllImport("gts.dll")]
        public static extern short GT_RN_GetDi(short diType, out Int32 pValue);
        
        [DllImport("gts.dll")]
        public static extern short GTN_LoadRingNetConfig(short core,string pFile);
        [DllImport("gts.dll")]
        public static extern short GTN_SaveRingNetConfig(short core,string pFile);

        public const short TERMINAL_LOAD_MODE_NONE = 0;
        public const short TERMINAL_LOAD_MODE_BOOT = 2;
 
        public struct TTerminalStatus
        {
	        public UInt16 type;
	        public short id;
	        public Int32 status;
	        public UInt32 synchCount;
	        public UInt32 ringNetType;
	        public UInt32 portStatus;
	        public UInt32 sportDropCount;
	        public UInt32 reserve1;
            public UInt32 reserve2;
            public UInt32 reserve3;
            public UInt32 reserve4;
            public UInt32 reserve5;
            public UInt32 reserve6;
            public UInt32 reserve7;
        }

        [DllImport("gts.dll")]
        public static extern short GTN_TerminalInit(short core,short detect);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalVersion(short core,short index,out GTN.mc.TVersion pTerminalVersion);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTerminalPermit(short core,short index,short dataType,UInt16 permit);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTerminalPermitEx(short core,short station,short dataType,ref short permit,short index,short count);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalPermitEx(short core,short station,short dataType,out short pPermit,short index,short count);

        [DllImport("gts.dll")]
        public static extern short GTN_FindStation(short core,short station,UInt32 time);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalPermit(short core,short index,short dataType,out UInt16 pPermit);
        [DllImport("gts.dll")]
        public static extern short GTN_ProgramTerminalConfig(short core,short loadMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalConfigLoadMode(short core,out short pLoadMode);

        [DllImport("gts.dll")]
        public static extern short GTN_ReadPhysicalMap();
        [DllImport("gts.dll")]
        public static extern short ConvertPhysical(short core,short dataType,short terminal,short index);

        [DllImport("gts.dll")]
        public static extern short GTN_SetTerminalSafeMode(short core,short index,short safeMode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalSafeMode(short core,short index,ref short pSafeMode);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearTerminalSafeMode(short core,short index);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalStatus(short core,short index,out TTerminalStatus pTerminalStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalType(short core,short count,out UInt16 pType,ref short pTypeConnect);
		
		/*-----------------------------------------------------------*/
		/* ��ȡSPORT������                                           */
		/*-----------------------------------------------------------*/
		public const short SPORT_COUNT = 256;

		public struct TTerminalData
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SPORT_COUNT)]
			public UInt32[] terminalTxBuf;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SPORT_COUNT)]
			public UInt32[] terminalRxBuf;
		};
		[DllImport("gts.dll")]
		public static extern short GTN_ReadTerminalData(short core,out TTerminalData pTerminalData);

        /*-----------------------------------------------------------*/
        /* Config of module                                          */
        /*-----------------------------------------------------------*/
        public const short TERMINAL_OPERATION_NONE = 0;
        public const short TERMINAL_OPERATION_SKIP = 1;
        public const short TERMINAL_OPERATION_CLEAR = 2;
        public const short TERMINAL_OPERATION_RESET_MODULE = 3;

        public const short TERMINAL_OPERATION_PROGRAM = 11;
        
        public struct TRingNetCrcStatus
        {
            public UInt32 portACrcOkCnt;
            public UInt16 portACrcErrorCnt;
            public UInt32 portBCrcOkCnt;
            public UInt16 portBCrcErrorCnt;
            public UInt32 reserve;             //Ŀǰ���ڶ�ȡFLASH�����ݳ���
        }

        public struct TTerminalError
        {
            public UInt16 errorCountReceive;
            public UInt16 errorCountPackageDown;
            public UInt16 errorCountPackageUp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
            public UInt16[] reserve;
        }
        public struct TTerminalMap
        {
            public short moduleDataType;
            public short moduleDataIndex;
            public short dataIndex;
            public short dataCount;
        }

        [DllImport("gts.dll")]
        public static extern short GT_SetMailbox(short core, short station, UInt16 byteAddress, ref UInt16 pData, UInt16 wordCount, UInt16 dataMode, UInt16 desId, UInt16 type);
        [DllImport("gts.dll")]
        public static extern short GT_GetMailbox(short core, short station, UInt16 byteAddress, out UInt16 pData, UInt16 wordCount, UInt16 dataMode, UInt16 desId, UInt16 type);

        [DllImport("gts.dll")]
        public static extern short GTN_LoadTerminalConfig(short core, string pFile);
        [DllImport("gts.dll")]
        public static extern short GTN_SaveTerminalConfig(short core, string pFile);
        [DllImport("gts.dll")]
        public static extern short GTN_TerminalOn(short core, short index);
        [DllImport("gts.dll")]
        public static extern short GTN_TerminalSynch(short core, short index);
        [DllImport("gts.dll")]
        public static extern short GTN_GetRingNetCrcStatus(short core, short index, out TRingNetCrcStatus pRingNetCrcStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalError(short core, short index, out TTerminalError pTerminalError);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTerminalType(short core, short count, ref short pType);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalLinkStatus(short core, short count, out short ringNetType, out short pLinkStatus);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTerminalMap(short core, short dataType, short moduleIndex, ref TTerminalMap pMap);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalMap(short core, short dataType, short moduleIndex, out TTerminalMap pMap);
        [DllImport("gts.dll")]
        public static extern short GTN_ClearTerminalMap(short core, short dataType);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTerminalMode(short core, short station, UInt16 mode);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalMode(short core, short station, out UInt16 pMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTerminalTest(short core, short station, short index, UInt16 value);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalTest(short core, short station, short index, out UInt16 pValue);
        [DllImport("gts.dll")]
        public static extern short GTN_SetTerminalOperation(short core, short operation);
        [DllImport("gts.dll")]
        public static extern short GTN_GetTerminalOperation(short core, out short pOperation);
        [DllImport("gts.dll")]
        public static extern short GTN_SetMailbox(short core, short station, UInt16 byteAddress, ref UInt16 pData, UInt16 wordCount, UInt16 dataMode, UInt16 desId, UInt16 type);
        [DllImport("gts.dll")]
        public static extern short GTN_GetMailbox(short core, short station, UInt16 byteAddress, out UInt16 pData, UInt16 wordCount, UInt16 dataMode, UInt16 desId, UInt16 type);
        [DllImport("gts.dll")]
        public static extern short GTN_GetUuid(short core, string pCode, short count);
        
        /*-----------------------------------------------------------*/
		/* ����ָ�ָ��                                              */
		/*-----------------------------------------------------------*/
		[DllImport("gts.dll")]
		public static extern short GTN_RN_Recover(short cardIndex);

		/*-----------------------------------------------------------*/
		/* GSHD�����С��������                                      */
		/*-----------------------------------------------------------*/
		public struct TTorqueLimit
		{
			public ushort torqueMax;
			public ushort torquePostive;
			public ushort torqueNegitive;
			public short reserve1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public double[] reserve2;
		};

		[DllImport("gts.dll")]
		public static extern short GTN_RN_SetTorqueLimit(short core,short axis,ref TTorqueLimit pTorqueLimit);
		[DllImport("gts.dll")]
        public static extern short GTN_RN_GetTorqueLimit(short core,short axis,out TTorqueLimit pTorqueLimit);
		
		/*-----------------------------------------------------------*/
		/* GSHD�ջ���������                                          */
		/*-----------------------------------------------------------*/
		public struct TServoPosLoopPidMode0
		{
			public double value;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public double[] reverse;
		};

		public struct TServoPosLoopPidUnion
		{
			public TServoPosLoopPidMode0 servoPosLoopPidMode0;
		};

		public struct TServoPosLoopPid  
		{
			public short mode;
			public TServoPosLoopPidUnion servoPosLoopPidPrm;
		};

		[DllImport("gts.dll")]
		public static extern short GTN_SetServoPosLoopPid(short core,short axis,ref TServoPosLoopPid pServoPosLoopPid);
		[DllImport("gts.dll")]
		public static extern short GTN_GetServoPosLoopPid(short core,short axis,out TServoPosLoopPid pServoPosLoopPid);

		/*-----------------------------------------------------------*/
		/* ��ȫģʽ����                                              */
		/*-----------------------------------------------------------*/
		[DllImport("gts.dll")]
		public static extern short GTN_RN_SetStationSafeModeControl(short cardIndex,short stationPhyId,short enable,short clearMode);
		[DllImport("gts.dll")]
		public static extern short GTN_RN_ClearStationSafeModeStatus(short cardIndex,short stationPhyId);
		[DllImport("gts.dll")]
		public static extern short GTN_RN_SetStationSafeModeOut(short cardIndex,short stationPhyId,short type,short index,ref short pEnable,ref double pValue,short count);
		[DllImport("gts.dll")]
		public static extern short GTN_RN_IlinkSetSafeModeControl(short cardIndex,short stationPhyId,short modulePhyId,short enable,short clearMode);
		[DllImport("gts.dll")]
		public static extern short GTN_RN_IlinkClearSafeModeStatus(short cardIndex,short stationPhyId,short modulePhyId);
		[DllImport("gts.dll")]
		public static extern short GTN_RN_IlinkSetSafeModeOut(short cardIndex,short stationPhyId,short modulePhyId,short type,short index,ref short pEnable,ref double pValue,short count);
	}

	/*-----------------------------------------------------------*/
	//ԭLookAheadEx.cs����ǰհ��ع��ܵ�ָ��                      */
	/*-----------------------------------------------------------*/
	public class mc_la
	{
		public const short LA_AXIS_NUM = 8;
		public const short LA_WORK_AXIS_NUM = 6;

        //��Ĳ�����Ϣ����������ٶȣ����������ٶȣ���������ٶȱ仯�����Ƿ������ٶ�ģʽ
        public const short AXIS_LIMIT_NONE = 0;     //��������
        public const short AXIS_LIMIT_MAX_VEL = 1;  //������ٶ�����
        public const short AXIS_LIMIT_MAX_ACC = 2;  //�������ٶ�����
        public const short AXIS_LIMIT_MAX_DV = 4;   //������ٶ�����������
		public const short KIN_MSG_BUFFER_SIZE = 32;

        //�ٶȹ滮ģʽ
        public enum EVelMode
        {
            T_CURVE = 0,
            S_CURVE,
            S_CURVE_NEW,                    //���ݼӼ��ٶȡ������ٶȽ���S�����ٶ�ǰհ��2015.11.16
            S_CURVE_SMOOTH,

            VEL_MODE_MAX = 0x10000,         //ȷ������Ϊ4Byte
        };

		//��������ϵ�¹켣�Ƿ������ٶ�ģʽ
		public enum EWorkLimitMode
		{
			WORK_LIMIT_INVALID = 0,		    //������
			WORK_LIMIT_VALID = 1,			//������Ч
			
			WORK_LIMIT_MODE_MAX=0x10000,    //ȷ������Ϊ4Byte
		};
		
		//���õ��ٶȶ������
		public enum EVelSettingDef
		{
			NORMAL_DEF_VEL = 0,			    //����Ϊ������ϵ������ĺϳ��ٶ�
			NUM_DEF_VEL = 1,				//��NUMϵͳ�Ĺ�����
			CUT_DEF_VEL = 2,				//�ٶ�Ϊ�����ٶ�
		
			VEL_SETTING_DEF_MAX=0x10000,    //ȷ������Ϊ4Byte
		};
		
		//���õļ��ٶȶ������
		public enum EAccSettingDef
		{
			NORMAL_DEF_ACC = 0,             //���뼴���
			LONG_AXIS_ACC = 1,              //��������ٶ�
		
			VEL_SETTING_DEF_MAX=0x10000,    //ȷ������Ϊ4Byte
		};
		
		//��������
		public enum EMachineMode
		{
			NORMAL_THREE_AXIS = 0,		    //��׼�������ģʽ
			MULTI_AXES = 1,					//��������ģʽ
			FIVE_AXIS = 2,					//�������ģʽ��������ϵΪ������������ϵΪ��
			FIVE_AXIS_WORK = 3,				//�������ģʽ����������ϵΪ����������ϵΪ��
			ROBOT = 4,
		
			VEL_SETTING_DEF_MAX=0x10000,    //ȷ������Ϊ4Byte
		};
		//ǰհ�����ṹ��
		public struct TLookAheadParameter
		{
			public int lookAheadNum;					          //ǰհ����
			public double time;						              //ʱ�䳣��
			public double radiusRatio;					          //�������Ƶ��ڲ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public double[] vMax;			                      //���������ٶ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public double[] aMax;			                      //����������ٶ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public double[] DVMax;			                      //���������ٶȱ仯������ʱ�䳣���ڣ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public double[] scale;			                      //��������嵱��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public short[] axisRelation;	                      //����������ڲ�����Ķ�Ӧ��ϵ
            [MarshalAs(UnmanagedType.ByValArray,SizeConst = 128)]
			public char[] machineCfgFileName;		              //���������ļ���
		};
		
		//////////////////////////////////////
		public struct RC_KIN_CONFIG
		{
			public short RobotType;
			public short reserved1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
			public short[] KinParUse;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
			public double[] KinPar;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
			public short[] KinLimitUse;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
			public double[] KinLimitMin;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
			public double[] KinLimitMax;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
			public double[] KinLimitMinShift;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
			public double[] KinLimitMaxShift1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public short[] AxisUse;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public char[] AxisPosSignSwitch;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public double[] AxisPosOffset;
		
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
			public short[] CartUnitUse;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
			public char[] CartPosKCSSignSwitch;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public short[] reserved2;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
			public double[] CartPosKCSOffset;
		};
		
		public struct RC_ERROR_INTERFACE
		{
			public char Error;
			public short ErrorID;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 129)]
			public char[] Message;
		};
		
		public struct RC_MSG_BUFFER_ELEMENT
		{
			public short ErrorID;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 129)]
			public char[] Message;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public char[] LogTime;
			public Int32 InternalID;
		};
		
		public struct RC_MSG_BUFFER 
		{
			public short LastMsgIndex;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public RC_MSG_BUFFER_ELEMENT[] MsgElement;
			public Int32 LastMsgID;
		};

        //����ⷽ��
        public enum ETransDir
        {
            FORWARD_TRANS = 0,          //����
            INVERSE_TRANS,              //���

            TRANS_DIR_MAX = 0x10000,	// ȷ������Ϊ4Byte
        };

		//��ת�᷶Χ����
		public struct TRotationAxisRange
		{
			public int primaryAxisRangeOn;              //��һ��ת���޶���Χ�Ƿ���Ч��0������Ч��1����Ч
			public int slaveAxisRangeOn;                //�ڶ���ת���޶���Χ�Ƿ���Ч��0������Ч��1����Ч
			public double maxPrimaryAngle;              //��һ��ת�����ֵ
			public double minPrimaryAngle;              //��һ��ת����Сֵ
			public double maxSlaveAngle;                //�ڶ���ת�����ֵ
			public double minSlaveAgnle;                //�ڶ���ת����Сֵ
		};
		
		//ѡ�����
		public enum EGroupSelect
		{
			Continuous=0,
			Group_1,
			Group_2,
		};
	
		public enum OptimizeState
        {
            OPT_OFF=0,
            OPT_ON=1
        };

		public enum OptimizeMethod
        {
            NO_OPT = 0,
            OPT_BLENDING, 
            OPT_CIRCLEFITTING,
            OPT_CUBICSPLINE,
            OPT_BSPLINE,
        };
		
		public enum ErrorID
        {
            INIT_ERROR = 1,		                    //û�н��в�����ʼ��
			PASSWORD_ERROR,		                    //����������ڹ̸��˶�����ƽ̨������
			INDATA_ERROR,		                    //�������ݴ��󣨼��Բ�������Ƿ���ȷ��
			PRE_PROCESS_ERROR,	
			TOOL_RADIUS_COMPENSATE_ERROR_INOUT,		//���߰뾶�������󣺽���/����������������Բ��
			TOOL_RADIUS_COMPENSATE_ERROR_NOCROSS,	//���߰뾶�����������ݲ������޷����㽻��
			USERDATA_ERROR,
		};
		
		//�켣�Ż������ṹ��
		public struct TOptimizeParamUser 
		{
			public OptimizeState usePathOptimize;	 //�Ƿ�ʹ��·���Ż���OPT_OFF:��ʹ��	OPT_ON:ʹ��
		
			public float tolerance;				     //����(suggest: rough:0.1, pre-finish:0.05, finish:0.01)
		
			public OptimizeMethod optimizeMethod;	//ѡ�������Ż���ʽ
		
			public OptimizeState keepLargeArc;		//�Ƿ�����Բ����OPT_OFF���������� OPT_ON������
		
			public float blendingMinError;			//blending����С�趨���
		
			public float blendingMaxAngle;			//blending�����Ƕ����ƣ������߶������Ƕȴ��ڸýǶ�ʱ������blending����λ���ȣ�
		
		};
		
		public struct TErrorInfo 
		{
			public ErrorID errorID;		//�����(INIT_ERROR:δ��ʼ��������PRE_PROCESS_ERROR:Ԥ����ģ�����
			public int errorRowNum;		//�����к�
		};
		
		public struct TPreStartPos 
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LA_AXIS_NUM)]
		    public double[] Pos;
		};
		
		public enum EMachineType
		{
			RW_C_ON_B=0,//B Ϊ��һ��ת�ᣬC Ϊ�ڶ���ת��
			RW_B_ON_A,	//A Ϊ��һ��ת�ᣬB Ϊ�ڶ���ת��
			RW_A_ON_B,	//B Ϊ��һ��ת�ᣬA Ϊ�ڶ���ת��
			RW_C_ON_A,	//A Ϊ��һ��ת�ᣬC Ϊ�ڶ���ת��
			DT_B_ON_A,	//A Ϊ��һ��ת�ᣬB Ϊ�ڶ���ת��
			DT_A_ON_B,	//B Ϊ��һ��ת�ᣬA Ϊ�ڶ���ת��
			DT_A_ON_C,	//C Ϊ��һ��ת�ᣬA Ϊ�ڶ���ת��
			DT_B_ON_C,	//C Ϊ��һ��ת�ᣬB Ϊ�ڶ���ת��
			T_A_W_B,	//A Ϊ��һ��ת�ᣬB Ϊ�ڶ���ת��
			T_B_W_A,	//B Ϊ��һ��ת�ᣬA Ϊ�ڶ���ת��
			T_A_W_C,	//A Ϊ��һ��ת�ᣬC Ϊ�ڶ���ת��
			T_B_W_C,	//B Ϊ��һ��ת�ᣬC Ϊ�ڶ���ת��
		};
		
		public struct TMachCfgInfo
		{
			public EMachineType machineType;                        //��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public short[] reserve1;                                //��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public double[] primaryAxisPoint;                       //��һ��ת��������MCS������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public double[] slaveAxisPoint;                         //�ڶ���ת��������MCS������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public double[] toolLocationPoint;                      //��������ϵ������MCS������
			public short dirMode;                                   //��������ģʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public short[] reserve2;                                //��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
			public short[] dir;                                     //���᷽��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5*3)]
			public double[] axisVector;                             //�������߷���
		};

		public struct TLaserFollowDuoTablePrm
		{
			public short frqTableId;
			public short dutyTableId;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public double[] pad1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public short[] pad2;
		}

        [DllImport("gts.dll")]
        public static extern short GT_SetupLookAheadCrd(short crd, EMachineMode machineMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetVelDefineModeLa(short crd, EVelSettingDef velDefMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetAccDefineModeLa(short crd, EAccSettingDef accDefMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisLimitModeLa(short crd, ref int pAxisLimitMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetWorkLimitModeLa(short crd, EWorkLimitMode workLimitMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisFollowModeLa(short crd, ref int pFollowMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisVelValidModeLa(short crd, int velValidAxis);
        [DllImport("gts.dll")]
        public static extern short GT_SetArcAllowErrorLa(short crd, double error);
        [DllImport("gts.dll")]
        public static extern short GT_SetMinEvenVelTime(short crd, double evenTime);
        [DllImport("gts.dll")]
        public static extern short GT_SetMinDccAngle(short crd, double dccAngle);
        [DllImport("gts.dll")]
        public static extern short GT_SetProfilePeriod(short crd, double profilePeriod);
        [DllImport("gts.dll")]
        public static extern short GT_SetFilterTime(short crd, Int32 filtNum);
        [DllImport("gts.dll")]
        public static extern short GT_SetPrecisionControl(short crd, short mode, double error);
        [DllImport("gts.dll")]
        public static extern short GT_SetVelSmoothModeLa(short crd, short smoothMode);
        [DllImport("gts.dll")]
        public static extern short GT_SetVelModeLa(short crd, EVelMode velMode);
        [DllImport("gts.dll")]
        public static extern short GT_InitLookAheadEx(short crd, ref TLookAheadParameter pLookAheadPara, short fifo, short motionMode, ref TPreStartPos pPreStartPos);
        [DllImport("gts.dll")]
        public static extern short GT_PrintLACmdLa(short crd, int printFlag, int clearFile);
        
        [DllImport("gts.dll")]
        public static extern short GT_GetLookAheadSegCountEx(short crd, out int pSegCount, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetMotionTimeEx(short crd, out double pTime, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_SetUserSegNumEx(short crd, int segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_CrdDataEx(short crd, System.IntPtr pCrdData, short fifo);  //����ʱ���� IntPtr.Zero GTN_CrdDataEx(1, System.IntPtr.Zero, 0);

        [DllImport("gts.dll")]
        public static extern short GT_LnXYEx(short crd, double x, double y, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYG0Ex(short crd, double x, double y, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZEx(short crd, double x, double y, double z, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZG0Ex(short crd, double x, double y, double z, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAEx(short crd, double x, double y, double z, double a, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAG0Ex(short crd, double x, double y, double z, double a, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZACEx(short crd, ref double pPos, short posMask, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZACG0Ex(short crd, ref double pPos, short posMask, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZACUVWEx(short crd, ref double pPos, short posMask, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZACUVWG0Ex(short crd, ref double pPos, short posMask, double synVel, double synAcc, int segNum, short override2, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_ArcXYREx(short crd, double x, double y, double radius, short circleDir, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZREx(short crd, double y, double z, double radius, short circleDir, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXREx(short crd, double z, double x, double radius, short circleDir, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYCEx(short crd, double x, double y, double xCenter, double yCenter, short circleDir, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZCEx(short crd, double y, double z, double yCenter, double zCenter, short circleDir, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXCEx(short crd, double z, double x, double zCenter, double xCenter, short circleDir, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYZEx(short crd, double x, double y, double z, double interX, double interY, double interZ, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYRZEx(short crd, double x, double y, double z, double radius, short circleDir, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYCZEx(short crd, double x, double y, double z, double xCenter, double yCenter, short circleDir, double synVel, double synAcc, int segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZRXEx(short crd, double x, double y, double z, double radius, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZCXEx(short crd, double x, double y, double z, double yCenter, double zCenter, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXRYEx(short crd, double x, double y, double z, double radius, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXCYEx(short crd, double x, double y, double z, double zCenter, double xCenter, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_HelixXYRMultiZEx(short crd, ref double pPos, double radius, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixXYCMultiZEx(short crd, ref double pPos, double xCenter, double yCenter, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZRMultiXEx(short crd, ref double pPos, double radius, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixYZCMultiXEx(short crd, ref double pPos, double yCenter, double zCenter, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXRMultiYEx(short crd, ref double pPos, double radius, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_HelixZXCMultiYEx(short crd, ref double pPos, double zCenter, double xCenter, short circleDir, double synVel, double synAcc, Int32 segNum, short override2, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_BufDelayEx(short crd, ushort delayTime, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufIOEx(short crd, ushort doType, ushort doMask, ushort doValue, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufDAEx(short crd, short chn, short daValue, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufEnableDoBitPulseEx(short crd, short doType, short doIndex, ushort highLevelTime, ushort lowLevelTime, int pulseNum, short firstLevel, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufDisableDoBitPulseEx(short crd, short doType, short doIndex, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufGearEx(short crd, short gearAxis, double deltaPos, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufMoveEx(short crd, short moveAxis, double pos, double vel, double acc, short modal, short fifo);
        
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowMasterEx(short crd, ref GTN.mc.TBufFollowMaster pBufFollowMaster, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowEventCrossEx(short crd, ref GTN.mc.TBufFollowEventCross pEventCross, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowEventTriggerEx(short crd, ref GTN.mc.TBufFollowEventTrigger pEventTrigger, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowStartEx(short crd, Int32 masterSegment, Int32 slaveSegment, Int32 masterFrameWidth, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowNextEx(short crd, Int32 width, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufFollowReturnEx(short crd, double vel, double acc, short smoothPercent, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_BufSmartCutterOnEx(short crd, short index, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufSmartCutterOffEx(short crd, short index, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_BufLaserOnEx(short crd, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserOffEx(short crd, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowModeEx(short crd, short source, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowTableEx(short crd, short tableId, double minPower, double maxPower, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowOffEx(short crd, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserPrfCmdEx(short crd, double laserPower, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GT_BufLaserFollowRatioEx(short crd, double ratio, double minPower, double maxPower, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_SetupLookAheadCrd(short core,short crd,EMachineMode machineMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisFollowModeLa(short core, short crd, ref Int32 pFollowMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetVelDefineModeLa(short core,short crd,EVelSettingDef velDefMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAccDefineModeLa(short core, short crd, EAccSettingDef accDefMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisLimitModeLa(short core, short crd, ref Int32 pAxisLimitMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetWorkLimitModeLa(short core,short crd,EWorkLimitMode workLimitMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisVelValidModeLa(short core, short crd, Int32 velValidAxis);
        [DllImport("gts.dll")]
        public static extern short GTN_SetVelModeLa(short core, short crd, EVelMode velMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetVelSmoothModeLa(short core, short crd, short smoothMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetVelSmoothMode(short core, short crd, Int32 smoothMode);
        [DllImport("gts.dll")]
        public static extern short GTN_PrintLACmdLa(short core, short crd, Int32 printFlag, Int32 clearFile);
        [DllImport("gts.dll")]
        public static extern short GTN_UpdateMachineBuildingFileLa(short core, short crd, int update);
        [DllImport("gts.dll")]
        public static extern short GTN_InitialMachineBuildingEx(short core, short crd, string pMachineCfgFileName, ref double machineCoordCenter, ref double workCoordCenter, double toolLength);
        [DllImport("gts.dll")]
        public static extern short GTN_InitialMachineBuildingPara(short core, short crd, ref TMachCfgInfo pMachCfgInfo, ref double machineCoordCenter,ref double workCoordCenter, double toolLength);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdRTCPOn(short core, short crd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdRTCPOff(short core, short crd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetNonlinearErrorControl(short core, short crd, Int32 enable, double nonlinearError);
        [DllImport("gts.dll")]
        public static extern short GTN_EnableDiscreateArc(short core, short crd, short enable, double arcError);
        [DllImport("gts.dll")]
        public static extern short GTN_SetAxisVelValidCompModeLa(short core, short crd, Int32 enable, ref Int32 pCompAxis);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowAxisProcessModeLa(short core, short crd, Int32 AxisFollowMode);
        [DllImport("gts.dll")]
        public static extern short GTN_SetCmdVelLimitLa(short core, short crd, Int32 enable, Int32 n1, Int32 n2, Int32 mode);
        [DllImport("gts.dll")]
        public static extern short GTN_InitLookAheadEx(short core, short crd, ref TLookAheadParameter pLookAheadPara, short fifo, short motionMode, ref TPreStartPos pPreStartPos);
        [DllImport("gts.dll")]
        public static extern short GTN_InitLookAheadPara(short core, short crd, Int32 lookAheadNum, double time, double radiusRatio, double scale, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetFollowAxisParaLa(short core, short crd, ref Int32 pAxisLimitMode, ref double pVmax, ref double pAmax, ref double pDVmax);
		[DllImport("gts.dll")]
		public static extern short GTN_SetCompToolLength(short core,short crd, double compToolLength);
		[DllImport("gts.dll")]
		public static extern short GTN_SetCompWorkCoordOffset(short core,short crd, ref double pCompWorkOffset);

        [DllImport("gts.dll")]
        public static extern short GTN_GetLookAheadSegCountEx(short core, short crd, out int pSegCount, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_GetMotionTimeEx(short core, short crd, out double pTime, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_SetUserSegNumEx(short core, short crd, int segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_CrdDataEx(short core, short crd, System.IntPtr pCrdData, short fifo);  //����ʱ���� IntPtr.Zero GTN_CrdDataEx(1, System.IntPtr.Zero, 0);      
        
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYEx(short core,short crd,double x,double y,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYG0Ex(short core,short crd,double x,double y,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYZEx(short core,short crd,double x,double y,double z,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYZG0Ex(short core,short crd,double x,double y,double z,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYZAEx(short core,short crd,double x,double y,double z,double a,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYZAG0Ex(short core,short crd,double x,double y,double z,double a,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYZACEx(short core,short crd,ref double pPos,short posMask,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYZACG0Ex(short core,short crd,ref double pPos,short posMask,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYZACUVWEx(short core,short crd,ref double pPos,short posMask,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_LnXYZACUVWG0Ex(short core,short crd,ref double pPos,short posMask,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_ArcXYREx(short core,short crd,double x,double y,double radius,short circleDir,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_ArcYZREx(short core,short crd,double y,double z,double radius,short circleDir,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_ArcZXREx(short core,short crd,double z,double x,double radius,short circleDir,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_ArcXYCEx(short core,short crd,double x,double y,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_ArcYZCEx(short core,short crd,double y,double z,double yCenter,double zCenter,short circleDir,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_ArcZXCEx(short core,short crd,double z,double x,double zCenter,double xCenter,short circleDir,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_ArcXYZEx(short core,short crd,double x,double y,double z,double interX,double interY,double interZ,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYRACEx(short core, short crd, double x, double y, double a, double c, double radius, short circleDir, double synVel, double synAcc, long segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYCACEx(short core, short crd, double x, double y, double a, double c, double xCenter, double yCenter, short circleDir, double synVel, double synAcc, long segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_ArcXYZACEx(short core, short crd, double x, double y, double z, double a, double c, double interX, double interY, double interZ, double interA, double interC, double synVel, double synAcc, long segNum, short override2, short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_HelixXYRZEx(short core,short crd,double x,double y,double z,double radius,short circleDir,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_HelixXYCZEx(short core,short crd,double x,double y,double z,double xCenter,double yCenter,short circleDir,double synVel,double synAcc,int segNum,short override2,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_BufDelayEx(short core,short crd,ushort delayTime,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_BufGearEx(short core,short crd,short gearAxis,double deltaPos,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_BufMoveEx(short core,short crd,short moveAxis,double pos,double vel,double acc,short modal,short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_BufIOEx(short core,short crd,ushort doType,ushort doMask,ushort doValue,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufEnableDoBitPulseEx(short core, short crd, short doType, short doIndex, ushort highLevelTime, ushort lowLevelTime, int pulseNum, short firstLevel, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDisableDoBitPulseEx(short core, short crd, short doType, short doIndex, short fifo);
        [DllImport("gts.dll")]
        public static extern short  GTN_BufDAEx(short core,short crd,short chn,short daValue,short fifo);

        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowMasterEx(short core, short crd, ref GTN.mc.TBufFollowMaster pBufFollowMaster, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowEventCrossEx(short core, short crd, ref GTN.mc.TBufFollowEventCross pEventCross, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowEventTriggerEx(short core, short crd, ref GTN.mc.TBufFollowEventTrigger pEventTrigger, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowStartEx(short core, short crd, Int32 masterSegment, Int32 slaveSegment, Int32 masterFrameWidth, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowNextEx(short core, short crd, Int32 width, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufFollowReturnEx(short core, short crd, double vel, double acc, short smoothPercent, short fifo);

        [DllImport("gts.dll")]
        public static extern short GTN_BufSmartCutterOnEx(short core, short crd, short index, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufSmartCutterOffEx(short core, short crd, short index, short fifo);

        [DllImport("gts.dll")]
        public static extern short  GTN_BufLaserOnEx(short core,short crd,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short  GTN_BufLaserOffEx(short core,short crd,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserFollowModeEx(short core, short crd, short source, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserFollowTableEx(short core, short crd, short tableId, double minPower, double maxPower, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short GTN_BufLaserFollowOffEx(short core, short crd, short fifo, short channel);
        [DllImport("gts.dll")]
        public static extern short  GTN_BufLaserPrfCmdEx(short core,short crd,double laserPower,short fifo,short channel);
        [DllImport("gts.dll")]
        public static extern short  GTN_BufLaserFollowRatioEx(short core,short crd,double ratio,double minPower,double maxPower,short fifo,short channel);
              
        [DllImport("gts.dll")]
        public static extern short GT_BufWaitDiEx(short crd, short diType, UInt16 diIndex, UInt16 level, short continueTime, Int32 overTime, short flagMode, Int32 segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufWaitLongVarEx(short crd, short index, Int32 value, Int32 overTime, short flagMode, Int32 segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufWaitDiEx(short core, short crd, short diType, UInt16 diIndex, UInt16 level, short continueTime, Int32 overTime, short flagMode, Int32 segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufWaitLongVarEx(short core, short crd, short index, Int32 value, Int32 overTime, short flagMode, Int32 segNum, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_BufDoBitEx(short crd,UInt16 doType,UInt16 index,short value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDoBitEx(short core,short crd, Int32 doType,UInt16 index,short value,short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufDoBitDelayEx(short core,short crd,UInt16  doType,UInt16 index,short value,Int32 delayTime,short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_BufPosCompareStartEx(short core, short crd, short fifo, short index);
        [DllImport("gts.dll")]
        public static extern short GT_BufPosCompareStopEx(short core, short crd, short fifo, short index);
        [DllImport("gts.dll")]
        public static extern short GTN_BufPosComparePsoPrmEx(short core, short crd, short index, ref GTN.mc.TPosComparePsoPrm pPrm, short fifo);
        [DllImport("gts.dll")]
        public static extern short GTN_BufPosCompareStartEx(short core, short crd, short fifo, short index);
        [DllImport("gts.dll")]
        public static extern short GTN_BufPosCompareStopEx(short core, short crd, short fifo, short index);
		
		[DllImport("gts.dll")]
		public static extern short GTN_BufMoveJogEx(short core,short crd,short moveAxis,double vel,double acc,short modal,short fifo);
		[DllImport("gts.dll")]
		public static extern short GTN_BufStopEx(short core,short crd,Int32 mask,Int32 option,short fifo);

		[DllImport("gts.dll")]
		public static extern short GTN_BufLaserFollowDuoTableEx(short core,short crd,ref TLaserFollowDuoTablePrm pPrm,short fifo,short channel);
		[DllImport("gts.dll")]
		public static extern short GTN_SetRadiusRatioTableLa(short core,short crd,short count,ref double pRadius,ref double pRatio);
		/*-----------------------------------------------------------*/
        /* Comp                                                      */
        /*-----------------------------------------------------------*/ 
		[DllImport("gts.dll")]
		public static extern short GT_BufPrfCompEnableEx(short crd,short fifo,short profile,short enable,short enableType);
        [DllImport("gts.dll")]
        public static extern short GTN_BufPrfCompEnableEx(short core, short crd, short fifo, short profile, short enable, short enableType);

		public struct TAxisPressPid
		{
			public double kp;
			public double ki;
			public double kd;
			public double integralLimit;	//���ּ���
			public double derivativeLimit;	//΢�ּ���
			public double limit;			//�������ƣ������ѹ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		    public double[] pad1;
		};

		public const short PRESS_COMPENSATE_MODE_LINEAR = 0;                          // ���Բ���
		public const short PRESS_COMPENSATE_MODE_TABLE = 1;                           // �����
		public const short PRESS_COMPENSATE_MODE_REGION_LEARN = 2;                    // ��������ѧϰ����

		public struct TAxisPressCompensate
		{
			public short enable;		          //�Ƿ�ʹ�ܣ�0-�رգ�1-ʹ��
			public short type;			          //�������ͣ���ѹ������ģ������
			public short dimension;	              //���������ά�ȣ����3ά
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		    public short[] index;		          //���������,DAC��1��ʼ��ECAT IOģ��վ�Ŵ�0��ʼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		    public short[] subIndex;              //�������������,DAC�ò�����Ч��ECAT IOģ���IOMAP��0��ʼ
			public short mode;			          //ģʽ�����Ի��ǲ��
			public short revolveAxis;             //����������ת�Ƕȵ����
			public short regionAxisIndex;         //��������������Ч�Ĳο���
			public short relatedMasterIndex;      //�涯���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		    public short[] pad1;
			public double target;			       //Ŀ�������ѹ
			public double thredshold;		       //thredshold��ʲôʱ��ʼ����
			public double deadZone;		           //���������ѹ�������ڲ�����
			public double factor;			       //����λ�Ƶ�ת��ϵ��
			public double revolveOffset;	       //��ʼ��ת����������Ĭ�Ϻϳɷ����ingdex[0]�ķ����غ�
			public double revolveScale;	           //��ת���һȦ������
			public TAxisPressPid pid;
			public Int32 compPosMaxP;              //�������λ������[N,P]�Ķ˵�P
			public Int32 compPosMaxN;              //�������λ������[N,P]�Ķ˵�N
			public double k;	                   //�������˲�ϵ�� 0-1 ��ֵԽ���˲�Խǿ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		    public double[] pad2;
			public Int32 activeRegionP;            //����������Ч�Ĺ滮λ������[N,P]�Ķ˵�P
			public Int32 activeRegionN;            //����������Ч�Ĺ滮λ������[N,P]�Ķ˵�N
			public Int32 activeRegionInterval;     //����������Ч�Ĺ滮λ�������ڵ���ѧϰ�������modeΪ��ѧϰPRESS_COMPENSATE_MODE_REGION_LEARNʱ��Ч
			public Int32 relatedMasterEven;        //�涯����ı���
			public Int32 relatedSlaveEven;         //�涯����ı���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		    public Int32[] pad3;
		};
		
		[DllImport("gts.dll")]
		public static extern short GT_SetAxisPressCompensate(short axis,ref TAxisPressCompensate pPressComp);
		[DllImport("gts.dll")]
		public static extern short GT_GetAxisPressCompensate(short axis,out TAxisPressCompensate pPressComp);
		[DllImport("gts.dll")]
		public static extern short GTN_SetAxisPressCompensate(short core,short axis,ref TAxisPressCompensate pPressComp);
		[DllImport("gts.dll")]
		public static extern short GTN_GetAxisPressCompensate(short core,short axis,out TAxisPressCompensate pPressComp);
		[DllImport("gts.dll")]
        public static extern short GT_SetAxisPressCompensateTable(short axis, short index, Int32 count, ref double pPressData, ref double pPosData);
		[DllImport("gts.dll")]
		public static extern short GT_SelectAxisPressCompensateTable(short axis,short index);
		[DllImport("gts.dll")]
        public static extern short GTN_SetAxisPressCompensateTable(short core, short axis, short index, Int32 count, ref double pPressData, ref double pPosData);
		[DllImport("gts.dll")]
		public static extern short GTN_SelectAxisPressCompensateTable(short core,short axis,short index);

		public struct TAxisPressCompensateFixFactor
		{
			public short type;			       //�������ͣ���ѹ������ģ������
			public short dimension;	           //���������ά�ȣ����3ά
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		    public short[] index;		       //���������,DAC��1��ʼ��ECAT IOģ��վ�Ŵ�0��ʼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		    public short[] subIndex;           //�������������,DAC�ò�����Ч��ECAT IOģ���IOMAP��0��ʼ

			public double targetMax;	       //�궨�������ֵ���ﵽ�򳬹���ֵʱ�궨����
			public double targetMin;	       //�궨������Сֵ���ﵽ��С�ڸ�ֵʱ�궨����
			public double factor;		       //����λ�Ƶ�ת��ϵ��������ʱ����0,��ȡ״̬ʱ�õ��궨ֵ��

			public Int32 fixRegionP;           //�궨�滮λ������[N,P]�Ķ˵�P������λ�õ����λ��
            public Int32 fixRegionN;           //�궨�滮λ������[N,P]�Ķ˵�N������λ�õ����λ��
            public Int32 fixRegionInterval;    //�궨�滮λ�������ڵı궨���

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public Int32[] tmp;
		};

		[DllImport("gts.dll")]
		public static extern short GT_StartAxisPressCompensateFixFactor(short axis,ref TAxisPressCompensateFixFactor pPressComp);
		[DllImport("gts.dll")]
		public static extern short GT_GetAxisPressCompensateFixFactorStatus(short axis,out short pFixFactorSts,out TAxisPressCompensateFixFactor pPressComp);

		[DllImport("gts.dll")]
		public static extern short GTN_StartAxisPressCompensateFixFactor(short core,short axis,ref TAxisPressCompensateFixFactor pPressComp);
		[DllImport("gts.dll")]
		public static extern short GTN_GetAxisPressCompensateFixFactorStatus(short core,short axis,out short pFixFactorSts,out TAxisPressCompensateFixFactor pPressComp);

		public struct TAxisPressCompensateFixPid
		{
			public short type;			 //�������ͣ���ѹ������ģ������
			public short dimension;      //���������ά�ȣ����3ά
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		    public short[] index;		 //���������,DAC��1��ʼ��ECAT IOģ��վ�Ŵ�0��ʼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		    public short[] subIndex;     //�������������,DAC�ò�����Ч��ECAT IOģ���IOMAP��0��ʼ

			public double target;		 //Ŀ�������ѹ
			public double factor;		 //����λ�Ƶ�ת��ϵ��
			public TAxisPressPid pid;

            public Int32 fixPosLimitP;    //�궨λ������[N,P]�Ķ˵�P
            public Int32 fixPosLimitN;    //�궨����λ������[N,P]�Ķ˵�N
			public double thredshold;    //thredshold��ʲôʱ��ʼ����
			public double deadZone;	     //���������ѹ�������ڲ�����

			//�������ڲ�����������ʹ�ã������û��ӿ�û�иò���
			public double Knp;			 //ѹ����ȫ������
			public double K1;			 //ȫ���������ϵ��1
			public double K2;			 //ȫ���������ϵ��2
			public double K3;			 //ȫ���������ϵ��3
			public double Krise;		 //����ϵ��
			public double Kpeak;		 //��ֵϵ��
			public double Tset;		     //Ŀ����Ӧʱ��
			public double Td;			 //������Ӧʱ��	

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		    public double[] tmp;
		};

		[DllImport("gts.dll")]
		public static extern short GT_StartAxisPressCompensateFixPid(short axis,ref TAxisPressCompensateFixPid pPressComp);
		[DllImport("gts.dll")]
		public static extern short GT_GetAxisPressCompensateFixPidStatus(short axis,out short pFixPidSts,out TAxisPressCompensateFixPid pPressComp);

		[DllImport("gts.dll")]
		public static extern short GTN_StartAxisPressCompensateFixPid(short core,short axis,ref TAxisPressCompensateFixPid pPressComp);
		[DllImport("gts.dll")]
		public static extern short GTN_GetAxisPressCompensateFixPidStatus(short core,short axis,out short pFixPidSts,out TAxisPressCompensateFixPid pPressComp);

		[DllImport("gts.dll")]
        public static extern short GTN_AxisPressCompensateEnable(short core, short axis, short enable, double deadZone, double factor, ref GTN.mc.TListInfo pListInfo);
		[DllImport("gts.dll")]
		public static extern short GTN_SetAxisPressCompensateTarget(short core,short axis,double target,double thredshold,ref GTN.mc.TListInfo pListInfo);

		[DllImport("gts.dll")]
		public static extern short GTN_BufAxisPressCompensatePrmEx(short core,short crd,short axis,double target,double thredshold,short fifo);
		[DllImport("gts.dll")]
		public static extern short GTN_BufAxisPressCompensateEx(short core,short crd,short axis,short enable,double deadZone,double factor,short fifo);

		[DllImport("gts.dll")]
		public static extern short GTN_SetAdcBias(short core,short adc,short bias);
		[DllImport("gts.dll")]
		public static extern short GTN_GetAdcBias(short core,short adc,out short pBias);
		[DllImport("gts.dll")]
		public static extern short GTN_SetAuAdcBias(short core,short auAdc,short bias);
		[DllImport("gts.dll")]
		public static extern short GTN_GetAuAdcBias(short core,short auAdc,out short pBias);
      }
}