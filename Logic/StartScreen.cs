using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GordoLagTool
{
    public partial class StartScreen : Form
    {
        public static StartScreen mainScreen;
        public StartScreen()
        {
            InitializeComponent();

            mainScreen = this;
            GameMemory.ins = new GameMemory();
            RevisionList.ins = new RevisionList();
            HotKeyInput.SetupInputHook();

            FormClosing += WindowClosing;
        }

        private void WindowClosing(object sender, FormClosingEventArgs e)
        {
            HotKeyInput.RemoveInputHook();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        public void AddInfoToList(string info)
        {
            // i should make a better output system
            // but since i only need to care about the first output lines i will do nothing :)
            DataInfo.Items.Add(info);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes");
        }

        private void FPS_LAG_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.ins.MAX_FPS = (float)FPS_NORMAL.Value;
                Program.ins.MIN_FPS = (float)FPS_LAG.Value;
                Program.ins.MAIN_BUTTON = Convert.ToInt32(ButtonCode.Text, 16);
                AddInfoToList("[Warning] This application will not save this configuration between restarts, Gordo = Lazy");
            }
            catch
            {
                AddInfoToList("[ERROR] Something is not right");
                AddInfoToList("[ERROR] make sure you did place the correct value in Button. Ex: 0xA0");
            }

            foreach(RevisionList.GameRevision i in RevisionList.ins.ReturnRevisionList())
            {
                if (i.revision == int.Parse(GameRevisionBox.SelectedItem.ToString()))
                {
                    GameMemory.ins.SetGameRevision(i.revision);
                    AddInfoToList($"[INFO] Game rev is: {i.revision}");
                    break;
                }
            }

            GameMemory.ins.DoSetup();
        }

        private void GameRevisionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }
    }
}
