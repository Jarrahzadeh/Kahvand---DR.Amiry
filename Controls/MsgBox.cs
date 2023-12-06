﻿using System.Windows.Forms;

namespace Ophthalmology.Controls
{
    public class MsgBox
    {
        public static void ShowInformation(string msg, string title)
        {
            ShowMessageCore(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarning(string msg, string title)
        {
            ShowMessageCore(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string msg, string title)
        {
            ShowMessageCore(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowQuestion(string msg, string title)
        {
            return ShowQuestion(msg, title, MessageBoxButtons.YesNo);
        }

        public static DialogResult ShowQuestion(string msg, string title, MessageBoxButtons buttons)
        {
            return ShowMessageCore(msg, title, buttons, MessageBoxIcon.Question);
        }

        public static DialogResult ShowYesNo(string msg, string title, MessageBoxIcon icon)
        {
            return ShowMessageCore(msg, title, MessageBoxButtons.YesNo, icon);
        }

        private static DialogResult ShowMessageCore(string msg, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(msg, title, buttons, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }
    }
}
