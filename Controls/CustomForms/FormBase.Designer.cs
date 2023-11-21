﻿namespace Ophthalmology.Controls.CustomForms
{
    partial class FormBase
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
            this.visualStyleManager = new Janus.Windows.Common.VisualStyleManager(this.components);
            this.SuspendLayout();
            // 
            // visualStyleManager
            // 
            janusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme1.Name = "Office2007Style";
            janusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme2.Name = "Office2003Style";
            janusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme3.Name = "Vs2005Style";
            janusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.VS2005;
            janusColorScheme4.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            janusColorScheme4.Name = "StandardStyle";
            janusColorScheme4.Office2007CustomColor = System.Drawing.Color.Empty;
            janusColorScheme4.VisualStyle = Janus.Windows.Common.VisualStyle.Standard;
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme1);
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme2);
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme3);
            this.visualStyleManager.ColorSchemes.Add(janusColorScheme4);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(334, 245);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormBase";
            this.Padding = new System.Windows.Forms.Padding(18, 22, 18, 22);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResumeLayout(false);

        }

        #endregion

        public Janus.Windows.Common.VisualStyleManager visualStyleManager;
    }
}