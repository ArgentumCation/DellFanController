using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellFanController
{
    static class Program
    {
        private static bool _useAltMethod = false;
        private static bool _changeFanSpeedOnDisable = false;
        private static bool _fanEnabled = true;

        public static void ToggleChangeFanSpeedOnDisable()
        {
            _changeFanSpeedOnDisable = !_changeFanSpeedOnDisable;
        }

        public static void ToggleAltMethod()
        {
            _useAltMethod = !_useAltMethod;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void ToggleFanControl()
        {
            if (_fanEnabled)
            {
                DisableFanControl();
            }
            else
            {
                EnableFanControl();
            }

            _fanEnabled = !_fanEnabled;
        }

        private static void EnableFanControl()
        {
            var cmd = "DellFanCmd\\DellFanCmd.exe ec-enable";
            if (_useAltMethod)
            {
                cmd += "-alt";
            }

            Process.Start("CMD.exe", $"/k {cmd} && pause");
        }

        private static void DisableFanControl()
        {
            var cmd = "DellFanCmd\\DellFanCmd.exe ec-disable";
            if (_useAltMethod)
            {
                cmd += "-alt";
            }

            if (!_changeFanSpeedOnDisable)
            {
                cmd += "-nofanchg";
            }

            Process.Start("CMD.exe", $"/k {cmd} && pause");
        }

        public static bool GetFanControlStatus()
        {
            return _fanEnabled;
        }

        public static void SetFanSpeed(int fan1Speed, int fan2Speed)
        {
            Process.Start("CMD.exe",
                $"/c DellFanCmd\\DellFanCmd.exe fan1-level{fan1Speed} && DellFanCmd\\DellFanCmd.exe fan2-level{fan2Speed}");
        }
    }
}