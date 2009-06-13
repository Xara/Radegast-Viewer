namespace Radegast
{
    partial class frmMain
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
            if (InvokeRequired)
            {
                Invoke(new System.Windows.Forms.MethodInvoker(delegate() { Dispose(disposing);} ));
                return;
            }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSLeek = new System.Windows.Forms.ToolStripDropDownButton();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmnuPrefs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tmnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnDebug = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmnuDebugLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtnStatus = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmnuStatusAway = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuStatusBusy = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtnControl = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmnuControlFly = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuControlAlwaysRun = new System.Windows.Forms.ToolStripMenuItem();
            this.groundSitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbnTeleprotMulti = new System.Windows.Forms.ToolStripDropDownButton();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autopilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearbyObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebakeTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbnObjects = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlblLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblMoneyBalance = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblRegionInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.icoHealth = new System.Windows.Forms.ToolStripStatusLabel();
            this.icoNoFly = new System.Windows.Forms.ToolStripStatusLabel();
            this.icoNoBuild = new System.Windows.Forms.ToolStripStatusLabel();
            this.icoNoScript = new System.Windows.Forms.ToolStripStatusLabel();
            this.icoNoPush = new System.Windows.Forms.ToolStripStatusLabel();
            this.icoNoVoice = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlblParcel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSLeek,
            this.toolStripSeparator1,
            this.tbtnDebug,
            this.tbtnStatus,
            this.tbtnControl,
            this.toolStripSeparator2,
            this.tbnTeleprotMulti,
            this.tbnObjects});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSLeek
            // 
            this.tbtnSLeek.AutoToolTip = false;
            this.tbtnSLeek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnSLeek.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.tmnuImport,
            this.toolStripMenuItem3,
            this.tmnuPrefs,
            this.toolStripMenuItem2,
            this.tmnuExit});
            this.tbtnSLeek.Image = global::Radegast.Properties.Resources.computer_16;
            this.tbtnSLeek.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSLeek.Name = "tbtnSLeek";
            this.tbtnSLeek.Size = new System.Drawing.Size(38, 22);
            this.tbtnSLeek.Text = "&File";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newWindowToolStripMenuItem.Text = "&New window...";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // tmnuImport
            // 
            this.tmnuImport.Enabled = false;
            this.tmnuImport.Name = "tmnuImport";
            this.tmnuImport.Size = new System.Drawing.Size(155, 22);
            this.tmnuImport.Text = "Import object...";
            this.tmnuImport.Click += new System.EventHandler(this.importObjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 6);
            // 
            // tmnuPrefs
            // 
            this.tmnuPrefs.Image = global::Radegast.Properties.Resources.applications_16;
            this.tmnuPrefs.Name = "tmnuPrefs";
            this.tmnuPrefs.Size = new System.Drawing.Size(155, 22);
            this.tmnuPrefs.Text = "Preferences...";
            this.tmnuPrefs.Click += new System.EventHandler(this.tmnuPrefs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // tmnuExit
            // 
            this.tmnuExit.Name = "tmnuExit";
            this.tmnuExit.Size = new System.Drawing.Size(155, 22);
            this.tmnuExit.Text = "E&xit";
            this.tmnuExit.Click += new System.EventHandler(this.tmnuExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnDebug
            // 
            this.tbtnDebug.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnDebug.AutoToolTip = false;
            this.tbtnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuDebugLog});
            this.tbtnDebug.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDebug.Image")));
            this.tbtnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDebug.Name = "tbtnDebug";
            this.tbtnDebug.Size = new System.Drawing.Size(55, 22);
            this.tbtnDebug.Text = "Debug";
            this.tbtnDebug.Visible = false;
            // 
            // tmnuDebugLog
            // 
            this.tmnuDebugLog.Name = "tmnuDebugLog";
            this.tmnuDebugLog.Size = new System.Drawing.Size(103, 22);
            this.tmnuDebugLog.Text = "Log...";
            this.tmnuDebugLog.Click += new System.EventHandler(this.tmnuDebugLog_Click);
            // 
            // tbtnStatus
            // 
            this.tbtnStatus.AutoToolTip = false;
            this.tbtnStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuStatusAway,
            this.tmnuStatusBusy});
            this.tbtnStatus.Enabled = false;
            this.tbtnStatus.Image = ((System.Drawing.Image)(resources.GetObject("tbtnStatus.Image")));
            this.tbtnStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnStatus.Name = "tbtnStatus";
            this.tbtnStatus.Size = new System.Drawing.Size(52, 22);
            this.tbtnStatus.Text = "Status";
            // 
            // tmnuStatusAway
            // 
            this.tmnuStatusAway.CheckOnClick = true;
            this.tmnuStatusAway.Name = "tmnuStatusAway";
            this.tmnuStatusAway.Size = new System.Drawing.Size(103, 22);
            this.tmnuStatusAway.Text = "Away";
            this.tmnuStatusAway.Click += new System.EventHandler(this.tmnuStatusAway_Click);
            // 
            // tmnuStatusBusy
            // 
            this.tmnuStatusBusy.CheckOnClick = true;
            this.tmnuStatusBusy.Name = "tmnuStatusBusy";
            this.tmnuStatusBusy.Size = new System.Drawing.Size(103, 22);
            this.tmnuStatusBusy.Text = "Busy";
            this.tmnuStatusBusy.Click += new System.EventHandler(this.tmnuStatusBusy_Click);
            // 
            // tbtnControl
            // 
            this.tbtnControl.AutoToolTip = false;
            this.tbtnControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuControlFly,
            this.tmnuControlAlwaysRun,
            this.groundSitToolStripMenuItem,
            this.standToolStripMenuItem});
            this.tbtnControl.Enabled = false;
            this.tbtnControl.Image = ((System.Drawing.Image)(resources.GetObject("tbtnControl.Image")));
            this.tbtnControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnControl.Name = "tbtnControl";
            this.tbtnControl.Size = new System.Drawing.Size(78, 22);
            this.tbtnControl.Text = "Movement";
            // 
            // tmnuControlFly
            // 
            this.tmnuControlFly.CheckOnClick = true;
            this.tmnuControlFly.Name = "tmnuControlFly";
            this.tmnuControlFly.Size = new System.Drawing.Size(146, 22);
            this.tmnuControlFly.Text = "Fly";
            this.tmnuControlFly.Click += new System.EventHandler(this.tmnuControlFly_Click);
            // 
            // tmnuControlAlwaysRun
            // 
            this.tmnuControlAlwaysRun.CheckOnClick = true;
            this.tmnuControlAlwaysRun.Name = "tmnuControlAlwaysRun";
            this.tmnuControlAlwaysRun.Size = new System.Drawing.Size(146, 22);
            this.tmnuControlAlwaysRun.Text = "Always Run";
            this.tmnuControlAlwaysRun.Click += new System.EventHandler(this.tmnuControlAlwaysRun_Click);
            // 
            // groundSitToolStripMenuItem
            // 
            this.groundSitToolStripMenuItem.Name = "groundSitToolStripMenuItem";
            this.groundSitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.groundSitToolStripMenuItem.Text = "Sit on ground";
            this.groundSitToolStripMenuItem.Click += new System.EventHandler(this.groundSitToolStripMenuItem_Click);
            // 
            // standToolStripMenuItem
            // 
            this.standToolStripMenuItem.Name = "standToolStripMenuItem";
            this.standToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.standToolStripMenuItem.Text = "Stand";
            this.standToolStripMenuItem.Click += new System.EventHandler(this.standToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbnTeleprotMulti
            // 
            this.tbnTeleprotMulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbnTeleprotMulti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.autopilotToolStripMenuItem,
            this.aLICEToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.cleanCacheToolStripMenuItem,
            this.nearbyObjectsToolStripMenuItem,
            this.setAppearanceToolStripMenuItem,
            this.rebakeTexturesToolStripMenuItem});
            this.tbnTeleprotMulti.Enabled = false;
            this.tbnTeleprotMulti.Image = ((System.Drawing.Image)(resources.GetObject("tbnTeleprotMulti.Image")));
            this.tbnTeleprotMulti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbnTeleprotMulti.Name = "tbnTeleprotMulti";
            this.tbnTeleprotMulti.Size = new System.Drawing.Size(49, 22);
            this.tbnTeleprotMulti.Text = "&Tools";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.locationToolStripMenuItem.Text = "Teleport sim";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.tbtnTeleport_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.homeToolStripMenuItem.Text = "Teleport home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // autopilotToolStripMenuItem
            // 
            this.autopilotToolStripMenuItem.Enabled = false;
            this.autopilotToolStripMenuItem.Name = "autopilotToolStripMenuItem";
            this.autopilotToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.autopilotToolStripMenuItem.Text = "&Autopilot";
            this.autopilotToolStripMenuItem.Click += new System.EventHandler(this.autopilotToolStripMenuItem_Click);
            // 
            // aLICEToolStripMenuItem
            // 
            this.aLICEToolStripMenuItem.Name = "aLICEToolStripMenuItem";
            this.aLICEToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aLICEToolStripMenuItem.Text = "A.L.I.C.E chatbot";
            this.aLICEToolStripMenuItem.Click += new System.EventHandler(this.aLICEToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // cleanCacheToolStripMenuItem
            // 
            this.cleanCacheToolStripMenuItem.Name = "cleanCacheToolStripMenuItem";
            this.cleanCacheToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cleanCacheToolStripMenuItem.Text = "Clean cache";
            this.cleanCacheToolStripMenuItem.Click += new System.EventHandler(this.cleanCacheToolStripMenuItem_Click);
            // 
            // nearbyObjectsToolStripMenuItem
            // 
            this.nearbyObjectsToolStripMenuItem.Name = "nearbyObjectsToolStripMenuItem";
            this.nearbyObjectsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nearbyObjectsToolStripMenuItem.Text = "Nearby objects";
            this.nearbyObjectsToolStripMenuItem.Click += new System.EventHandler(this.tbtnObjects_Click);
            // 
            // setAppearanceToolStripMenuItem
            // 
            this.setAppearanceToolStripMenuItem.Name = "setAppearanceToolStripMenuItem";
            this.setAppearanceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.setAppearanceToolStripMenuItem.Text = "Set appearance";
            this.setAppearanceToolStripMenuItem.Click += new System.EventHandler(this.tbtnAppearance_Click);
            // 
            // rebakeTexturesToolStripMenuItem
            // 
            this.rebakeTexturesToolStripMenuItem.Name = "rebakeTexturesToolStripMenuItem";
            this.rebakeTexturesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rebakeTexturesToolStripMenuItem.Text = "Rebake textures";
            this.rebakeTexturesToolStripMenuItem.Click += new System.EventHandler(this.rebakeTexturesToolStripMenuItem_Click);
            // 
            // tbnObjects
            // 
            this.tbnObjects.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbnObjects.Enabled = false;
            this.tbnObjects.Image = ((System.Drawing.Image)(resources.GetObject("tbnObjects.Image")));
            this.tbnObjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbnObjects.Name = "tbnObjects";
            this.tbnObjects.Size = new System.Drawing.Size(51, 22);
            this.tbnObjects.Text = "Objects";
            this.tbnObjects.ToolTipText = "Displays a list of nearby objects that you can perform various operations on";
            this.tbnObjects.Click += new System.EventHandler(this.tbnObjects_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblLoginName,
            this.tlblMoneyBalance,
            this.tlblRegionInfo,
            this.icoHealth,
            this.icoNoFly,
            this.icoNoBuild,
            this.icoNoScript,
            this.icoNoPush,
            this.icoNoVoice,
            this.tlblParcel});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(738, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlblLoginName
            // 
            this.tlblLoginName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlblLoginName.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tlblLoginName.Name = "tlblLoginName";
            this.tlblLoginName.Size = new System.Drawing.Size(47, 20);
            this.tlblLoginName.Text = "Offline";
            // 
            // tlblMoneyBalance
            // 
            this.tlblMoneyBalance.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlblMoneyBalance.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tlblMoneyBalance.Image = global::Radegast.Properties.Resources.status_buy_currency;
            this.tlblMoneyBalance.Name = "tlblMoneyBalance";
            this.tlblMoneyBalance.Size = new System.Drawing.Size(33, 20);
            this.tlblMoneyBalance.Text = "0";
            // 
            // tlblRegionInfo
            // 
            this.tlblRegionInfo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlblRegionInfo.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tlblRegionInfo.Name = "tlblRegionInfo";
            this.tlblRegionInfo.Size = new System.Drawing.Size(67, 20);
            this.tlblRegionInfo.Text = "No Region";
            this.tlblRegionInfo.Click += new System.EventHandler(this.tlblRegionInfo_Click);
            // 
            // icoHealth
            // 
            this.icoHealth.Image = global::Radegast.Properties.Resources.status_health;
            this.icoHealth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.icoHealth.Name = "icoHealth";
            this.icoHealth.Size = new System.Drawing.Size(67, 20);
            this.icoHealth.Text = "100%";
            this.icoHealth.ToolTipText = "Damage enabled on the parcel";
            this.icoHealth.Visible = false;
            // 
            // icoNoFly
            // 
            this.icoNoFly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.icoNoFly.Image = global::Radegast.Properties.Resources.status_no_fly;
            this.icoNoFly.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.icoNoFly.Name = "icoNoFly";
            this.icoNoFly.Size = new System.Drawing.Size(32, 20);
            this.icoNoFly.Text = "Fly";
            this.icoNoFly.ToolTipText = "Flying not allowed here";
            this.icoNoFly.Visible = false;
            // 
            // icoNoBuild
            // 
            this.icoNoBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.icoNoBuild.Image = global::Radegast.Properties.Resources.status_no_build;
            this.icoNoBuild.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.icoNoBuild.Name = "icoNoBuild";
            this.icoNoBuild.Size = new System.Drawing.Size(32, 20);
            this.icoNoBuild.Text = "Build";
            this.icoNoBuild.ToolTipText = "No building or rezzing objects allowed on this parcel";
            this.icoNoBuild.Visible = false;
            // 
            // icoNoScript
            // 
            this.icoNoScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.icoNoScript.Image = global::Radegast.Properties.Resources.status_no_scripts;
            this.icoNoScript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.icoNoScript.Name = "icoNoScript";
            this.icoNoScript.Size = new System.Drawing.Size(32, 20);
            this.icoNoScript.Text = "Script";
            this.icoNoScript.ToolTipText = "Scripts disallowd on the parcel";
            this.icoNoScript.Visible = false;
            // 
            // icoNoPush
            // 
            this.icoNoPush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.icoNoPush.Image = global::Radegast.Properties.Resources.status_no_push;
            this.icoNoPush.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.icoNoPush.Name = "icoNoPush";
            this.icoNoPush.Size = new System.Drawing.Size(32, 20);
            this.icoNoPush.Text = "Push";
            this.icoNoPush.ToolTipText = "No pushing by scripts allowed";
            this.icoNoPush.Visible = false;
            // 
            // icoNoVoice
            // 
            this.icoNoVoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.icoNoVoice.Image = global::Radegast.Properties.Resources.status_no_voice;
            this.icoNoVoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.icoNoVoice.Name = "icoNoVoice";
            this.icoNoVoice.Size = new System.Drawing.Size(32, 20);
            this.icoNoVoice.Text = "Push";
            this.icoNoVoice.ToolTipText = "Voice chat disabled";
            this.icoNoVoice.Visible = false;
            // 
            // tlblParcel
            // 
            this.tlblParcel.AutoToolTip = true;
            this.tlblParcel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tlblParcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlblParcel.Margin = new System.Windows.Forms.Padding(0, 3, -5, 2);
            this.tlblParcel.Name = "tlblParcel";
            this.tlblParcel.Size = new System.Drawing.Size(58, 20);
            this.tlblParcel.Text = "No Parcel";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(738, 455);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripContainer1.Size = new System.Drawing.Size(738, 480);
            this.toolStripContainer1.TabIndex = 10;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // pnlDialog
            // 
            this.pnlDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDialog.AutoSize = true;
            this.pnlDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlDialog.Location = new System.Drawing.Point(540, 0);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(198, 151);
            this.pnlDialog.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 505);
            this.Controls.Add(this.pnlDialog);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(754, 541);
            this.Name = "frmMain";
            this.Text = "Radegast";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton tbtnSLeek;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmnuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlblLoginName;
        private System.Windows.Forms.ToolStripStatusLabel tlblRegionInfo;
        private System.Windows.Forms.ToolStripStatusLabel tlblMoneyBalance;
        private System.Windows.Forms.ToolStripDropDownButton tbtnDebug;
        private System.Windows.Forms.ToolStripMenuItem tmnuPrefs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tmnuDebugLog;
        private System.Windows.Forms.ToolStripDropDownButton tbtnStatus;
        private System.Windows.Forms.ToolStripMenuItem tmnuStatusAway;
        private System.Windows.Forms.ToolStripMenuItem tmnuStatusBusy;
        private System.Windows.Forms.ToolStripDropDownButton tbtnControl;
        private System.Windows.Forms.ToolStripMenuItem tmnuControlFly;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tmnuControlAlwaysRun;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripStatusLabel tlblParcel;
        private System.Windows.Forms.ToolStripDropDownButton tbnTeleprotMulti;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmnuImport;
        private System.Windows.Forms.ToolStripMenuItem autopilotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nearbyObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAppearanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebakeTexturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groundSitToolStripMenuItem;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripContainer toolStripContainer1;
        public System.Windows.Forms.Panel pnlDialog;
        private System.Windows.Forms.ToolStripButton tbnObjects;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel icoNoBuild;
        private System.Windows.Forms.ToolStripStatusLabel icoHealth;
        private System.Windows.Forms.ToolStripStatusLabel icoNoFly;
        private System.Windows.Forms.ToolStripStatusLabel icoNoScript;
        private System.Windows.Forms.ToolStripStatusLabel icoNoPush;
        private System.Windows.Forms.ToolStripStatusLabel icoNoVoice;
    }
}

