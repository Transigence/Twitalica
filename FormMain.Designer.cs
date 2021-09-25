
namespace Twitalica
{
    partial class FormMain
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
            this.radioItalic = new System.Windows.Forms.RadioButton();
            this.radioBold = new System.Windows.Forms.RadioButton();
            this.radioItBo = new System.Windows.Forms.RadioButton();
            this.labelBytes = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.panelUI = new System.Windows.Forms.Panel();
            this.radioBlaBo = new System.Windows.Forms.RadioButton();
            this.radioBlackletter = new System.Windows.Forms.RadioButton();
            this.radioScrBo = new System.Windows.Forms.RadioButton();
            this.radioScript = new System.Windows.Forms.RadioButton();
            this.panelCommands = new System.Windows.Forms.Panel();
            this.labelKeystrokes = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonTopMost = new System.Windows.Forms.Button();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.panelUI.SuspendLayout();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioItalic
            // 
            this.radioItalic.AutoSize = true;
            this.radioItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioItalic.Location = new System.Drawing.Point(3, 125);
            this.radioItalic.Name = "radioItalic";
            this.radioItalic.Size = new System.Drawing.Size(57, 21);
            this.radioItalic.TabIndex = 1;
            this.radioItalic.TabStop = true;
            this.radioItalic.Text = "Italic";
            this.radioItalic.UseVisualStyleBackColor = true;
            this.radioItalic.CheckedChanged += new System.EventHandler(this.radioItalic_CheckedChanged);
            // 
            // radioBold
            // 
            this.radioBold.AutoSize = true;
            this.radioBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBold.Location = new System.Drawing.Point(66, 125);
            this.radioBold.Name = "radioBold";
            this.radioBold.Size = new System.Drawing.Size(61, 21);
            this.radioBold.TabIndex = 2;
            this.radioBold.TabStop = true;
            this.radioBold.Text = "Bold";
            this.radioBold.UseVisualStyleBackColor = true;
            this.radioBold.CheckedChanged += new System.EventHandler(this.radioBold_CheckedChanged);
            // 
            // radioItBo
            // 
            this.radioItBo.AutoSize = true;
            this.radioItBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioItBo.Location = new System.Drawing.Point(133, 125);
            this.radioItBo.Name = "radioItBo";
            this.radioItBo.Size = new System.Drawing.Size(57, 21);
            this.radioItBo.TabIndex = 3;
            this.radioItBo.TabStop = true;
            this.radioItBo.Text = "ItBo";
            this.radioItBo.UseVisualStyleBackColor = true;
            this.radioItBo.CheckedChanged += new System.EventHandler(this.radioItBo_CheckedChanged);
            // 
            // labelBytes
            // 
            this.labelBytes.AutoSize = true;
            this.labelBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBytes.Location = new System.Drawing.Point(196, 125);
            this.labelBytes.Name = "labelBytes";
            this.labelBytes.Size = new System.Drawing.Size(0, 20);
            this.labelBytes.TabIndex = 3;
            // 
            // textBoxIn
            // 
            this.textBoxIn.AcceptsReturn = true;
            this.textBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIn.Location = new System.Drawing.Point(3, 3);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(350, 116);
            this.textBoxIn.TabIndex = 4;
            this.textBoxIn.TextChanged += new System.EventHandler(this.textBoxIn_TextChanged);
            // 
            // panelUI
            // 
            this.panelUI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelUI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUI.Controls.Add(this.radioBlaBo);
            this.panelUI.Controls.Add(this.radioBlackletter);
            this.panelUI.Controls.Add(this.radioScrBo);
            this.panelUI.Controls.Add(this.radioScript);
            this.panelUI.Controls.Add(this.textBoxIn);
            this.panelUI.Controls.Add(this.labelBytes);
            this.panelUI.Controls.Add(this.radioItBo);
            this.panelUI.Controls.Add(this.radioItalic);
            this.panelUI.Controls.Add(this.radioBold);
            this.panelUI.Location = new System.Drawing.Point(0, 20);
            this.panelUI.Name = "panelUI";
            this.panelUI.Size = new System.Drawing.Size(360, 180);
            this.panelUI.TabIndex = 6;
            // 
            // radioBlaBo
            // 
            this.radioBlaBo.AutoSize = true;
            this.radioBlaBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBlaBo.Location = new System.Drawing.Point(261, 152);
            this.radioBlaBo.Name = "radioBlaBo";
            this.radioBlaBo.Size = new System.Drawing.Size(71, 21);
            this.radioBlaBo.TabIndex = 8;
            this.radioBlaBo.TabStop = true;
            this.radioBlaBo.Text = "𝕭𝖑𝖆𝕭𝖔";
            this.radioBlaBo.UseVisualStyleBackColor = true;
            this.radioBlaBo.CheckedChanged += new System.EventHandler(this.radioBlaBo_CheckedChanged);
            // 
            // radioBlackletter
            // 
            this.radioBlackletter.AutoSize = true;
            this.radioBlackletter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBlackletter.Location = new System.Drawing.Point(168, 152);
            this.radioBlackletter.Name = "radioBlackletter";
            this.radioBlackletter.Size = new System.Drawing.Size(80, 21);
            this.radioBlackletter.TabIndex = 7;
            this.radioBlackletter.TabStop = true;
            this.radioBlackletter.Text = "𝔅𝔩𝔞𝔠𝔨𝔩𝔢𝔱𝔱𝔢𝔯";
            this.radioBlackletter.UseVisualStyleBackColor = true;
            this.radioBlackletter.CheckedChanged += new System.EventHandler(this.radioBlackletter_CheckedChanged);
            // 
            // radioScrBo
            // 
            this.radioScrBo.AutoSize = true;
            this.radioScrBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioScrBo.Location = new System.Drawing.Point(82, 152);
            this.radioScrBo.Name = "radioScrBo";
            this.radioScrBo.Size = new System.Drawing.Size(73, 21);
            this.radioScrBo.TabIndex = 6;
            this.radioScrBo.TabStop = true;
            this.radioScrBo.Text = "𝓢𝓬𝓻𝓑𝓸";
            this.radioScrBo.UseVisualStyleBackColor = true;
            this.radioScrBo.CheckedChanged += new System.EventHandler(this.radioScrBo_CheckedChanged);
            // 
            // radioScript
            // 
            this.radioScript.AutoSize = true;
            this.radioScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioScript.Location = new System.Drawing.Point(3, 152);
            this.radioScript.Name = "radioScript";
            this.radioScript.Size = new System.Drawing.Size(73, 21);
            this.radioScript.TabIndex = 5;
            this.radioScript.TabStop = true;
            this.radioScript.Text = "𝒮𝒸𝓇𝒾𝓅𝓉";
            this.radioScript.UseVisualStyleBackColor = true;
            this.radioScript.CheckedChanged += new System.EventHandler(this.radioScript_CheckedChanged);
            // 
            // panelCommands
            // 
            this.panelCommands.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCommands.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCommands.Controls.Add(this.labelKeystrokes);
            this.panelCommands.Location = new System.Drawing.Point(0, 20);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(360, 180);
            this.panelCommands.TabIndex = 7;
            this.panelCommands.Visible = false;
            // 
            // labelKeystrokes
            // 
            this.labelKeystrokes.AutoSize = true;
            this.labelKeystrokes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeystrokes.Location = new System.Drawing.Point(61, 20);
            this.labelKeystrokes.Name = "labelKeystrokes";
            this.labelKeystrokes.Size = new System.Drawing.Size(243, 125);
            this.labelKeystrokes.TabIndex = 0;
            this.labelKeystrokes.Text = "CTRL+C / CTRL+Enter:\r\nSend text to clipboard\r\n\r\nCTRL+Q / ALT+F4:\r\nQuit";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(338, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(16, 16);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinimize.Location = new System.Drawing.Point(318, 2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(16, 16);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonTopMost
            // 
            this.buttonTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTopMost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.buttonTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTopMost.Location = new System.Drawing.Point(298, 2);
            this.buttonTopMost.Name = "buttonTopMost";
            this.buttonTopMost.Size = new System.Drawing.Size(16, 16);
            this.buttonTopMost.TabIndex = 9;
            this.buttonTopMost.Text = ".";
            this.buttonTopMost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTopMost.UseVisualStyleBackColor = false;
            this.buttonTopMost.Click += new System.EventHandler(this.buttonTopMost_Click);
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.AutoSize = true;
            this.labelTitleBar.Location = new System.Drawing.Point(12, 1);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Size = new System.Drawing.Size(238, 17);
            this.labelTitleBar.TabIndex = 10;
            this.labelTitleBar.Text = "Twitalica (Hold CTRL for commands)";
            this.labelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitleBar_MouseDown);
            this.labelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitleBar_MouseMove);
            this.labelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelTitleBar_MouseUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(360, 200);
            this.Controls.Add(this.labelTitleBar);
            this.Controls.Add(this.buttonTopMost);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelUI);
            this.Controls.Add(this.panelCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Twitalica";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.panelUI.ResumeLayout(false);
            this.panelUI.PerformLayout();
            this.panelCommands.ResumeLayout(false);
            this.panelCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioItalic;
        private System.Windows.Forms.RadioButton radioBold;
        private System.Windows.Forms.RadioButton radioItBo;
        private System.Windows.Forms.Label labelBytes;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Panel panelUI;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonTopMost;
        private System.Windows.Forms.Panel panelCommands;
        private System.Windows.Forms.Label labelTitleBar;
        private System.Windows.Forms.Label labelKeystrokes;
        private System.Windows.Forms.RadioButton radioScript;
        private System.Windows.Forms.RadioButton radioScrBo;
        private System.Windows.Forms.RadioButton radioBlackletter;
        private System.Windows.Forms.RadioButton radioBlaBo;
    }
}

