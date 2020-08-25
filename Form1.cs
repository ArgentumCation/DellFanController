using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellFanController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void ToggleFanControlClick(object sender, EventArgs e)
        {
            Program.ToggleFanControl();
            ToggleFanButton.Text = $"{(Program.GetFanControlStatus() ? "Disable" : "Enable")} fan control";
            ToggleFanButton.Refresh();
        }

        private void ChangeFanSpeedBox(object sender, EventArgs e)
        {
            Program.ToggleChangeFanSpeedOnDisable();
        }

        private void AlternateMethodBox_CheckedChanged(object sender, EventArgs e)
        {
            Program.ToggleAltMethod();
        }

        private void SetSpeedButton_Click(object sender, EventArgs e)
        {
            Program.SetFanSpeed(2-Fan1Speeds.SelectedIndex, 2-Fan2Speeds.SelectedIndex);
        }
    }
}