using System;
using System.Windows.Forms;

namespace GordoLagTool
{
    //=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    // ----- Program Window ------
    //=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    public partial class StartScreen : Form
    {
        public static StartScreen mainScreen;
        public StartScreen()
        {
            InitializeComponent();

            mainScreen = this;
            //start class instances
            GameMemory.ins = new GameMemory();
            //Setup hook to keyboard, so the program can register inputs.
            WinKeyboardAPI.SetupInputHook();
            FormClosing += WindowClosing;
        }

        private void WindowClosing(object sender, FormClosingEventArgs e)
        {
            WinKeyboardAPI.RemoveInputHook();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            // :P
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (GameMemory.ins.DoSetup())
            {
                button_Test.Enabled = true;
                ReloadButtons(false);
            }
        }

        private void GameRevisionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtom.Enabled = true;
        }

        private void listBox_GameNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_GameNames.SelectedIndex < 0)
                return;

            //Game Selected
            var giSelected = (GameInfo)listBox_GameNames.Items[listBox_GameNames.SelectedIndex];
            listBox_GameVersions.Items.Clear();
            foreach (PatchInfo pi in giSelected.PatchInfos)
            {
                listBox_GameVersions.Items.Add(pi);
            }
        }

        private void listBox_GameVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_GameVersions.SelectedIndex < 0)
                return;

            //Game Version Selected
            try
            {
                MainLogic.MAX_FPS = (float)FPS_NORMAL.Value;
                MainLogic.MIN_FPS = (float)FPS_LAG.Value;
                MainLogic.MAIN_BUTTON = Convert.ToInt32(ButtonCode.Text, 16);
            }
            catch
            {
                MessageBox.Show("Something is not right, make sure you did setup everthing correctly");
            }

            GameMemory.ins.gameInfo = (GameInfo)listBox_GameNames.Items[listBox_GameNames.SelectedIndex];
            GameMemory.ins.patchInfo = (PatchInfo)listBox_GameVersions.Items[listBox_GameVersions.SelectedIndex];
            ReloadButtons(true);
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            listBox_GameNames.Items.Clear();
            listBox_GameVersions.Items.Clear();
            ReloadButtons(false);
            //reload List
            LoadFilesToList();
        }
        private void ReloadButtons(bool state)
        {
            EnableButtom.Enabled = state;
            if (state)
                EnableButtom.Text = "Enable Tool";
            else
                EnableButtom.Text = "Have Fun!";
        }
        private void LoadFilesToList()
        {
            var entries = FileController.GetFileEntries();
            if (entries == null || entries.Length < 1)
            {
                MessageBox.Show("GameFiles are empty, please make sure to have at least one .game file before using the tool", "No .game Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            entries = FileController.RemovePathFromString(entries);

            foreach (var entry in entries)
            {
                GameInfo gi = FileController.ReadGameInfoFromFile(entry);
                if (gi == null)
                {
                    break;
                }
                listBox_GameNames.Items.Add(gi);
            }
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            GameMemory.ins.ReadMemoryAddress(out byte[] data);
            var result = BitConverter.ToSingle(data, 0);
            MessageBox.Show($"if the value is similar to your game fps limit then the tool is working. if is not, something is wrong with the memory address or offsets on .game file.\n \nVALUE: {result}", "Memory Test");
        }

        private void CreatorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GordoLeal/GordoLagTool");
        }
    }
}
