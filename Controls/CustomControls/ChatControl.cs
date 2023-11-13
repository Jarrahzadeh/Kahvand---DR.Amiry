using System;
using Ophthalmology.CustomControls.Controls;

namespace Ophthalmology.Controls.CustomControls
{
    public partial class ChatControl : UserControlBase
    {
        private string _title;

        public Action<ChatControl, string> SendMessageAction;
        public Action<ChatControl> AddCustomMessageAction;

        public ChatControl()
        {
            InitializeComponent();
        }

        public void PopulateTextBoxCustomDataSource(string[] items)
        {
            ComboBoxMessage.Items.Clear();
            ComboBoxMessage.Items.AddRange(items);
        }

        public void AppendMessage(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                ListBoxMessages.Items.Add(message);
            }
        }

        public void ClearMessage()
        {
            ComboBoxMessage.Text = string.Empty;
        }

        public void ClearChatList()
        {
            ListBoxMessages.Items.Clear();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            var message = ComboBoxMessage.Text;
            if (string.IsNullOrWhiteSpace(message))
                return;

            AppendMessage($"من : {message}");
            SendMessageAction?.Invoke(this, message);
        }

        private void ButtonCustomMessage_Click(object sender, EventArgs e)
        {
            AddCustomMessageAction?.Invoke(this);
        }

        public new string Text
        {
            get => _title;
            set
            {
                _title = value;
                GroupBox1.Text = $"نمایش پیام های {_title}";
            }
        }

        private void ChatControl_Load(object sender, EventArgs e)
        {
            ActiveControl = ComboBoxMessage;
        }
    }
}