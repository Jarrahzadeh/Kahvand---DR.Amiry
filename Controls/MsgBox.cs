using System;
using System.Windows.Forms;
using BehComponents;

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
            var buttonsFarsi = (MessageBoxFarsiButtons)buttons;
            var iconFarsi = (MessageBoxFarsiIcon)icon;
            if (icon == MessageBoxIcon.None)
                iconFarsi = MessageBoxFarsiIcon.None;
            else if (icon == MessageBoxIcon.Error)
                iconFarsi = MessageBoxFarsiIcon.Error;
            else if (icon == MessageBoxIcon.Hand)
                iconFarsi = MessageBoxFarsiIcon.Delete;
            else if (icon == MessageBoxIcon.Stop)
                iconFarsi = MessageBoxFarsiIcon.Stop;
            else if (icon == MessageBoxIcon.Question)
                iconFarsi = MessageBoxFarsiIcon.Question;
            else if (icon == MessageBoxIcon.Exclamation)
                iconFarsi = MessageBoxFarsiIcon.Warning;
            else if (icon == MessageBoxIcon.Warning)
                iconFarsi = MessageBoxFarsiIcon.Preference;
            else if (icon == MessageBoxIcon.Asterisk)
                iconFarsi = MessageBoxFarsiIcon.Information;
            else
                throw new ArgumentOutOfRangeException(nameof(icon), icon, null);

            var result =  MessageBoxFarsi.Show(msg, title, buttonsFarsi, iconFarsi);
            //MessageBox.Show(msg, title, buttons, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            return result;
        }
    }
}
