namespace Ophthalmology.UI.Win.Forms
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.Common.JanusColorScheme janusColorScheme1 = new Janus.Windows.Common.JanusColorScheme();
            Janus.Windows.Common.JanusColorScheme janusColorScheme2 = new Janus.Windows.Common.JanusColorScheme();
            Janus.Windows.Common.JanusColorScheme janusColorScheme3 = new Janus.Windows.Common.JanusColorScheme();
            Janus.Windows.Common.JanusColorScheme janusColorScheme4 = new Janus.Windows.Common.JanusColorScheme();
            Janus.Windows.Common.JanusColorScheme janusColorScheme5 = new Janus.Windows.Common.JanusColorScheme();
            Janus.Windows.Common.JanusColorScheme janusColorScheme6 = new Janus.Windows.Common.JanusColorScheme();
            this.visualStyleManager = new Janus.Windows.Common.VisualStyleManager(this.components);
            this.SuspendLayout();
            // 
            // visualStyleManager
            // 
            janusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme1.Name = "Office2007 (Blue)";
            janusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007;
            janusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme2.Name = "Office2003 (Blue)";
            janusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme3.Name = "VisualStudio 2005";
            janusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.VS2005;
            janusColorScheme4.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme4.Name = "Standard";
            janusColorScheme4.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme4.VisualStyle = Janus.Windows.Common.VisualStyle.Standard;
            janusColorScheme5.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme5.Name = "Office2007 (Black)";
            janusColorScheme5.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Black;
            janusColorScheme5.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme5.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007;
            janusColorScheme6.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme6.Name = "Office2007 (Silver)";
            janusColorScheme6.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver;
            janusColorScheme6.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme6.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007;
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme1);
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme2);
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme3);
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme4);
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme5);
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme6);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(334, 245);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BaseForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBase_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaseForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        public Janus.Windows.Common.VisualStyleManager visualStyleManager;
    }
}