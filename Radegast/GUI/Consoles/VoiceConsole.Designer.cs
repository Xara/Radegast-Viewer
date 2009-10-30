// 
// Radegast Metaverse Client
// Copyright (c) 2009, Radegast Development Team
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//       this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//       notice, this list of conditions and the following disclaimer in the
//       documentation and/or other materials provided with the distribution.
//     * Neither the name of the application "Radegast", nor the names of its
//       contributors may be used to endorse or promote products derived from
//       this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// $Id: ChatConsole.Designer.cs 371 2009-10-26 10:26:04Z latifer $
//
using System.Windows.Forms;

namespace Radegast
{
    partial class VoiceConsole
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceConsole));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spkrMute = new System.Windows.Forms.CheckBox();
            this.micMute = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.micLevel = new System.Windows.Forms.TrackBar();
            this.spkrLevel = new System.Windows.Forms.TrackBar();
            this.spkrDevice = new System.Windows.Forms.ComboBox();
            this.micDevice = new System.Windows.Forms.ComboBox();
            this.chkVoiceEnable = new System.Windows.Forms.CheckBox();
            this.participants = new Radegast.ListViewNoFlicker();
            this.avatarContext = new Radegast.RadegastContextMenuStrip(this.components);
            this.ctxProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPay = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxStartIM = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFollow = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTextures = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxAttach = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxAnim = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSource = new System.Windows.Forms.ToolStripMenuItem();
            this.TalkStates = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spkrLevel)).BeginInit();
            this.avatarContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.spkrMute);
            this.splitContainer1.Panel1.Controls.Add(this.micMute);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.micLevel);
            this.splitContainer1.Panel1.Controls.Add(this.spkrLevel);
            this.splitContainer1.Panel1.Controls.Add(this.spkrDevice);
            this.splitContainer1.Panel1.Controls.Add(this.micDevice);
            this.splitContainer1.Panel1.Controls.Add(this.chkVoiceEnable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.participants);
            this.splitContainer1.Size = new System.Drawing.Size(654, 424);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.TabStop = false;
            // 
            // spkrMute
            // 
            this.spkrMute.AutoSize = true;
            this.spkrMute.Location = new System.Drawing.Point(92, 114);
            this.spkrMute.Name = "spkrMute";
            this.spkrMute.Size = new System.Drawing.Size(50, 17);
            this.spkrMute.TabIndex = 21;
            this.spkrMute.Text = "Mute";
            this.spkrMute.UseVisualStyleBackColor = true;
            // 
            // micMute
            // 
            this.micMute.AutoSize = true;
            this.micMute.Checked = true;
            this.micMute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.micMute.Location = new System.Drawing.Point(92, 69);
            this.micMute.Name = "micMute";
            this.micMute.Size = new System.Drawing.Size(50, 17);
            this.micMute.TabIndex = 20;
            this.micMute.Text = "Mute";
            this.micMute.UseVisualStyleBackColor = true;
            this.micMute.CheckedChanged += new System.EventHandler(this.micMute_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(158, 14);
            this.progressBar1.Maximum = 8;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(147, 15);
            this.progressBar1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Levels";
            // 
            // micLevel
            // 
            this.micLevel.BackColor = System.Drawing.SystemColors.Control;
            this.micLevel.LargeChange = 20;
            this.micLevel.Location = new System.Drawing.Point(92, 161);
            this.micLevel.Maximum = 100;
            this.micLevel.Minimum = -100;
            this.micLevel.Name = "micLevel";
            this.micLevel.Size = new System.Drawing.Size(104, 42);
            this.micLevel.TabIndex = 15;
            this.micLevel.TickFrequency = 20;
            this.micLevel.ValueChanged += new System.EventHandler(this.micLevel_ValueChanged);
            // 
            // spkrLevel
            // 
            this.spkrLevel.Location = new System.Drawing.Point(330, 161);
            this.spkrLevel.Maximum = 100;
            this.spkrLevel.Minimum = -100;
            this.spkrLevel.Name = "spkrLevel";
            this.spkrLevel.Size = new System.Drawing.Size(104, 42);
            this.spkrLevel.TabIndex = 14;
            this.spkrLevel.TickFrequency = 20;
            this.spkrLevel.ValueChanged += new System.EventHandler(this.spkrLevel_ValueChanged);
            // 
            // spkrDevice
            // 
            this.spkrDevice.FormattingEnabled = true;
            this.spkrDevice.Location = new System.Drawing.Point(158, 112);
            this.spkrDevice.Name = "spkrDevice";
            this.spkrDevice.Size = new System.Drawing.Size(276, 21);
            this.spkrDevice.TabIndex = 12;
            this.spkrDevice.SelectedIndexChanged += new System.EventHandler(this.spkrDevice_SelectedIndexChanged);
            // 
            // micDevice
            // 
            this.micDevice.FormattingEnabled = true;
            this.micDevice.Location = new System.Drawing.Point(158, 67);
            this.micDevice.Name = "micDevice";
            this.micDevice.Size = new System.Drawing.Size(276, 21);
            this.micDevice.TabIndex = 11;
            this.micDevice.SelectedIndexChanged += new System.EventHandler(this.micDevice_SelectedIndexChanged);
            // 
            // chkVoiceEnable
            // 
            this.chkVoiceEnable.AutoSize = true;
            this.chkVoiceEnable.Location = new System.Drawing.Point(13, 12);
            this.chkVoiceEnable.Name = "chkVoiceEnable";
            this.chkVoiceEnable.Size = new System.Drawing.Size(86, 17);
            this.chkVoiceEnable.TabIndex = 0;
            this.chkVoiceEnable.Text = "Enable voice";
            this.chkVoiceEnable.UseVisualStyleBackColor = true;
            this.chkVoiceEnable.Click += new System.EventHandler(this.chkVoiceEnable_Click);
            // 
            // participants
            // 
            this.participants.AllowDrop = true;
            this.participants.ContextMenuStrip = this.avatarContext;
            this.participants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participants.FullRowSelect = true;
            this.participants.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.participants.HideSelection = false;
            this.participants.LabelWrap = false;
            this.participants.Location = new System.Drawing.Point(0, 0);
            this.participants.MultiSelect = false;
            this.participants.Name = "participants";
            this.participants.Size = new System.Drawing.Size(188, 424);
            this.participants.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.participants.StateImageList = this.TalkStates;
            this.participants.TabIndex = 8;
            this.participants.UseCompatibleStateImageBehavior = false;
            this.participants.View = System.Windows.Forms.View.List;
            // 
            // avatarContext
            // 
            this.avatarContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxProfile,
            this.ctxPay,
            this.ctxStartIM,
            this.ctxFollow,
            this.ctxTextures,
            this.ctxAttach,
            this.ctxMaster,
            this.ctxAnim,
            this.ctxPoint,
            this.ctxSource});
            this.avatarContext.Name = "avatarContext";
            this.avatarContext.Size = new System.Drawing.Size(68, 224);
            // 
            // ctxProfile
            // 
            this.ctxProfile.Name = "ctxProfile";
            this.ctxProfile.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxPay
            // 
            this.ctxPay.Name = "ctxPay";
            this.ctxPay.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxStartIM
            // 
            this.ctxStartIM.Name = "ctxStartIM";
            this.ctxStartIM.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxFollow
            // 
            this.ctxFollow.Name = "ctxFollow";
            this.ctxFollow.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxTextures
            // 
            this.ctxTextures.Name = "ctxTextures";
            this.ctxTextures.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxAttach
            // 
            this.ctxAttach.Name = "ctxAttach";
            this.ctxAttach.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxMaster
            // 
            this.ctxMaster.Name = "ctxMaster";
            this.ctxMaster.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxAnim
            // 
            this.ctxAnim.Name = "ctxAnim";
            this.ctxAnim.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxPoint
            // 
            this.ctxPoint.Name = "ctxPoint";
            this.ctxPoint.Size = new System.Drawing.Size(67, 22);
            // 
            // ctxSource
            // 
            this.ctxSource.Name = "ctxSource";
            this.ctxSource.Size = new System.Drawing.Size(67, 22);
            // 
            // TalkStates
            // 
            this.TalkStates.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TalkStates.ImageStream")));
            this.TalkStates.TransparentColor = System.Drawing.Color.Transparent;
            this.TalkStates.Images.SetKeyName(0, "TalkIdle.png");
            this.TalkStates.Images.SetKeyName(1, "Talking.png");
            this.TalkStates.Images.SetKeyName(2, "TalkMute.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Middle Mouse here for PTT";
            // 
            // VoiceConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VoiceConsole";
            this.Size = new System.Drawing.Size(654, 424);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spkrLevel)).EndInit();
            this.avatarContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public ListViewNoFlicker participants;
        public SplitContainer splitContainer1;
        public RadegastContextMenuStrip avatarContext;
        public ToolStripMenuItem ctxProfile;
        public ToolStripMenuItem ctxStartIM;
        public ToolStripMenuItem ctxFollow;
        public ToolStripMenuItem ctxTextures;
        public ToolStripMenuItem ctxAttach;
        public ToolStripMenuItem ctxMaster;
        public ToolStripMenuItem ctxAnim;
        public ToolStripMenuItem ctxPoint;
        public ToolStripMenuItem ctxSource;
        public ToolStripMenuItem ctxPay;
        private CheckBox chkVoiceEnable;
        private ImageList TalkStates;
        private ComboBox micDevice;
        private ComboBox spkrDevice;
        private TrackBar spkrLevel;
        private Label label2;
        private TrackBar micLevel;
        private ProgressBar progressBar1;
        private PictureBox pictureBox2;
        private CheckBox micMute;
        private CheckBox spkrMute;
        private Label label1;
    }
}
