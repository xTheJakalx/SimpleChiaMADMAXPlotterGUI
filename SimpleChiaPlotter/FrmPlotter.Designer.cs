
namespace SimpleChiaPlotter
{
    partial class FrmPlotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlotter));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlot = new System.Windows.Forms.Button();
            this.lblBuckets = new System.Windows.Forms.Label();
            this.lblPlotCount = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.textBoxBuckets = new System.Windows.Forms.TextBox();
            this.lblFinalDir = new System.Windows.Forms.Label();
            this.textBoxThreads = new System.Windows.Forms.TextBox();
            this.btnFinalDir = new System.Windows.Forms.Button();
            this.lblTempDir2 = new System.Windows.Forms.Label();
            this.lblTempDir1 = new System.Windows.Forms.Label();
            this.textBoxFinalDir = new System.Windows.Forms.TextBox();
            this.btnTempDir2 = new System.Windows.Forms.Button();
            this.btnTempDir1 = new System.Windows.Forms.Button();
            this.textBoxTempDir2 = new System.Windows.Forms.TextBox();
            this.textBoxTempDir1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBuckets3 = new System.Windows.Forms.CheckBox();
            this.textBoxBuckets3 = new System.Windows.Forms.TextBox();
            this.lblBuckets3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlotCount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxSwap = new System.Windows.Forms.CheckBox();
            this.checkBoxWait = new System.Windows.Forms.CheckBox();
            this.lblTmpDir1Info = new System.Windows.Forms.Label();
            this.checkBox2ndTempDir = new System.Windows.Forms.CheckBox();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxPoolPublicKey = new System.Windows.Forms.TextBox();
            this.lblFarmerPublicKey = new System.Windows.Forms.Label();
            this.textBoxFarmerPublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuyMeACoffee = new System.Windows.Forms.Button();
            this.lblPlotterLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxPublicPoolKey = new System.Windows.Forms.CheckBox();
            this.checkBoxNFTAddress = new System.Windows.Forms.CheckBox();
            this.textBoxNFTAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(850, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(672, 342);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(127, 62);
            this.btnPlot.TabIndex = 2;
            this.btnPlot.Text = "Build Plots";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // lblBuckets
            // 
            this.lblBuckets.AutoSize = true;
            this.lblBuckets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuckets.Location = new System.Drawing.Point(5, 132);
            this.lblBuckets.Name = "lblBuckets";
            this.lblBuckets.Size = new System.Drawing.Size(101, 13);
            this.lblBuckets.TabIndex = 10;
            this.lblBuckets.Text = "Num. of Buckets";
            // 
            // lblPlotCount
            // 
            this.lblPlotCount.AutoSize = true;
            this.lblPlotCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotCount.Location = new System.Drawing.Point(6, 16);
            this.lblPlotCount.Name = "lblPlotCount";
            this.lblPlotCount.Size = new System.Drawing.Size(66, 13);
            this.lblPlotCount.TabIndex = 12;
            this.lblPlotCount.Text = "Plot Count";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.Location = new System.Drawing.Point(6, 76);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(53, 13);
            this.lblThreads.TabIndex = 13;
            this.lblThreads.Text = "Threads";
            // 
            // textBoxBuckets
            // 
            this.textBoxBuckets.Location = new System.Drawing.Point(8, 162);
            this.textBoxBuckets.Name = "textBoxBuckets";
            this.textBoxBuckets.Size = new System.Drawing.Size(95, 20);
            this.textBoxBuckets.TabIndex = 21;
            this.textBoxBuckets.Text = "256";
            // 
            // lblFinalDir
            // 
            this.lblFinalDir.AutoSize = true;
            this.lblFinalDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDir.Location = new System.Drawing.Point(6, 166);
            this.lblFinalDir.Name = "lblFinalDir";
            this.lblFinalDir.Size = new System.Drawing.Size(129, 13);
            this.lblFinalDir.TabIndex = 15;
            this.lblFinalDir.Text = "Select Final Directory";
            // 
            // textBoxThreads
            // 
            this.textBoxThreads.Location = new System.Drawing.Point(8, 107);
            this.textBoxThreads.Name = "textBoxThreads";
            this.textBoxThreads.Size = new System.Drawing.Size(95, 20);
            this.textBoxThreads.TabIndex = 19;
            this.textBoxThreads.Text = "4";
            // 
            // btnFinalDir
            // 
            this.btnFinalDir.Location = new System.Drawing.Point(148, 182);
            this.btnFinalDir.Name = "btnFinalDir";
            this.btnFinalDir.Size = new System.Drawing.Size(75, 22);
            this.btnFinalDir.TabIndex = 23;
            this.btnFinalDir.Text = "Browse";
            this.btnFinalDir.UseVisualStyleBackColor = true;
            this.btnFinalDir.Click += new System.EventHandler(this.btnFinalDir_Click);
            // 
            // lblTempDir2
            // 
            this.lblTempDir2.AutoSize = true;
            this.lblTempDir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempDir2.Location = new System.Drawing.Point(6, 86);
            this.lblTempDir2.Name = "lblTempDir2";
            this.lblTempDir2.Size = new System.Drawing.Size(186, 13);
            this.lblTempDir2.TabIndex = 7;
            this.lblTempDir2.Text = "Select 2nd Temporary Directory";
            // 
            // lblTempDir1
            // 
            this.lblTempDir1.AutoSize = true;
            this.lblTempDir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempDir1.Location = new System.Drawing.Point(6, 24);
            this.lblTempDir1.Name = "lblTempDir1";
            this.lblTempDir1.Size = new System.Drawing.Size(161, 13);
            this.lblTempDir1.TabIndex = 6;
            this.lblTempDir1.Text = "Select Temporary Directory";
            // 
            // textBoxFinalDir
            // 
            this.textBoxFinalDir.Location = new System.Drawing.Point(9, 183);
            this.textBoxFinalDir.Name = "textBoxFinalDir";
            this.textBoxFinalDir.Size = new System.Drawing.Size(132, 20);
            this.textBoxFinalDir.TabIndex = 17;
            // 
            // btnTempDir2
            // 
            this.btnTempDir2.Location = new System.Drawing.Point(148, 142);
            this.btnTempDir2.Name = "btnTempDir2";
            this.btnTempDir2.Size = new System.Drawing.Size(75, 22);
            this.btnTempDir2.TabIndex = 24;
            this.btnTempDir2.Text = "Browse";
            this.btnTempDir2.UseVisualStyleBackColor = true;
            this.btnTempDir2.Click += new System.EventHandler(this.btnTempDir2_Click);
            // 
            // btnTempDir1
            // 
            this.btnTempDir1.Location = new System.Drawing.Point(148, 62);
            this.btnTempDir1.Name = "btnTempDir1";
            this.btnTempDir1.Size = new System.Drawing.Size(75, 22);
            this.btnTempDir1.TabIndex = 25;
            this.btnTempDir1.Text = "Browse";
            this.btnTempDir1.UseVisualStyleBackColor = true;
            this.btnTempDir1.Click += new System.EventHandler(this.btnTempDir1_Click);
            // 
            // textBoxTempDir2
            // 
            this.textBoxTempDir2.Location = new System.Drawing.Point(9, 143);
            this.textBoxTempDir2.Name = "textBoxTempDir2";
            this.textBoxTempDir2.Size = new System.Drawing.Size(132, 20);
            this.textBoxTempDir2.TabIndex = 22;
            // 
            // textBoxTempDir1
            // 
            this.textBoxTempDir1.Location = new System.Drawing.Point(9, 63);
            this.textBoxTempDir1.Name = "textBoxTempDir1";
            this.textBoxTempDir1.Size = new System.Drawing.Size(132, 20);
            this.textBoxTempDir1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxBuckets3);
            this.groupBox2.Controls.Add(this.textBoxBuckets3);
            this.groupBox2.Controls.Add(this.lblBuckets3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblPlotCount);
            this.groupBox2.Controls.Add(this.textBoxPlotCount);
            this.groupBox2.Controls.Add(this.textBoxThreads);
            this.groupBox2.Controls.Add(this.textBoxBuckets);
            this.groupBox2.Controls.Add(this.lblBuckets);
            this.groupBox2.Controls.Add(this.lblThreads);
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 248);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Setup basic settings";
            // 
            // checkBoxBuckets3
            // 
            this.checkBoxBuckets3.AutoSize = true;
            this.checkBoxBuckets3.Location = new System.Drawing.Point(11, 202);
            this.checkBoxBuckets3.Name = "checkBoxBuckets3";
            this.checkBoxBuckets3.Size = new System.Drawing.Size(107, 17);
            this.checkBoxBuckets3.TabIndex = 27;
            this.checkBoxBuckets3.Text = "Enable Buckets3";
            this.checkBoxBuckets3.UseVisualStyleBackColor = true;
            // 
            // textBoxBuckets3
            // 
            this.textBoxBuckets3.Location = new System.Drawing.Point(8, 220);
            this.textBoxBuckets3.Name = "textBoxBuckets3";
            this.textBoxBuckets3.Size = new System.Drawing.Size(95, 20);
            this.textBoxBuckets3.TabIndex = 26;
            this.textBoxBuckets3.Text = "256";
            // 
            // lblBuckets3
            // 
            this.lblBuckets3.AutoSize = true;
            this.lblBuckets3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuckets3.Location = new System.Drawing.Point(7, 188);
            this.lblBuckets3.Name = "lblBuckets3";
            this.lblBuckets3.Size = new System.Drawing.Size(122, 13);
            this.lblBuckets3.TabIndex = 25;
            this.lblBuckets3.Text = "Phase [3-4] Buckets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "(default = 256)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "(default = 4)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "(default = 1, -1 = infinite)";
            // 
            // textBoxPlotCount
            // 
            this.textBoxPlotCount.Location = new System.Drawing.Point(8, 48);
            this.textBoxPlotCount.Name = "textBoxPlotCount";
            this.textBoxPlotCount.Size = new System.Drawing.Size(95, 20);
            this.textBoxPlotCount.TabIndex = 18;
            this.textBoxPlotCount.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxSwap);
            this.groupBox3.Controls.Add(this.checkBoxWait);
            this.groupBox3.Controls.Add(this.lblTmpDir1Info);
            this.groupBox3.Controls.Add(this.checkBox2ndTempDir);
            this.groupBox3.Controls.Add(this.lblTempDir1);
            this.groupBox3.Controls.Add(this.textBoxTempDir1);
            this.groupBox3.Controls.Add(this.textBoxTempDir2);
            this.groupBox3.Controls.Add(this.lblFinalDir);
            this.groupBox3.Controls.Add(this.btnTempDir1);
            this.groupBox3.Controls.Add(this.btnFinalDir);
            this.groupBox3.Controls.Add(this.btnTempDir2);
            this.groupBox3.Controls.Add(this.textBoxFinalDir);
            this.groupBox3.Controls.Add(this.lblTempDir2);
            this.groupBox3.Location = new System.Drawing.Point(148, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 248);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Select Directories";
            // 
            // checkBoxSwap
            // 
            this.checkBoxSwap.AutoSize = true;
            this.checkBoxSwap.Location = new System.Drawing.Point(12, 123);
            this.checkBoxSwap.Name = "checkBoxSwap";
            this.checkBoxSwap.Size = new System.Drawing.Size(446, 17);
            this.checkBoxSwap.TabIndex = 29;
            this.checkBoxSwap.Text = "Swap temporary drives after every plot (evenly distribute drive wear, no need for" +
    " ramdrive)";
            this.checkBoxSwap.UseVisualStyleBackColor = true;
            // 
            // checkBoxWait
            // 
            this.checkBoxWait.AutoSize = true;
            this.checkBoxWait.Location = new System.Drawing.Point(12, 209);
            this.checkBoxWait.Name = "checkBoxWait";
            this.checkBoxWait.Size = new System.Drawing.Size(237, 17);
            this.checkBoxWait.TabIndex = 28;
            this.checkBoxWait.Text = "Wait for plot copy to finish before proceeding";
            this.checkBoxWait.UseVisualStyleBackColor = true;
            // 
            // lblTmpDir1Info
            // 
            this.lblTmpDir1Info.AutoSize = true;
            this.lblTmpDir1Info.Location = new System.Drawing.Point(12, 43);
            this.lblTmpDir1Info.Name = "lblTmpDir1Info";
            this.lblTmpDir1Info.Size = new System.Drawing.Size(310, 13);
            this.lblTmpDir1Info.TabIndex = 27;
            this.lblTmpDir1Info.Text = "needs about 220 GiB space, it will handle about 25% of all writes";
            // 
            // checkBox2ndTempDir
            // 
            this.checkBox2ndTempDir.AutoSize = true;
            this.checkBox2ndTempDir.Location = new System.Drawing.Point(12, 103);
            this.checkBox2ndTempDir.Name = "checkBox2ndTempDir";
            this.checkBox2ndTempDir.Size = new System.Drawing.Size(430, 17);
            this.checkBox2ndTempDir.TabIndex = 26;
            this.checkBox2ndTempDir.Text = "Enable (needs about 110 GiB space and ideally is a RAM drive handles 75% of write" +
    "s)";
            this.checkBox2ndTempDir.UseVisualStyleBackColor = true;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Location = new System.Drawing.Point(12, 76);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(818, 39);
            this.lblMainInfo.TabIndex = 10;
            this.lblMainInfo.Text = resources.GetString("lblMainInfo.Text");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxNFTAddress);
            this.groupBox4.Controls.Add(this.checkBoxNFTAddress);
            this.groupBox4.Controls.Add(this.checkBoxPublicPoolKey);
            this.groupBox4.Controls.Add(this.textBoxPoolPublicKey);
            this.groupBox4.Controls.Add(this.lblFarmerPublicKey);
            this.groupBox4.Controls.Add(this.textBoxFarmerPublicKey);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(824, 163);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "1. Public Keys and NFT Address";
            // 
            // textBoxPoolPublicKey
            // 
            this.textBoxPoolPublicKey.Location = new System.Drawing.Point(127, 98);
            this.textBoxPoolPublicKey.Name = "textBoxPoolPublicKey";
            this.textBoxPoolPublicKey.Size = new System.Drawing.Size(660, 20);
            this.textBoxPoolPublicKey.TabIndex = 6;
            // 
            // lblFarmerPublicKey
            // 
            this.lblFarmerPublicKey.AutoSize = true;
            this.lblFarmerPublicKey.Location = new System.Drawing.Point(26, 36);
            this.lblFarmerPublicKey.Name = "lblFarmerPublicKey";
            this.lblFarmerPublicKey.Size = new System.Drawing.Size(92, 13);
            this.lblFarmerPublicKey.TabIndex = 31;
            this.lblFarmerPublicKey.Text = "Farmer Public Key";
            // 
            // textBoxFarmerPublicKey
            // 
            this.textBoxFarmerPublicKey.Location = new System.Drawing.Point(127, 33);
            this.textBoxFarmerPublicKey.Name = "textBoxFarmerPublicKey";
            this.textBoxFarmerPublicKey.Size = new System.Drawing.Size(660, 20);
            this.textBoxFarmerPublicKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use this section to enter your public Farmer and Pool keys - ALWAYS copy and past" +
    "e your keys! (you might accidentally type the wrong key if you don\'t)\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Does this app help you out?\r\n";
            // 
            // btnBuyMeACoffee
            // 
            this.btnBuyMeACoffee.AutoSize = true;
            this.btnBuyMeACoffee.BackgroundImage = global::SimpleChiaPlotter.Properties.Resources.BuyMeACoffee;
            this.btnBuyMeACoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuyMeACoffee.Location = new System.Drawing.Point(616, 439);
            this.btnBuyMeACoffee.Name = "btnBuyMeACoffee";
            this.btnBuyMeACoffee.Size = new System.Drawing.Size(222, 67);
            this.btnBuyMeACoffee.TabIndex = 30;
            this.btnBuyMeACoffee.UseVisualStyleBackColor = true;
            this.btnBuyMeACoffee.Click += new System.EventHandler(this.btnBuyMeACoffee_Click);
            // 
            // lblPlotterLink
            // 
            this.lblPlotterLink.AutoSize = true;
            this.lblPlotterLink.Location = new System.Drawing.Point(715, 89);
            this.lblPlotterLink.Name = "lblPlotterLink";
            this.lblPlotterLink.Size = new System.Drawing.Size(28, 13);
            this.lblPlotterLink.TabIndex = 31;
            this.lblPlotterLink.TabStop = true;
            this.lblPlotterLink.Text = "here";
            this.lblPlotterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPlotterLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Compatable with MADMAX plotter 0.1.1";
            // 
            // checkBoxPublicPoolKey
            // 
            this.checkBoxPublicPoolKey.AutoSize = true;
            this.checkBoxPublicPoolKey.Location = new System.Drawing.Point(21, 100);
            this.checkBoxPublicPoolKey.Name = "checkBoxPublicPoolKey";
            this.checkBoxPublicPoolKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxPublicPoolKey.Size = new System.Drawing.Size(100, 17);
            this.checkBoxPublicPoolKey.TabIndex = 33;
            this.checkBoxPublicPoolKey.Text = "Pool Public Key";
            this.checkBoxPublicPoolKey.UseVisualStyleBackColor = true;
            this.checkBoxPublicPoolKey.CheckedChanged += new System.EventHandler(this.checkBoxPublicPoolKey_CheckedChanged);
            // 
            // checkBoxNFTAddress
            // 
            this.checkBoxNFTAddress.AutoSize = true;
            this.checkBoxNFTAddress.Location = new System.Drawing.Point(33, 123);
            this.checkBoxNFTAddress.Name = "checkBoxNFTAddress";
            this.checkBoxNFTAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxNFTAddress.Size = new System.Drawing.Size(88, 17);
            this.checkBoxNFTAddress.TabIndex = 34;
            this.checkBoxNFTAddress.Text = "NFT Address";
            this.checkBoxNFTAddress.UseVisualStyleBackColor = true;
            this.checkBoxNFTAddress.CheckedChanged += new System.EventHandler(this.checkBoxNFTAddress_CheckedChanged);
            // 
            // textBoxNFTAddress
            // 
            this.textBoxNFTAddress.Location = new System.Drawing.Point(127, 120);
            this.textBoxNFTAddress.Name = "textBoxNFTAddress";
            this.textBoxNFTAddress.Size = new System.Drawing.Size(660, 20);
            this.textBoxNFTAddress.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(490, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "NFT contract address and pool key are mutually exclusive - meaning you can only u" +
    "se one or the other";
            // 
            // FrmPlotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 558);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPlotterLink);
            this.Controls.Add(this.btnBuyMeACoffee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPlotter";
            this.Text = "Simple Chia MADMAX plotter GUI";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Label lblBuckets;
        private System.Windows.Forms.Label lblPlotCount;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.TextBox textBoxBuckets;
        private System.Windows.Forms.Label lblFinalDir;
        private System.Windows.Forms.TextBox textBoxThreads;
        private System.Windows.Forms.Button btnFinalDir;
        private System.Windows.Forms.Label lblTempDir2;
        private System.Windows.Forms.Label lblTempDir1;
        private System.Windows.Forms.TextBox textBoxFinalDir;
        private System.Windows.Forms.Button btnTempDir2;
        private System.Windows.Forms.Button btnTempDir1;
        private System.Windows.Forms.TextBox textBoxTempDir2;
        private System.Windows.Forms.TextBox textBoxTempDir1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxPlotCount;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.CheckBox checkBox2ndTempDir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxPoolPublicKey;
        private System.Windows.Forms.TextBox textBoxFarmerPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuyMeACoffee;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label lblFarmerPublicKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTmpDir1Info;
        private System.Windows.Forms.LinkLabel lblPlotterLink;
        private System.Windows.Forms.TextBox textBoxBuckets3;
        private System.Windows.Forms.Label lblBuckets3;
        private System.Windows.Forms.CheckBox checkBoxWait;
        private System.Windows.Forms.CheckBox checkBoxSwap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxBuckets3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNFTAddress;
        private System.Windows.Forms.CheckBox checkBoxNFTAddress;
        private System.Windows.Forms.CheckBox checkBoxPublicPoolKey;
    }
}