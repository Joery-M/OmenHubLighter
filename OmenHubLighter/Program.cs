using Hp.Ohl.WmiService;
using Hp.Ohl.WmiService.Models;
using Hp.Omen.OmenCommonLib;
using Hp.Omen.OmenCommonLib.PowerControl.Enum;
using Newtonsoft.Json.Linq;
using OmenHubLight.Lib;
using OmenHubLighter.Forms;
using OmenHubLighter.Properties;
using OpenHardwareMonitor.Hardware;
using System;

namespace OmenHubLighter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if(Settings.Default.FirstStart == true)
            {
                Settings.Default.FirstStart = false;
                Settings.Default.PerformanceMode = PerformanceMode.Default;
                Settings.Default.AlternateKey = Keys.None;
                Settings.Default.ExecuteArguments = "";
                Settings.Default.ExecutePath = "";
                Settings.Default.Save();
            }

            BackgroundForm bgForm = new BackgroundForm();
            WmiEventWatcher.StartHpBiosEventWatcher();
            WmiEventWatcher.HpBiosEventArrived += bgForm.WmiEventWatcher_HpBiosEventArrived;

            Ring0.Open();
            Opcode.Open();
            GpuInfo.OpenGpuGroups();
            CpuInfo.OpenCpuGroups();

            Application.Run(bgForm);
        }

        public static void Quit()
        {
            WmiEventWatcher.StopHpBiosEventWatcher();
            GpuInfo.CloseGpuGroups();
            CpuInfo.CloseCpuGroups();
            Opcode.Close();
            Ring0.Close();
            Application.Exit();
        }
    }
}