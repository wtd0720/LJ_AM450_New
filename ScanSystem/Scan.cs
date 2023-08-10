using RTC5Import;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Numerics;

namespace ScanSystem
{
    public class Scan
    {
        bool scanerror;
        bool isscanning;
        public bool isconct = false;
        uint ErrorCode;
        Rtc5 rtc0 = null;
        Rtc5 rtc1 = null;
        public uint Index { get; }
        public double kfactor = Math.Pow(2, 20);
        public Scan()
        {           
            if (init())
            {

            }
        }
        ~Scan()
        {
            Disconnect();
        }
        public bool init()
        {
            try
            {
                rtc0 = new Rtc5(0);
                //rtc1 = new Rtc5(1);
                double fov = 60.0;    /// scanner field of view : 60mm            
                double kf = kfactor / fov; /// k factor (bits/mm) = 2^20 / fov
                bool sus1 = rtc0.Initialize(kf, LaserMode.Yag1, "cor_1to1.ct5");    ///default correction file
                /*bool sus2 = rtc1.Initialize(kf, LaserMode.Yag1, "cor_1to1.ct5");   */ ///default correction file
                return sus1 /*&& sus2*/;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }
        public void StartScan(List<List<PointF[]>> scanpath, ScanPara para, LaserPara lpara, bool isFrame)
        {
            rtc0.ListBegin();
            SetPara(ref rtc0, para, lpara, isFrame);
            SetMarkList(ref rtc0, scanpath, para, isFrame);
            rtc0.ListEnd();
            rtc0.ListExecute();
        }
        public void StartScan(List<PointF[]> scanpath, ScanPara para, LaserPara lpara,bool isFrame)
        {
            rtc0.ListBegin();
            SetPara(ref rtc0,para,lpara, isFrame);
            SetMarkList(ref rtc0, scanpath, para, isFrame);
            rtc0.ListEnd();
            rtc0.ListExecute();
        }
        private void SetPara(ref Rtc5 rtc ,ScanPara para, LaserPara lpara, bool isFrame)
        {
            var Speed = isFrame ? para.FrameSpeed : para.ScanSpeed;
            var Power = isFrame ? para.FramePower : para.ScanPower;
            rtc.ListFrequency(lpara.LaserFrequency, lpara.LaserPulseWidth, Power); ///laser frequency :KHz, pulse width : usec
            rtc.ListSpeed(para.JumpSpeed, Speed); /// default jump and mark speed 
            rtc.ListDelay(para.laserOnDelay, (uint)para.laserOffDelay,(uint)para.JumpDelay, (uint)para.MarkDelay, (uint)para.polygonDelay); ///scanner and laser delays
        }
        private void SetMarkList(ref Rtc5 rtc, List<PointF[]> scanpath, ScanPara para, bool isFrame)
        {
            var time = isFrame ? para.FrameTime : para.ScanTime;
            for (int i = 0; i < time; i++)
                foreach (var pf in scanpath)
                    if (pf.Length > 0)
                    {
                        rtc.ListJump(new Vector2(pf[0].X, pf[0].Y));
                        for (int j = 0; j < pf.Length; j++)
                            rtc.ListMark(new Vector2(pf[j].X, pf[j].Y));
                    }
        }
        private void SetMarkList(ref Rtc5 rtc, List<List<PointF[]>> scanpath, ScanPara para, bool isFrame)
        {
            var time = isFrame ? para.FrameTime : para.ScanTime;
            for (int i = 0; i < time; i++)
            {
                foreach (var pfs in scanpath)
                {
                    foreach (var pf in pfs)
                    {
                        if (pf.Length > 0)
                        {
                            rtc.ListJump(new Vector2(pf[0].X, pf[0].Y));
                            for (int j = 0; j < pf.Length; j++)
                            {
                                rtc.ListMark(new Vector2(pf[j].X, pf[j].Y));
                            }
                        }
                    }
                }
            }
        }
        public void StopExcute()
        {
            if (isconct)
            {
                rtc0.CtlLaserOff();
                rtc1.CtlLaserOff();
                //RTC5Wrap.stop_execution();
            }
        }
        public void Disconnect()
        {
            if (isconct)
            {
                isconct = false;
            }
        }
    }



}
