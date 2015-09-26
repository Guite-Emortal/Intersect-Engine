﻿namespace Intersect_Editor.Forms
{
    partial class frmMapLayers
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTiles = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMapLayer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTilesetContainer = new System.Windows.Forms.Panel();
            this.picTileset = new System.Windows.Forms.PictureBox();
            this.cmbAutotile = new System.Windows.Forms.ComboBox();
            this.cmbTilesets = new System.Windows.Forms.ComboBox();
            this.tabAttributes = new System.Windows.Forms.TabPage();
            this.rbResource = new System.Windows.Forms.RadioButton();
            this.rbSound = new System.Windows.Forms.RadioButton();
            this.rbWarp = new System.Windows.Forms.RadioButton();
            this.rbNPCAvoid = new System.Windows.Forms.RadioButton();
            this.rbZDimension = new System.Windows.Forms.RadioButton();
            this.rbItem = new System.Windows.Forms.RadioButton();
            this.rbBlocked = new System.Windows.Forms.RadioButton();
            this.grpResource = new System.Windows.Forms.GroupBox();
            this.lblResource = new System.Windows.Forms.Label();
            this.scrlResource = new System.Windows.Forms.HScrollBar();
            this.grpSound = new System.Windows.Forms.GroupBox();
            this.cmbMapAttributeSound = new System.Windows.Forms.ComboBox();
            this.lblSoundDistance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scrlSoundDistance = new System.Windows.Forms.HScrollBar();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.lblMaxItemAmount = new System.Windows.Forms.Label();
            this.lblMapItem = new System.Windows.Forms.Label();
            this.scrlMaxItemVal = new System.Windows.Forms.HScrollBar();
            this.scrlMapItem = new System.Windows.Forms.HScrollBar();
            this.grpWarp = new System.Windows.Forms.GroupBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.scrlX = new System.Windows.Forms.HScrollBar();
            this.scrlY = new System.Windows.Forms.HScrollBar();
            this.scrlMap = new System.Windows.Forms.HScrollBar();
            this.grpZDimension = new System.Windows.Forms.GroupBox();
            this.grpGateway = new System.Windows.Forms.GroupBox();
            this.rbGateway2 = new System.Windows.Forms.RadioButton();
            this.rbGateway1 = new System.Windows.Forms.RadioButton();
            this.rbGatewayNone = new System.Windows.Forms.RadioButton();
            this.grpDimBlock = new System.Windows.Forms.GroupBox();
            this.rbBlock2 = new System.Windows.Forms.RadioButton();
            this.rbBlock1 = new System.Windows.Forms.RadioButton();
            this.rbBlockNone = new System.Windows.Forms.RadioButton();
            this.tabLights = new System.Windows.Forms.TabPage();
            this.pnlLight = new System.Windows.Forms.Panel();
            this.scrlLightRange = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLightRange = new System.Windows.Forms.TextBox();
            this.scrlLightIntensity = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLightIntensity = new System.Windows.Forms.TextBox();
            this.txtLightOffsetY = new System.Windows.Forms.TextBox();
            this.txtLightOffsetX = new System.Windows.Forms.TextBox();
            this.lblOffsetY = new System.Windows.Forms.Label();
            this.lblOffsetX = new System.Windows.Forms.Label();
            this.btnLightEditorRevert = new System.Windows.Forms.Button();
            this.btnLightEditorClose = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.tabNPCs = new System.Windows.Forms.TabPage();
            this.grpManage = new System.Windows.Forms.GroupBox();
            this.btnRemoveMapNpc = new System.Windows.Forms.Button();
            this.btnAddMapNpc = new System.Windows.Forms.Button();
            this.cmbNpc = new System.Windows.Forms.ComboBox();
            this.grpSpawnLoc = new System.Windows.Forms.GroupBox();
            this.cmbDir = new System.Windows.Forms.ComboBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbDeclared = new System.Windows.Forms.RadioButton();
            this.lstMapNpcs = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabTiles.SuspendLayout();
            this.pnlTilesetContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileset)).BeginInit();
            this.tabAttributes.SuspendLayout();
            this.grpResource.SuspendLayout();
            this.grpSound.SuspendLayout();
            this.grpItem.SuspendLayout();
            this.grpWarp.SuspendLayout();
            this.grpZDimension.SuspendLayout();
            this.grpGateway.SuspendLayout();
            this.grpDimBlock.SuspendLayout();
            this.tabLights.SuspendLayout();
            this.pnlLight.SuspendLayout();
            this.tabNPCs.SuspendLayout();
            this.grpManage.SuspendLayout();
            this.grpSpawnLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabTiles);
            this.tabControl.Controls.Add(this.tabAttributes);
            this.tabControl.Controls.Add(this.tabLights);
            this.tabControl.Controls.Add(this.tabEvents);
            this.tabControl.Controls.Add(this.tabNPCs);
            this.tabControl.Location = new System.Drawing.Point(5, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(275, 394);
            this.tabControl.TabIndex = 17;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabTiles
            // 
            this.tabTiles.Controls.Add(this.label5);
            this.tabTiles.Controls.Add(this.cmbMapLayer);
            this.tabTiles.Controls.Add(this.label2);
            this.tabTiles.Controls.Add(this.label1);
            this.tabTiles.Controls.Add(this.pnlTilesetContainer);
            this.tabTiles.Controls.Add(this.cmbAutotile);
            this.tabTiles.Controls.Add(this.cmbTilesets);
            this.tabTiles.Location = new System.Drawing.Point(4, 22);
            this.tabTiles.Name = "tabTiles";
            this.tabTiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabTiles.Size = new System.Drawing.Size(267, 368);
            this.tabTiles.TabIndex = 0;
            this.tabTiles.Text = "Tiles";
            this.tabTiles.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Layer:";
            // 
            // cmbMapLayer
            // 
            this.cmbMapLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMapLayer.FormattingEnabled = true;
            this.cmbMapLayer.Items.AddRange(new object[] {
            "Ground",
            "Mask",
            "Mask 2",
            "Fringe",
            "Fringe 2"});
            this.cmbMapLayer.Location = new System.Drawing.Point(81, 6);
            this.cmbMapLayer.Name = "cmbMapLayer";
            this.cmbMapLayer.Size = new System.Drawing.Size(178, 21);
            this.cmbMapLayer.TabIndex = 22;
            this.cmbMapLayer.SelectedIndexChanged += new System.EventHandler(this.cmbMapLayer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tile Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tileset:";
            // 
            // pnlTilesetContainer
            // 
            this.pnlTilesetContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTilesetContainer.AutoScroll = true;
            this.pnlTilesetContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTilesetContainer.Controls.Add(this.picTileset);
            this.pnlTilesetContainer.Location = new System.Drawing.Point(6, 93);
            this.pnlTilesetContainer.Name = "pnlTilesetContainer";
            this.pnlTilesetContainer.Size = new System.Drawing.Size(253, 269);
            this.pnlTilesetContainer.TabIndex = 19;
            // 
            // picTileset
            // 
            this.picTileset.Location = new System.Drawing.Point(1, 1);
            this.picTileset.Name = "picTileset";
            this.picTileset.Size = new System.Drawing.Size(167, 148);
            this.picTileset.TabIndex = 2;
            this.picTileset.TabStop = false;
            this.picTileset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTileset_MouseDown);
            this.picTileset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTileset_MouseMove);
            this.picTileset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTileset_MouseUp);
            // 
            // cmbAutotile
            // 
            this.cmbAutotile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutotile.FormattingEnabled = true;
            this.cmbAutotile.Items.AddRange(new object[] {
            "Normal",
            "Autotile",
            "Fake",
            "Animated",
            "Cliff",
            "Waterfall"});
            this.cmbAutotile.Location = new System.Drawing.Point(81, 62);
            this.cmbAutotile.Name = "cmbAutotile";
            this.cmbAutotile.Size = new System.Drawing.Size(178, 21);
            this.cmbAutotile.TabIndex = 18;
            this.cmbAutotile.SelectedIndexChanged += new System.EventHandler(this.cmbAutotile_SelectedIndexChanged);
            // 
            // cmbTilesets
            // 
            this.cmbTilesets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTilesets.FormattingEnabled = true;
            this.cmbTilesets.Location = new System.Drawing.Point(81, 33);
            this.cmbTilesets.Name = "cmbTilesets";
            this.cmbTilesets.Size = new System.Drawing.Size(178, 21);
            this.cmbTilesets.TabIndex = 17;
            this.cmbTilesets.SelectedIndexChanged += new System.EventHandler(this.cmbTilesets_SelectedIndexChanged);
            // 
            // tabAttributes
            // 
            this.tabAttributes.Controls.Add(this.rbResource);
            this.tabAttributes.Controls.Add(this.rbSound);
            this.tabAttributes.Controls.Add(this.rbWarp);
            this.tabAttributes.Controls.Add(this.rbNPCAvoid);
            this.tabAttributes.Controls.Add(this.rbZDimension);
            this.tabAttributes.Controls.Add(this.rbItem);
            this.tabAttributes.Controls.Add(this.rbBlocked);
            this.tabAttributes.Controls.Add(this.grpResource);
            this.tabAttributes.Controls.Add(this.grpSound);
            this.tabAttributes.Controls.Add(this.grpItem);
            this.tabAttributes.Controls.Add(this.grpWarp);
            this.tabAttributes.Controls.Add(this.grpZDimension);
            this.tabAttributes.Location = new System.Drawing.Point(4, 22);
            this.tabAttributes.Name = "tabAttributes";
            this.tabAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttributes.Size = new System.Drawing.Size(267, 368);
            this.tabAttributes.TabIndex = 1;
            this.tabAttributes.Text = "Attributes";
            this.tabAttributes.UseVisualStyleBackColor = true;
            // 
            // rbResource
            // 
            this.rbResource.AutoSize = true;
            this.rbResource.Location = new System.Drawing.Point(5, 145);
            this.rbResource.Name = "rbResource";
            this.rbResource.Size = new System.Drawing.Size(71, 17);
            this.rbResource.TabIndex = 30;
            this.rbResource.Text = "Resource";
            this.rbResource.UseVisualStyleBackColor = true;
            this.rbResource.CheckedChanged += new System.EventHandler(this.rbResource_CheckedChanged);
            // 
            // rbSound
            // 
            this.rbSound.AutoSize = true;
            this.rbSound.Location = new System.Drawing.Point(5, 122);
            this.rbSound.Name = "rbSound";
            this.rbSound.Size = new System.Drawing.Size(80, 17);
            this.rbSound.TabIndex = 28;
            this.rbSound.Text = "Map Sound";
            this.rbSound.UseVisualStyleBackColor = true;
            this.rbSound.CheckedChanged += new System.EventHandler(this.rbSound_CheckedChanged);
            // 
            // rbWarp
            // 
            this.rbWarp.AutoSize = true;
            this.rbWarp.Location = new System.Drawing.Point(5, 75);
            this.rbWarp.Name = "rbWarp";
            this.rbWarp.Size = new System.Drawing.Size(51, 17);
            this.rbWarp.TabIndex = 25;
            this.rbWarp.Text = "Warp";
            this.rbWarp.UseVisualStyleBackColor = true;
            this.rbWarp.CheckedChanged += new System.EventHandler(this.rbWarp_CheckedChanged);
            // 
            // rbNPCAvoid
            // 
            this.rbNPCAvoid.AutoSize = true;
            this.rbNPCAvoid.Location = new System.Drawing.Point(5, 52);
            this.rbNPCAvoid.Name = "rbNPCAvoid";
            this.rbNPCAvoid.Size = new System.Drawing.Size(77, 17);
            this.rbNPCAvoid.TabIndex = 24;
            this.rbNPCAvoid.Text = "NPC Avoid";
            this.rbNPCAvoid.UseVisualStyleBackColor = true;
            this.rbNPCAvoid.CheckedChanged += new System.EventHandler(this.rbNPCAvoid_CheckedChanged);
            // 
            // rbZDimension
            // 
            this.rbZDimension.AutoSize = true;
            this.rbZDimension.Location = new System.Drawing.Point(5, 28);
            this.rbZDimension.Name = "rbZDimension";
            this.rbZDimension.Size = new System.Drawing.Size(84, 17);
            this.rbZDimension.TabIndex = 23;
            this.rbZDimension.Text = "Z-Dimension";
            this.rbZDimension.UseVisualStyleBackColor = true;
            this.rbZDimension.CheckedChanged += new System.EventHandler(this.rbZDimension_CheckedChanged);
            // 
            // rbItem
            // 
            this.rbItem.AutoSize = true;
            this.rbItem.Location = new System.Drawing.Point(5, 98);
            this.rbItem.Name = "rbItem";
            this.rbItem.Size = new System.Drawing.Size(81, 17);
            this.rbItem.TabIndex = 21;
            this.rbItem.Text = "Item Spawn";
            this.rbItem.UseVisualStyleBackColor = true;
            this.rbItem.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbBlocked
            // 
            this.rbBlocked.AutoSize = true;
            this.rbBlocked.Checked = true;
            this.rbBlocked.Location = new System.Drawing.Point(6, 6);
            this.rbBlocked.Name = "rbBlocked";
            this.rbBlocked.Size = new System.Drawing.Size(64, 17);
            this.rbBlocked.TabIndex = 20;
            this.rbBlocked.TabStop = true;
            this.rbBlocked.Text = "Blocked";
            this.rbBlocked.UseVisualStyleBackColor = true;
            this.rbBlocked.CheckedChanged += new System.EventHandler(this.rbBlocked_CheckedChanged);
            // 
            // grpResource
            // 
            this.grpResource.Controls.Add(this.lblResource);
            this.grpResource.Controls.Add(this.scrlResource);
            this.grpResource.Location = new System.Drawing.Point(5, 233);
            this.grpResource.Name = "grpResource";
            this.grpResource.Size = new System.Drawing.Size(256, 100);
            this.grpResource.TabIndex = 31;
            this.grpResource.TabStop = false;
            this.grpResource.Text = "Resource";
            this.grpResource.Visible = false;
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Location = new System.Drawing.Point(14, 31);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(94, 13);
            this.lblResource.TabIndex = 10;
            this.lblResource.Text = "Resource: 0 None";
            // 
            // scrlResource
            // 
            this.scrlResource.LargeChange = 1;
            this.scrlResource.Location = new System.Drawing.Point(17, 53);
            this.scrlResource.Maximum = 255;
            this.scrlResource.Minimum = -1;
            this.scrlResource.Name = "scrlResource";
            this.scrlResource.Size = new System.Drawing.Size(222, 20);
            this.scrlResource.TabIndex = 9;
            this.scrlResource.Value = -1;
            this.scrlResource.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlResource_Scroll);
            // 
            // grpSound
            // 
            this.grpSound.Controls.Add(this.cmbMapAttributeSound);
            this.grpSound.Controls.Add(this.lblSoundDistance);
            this.grpSound.Controls.Add(this.label7);
            this.grpSound.Controls.Add(this.scrlSoundDistance);
            this.grpSound.Location = new System.Drawing.Point(9, 195);
            this.grpSound.Name = "grpSound";
            this.grpSound.Size = new System.Drawing.Size(252, 132);
            this.grpSound.TabIndex = 29;
            this.grpSound.TabStop = false;
            this.grpSound.Text = "Map Sound";
            this.grpSound.Visible = false;
            // 
            // cmbMapAttributeSound
            // 
            this.cmbMapAttributeSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMapAttributeSound.FormattingEnabled = true;
            this.cmbMapAttributeSound.Location = new System.Drawing.Point(16, 41);
            this.cmbMapAttributeSound.Name = "cmbMapAttributeSound";
            this.cmbMapAttributeSound.Size = new System.Drawing.Size(219, 21);
            this.cmbMapAttributeSound.TabIndex = 9;
            // 
            // lblSoundDistance
            // 
            this.lblSoundDistance.AutoSize = true;
            this.lblSoundDistance.Location = new System.Drawing.Point(13, 72);
            this.lblSoundDistance.Name = "lblSoundDistance";
            this.lblSoundDistance.Size = new System.Drawing.Size(92, 13);
            this.lblSoundDistance.TabIndex = 8;
            this.lblSoundDistance.Text = "Distance: 1 Tile(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sound:";
            // 
            // scrlSoundDistance
            // 
            this.scrlSoundDistance.LargeChange = 1;
            this.scrlSoundDistance.Location = new System.Drawing.Point(16, 94);
            this.scrlSoundDistance.Maximum = 15;
            this.scrlSoundDistance.Minimum = 1;
            this.scrlSoundDistance.Name = "scrlSoundDistance";
            this.scrlSoundDistance.Size = new System.Drawing.Size(219, 17);
            this.scrlSoundDistance.TabIndex = 6;
            this.scrlSoundDistance.Value = 1;
            this.scrlSoundDistance.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlSoundDistance_Scroll);
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.lblMaxItemAmount);
            this.grpItem.Controls.Add(this.lblMapItem);
            this.grpItem.Controls.Add(this.scrlMaxItemVal);
            this.grpItem.Controls.Add(this.scrlMapItem);
            this.grpItem.Location = new System.Drawing.Point(9, 198);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(246, 132);
            this.grpItem.TabIndex = 22;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Map Item";
            this.grpItem.Visible = false;
            // 
            // lblMaxItemAmount
            // 
            this.lblMaxItemAmount.AutoSize = true;
            this.lblMaxItemAmount.Location = new System.Drawing.Point(13, 72);
            this.lblMaxItemAmount.Name = "lblMaxItemAmount";
            this.lblMaxItemAmount.Size = new System.Drawing.Size(63, 13);
            this.lblMaxItemAmount.TabIndex = 8;
            this.lblMaxItemAmount.Text = "Quantity: x1";
            // 
            // lblMapItem
            // 
            this.lblMapItem.AutoSize = true;
            this.lblMapItem.Location = new System.Drawing.Point(13, 21);
            this.lblMapItem.Name = "lblMapItem";
            this.lblMapItem.Size = new System.Drawing.Size(39, 13);
            this.lblMapItem.TabIndex = 7;
            this.lblMapItem.Text = "Item: 1";
            // 
            // scrlMaxItemVal
            // 
            this.scrlMaxItemVal.LargeChange = 1;
            this.scrlMaxItemVal.Location = new System.Drawing.Point(16, 94);
            this.scrlMaxItemVal.Maximum = 1000;
            this.scrlMaxItemVal.Minimum = 1;
            this.scrlMaxItemVal.Name = "scrlMaxItemVal";
            this.scrlMaxItemVal.Size = new System.Drawing.Size(219, 18);
            this.scrlMaxItemVal.TabIndex = 6;
            this.scrlMaxItemVal.Value = 1;
            this.scrlMaxItemVal.ValueChanged += new System.EventHandler(this.scrlMaxItemVal_ValueChanged);
            // 
            // scrlMapItem
            // 
            this.scrlMapItem.LargeChange = 1;
            this.scrlMapItem.Location = new System.Drawing.Point(16, 44);
            this.scrlMapItem.Minimum = 1;
            this.scrlMapItem.Name = "scrlMapItem";
            this.scrlMapItem.Size = new System.Drawing.Size(219, 20);
            this.scrlMapItem.TabIndex = 5;
            this.scrlMapItem.Value = 1;
            this.scrlMapItem.ValueChanged += new System.EventHandler(this.scrlMapItem_ValueChanged);
            // 
            // grpWarp
            // 
            this.grpWarp.Controls.Add(this.lblY);
            this.grpWarp.Controls.Add(this.lblX);
            this.grpWarp.Controls.Add(this.lblMap);
            this.grpWarp.Controls.Add(this.scrlX);
            this.grpWarp.Controls.Add(this.scrlY);
            this.grpWarp.Controls.Add(this.scrlMap);
            this.grpWarp.Location = new System.Drawing.Point(6, 168);
            this.grpWarp.Name = "grpWarp";
            this.grpWarp.Size = new System.Drawing.Size(255, 162);
            this.grpWarp.TabIndex = 26;
            this.grpWarp.TabStop = false;
            this.grpWarp.Text = "Warp";
            this.grpWarp.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(22, 106);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(26, 13);
            this.lblY.TabIndex = 11;
            this.lblY.Text = "Y: 0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(22, 65);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 13);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X: 0";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(19, 21);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(40, 13);
            this.lblMap.TabIndex = 9;
            this.lblMap.Text = "Map: 0";
            // 
            // scrlX
            // 
            this.scrlX.LargeChange = 1;
            this.scrlX.Location = new System.Drawing.Point(19, 78);
            this.scrlX.Name = "scrlX";
            this.scrlX.Size = new System.Drawing.Size(219, 21);
            this.scrlX.TabIndex = 8;
            this.scrlX.ValueChanged += new System.EventHandler(this.scrlX_ValueChanged);
            // 
            // scrlY
            // 
            this.scrlY.LargeChange = 1;
            this.scrlY.Location = new System.Drawing.Point(19, 121);
            this.scrlY.Name = "scrlY";
            this.scrlY.Size = new System.Drawing.Size(219, 21);
            this.scrlY.TabIndex = 7;
            this.scrlY.ValueChanged += new System.EventHandler(this.scrlY_ValueChanged);
            // 
            // scrlMap
            // 
            this.scrlMap.LargeChange = 1;
            this.scrlMap.Location = new System.Drawing.Point(20, 34);
            this.scrlMap.Name = "scrlMap";
            this.scrlMap.Size = new System.Drawing.Size(218, 21);
            this.scrlMap.TabIndex = 6;
            this.scrlMap.ValueChanged += new System.EventHandler(this.scrlMap_ValueChanged);
            // 
            // grpZDimension
            // 
            this.grpZDimension.Controls.Add(this.grpGateway);
            this.grpZDimension.Controls.Add(this.grpDimBlock);
            this.grpZDimension.Location = new System.Drawing.Point(4, 201);
            this.grpZDimension.Name = "grpZDimension";
            this.grpZDimension.Size = new System.Drawing.Size(257, 132);
            this.grpZDimension.TabIndex = 27;
            this.grpZDimension.TabStop = false;
            this.grpZDimension.Text = "Z-Dimension";
            this.grpZDimension.Visible = false;
            // 
            // grpGateway
            // 
            this.grpGateway.Controls.Add(this.rbGateway2);
            this.grpGateway.Controls.Add(this.rbGateway1);
            this.grpGateway.Controls.Add(this.rbGatewayNone);
            this.grpGateway.Location = new System.Drawing.Point(10, 25);
            this.grpGateway.Name = "grpGateway";
            this.grpGateway.Size = new System.Drawing.Size(107, 91);
            this.grpGateway.TabIndex = 9;
            this.grpGateway.TabStop = false;
            this.grpGateway.Text = "Gateway";
            // 
            // rbGateway2
            // 
            this.rbGateway2.AutoSize = true;
            this.rbGateway2.Location = new System.Drawing.Point(6, 64);
            this.rbGateway2.Name = "rbGateway2";
            this.rbGateway2.Size = new System.Drawing.Size(60, 17);
            this.rbGateway2.TabIndex = 12;
            this.rbGateway2.Text = "Level 2";
            this.rbGateway2.UseVisualStyleBackColor = true;
            // 
            // rbGateway1
            // 
            this.rbGateway1.AutoSize = true;
            this.rbGateway1.Location = new System.Drawing.Point(6, 41);
            this.rbGateway1.Name = "rbGateway1";
            this.rbGateway1.Size = new System.Drawing.Size(60, 17);
            this.rbGateway1.TabIndex = 11;
            this.rbGateway1.Text = "Level 1";
            this.rbGateway1.UseVisualStyleBackColor = true;
            // 
            // rbGatewayNone
            // 
            this.rbGatewayNone.AutoSize = true;
            this.rbGatewayNone.Checked = true;
            this.rbGatewayNone.Location = new System.Drawing.Point(6, 19);
            this.rbGatewayNone.Name = "rbGatewayNone";
            this.rbGatewayNone.Size = new System.Drawing.Size(51, 17);
            this.rbGatewayNone.TabIndex = 10;
            this.rbGatewayNone.TabStop = true;
            this.rbGatewayNone.Text = "None";
            this.rbGatewayNone.UseVisualStyleBackColor = true;
            // 
            // grpDimBlock
            // 
            this.grpDimBlock.Controls.Add(this.rbBlock2);
            this.grpDimBlock.Controls.Add(this.rbBlock1);
            this.grpDimBlock.Controls.Add(this.rbBlockNone);
            this.grpDimBlock.Location = new System.Drawing.Point(123, 25);
            this.grpDimBlock.Name = "grpDimBlock";
            this.grpDimBlock.Size = new System.Drawing.Size(111, 91);
            this.grpDimBlock.TabIndex = 8;
            this.grpDimBlock.TabStop = false;
            this.grpDimBlock.Text = "Block";
            // 
            // rbBlock2
            // 
            this.rbBlock2.AutoSize = true;
            this.rbBlock2.Location = new System.Drawing.Point(6, 64);
            this.rbBlock2.Name = "rbBlock2";
            this.rbBlock2.Size = new System.Drawing.Size(60, 17);
            this.rbBlock2.TabIndex = 15;
            this.rbBlock2.Text = "Level 2";
            this.rbBlock2.UseVisualStyleBackColor = true;
            // 
            // rbBlock1
            // 
            this.rbBlock1.AutoSize = true;
            this.rbBlock1.Location = new System.Drawing.Point(6, 41);
            this.rbBlock1.Name = "rbBlock1";
            this.rbBlock1.Size = new System.Drawing.Size(60, 17);
            this.rbBlock1.TabIndex = 14;
            this.rbBlock1.Text = "Level 1";
            this.rbBlock1.UseVisualStyleBackColor = true;
            // 
            // rbBlockNone
            // 
            this.rbBlockNone.AutoSize = true;
            this.rbBlockNone.Checked = true;
            this.rbBlockNone.Location = new System.Drawing.Point(6, 19);
            this.rbBlockNone.Name = "rbBlockNone";
            this.rbBlockNone.Size = new System.Drawing.Size(51, 17);
            this.rbBlockNone.TabIndex = 13;
            this.rbBlockNone.TabStop = true;
            this.rbBlockNone.Text = "None";
            this.rbBlockNone.UseVisualStyleBackColor = true;
            // 
            // tabLights
            // 
            this.tabLights.Controls.Add(this.pnlLight);
            this.tabLights.Location = new System.Drawing.Point(4, 22);
            this.tabLights.Name = "tabLights";
            this.tabLights.Size = new System.Drawing.Size(267, 368);
            this.tabLights.TabIndex = 2;
            this.tabLights.Text = "Lights";
            this.tabLights.UseVisualStyleBackColor = true;
            // 
            // pnlLight
            // 
            this.pnlLight.Controls.Add(this.scrlLightRange);
            this.pnlLight.Controls.Add(this.label3);
            this.pnlLight.Controls.Add(this.txtLightRange);
            this.pnlLight.Controls.Add(this.scrlLightIntensity);
            this.pnlLight.Controls.Add(this.label4);
            this.pnlLight.Controls.Add(this.txtLightIntensity);
            this.pnlLight.Controls.Add(this.txtLightOffsetY);
            this.pnlLight.Controls.Add(this.txtLightOffsetX);
            this.pnlLight.Controls.Add(this.lblOffsetY);
            this.pnlLight.Controls.Add(this.lblOffsetX);
            this.pnlLight.Controls.Add(this.btnLightEditorRevert);
            this.pnlLight.Controls.Add(this.btnLightEditorClose);
            this.pnlLight.Location = new System.Drawing.Point(4, 4);
            this.pnlLight.Name = "pnlLight";
            this.pnlLight.Size = new System.Drawing.Size(259, 257);
            this.pnlLight.TabIndex = 0;
            this.pnlLight.Visible = false;
            // 
            // scrlLightRange
            // 
            this.scrlLightRange.Location = new System.Drawing.Point(3, 177);
            this.scrlLightRange.Maximum = 179;
            this.scrlLightRange.Minimum = 2;
            this.scrlLightRange.Name = "scrlLightRange";
            this.scrlLightRange.Size = new System.Drawing.Size(225, 17);
            this.scrlLightRange.TabIndex = 35;
            this.scrlLightRange.Value = 2;
            this.scrlLightRange.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlLightRange_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Range:";
            // 
            // txtLightRange
            // 
            this.txtLightRange.Location = new System.Drawing.Point(3, 154);
            this.txtLightRange.Name = "txtLightRange";
            this.txtLightRange.Size = new System.Drawing.Size(225, 20);
            this.txtLightRange.TabIndex = 33;
            this.txtLightRange.TextChanged += new System.EventHandler(this.txtLightRange_TextChanged);
            // 
            // scrlLightIntensity
            // 
            this.scrlLightIntensity.LargeChange = 1000;
            this.scrlLightIntensity.Location = new System.Drawing.Point(3, 121);
            this.scrlLightIntensity.Maximum = 10000;
            this.scrlLightIntensity.Minimum = 1;
            this.scrlLightIntensity.Name = "scrlLightIntensity";
            this.scrlLightIntensity.Size = new System.Drawing.Size(225, 17);
            this.scrlLightIntensity.TabIndex = 32;
            this.scrlLightIntensity.Value = 1;
            this.scrlLightIntensity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlLightIntensity_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Intensity:";
            // 
            // txtLightIntensity
            // 
            this.txtLightIntensity.Location = new System.Drawing.Point(3, 98);
            this.txtLightIntensity.Name = "txtLightIntensity";
            this.txtLightIntensity.Size = new System.Drawing.Size(225, 20);
            this.txtLightIntensity.TabIndex = 30;
            this.txtLightIntensity.TextChanged += new System.EventHandler(this.txtLightIntensity_TextChanged);
            // 
            // txtLightOffsetY
            // 
            this.txtLightOffsetY.Location = new System.Drawing.Point(3, 59);
            this.txtLightOffsetY.Name = "txtLightOffsetY";
            this.txtLightOffsetY.Size = new System.Drawing.Size(114, 20);
            this.txtLightOffsetY.TabIndex = 29;
            this.txtLightOffsetY.TextChanged += new System.EventHandler(this.txtLightOffsetX_TextChanged);
            // 
            // txtLightOffsetX
            // 
            this.txtLightOffsetX.Location = new System.Drawing.Point(3, 20);
            this.txtLightOffsetX.Name = "txtLightOffsetX";
            this.txtLightOffsetX.Size = new System.Drawing.Size(114, 20);
            this.txtLightOffsetX.TabIndex = 28;
            this.txtLightOffsetX.TextChanged += new System.EventHandler(this.txtLightOffsetX_TextChanged);
            // 
            // lblOffsetY
            // 
            this.lblOffsetY.AutoSize = true;
            this.lblOffsetY.Location = new System.Drawing.Point(3, 43);
            this.lblOffsetY.Name = "lblOffsetY";
            this.lblOffsetY.Size = new System.Drawing.Size(48, 13);
            this.lblOffsetY.TabIndex = 27;
            this.lblOffsetY.Text = "Offset Y:";
            // 
            // lblOffsetX
            // 
            this.lblOffsetX.AutoSize = true;
            this.lblOffsetX.Location = new System.Drawing.Point(4, 4);
            this.lblOffsetX.Name = "lblOffsetX";
            this.lblOffsetX.Size = new System.Drawing.Size(48, 13);
            this.lblOffsetX.TabIndex = 26;
            this.lblOffsetX.Text = "Offset X:";
            // 
            // btnLightEditorRevert
            // 
            this.btnLightEditorRevert.Location = new System.Drawing.Point(3, 227);
            this.btnLightEditorRevert.Name = "btnLightEditorRevert";
            this.btnLightEditorRevert.Size = new System.Drawing.Size(75, 23);
            this.btnLightEditorRevert.TabIndex = 25;
            this.btnLightEditorRevert.Text = "Revert";
            this.btnLightEditorRevert.UseVisualStyleBackColor = true;
            this.btnLightEditorRevert.Click += new System.EventHandler(this.btnLightEditorRevert_Click);
            // 
            // btnLightEditorClose
            // 
            this.btnLightEditorClose.Location = new System.Drawing.Point(153, 227);
            this.btnLightEditorClose.Name = "btnLightEditorClose";
            this.btnLightEditorClose.Size = new System.Drawing.Size(75, 23);
            this.btnLightEditorClose.TabIndex = 24;
            this.btnLightEditorClose.Text = "Close";
            this.btnLightEditorClose.UseVisualStyleBackColor = true;
            this.btnLightEditorClose.Click += new System.EventHandler(this.btnLightEditorClose_Click);
            // 
            // tabEvents
            // 
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(267, 368);
            this.tabEvents.TabIndex = 3;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // tabNPCs
            // 
            this.tabNPCs.Controls.Add(this.grpManage);
            this.tabNPCs.Controls.Add(this.grpSpawnLoc);
            this.tabNPCs.Controls.Add(this.lstMapNpcs);
            this.tabNPCs.Location = new System.Drawing.Point(4, 22);
            this.tabNPCs.Name = "tabNPCs";
            this.tabNPCs.Size = new System.Drawing.Size(267, 368);
            this.tabNPCs.TabIndex = 4;
            this.tabNPCs.Text = "NPCs";
            this.tabNPCs.UseVisualStyleBackColor = true;
            // 
            // grpManage
            // 
            this.grpManage.Controls.Add(this.btnRemoveMapNpc);
            this.grpManage.Controls.Add(this.btnAddMapNpc);
            this.grpManage.Controls.Add(this.cmbNpc);
            this.grpManage.Location = new System.Drawing.Point(5, 274);
            this.grpManage.Name = "grpManage";
            this.grpManage.Size = new System.Drawing.Size(259, 85);
            this.grpManage.TabIndex = 12;
            this.grpManage.TabStop = false;
            this.grpManage.Text = "Add/Remove Map NPCs";
            // 
            // btnRemoveMapNpc
            // 
            this.btnRemoveMapNpc.Location = new System.Drawing.Point(147, 47);
            this.btnRemoveMapNpc.Name = "btnRemoveMapNpc";
            this.btnRemoveMapNpc.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMapNpc.TabIndex = 6;
            this.btnRemoveMapNpc.Text = "Remove";
            this.btnRemoveMapNpc.UseVisualStyleBackColor = true;
            this.btnRemoveMapNpc.Click += new System.EventHandler(this.btnRemoveMapNpc_Click);
            // 
            // btnAddMapNpc
            // 
            this.btnAddMapNpc.Location = new System.Drawing.Point(26, 47);
            this.btnAddMapNpc.Name = "btnAddMapNpc";
            this.btnAddMapNpc.Size = new System.Drawing.Size(75, 23);
            this.btnAddMapNpc.TabIndex = 5;
            this.btnAddMapNpc.Text = "Add";
            this.btnAddMapNpc.UseVisualStyleBackColor = true;
            this.btnAddMapNpc.Click += new System.EventHandler(this.btnAddMapNpc_Click);
            // 
            // cmbNpc
            // 
            this.cmbNpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNpc.FormattingEnabled = true;
            this.cmbNpc.Location = new System.Drawing.Point(6, 18);
            this.cmbNpc.Name = "cmbNpc";
            this.cmbNpc.Size = new System.Drawing.Size(247, 21);
            this.cmbNpc.TabIndex = 4;
            this.cmbNpc.SelectedIndexChanged += new System.EventHandler(this.cmbNpc_SelectedIndexChanged);
            // 
            // grpSpawnLoc
            // 
            this.grpSpawnLoc.Controls.Add(this.cmbDir);
            this.grpSpawnLoc.Controls.Add(this.lblDir);
            this.grpSpawnLoc.Controls.Add(this.rbRandom);
            this.grpSpawnLoc.Controls.Add(this.rbDeclared);
            this.grpSpawnLoc.Location = new System.Drawing.Point(3, 180);
            this.grpSpawnLoc.Name = "grpSpawnLoc";
            this.grpSpawnLoc.Size = new System.Drawing.Size(259, 81);
            this.grpSpawnLoc.TabIndex = 11;
            this.grpSpawnLoc.TabStop = false;
            this.grpSpawnLoc.Text = "Spawn Location: Random";
            // 
            // cmbDir
            // 
            this.cmbDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDir.FormattingEnabled = true;
            this.cmbDir.Items.AddRange(new object[] {
            "Random",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.cmbDir.Location = new System.Drawing.Point(5, 54);
            this.cmbDir.Name = "cmbDir";
            this.cmbDir.Size = new System.Drawing.Size(248, 21);
            this.cmbDir.TabIndex = 3;
            this.cmbDir.SelectedIndexChanged += new System.EventHandler(this.cmbDir_SelectedIndexChanged);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(5, 40);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 2;
            this.lblDir.Text = "Direction:";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Location = new System.Drawing.Point(117, 20);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(65, 17);
            this.rbRandom.TabIndex = 1;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.Click += new System.EventHandler(this.rbRandom_Click);
            // 
            // rbDeclared
            // 
            this.rbDeclared.AutoSize = true;
            this.rbDeclared.Location = new System.Drawing.Point(9, 20);
            this.rbDeclared.Name = "rbDeclared";
            this.rbDeclared.Size = new System.Drawing.Size(68, 17);
            this.rbDeclared.TabIndex = 0;
            this.rbDeclared.Text = "Declared";
            this.rbDeclared.UseVisualStyleBackColor = true;
            // 
            // lstMapNpcs
            // 
            this.lstMapNpcs.FormattingEnabled = true;
            this.lstMapNpcs.Location = new System.Drawing.Point(3, 3);
            this.lstMapNpcs.Name = "lstMapNpcs";
            this.lstMapNpcs.Size = new System.Drawing.Size(259, 173);
            this.lstMapNpcs.TabIndex = 10;
            this.lstMapNpcs.Click += new System.EventHandler(this.lstMapNpcs_Click);
            // 
            // frmMapLayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(298, 400);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HideOnClose = true;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "frmMapLayers";
            this.Text = "Map Layers";
            this.DockStateChanged += new System.EventHandler(this.frmMapLayers_DockStateChanged);
            this.tabControl.ResumeLayout(false);
            this.tabTiles.ResumeLayout(false);
            this.tabTiles.PerformLayout();
            this.pnlTilesetContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTileset)).EndInit();
            this.tabAttributes.ResumeLayout(false);
            this.tabAttributes.PerformLayout();
            this.grpResource.ResumeLayout(false);
            this.grpResource.PerformLayout();
            this.grpSound.ResumeLayout(false);
            this.grpSound.PerformLayout();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            this.grpWarp.ResumeLayout(false);
            this.grpWarp.PerformLayout();
            this.grpZDimension.ResumeLayout(false);
            this.grpGateway.ResumeLayout(false);
            this.grpGateway.PerformLayout();
            this.grpDimBlock.ResumeLayout(false);
            this.grpDimBlock.PerformLayout();
            this.tabLights.ResumeLayout(false);
            this.pnlLight.ResumeLayout(false);
            this.pnlLight.PerformLayout();
            this.tabNPCs.ResumeLayout(false);
            this.grpManage.ResumeLayout(false);
            this.grpSpawnLoc.ResumeLayout(false);
            this.grpSpawnLoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabTiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTilesetContainer;
        public System.Windows.Forms.PictureBox picTileset;
        private System.Windows.Forms.ComboBox cmbAutotile;
        public System.Windows.Forms.ComboBox cmbTilesets;
        public System.Windows.Forms.TabPage tabAttributes;
        public System.Windows.Forms.TabPage tabLights;
        public System.Windows.Forms.TabPage tabEvents;
        public System.Windows.Forms.Panel pnlLight;
        public System.Windows.Forms.HScrollBar scrlLightRange;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtLightRange;
        public System.Windows.Forms.HScrollBar scrlLightIntensity;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtLightIntensity;
        public System.Windows.Forms.TextBox txtLightOffsetY;
        public System.Windows.Forms.TextBox txtLightOffsetX;
        private System.Windows.Forms.Label lblOffsetY;
        private System.Windows.Forms.Label lblOffsetX;
        private System.Windows.Forms.Button btnLightEditorRevert;
        private System.Windows.Forms.Button btnLightEditorClose;
        private System.Windows.Forms.RadioButton rbResource;
        private System.Windows.Forms.RadioButton rbSound;
        private System.Windows.Forms.RadioButton rbWarp;
        private System.Windows.Forms.RadioButton rbNPCAvoid;
        private System.Windows.Forms.RadioButton rbZDimension;
        private System.Windows.Forms.RadioButton rbItem;
        private System.Windows.Forms.RadioButton rbBlocked;
        private System.Windows.Forms.GroupBox grpResource;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.HScrollBar scrlResource;
        private System.Windows.Forms.GroupBox grpSound;
        public System.Windows.Forms.ComboBox cmbMapAttributeSound;
        private System.Windows.Forms.Label lblSoundDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar scrlSoundDistance;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Label lblMaxItemAmount;
        private System.Windows.Forms.Label lblMapItem;
        private System.Windows.Forms.HScrollBar scrlMaxItemVal;
        public System.Windows.Forms.HScrollBar scrlMapItem;
        private System.Windows.Forms.GroupBox grpWarp;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblMap;
        public System.Windows.Forms.HScrollBar scrlX;
        public System.Windows.Forms.HScrollBar scrlY;
        public System.Windows.Forms.HScrollBar scrlMap;
        private System.Windows.Forms.GroupBox grpZDimension;
        private System.Windows.Forms.GroupBox grpGateway;
        private System.Windows.Forms.RadioButton rbGateway2;
        private System.Windows.Forms.RadioButton rbGateway1;
        private System.Windows.Forms.RadioButton rbGatewayNone;
        private System.Windows.Forms.GroupBox grpDimBlock;
        private System.Windows.Forms.RadioButton rbBlock2;
        private System.Windows.Forms.RadioButton rbBlock1;
        private System.Windows.Forms.RadioButton rbBlockNone;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbMapLayer;
        private System.Windows.Forms.TabPage tabNPCs;
        private System.Windows.Forms.GroupBox grpManage;
        private System.Windows.Forms.Button btnRemoveMapNpc;
        private System.Windows.Forms.Button btnAddMapNpc;
        private System.Windows.Forms.ComboBox cmbNpc;
        private System.Windows.Forms.GroupBox grpSpawnLoc;
        private System.Windows.Forms.ComboBox cmbDir;
        private System.Windows.Forms.Label lblDir;
        public System.Windows.Forms.RadioButton rbRandom;
        public System.Windows.Forms.RadioButton rbDeclared;
        public System.Windows.Forms.ListBox lstMapNpcs;

    }
}