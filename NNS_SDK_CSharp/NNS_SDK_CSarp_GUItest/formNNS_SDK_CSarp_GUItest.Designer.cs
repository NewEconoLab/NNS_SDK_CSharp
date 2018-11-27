namespace NNS_SDK_CSarp_GUItest
{
    partial class formNNS_SDK_CSarp_GUItest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butResetDoAddr = new System.Windows.Forms.Button();
            this.txtDoAddr = new System.Windows.Forms.TextBox();
            this.txtWIF = new System.Windows.Forms.TextBox();
            this.labPubKey = new System.Windows.Forms.Label();
            this.labAddr = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.cmbnelApiUrl = new System.Windows.Forms.ComboBox();
            this.txtInfoShow = new System.Windows.Forms.TextBox();
            this.txtTXIDshow = new System.Windows.Forms.TextBox();
            this.lbTX = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMinuteOfDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNNSRegisterSellhash = new System.Windows.Forms.TextBox();
            this.pbTimerForDay = new System.Windows.Forms.ProgressBar();
            this.labTimeForDay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butGetDomainUseState = new System.Windows.Forms.Button();
            this.butDoRenewDomain = new System.Windows.Forms.Button();
            this.butDoCollectDomain = new System.Windows.Forms.Button();
            this.butDoBidSettlement = new System.Windows.Forms.Button();
            this.labGetBalanceOfBid = new System.Windows.Forms.Label();
            this.butGetBalanceOfBid = new System.Windows.Forms.Button();
            this.txtDoBid = new System.Windows.Forms.TextBox();
            this.butDoBid = new System.Windows.Forms.Button();
            this.butGetAuctionStateByFullhash = new System.Windows.Forms.Button();
            this.butStartAuction = new System.Windows.Forms.Button();
            this.txtBlcokTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labGetCGASBanlance = new System.Windows.Forms.Label();
            this.butGetCGASBanlance = new System.Windows.Forms.Button();
            this.txtCGASout = new System.Windows.Forms.TextBox();
            this.butCGASout = new System.Windows.Forms.Button();
            this.butCGASin_2 = new System.Windows.Forms.Button();
            this.txtCGASin = new System.Windows.Forms.TextBox();
            this.butCGASin_1 = new System.Windows.Forms.Button();
            this.labBanlance = new System.Windows.Forms.Label();
            this.butGetBanlance = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNNScenterHash = new System.Windows.Forms.TextBox();
            this.butOwnerSetResolver = new System.Windows.Forms.Button();
            this.cbResolver = new System.Windows.Forms.ComboBox();
            this.butOwnerSetRegister = new System.Windows.Forms.Button();
            this.cbRegister = new System.Windows.Forms.ComboBox();
            this.txtOwnerSetOwnerAddrTo = new System.Windows.Forms.TextBox();
            this.butOwnerSetOwner = new System.Windows.Forms.Button();
            this.butGetOwnerInfo = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labSarChash = new System.Windows.Forms.Label();
            this.txtNNSresolverHash = new System.Windows.Forms.TextBox();
            this.txtSubDomainForResolve = new System.Windows.Forms.TextBox();
            this.txtResolveAddr = new System.Windows.Forms.TextBox();
            this.butSetResolverData = new System.Windows.Forms.Button();
            this.butResolve = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtSubDomainOwnerAddr = new System.Windows.Forms.TextBox();
            this.txtSubDomain = new System.Windows.Forms.TextBox();
            this.butSetSubDomainOwner = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butRevoke = new System.Windows.Forms.Button();
            this.butGetCreditInfo = new System.Windows.Forms.Button();
            this.butDoAuthenticate = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.butDoBuy = new System.Windows.Forms.Button();
            this.butDiscontinue = new System.Windows.Forms.Button();
            this.butGetFixedSellingInfo = new System.Windows.Forms.Button();
            this.txtLaunch = new System.Windows.Forms.TextBox();
            this.butLaunch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butNNCoutAll = new System.Windows.Forms.Button();
            this.labGetNNCbalance = new System.Windows.Forms.Label();
            this.butGetNNCbalance = new System.Windows.Forms.Button();
            this.txtNNCout = new System.Windows.Forms.TextBox();
            this.butNNCout = new System.Windows.Forms.Button();
            this.butDoNNCinStep1 = new System.Windows.Forms.Button();
            this.txtDoNNCinStep0 = new System.Windows.Forms.TextBox();
            this.butDoNNCinStep0 = new System.Windows.Forms.Button();
            this.labGetDEXfixedSellingBalance = new System.Windows.Forms.Label();
            this.butGetDEXfixedSellingBalance = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNNChash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCGAShash = new System.Windows.Forms.TextBox();
            this.labBlockCount = new System.Windows.Forms.Label();
            this.timerOneSecond = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtNNS_DEX_fixedSellingHash = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // butResetDoAddr
            // 
            this.butResetDoAddr.Location = new System.Drawing.Point(259, 76);
            this.butResetDoAddr.Name = "butResetDoAddr";
            this.butResetDoAddr.Size = new System.Drawing.Size(75, 23);
            this.butResetDoAddr.TabIndex = 41;
            this.butResetDoAddr.Text = "重置";
            this.butResetDoAddr.UseVisualStyleBackColor = true;
            // 
            // txtDoAddr
            // 
            this.txtDoAddr.Location = new System.Drawing.Point(12, 76);
            this.txtDoAddr.Name = "txtDoAddr";
            this.txtDoAddr.Size = new System.Drawing.Size(240, 21);
            this.txtDoAddr.TabIndex = 40;
            // 
            // txtWIF
            // 
            this.txtWIF.Location = new System.Drawing.Point(12, 12);
            this.txtWIF.Name = "txtWIF";
            this.txtWIF.PasswordChar = '*';
            this.txtWIF.Size = new System.Drawing.Size(335, 21);
            this.txtWIF.TabIndex = 37;
            this.txtWIF.Text = "KwKoVVb83HMWKJbxtVaHsS5MRfJVZK3gHigJAcuyepMAVmUU2B94";
            this.txtWIF.TextChanged += new System.EventHandler(this.txtPriKey_TextChanged);
            // 
            // labPubKey
            // 
            this.labPubKey.AutoSize = true;
            this.labPubKey.Location = new System.Drawing.Point(10, 40);
            this.labPubKey.Name = "labPubKey";
            this.labPubKey.Size = new System.Drawing.Size(59, 12);
            this.labPubKey.TabIndex = 38;
            this.labPubKey.Text = "labPubKey";
            // 
            // labAddr
            // 
            this.labAddr.AutoSize = true;
            this.labAddr.Location = new System.Drawing.Point(10, 59);
            this.labAddr.Name = "labAddr";
            this.labAddr.Size = new System.Drawing.Size(47, 12);
            this.labAddr.TabIndex = 39;
            this.labAddr.Text = "labAddr";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(379, 76);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(240, 21);
            this.txtDomain.TabIndex = 36;
            this.txtDomain.Text = "qmz.test";
            // 
            // cmbnelApiUrl
            // 
            this.cmbnelApiUrl.FormattingEnabled = true;
            this.cmbnelApiUrl.Items.AddRange(new object[] {
            "https://api.nel.group/api/testnet",
            "https://api.nel.group/api/mainnet"});
            this.cmbnelApiUrl.Location = new System.Drawing.Point(379, 12);
            this.cmbnelApiUrl.Name = "cmbnelApiUrl";
            this.cmbnelApiUrl.Size = new System.Drawing.Size(295, 20);
            this.cmbnelApiUrl.TabIndex = 42;
            this.cmbnelApiUrl.SelectedIndexChanged += new System.EventHandler(this.cmbnelApiUrl_SelectedIndexChanged);
            // 
            // txtInfoShow
            // 
            this.txtInfoShow.Location = new System.Drawing.Point(533, 375);
            this.txtInfoShow.Multiline = true;
            this.txtInfoShow.Name = "txtInfoShow";
            this.txtInfoShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfoShow.Size = new System.Drawing.Size(473, 220);
            this.txtInfoShow.TabIndex = 47;
            // 
            // txtTXIDshow
            // 
            this.txtTXIDshow.Location = new System.Drawing.Point(533, 341);
            this.txtTXIDshow.Name = "txtTXIDshow";
            this.txtTXIDshow.Size = new System.Drawing.Size(473, 21);
            this.txtTXIDshow.TabIndex = 46;
            // 
            // lbTX
            // 
            this.lbTX.FormattingEnabled = true;
            this.lbTX.ItemHeight = 12;
            this.lbTX.Location = new System.Drawing.Point(533, 134);
            this.lbTX.Name = "lbTX";
            this.lbTX.Size = new System.Drawing.Size(473, 196);
            this.lbTX.TabIndex = 45;
            this.lbTX.SelectedIndexChanged += new System.EventHandler(this.lbTX_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 482);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMinuteOfDay);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNNSRegisterSellhash);
            this.tabPage1.Controls.Add(this.pbTimerForDay);
            this.tabPage1.Controls.Add(this.labTimeForDay);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.txtBlcokTime);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "拍卖注册器";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMinuteOfDay
            // 
            this.txtMinuteOfDay.Location = new System.Drawing.Point(16, 217);
            this.txtMinuteOfDay.Name = "txtMinuteOfDay";
            this.txtMinuteOfDay.Size = new System.Drawing.Size(77, 21);
            this.txtMinuteOfDay.TabIndex = 43;
            this.txtMinuteOfDay.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "合约HASH";
            // 
            // txtNNSRegisterSellhash
            // 
            this.txtNNSRegisterSellhash.Location = new System.Drawing.Point(150, 4);
            this.txtNNSRegisterSellhash.Name = "txtNNSRegisterSellhash";
            this.txtNNSRegisterSellhash.Size = new System.Drawing.Size(256, 21);
            this.txtNNSRegisterSellhash.TabIndex = 41;
            this.txtNNSRegisterSellhash.Text = "5fd8c2aed0eec0fa103f6fba16748b453baf5b2e";
            // 
            // pbTimerForDay
            // 
            this.pbTimerForDay.Location = new System.Drawing.Point(323, 217);
            this.pbTimerForDay.Maximum = 5;
            this.pbTimerForDay.Name = "pbTimerForDay";
            this.pbTimerForDay.Size = new System.Drawing.Size(147, 24);
            this.pbTimerForDay.TabIndex = 33;
            // 
            // labTimeForDay
            // 
            this.labTimeForDay.AutoSize = true;
            this.labTimeForDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labTimeForDay.Location = new System.Drawing.Point(196, 220);
            this.labTimeForDay.Name = "labTimeForDay";
            this.labTimeForDay.Size = new System.Drawing.Size(83, 12);
            this.labTimeForDay.TabIndex = 32;
            this.labTimeForDay.Text = "labTimeForDay";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butGetDomainUseState);
            this.groupBox2.Controls.Add(this.butDoRenewDomain);
            this.groupBox2.Controls.Add(this.butDoCollectDomain);
            this.groupBox2.Controls.Add(this.butDoBidSettlement);
            this.groupBox2.Controls.Add(this.labGetBalanceOfBid);
            this.groupBox2.Controls.Add(this.butGetBalanceOfBid);
            this.groupBox2.Controls.Add(this.txtDoBid);
            this.groupBox2.Controls.Add(this.butDoBid);
            this.groupBox2.Controls.Add(this.butGetAuctionStateByFullhash);
            this.groupBox2.Controls.Add(this.butStartAuction);
            this.groupBox2.Location = new System.Drawing.Point(9, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 206);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "竞拍操作";
            // 
            // butGetDomainUseState
            // 
            this.butGetDomainUseState.Location = new System.Drawing.Point(82, 163);
            this.butGetDomainUseState.Name = "butGetDomainUseState";
            this.butGetDomainUseState.Size = new System.Drawing.Size(158, 23);
            this.butGetDomainUseState.TabIndex = 18;
            this.butGetDomainUseState.Text = "获取域名使用状态";
            this.butGetDomainUseState.UseVisualStyleBackColor = true;
            this.butGetDomainUseState.Click += new System.EventHandler(this.butGetDomainUseState_Click);
            // 
            // butDoRenewDomain
            // 
            this.butDoRenewDomain.Location = new System.Drawing.Point(82, 134);
            this.butDoRenewDomain.Name = "butDoRenewDomain";
            this.butDoRenewDomain.Size = new System.Drawing.Size(158, 23);
            this.butDoRenewDomain.TabIndex = 17;
            this.butDoRenewDomain.Text = "域名续约";
            this.butDoRenewDomain.UseVisualStyleBackColor = true;
            this.butDoRenewDomain.Click += new System.EventHandler(this.butDoRenewDomain_Click);
            // 
            // butDoCollectDomain
            // 
            this.butDoCollectDomain.Location = new System.Drawing.Point(262, 134);
            this.butDoCollectDomain.Name = "butDoCollectDomain";
            this.butDoCollectDomain.Size = new System.Drawing.Size(158, 23);
            this.butDoCollectDomain.TabIndex = 15;
            this.butDoCollectDomain.Text = "领取域名";
            this.butDoCollectDomain.UseVisualStyleBackColor = true;
            this.butDoCollectDomain.Click += new System.EventHandler(this.butDoCollectDomain_Click);
            // 
            // butDoBidSettlement
            // 
            this.butDoBidSettlement.Location = new System.Drawing.Point(262, 105);
            this.butDoBidSettlement.Name = "butDoBidSettlement";
            this.butDoBidSettlement.Size = new System.Drawing.Size(158, 23);
            this.butDoBidSettlement.TabIndex = 14;
            this.butDoBidSettlement.Text = "结算竞拍金";
            this.butDoBidSettlement.UseVisualStyleBackColor = true;
            this.butDoBidSettlement.Click += new System.EventHandler(this.butDoBidSettlement_Click);
            // 
            // labGetBalanceOfBid
            // 
            this.labGetBalanceOfBid.AutoSize = true;
            this.labGetBalanceOfBid.Location = new System.Drawing.Point(143, 76);
            this.labGetBalanceOfBid.Name = "labGetBalanceOfBid";
            this.labGetBalanceOfBid.Size = new System.Drawing.Size(113, 12);
            this.labGetBalanceOfBid.TabIndex = 13;
            this.labGetBalanceOfBid.Text = "labGetBalanceOfBid";
            // 
            // butGetBalanceOfBid
            // 
            this.butGetBalanceOfBid.Location = new System.Drawing.Point(262, 76);
            this.butGetBalanceOfBid.Name = "butGetBalanceOfBid";
            this.butGetBalanceOfBid.Size = new System.Drawing.Size(158, 23);
            this.butGetBalanceOfBid.TabIndex = 12;
            this.butGetBalanceOfBid.Text = "获取本地址全部竞拍金";
            this.butGetBalanceOfBid.UseVisualStyleBackColor = true;
            this.butGetBalanceOfBid.Click += new System.EventHandler(this.butGetBalanceOfBid_Click);
            // 
            // txtDoBid
            // 
            this.txtDoBid.Location = new System.Drawing.Point(179, 47);
            this.txtDoBid.Name = "txtDoBid";
            this.txtDoBid.Size = new System.Drawing.Size(77, 21);
            this.txtDoBid.TabIndex = 11;
            // 
            // butDoBid
            // 
            this.butDoBid.Location = new System.Drawing.Point(262, 47);
            this.butDoBid.Name = "butDoBid";
            this.butDoBid.Size = new System.Drawing.Size(75, 23);
            this.butDoBid.TabIndex = 10;
            this.butDoBid.Text = "加价";
            this.butDoBid.UseVisualStyleBackColor = true;
            this.butDoBid.Click += new System.EventHandler(this.butDoBid_Click);
            // 
            // butGetAuctionStateByFullhash
            // 
            this.butGetAuctionStateByFullhash.Location = new System.Drawing.Point(343, 18);
            this.butGetAuctionStateByFullhash.Name = "butGetAuctionStateByFullhash";
            this.butGetAuctionStateByFullhash.Size = new System.Drawing.Size(110, 23);
            this.butGetAuctionStateByFullhash.TabIndex = 2;
            this.butGetAuctionStateByFullhash.Text = "查询AuctionState";
            this.butGetAuctionStateByFullhash.UseVisualStyleBackColor = true;
            this.butGetAuctionStateByFullhash.Click += new System.EventHandler(this.butGetAuctionStateByFullhash_Click);
            // 
            // butStartAuction
            // 
            this.butStartAuction.Location = new System.Drawing.Point(262, 18);
            this.butStartAuction.Name = "butStartAuction";
            this.butStartAuction.Size = new System.Drawing.Size(75, 23);
            this.butStartAuction.TabIndex = 1;
            this.butStartAuction.Text = "开标";
            this.butStartAuction.UseVisualStyleBackColor = true;
            this.butStartAuction.Click += new System.EventHandler(this.butStartAuction_Click);
            // 
            // txtBlcokTime
            // 
            this.txtBlcokTime.Location = new System.Drawing.Point(113, 217);
            this.txtBlcokTime.Name = "txtBlcokTime";
            this.txtBlcokTime.Size = new System.Drawing.Size(77, 21);
            this.txtBlcokTime.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labGetCGASBanlance);
            this.groupBox1.Controls.Add(this.butGetCGASBanlance);
            this.groupBox1.Controls.Add(this.txtCGASout);
            this.groupBox1.Controls.Add(this.butCGASout);
            this.groupBox1.Controls.Add(this.butCGASin_2);
            this.groupBox1.Controls.Add(this.txtCGASin);
            this.groupBox1.Controls.Add(this.butCGASin_1);
            this.groupBox1.Controls.Add(this.labBanlance);
            this.groupBox1.Controls.Add(this.butGetBanlance);
            this.groupBox1.Location = new System.Drawing.Point(9, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 185);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作注册器竞拍账户";
            // 
            // labGetCGASBanlance
            // 
            this.labGetCGASBanlance.AutoSize = true;
            this.labGetCGASBanlance.Location = new System.Drawing.Point(222, 20);
            this.labGetCGASBanlance.Name = "labGetCGASBanlance";
            this.labGetCGASBanlance.Size = new System.Drawing.Size(113, 12);
            this.labGetCGASBanlance.TabIndex = 11;
            this.labGetCGASBanlance.Text = "labGetCGASBanlance";
            // 
            // butGetCGASBanlance
            // 
            this.butGetCGASBanlance.Location = new System.Drawing.Point(90, 20);
            this.butGetCGASBanlance.Name = "butGetCGASBanlance";
            this.butGetCGASBanlance.Size = new System.Drawing.Size(114, 23);
            this.butGetCGASBanlance.TabIndex = 10;
            this.butGetCGASBanlance.Text = "获取CGAS余额";
            this.butGetCGASBanlance.UseVisualStyleBackColor = true;
            this.butGetCGASBanlance.Click += new System.EventHandler(this.butGetCGASBanlance_Click);
            // 
            // txtCGASout
            // 
            this.txtCGASout.Location = new System.Drawing.Point(7, 142);
            this.txtCGASout.Name = "txtCGASout";
            this.txtCGASout.Size = new System.Drawing.Size(77, 21);
            this.txtCGASout.TabIndex = 9;
            // 
            // butCGASout
            // 
            this.butCGASout.Location = new System.Drawing.Point(90, 142);
            this.butCGASout.Name = "butCGASout";
            this.butCGASout.Size = new System.Drawing.Size(114, 23);
            this.butCGASout.TabIndex = 8;
            this.butCGASout.Text = "提取CGAS";
            this.butCGASout.UseVisualStyleBackColor = true;
            this.butCGASout.Click += new System.EventHandler(this.butCGASout_Click);
            // 
            // butCGASin_2
            // 
            this.butCGASin_2.Location = new System.Drawing.Point(90, 113);
            this.butCGASin_2.Name = "butCGASin_2";
            this.butCGASin_2.Size = new System.Drawing.Size(114, 23);
            this.butCGASin_2.TabIndex = 7;
            this.butCGASin_2.Text = "充值（验证转账）";
            this.butCGASin_2.UseVisualStyleBackColor = true;
            this.butCGASin_2.Click += new System.EventHandler(this.butCGASin_2_Click);
            // 
            // txtCGASin
            // 
            this.txtCGASin.Location = new System.Drawing.Point(7, 84);
            this.txtCGASin.Name = "txtCGASin";
            this.txtCGASin.Size = new System.Drawing.Size(77, 21);
            this.txtCGASin.TabIndex = 6;
            // 
            // butCGASin_1
            // 
            this.butCGASin_1.Location = new System.Drawing.Point(90, 84);
            this.butCGASin_1.Name = "butCGASin_1";
            this.butCGASin_1.Size = new System.Drawing.Size(114, 23);
            this.butCGASin_1.TabIndex = 4;
            this.butCGASin_1.Text = "CGAS转账注册器";
            this.butCGASin_1.UseVisualStyleBackColor = true;
            this.butCGASin_1.Click += new System.EventHandler(this.butCGASin_1_Click);
            // 
            // labBanlance
            // 
            this.labBanlance.AutoSize = true;
            this.labBanlance.Location = new System.Drawing.Point(222, 55);
            this.labBanlance.Name = "labBanlance";
            this.labBanlance.Size = new System.Drawing.Size(71, 12);
            this.labBanlance.TabIndex = 3;
            this.labBanlance.Text = "labBanlance";
            // 
            // butGetBanlance
            // 
            this.butGetBanlance.Location = new System.Drawing.Point(90, 55);
            this.butGetBanlance.Name = "butGetBanlance";
            this.butGetBanlance.Size = new System.Drawing.Size(114, 23);
            this.butGetBanlance.TabIndex = 2;
            this.butGetBanlance.Text = "获取竞拍账户余额";
            this.butGetBanlance.UseVisualStyleBackColor = true;
            this.butGetBanlance.Click += new System.EventHandler(this.butGetBanlance_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtNNScenterHash);
            this.tabPage3.Controls.Add(this.butOwnerSetResolver);
            this.tabPage3.Controls.Add(this.cbResolver);
            this.tabPage3.Controls.Add(this.butOwnerSetRegister);
            this.tabPage3.Controls.Add(this.cbRegister);
            this.tabPage3.Controls.Add(this.txtOwnerSetOwnerAddrTo);
            this.tabPage3.Controls.Add(this.butOwnerSetOwner);
            this.tabPage3.Controls.Add(this.butGetOwnerInfo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(497, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "域名中心";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "合约HASH";
            // 
            // txtNNScenterHash
            // 
            this.txtNNScenterHash.Location = new System.Drawing.Point(154, 18);
            this.txtNNScenterHash.Name = "txtNNScenterHash";
            this.txtNNScenterHash.Size = new System.Drawing.Size(256, 21);
            this.txtNNScenterHash.TabIndex = 41;
            this.txtNNScenterHash.Text = "348387116c4a75e420663277d9c02049907128c7";
            // 
            // butOwnerSetResolver
            // 
            this.butOwnerSetResolver.Location = new System.Drawing.Point(309, 196);
            this.butOwnerSetResolver.Name = "butOwnerSetResolver";
            this.butOwnerSetResolver.Size = new System.Drawing.Size(158, 23);
            this.butOwnerSetResolver.TabIndex = 37;
            this.butOwnerSetResolver.Text = "设置解析器";
            this.butOwnerSetResolver.UseVisualStyleBackColor = true;
            this.butOwnerSetResolver.Click += new System.EventHandler(this.butOwnerSetResolver_Click);
            // 
            // cbResolver
            // 
            this.cbResolver.FormattingEnabled = true;
            this.cbResolver.Items.AddRange(new object[] {
            "6e2aea28af9c5febea0774759b1b76398e3167f1"});
            this.cbResolver.Location = new System.Drawing.Point(23, 196);
            this.cbResolver.Name = "cbResolver";
            this.cbResolver.Size = new System.Drawing.Size(266, 20);
            this.cbResolver.TabIndex = 36;
            // 
            // butOwnerSetRegister
            // 
            this.butOwnerSetRegister.Location = new System.Drawing.Point(309, 159);
            this.butOwnerSetRegister.Name = "butOwnerSetRegister";
            this.butOwnerSetRegister.Size = new System.Drawing.Size(158, 23);
            this.butOwnerSetRegister.TabIndex = 35;
            this.butOwnerSetRegister.Text = "设置注册器";
            this.butOwnerSetRegister.UseVisualStyleBackColor = true;
            this.butOwnerSetRegister.Click += new System.EventHandler(this.butOwnerSetRegister_Click);
            // 
            // cbRegister
            // 
            this.cbRegister.FormattingEnabled = true;
            this.cbRegister.Items.AddRange(new object[] {
            "53e26c4b30f2be5bde66ec2c33cadafb93bc9318"});
            this.cbRegister.Location = new System.Drawing.Point(23, 159);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(266, 20);
            this.cbRegister.TabIndex = 34;
            // 
            // txtOwnerSetOwnerAddrTo
            // 
            this.txtOwnerSetOwnerAddrTo.Location = new System.Drawing.Point(23, 121);
            this.txtOwnerSetOwnerAddrTo.Name = "txtOwnerSetOwnerAddrTo";
            this.txtOwnerSetOwnerAddrTo.Size = new System.Drawing.Size(266, 21);
            this.txtOwnerSetOwnerAddrTo.TabIndex = 33;
            this.txtOwnerSetOwnerAddrTo.Text = "ASBhJFN3XiDu38EdEQyMY3N2XwGh1gd5WW";
            // 
            // butOwnerSetOwner
            // 
            this.butOwnerSetOwner.Location = new System.Drawing.Point(309, 119);
            this.butOwnerSetOwner.Name = "butOwnerSetOwner";
            this.butOwnerSetOwner.Size = new System.Drawing.Size(158, 23);
            this.butOwnerSetOwner.TabIndex = 32;
            this.butOwnerSetOwner.Text = "更改域名所有者";
            this.butOwnerSetOwner.UseVisualStyleBackColor = true;
            this.butOwnerSetOwner.Click += new System.EventHandler(this.butOwnerSetOwner_Click);
            // 
            // butGetOwnerInfo
            // 
            this.butGetOwnerInfo.Location = new System.Drawing.Point(309, 77);
            this.butGetOwnerInfo.Name = "butGetOwnerInfo";
            this.butGetOwnerInfo.Size = new System.Drawing.Size(158, 23);
            this.butGetOwnerInfo.TabIndex = 17;
            this.butGetOwnerInfo.Text = "查询所有者信息";
            this.butGetOwnerInfo.UseVisualStyleBackColor = true;
            this.butGetOwnerInfo.Click += new System.EventHandler(this.butGetOwnerInfo_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.labSarChash);
            this.tabPage5.Controls.Add(this.txtNNSresolverHash);
            this.tabPage5.Controls.Add(this.txtSubDomainForResolve);
            this.tabPage5.Controls.Add(this.txtResolveAddr);
            this.tabPage5.Controls.Add(this.butSetResolverData);
            this.tabPage5.Controls.Add(this.butResolve);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(497, 456);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "解析器";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // labSarChash
            // 
            this.labSarChash.AutoSize = true;
            this.labSarChash.Location = new System.Drawing.Point(75, 15);
            this.labSarChash.Name = "labSarChash";
            this.labSarChash.Size = new System.Drawing.Size(53, 12);
            this.labSarChash.TabIndex = 40;
            this.labSarChash.Text = "合约HASH";
            // 
            // txtNNSresolverHash
            // 
            this.txtNNSresolverHash.Location = new System.Drawing.Point(153, 12);
            this.txtNNSresolverHash.Name = "txtNNSresolverHash";
            this.txtNNSresolverHash.Size = new System.Drawing.Size(256, 21);
            this.txtNNSresolverHash.TabIndex = 39;
            this.txtNNSresolverHash.Text = "6e2aea28af9c5febea0774759b1b76398e3167f1";
            // 
            // txtSubDomainForResolve
            // 
            this.txtSubDomainForResolve.Location = new System.Drawing.Point(19, 117);
            this.txtSubDomainForResolve.Name = "txtSubDomainForResolve";
            this.txtSubDomainForResolve.Size = new System.Drawing.Size(266, 21);
            this.txtSubDomainForResolve.TabIndex = 38;
            // 
            // txtResolveAddr
            // 
            this.txtResolveAddr.Location = new System.Drawing.Point(19, 90);
            this.txtResolveAddr.Name = "txtResolveAddr";
            this.txtResolveAddr.Size = new System.Drawing.Size(266, 21);
            this.txtResolveAddr.TabIndex = 37;
            // 
            // butSetResolverData
            // 
            this.butSetResolverData.Location = new System.Drawing.Point(300, 90);
            this.butSetResolverData.Name = "butSetResolverData";
            this.butSetResolverData.Size = new System.Drawing.Size(158, 23);
            this.butSetResolverData.TabIndex = 36;
            this.butSetResolverData.Text = "设置解析地址";
            this.butSetResolverData.UseVisualStyleBackColor = true;
            this.butSetResolverData.Click += new System.EventHandler(this.butSetResolverData_Click);
            // 
            // butResolve
            // 
            this.butResolve.Location = new System.Drawing.Point(300, 49);
            this.butResolve.Name = "butResolve";
            this.butResolve.Size = new System.Drawing.Size(158, 23);
            this.butResolve.TabIndex = 35;
            this.butResolve.Text = "获取解析地址";
            this.butResolve.UseVisualStyleBackColor = true;
            this.butResolve.Click += new System.EventHandler(this.butResolve_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtSubDomainOwnerAddr);
            this.tabPage4.Controls.Add(this.txtSubDomain);
            this.tabPage4.Controls.Add(this.butSetSubDomainOwner);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(497, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "分发注册器";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtSubDomainOwnerAddr
            // 
            this.txtSubDomainOwnerAddr.Location = new System.Drawing.Point(21, 65);
            this.txtSubDomainOwnerAddr.Name = "txtSubDomainOwnerAddr";
            this.txtSubDomainOwnerAddr.Size = new System.Drawing.Size(266, 21);
            this.txtSubDomainOwnerAddr.TabIndex = 36;
            // 
            // txtSubDomain
            // 
            this.txtSubDomain.Location = new System.Drawing.Point(21, 27);
            this.txtSubDomain.Name = "txtSubDomain";
            this.txtSubDomain.Size = new System.Drawing.Size(266, 21);
            this.txtSubDomain.TabIndex = 35;
            // 
            // butSetSubDomainOwner
            // 
            this.butSetSubDomainOwner.Location = new System.Drawing.Point(309, 27);
            this.butSetSubDomainOwner.Name = "butSetSubDomainOwner";
            this.butSetSubDomainOwner.Size = new System.Drawing.Size(158, 23);
            this.butSetSubDomainOwner.TabIndex = 34;
            this.butSetSubDomainOwner.Text = "分发子域名";
            this.butSetSubDomainOwner.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butRevoke);
            this.tabPage2.Controls.Add(this.butGetCreditInfo);
            this.tabPage2.Controls.Add(this.butDoAuthenticate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "信誉";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // butRevoke
            // 
            this.butRevoke.Location = new System.Drawing.Point(313, 53);
            this.butRevoke.Name = "butRevoke";
            this.butRevoke.Size = new System.Drawing.Size(154, 23);
            this.butRevoke.TabIndex = 3;
            this.butRevoke.Text = "注销";
            this.butRevoke.UseVisualStyleBackColor = true;
            // 
            // butGetCreditInfo
            // 
            this.butGetCreditInfo.Location = new System.Drawing.Point(313, 94);
            this.butGetCreditInfo.Name = "butGetCreditInfo";
            this.butGetCreditInfo.Size = new System.Drawing.Size(154, 23);
            this.butGetCreditInfo.TabIndex = 2;
            this.butGetCreditInfo.Text = "获取";
            this.butGetCreditInfo.UseVisualStyleBackColor = true;
            // 
            // butDoAuthenticate
            // 
            this.butDoAuthenticate.Location = new System.Drawing.Point(313, 24);
            this.butDoAuthenticate.Name = "butDoAuthenticate";
            this.butDoAuthenticate.Size = new System.Drawing.Size(154, 23);
            this.butDoAuthenticate.TabIndex = 1;
            this.butDoAuthenticate.Text = "认证";
            this.butDoAuthenticate.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.txtNNS_DEX_fixedSellingHash);
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(497, 456);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "一口价交易";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.butDoBuy);
            this.groupBox4.Controls.Add(this.butDiscontinue);
            this.groupBox4.Controls.Add(this.butGetFixedSellingInfo);
            this.groupBox4.Controls.Add(this.txtLaunch);
            this.groupBox4.Controls.Add(this.butLaunch);
            this.groupBox4.Location = new System.Drawing.Point(18, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 147);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "交易操作";
            // 
            // butDoBuy
            // 
            this.butDoBuy.Location = new System.Drawing.Point(90, 114);
            this.butDoBuy.Name = "butDoBuy";
            this.butDoBuy.Size = new System.Drawing.Size(114, 23);
            this.butDoBuy.TabIndex = 17;
            this.butDoBuy.Text = "购买";
            this.butDoBuy.UseVisualStyleBackColor = true;
            this.butDoBuy.Click += new System.EventHandler(this.butDoBuy_Click);
            // 
            // butDiscontinue
            // 
            this.butDiscontinue.Location = new System.Drawing.Point(90, 72);
            this.butDiscontinue.Name = "butDiscontinue";
            this.butDiscontinue.Size = new System.Drawing.Size(114, 23);
            this.butDiscontinue.TabIndex = 16;
            this.butDiscontinue.Text = "下架NNS";
            this.butDiscontinue.UseVisualStyleBackColor = true;
            this.butDiscontinue.Click += new System.EventHandler(this.butDiscontinue_Click);
            // 
            // butGetFixedSellingInfo
            // 
            this.butGetFixedSellingInfo.Location = new System.Drawing.Point(225, 31);
            this.butGetFixedSellingInfo.Name = "butGetFixedSellingInfo";
            this.butGetFixedSellingInfo.Size = new System.Drawing.Size(114, 23);
            this.butGetFixedSellingInfo.TabIndex = 15;
            this.butGetFixedSellingInfo.Text = "查询出售信息";
            this.butGetFixedSellingInfo.UseVisualStyleBackColor = true;
            this.butGetFixedSellingInfo.Click += new System.EventHandler(this.butGetFixedSellingInfo_Click);
            // 
            // txtLaunch
            // 
            this.txtLaunch.Location = new System.Drawing.Point(7, 33);
            this.txtLaunch.Name = "txtLaunch";
            this.txtLaunch.Size = new System.Drawing.Size(77, 21);
            this.txtLaunch.TabIndex = 14;
            // 
            // butLaunch
            // 
            this.butLaunch.Location = new System.Drawing.Point(90, 31);
            this.butLaunch.Name = "butLaunch";
            this.butLaunch.Size = new System.Drawing.Size(114, 23);
            this.butLaunch.TabIndex = 13;
            this.butLaunch.Text = "上架NNS";
            this.butLaunch.UseVisualStyleBackColor = true;
            this.butLaunch.Click += new System.EventHandler(this.butLaunch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butNNCoutAll);
            this.groupBox3.Controls.Add(this.labGetNNCbalance);
            this.groupBox3.Controls.Add(this.butGetNNCbalance);
            this.groupBox3.Controls.Add(this.txtNNCout);
            this.groupBox3.Controls.Add(this.butNNCout);
            this.groupBox3.Controls.Add(this.butDoNNCinStep1);
            this.groupBox3.Controls.Add(this.txtDoNNCinStep0);
            this.groupBox3.Controls.Add(this.butDoNNCinStep0);
            this.groupBox3.Controls.Add(this.labGetDEXfixedSellingBalance);
            this.groupBox3.Controls.Add(this.butGetDEXfixedSellingBalance);
            this.groupBox3.Location = new System.Drawing.Point(18, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 185);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作余额账户";
            // 
            // butNNCoutAll
            // 
            this.butNNCoutAll.Location = new System.Drawing.Point(224, 142);
            this.butNNCoutAll.Name = "butNNCoutAll";
            this.butNNCoutAll.Size = new System.Drawing.Size(114, 23);
            this.butNNCoutAll.TabIndex = 12;
            this.butNNCoutAll.Text = "提取全部NNC";
            this.butNNCoutAll.UseVisualStyleBackColor = true;
            this.butNNCoutAll.Click += new System.EventHandler(this.butNNCoutAll_Click);
            // 
            // labGetNNCbalance
            // 
            this.labGetNNCbalance.AutoSize = true;
            this.labGetNNCbalance.Location = new System.Drawing.Point(222, 20);
            this.labGetNNCbalance.Name = "labGetNNCbalance";
            this.labGetNNCbalance.Size = new System.Drawing.Size(101, 12);
            this.labGetNNCbalance.TabIndex = 11;
            this.labGetNNCbalance.Text = "labGetNNCbalance";
            // 
            // butGetNNCbalance
            // 
            this.butGetNNCbalance.Location = new System.Drawing.Point(90, 20);
            this.butGetNNCbalance.Name = "butGetNNCbalance";
            this.butGetNNCbalance.Size = new System.Drawing.Size(114, 23);
            this.butGetNNCbalance.TabIndex = 10;
            this.butGetNNCbalance.Text = "获取NNC余额";
            this.butGetNNCbalance.UseVisualStyleBackColor = true;
            this.butGetNNCbalance.Click += new System.EventHandler(this.butGetNNCbalance_Click);
            // 
            // txtNNCout
            // 
            this.txtNNCout.Location = new System.Drawing.Point(7, 142);
            this.txtNNCout.Name = "txtNNCout";
            this.txtNNCout.Size = new System.Drawing.Size(77, 21);
            this.txtNNCout.TabIndex = 9;
            // 
            // butNNCout
            // 
            this.butNNCout.Location = new System.Drawing.Point(90, 142);
            this.butNNCout.Name = "butNNCout";
            this.butNNCout.Size = new System.Drawing.Size(114, 23);
            this.butNNCout.TabIndex = 8;
            this.butNNCout.Text = "提取NNC";
            this.butNNCout.UseVisualStyleBackColor = true;
            this.butNNCout.Click += new System.EventHandler(this.butNNCout_Click);
            // 
            // butDoNNCinStep1
            // 
            this.butDoNNCinStep1.Location = new System.Drawing.Point(90, 113);
            this.butDoNNCinStep1.Name = "butDoNNCinStep1";
            this.butDoNNCinStep1.Size = new System.Drawing.Size(114, 23);
            this.butDoNNCinStep1.TabIndex = 7;
            this.butDoNNCinStep1.Text = "充值（验证转账）";
            this.butDoNNCinStep1.UseVisualStyleBackColor = true;
            this.butDoNNCinStep1.Click += new System.EventHandler(this.butDoNNCinStep1_Click);
            // 
            // txtDoNNCinStep0
            // 
            this.txtDoNNCinStep0.Location = new System.Drawing.Point(7, 84);
            this.txtDoNNCinStep0.Name = "txtDoNNCinStep0";
            this.txtDoNNCinStep0.Size = new System.Drawing.Size(77, 21);
            this.txtDoNNCinStep0.TabIndex = 6;
            // 
            // butDoNNCinStep0
            // 
            this.butDoNNCinStep0.Location = new System.Drawing.Point(90, 84);
            this.butDoNNCinStep0.Name = "butDoNNCinStep0";
            this.butDoNNCinStep0.Size = new System.Drawing.Size(114, 23);
            this.butDoNNCinStep0.TabIndex = 4;
            this.butDoNNCinStep0.Text = "NNC转账一口价交易";
            this.butDoNNCinStep0.UseVisualStyleBackColor = true;
            this.butDoNNCinStep0.Click += new System.EventHandler(this.butDoNNCinStep0_Click);
            // 
            // labGetDEXfixedSellingBalance
            // 
            this.labGetDEXfixedSellingBalance.AutoSize = true;
            this.labGetDEXfixedSellingBalance.Location = new System.Drawing.Point(222, 55);
            this.labGetDEXfixedSellingBalance.Name = "labGetDEXfixedSellingBalance";
            this.labGetDEXfixedSellingBalance.Size = new System.Drawing.Size(173, 12);
            this.labGetDEXfixedSellingBalance.TabIndex = 3;
            this.labGetDEXfixedSellingBalance.Text = "labGetDEXfixedSellingBalance";
            // 
            // butGetDEXfixedSellingBalance
            // 
            this.butGetDEXfixedSellingBalance.Location = new System.Drawing.Point(90, 55);
            this.butGetDEXfixedSellingBalance.Name = "butGetDEXfixedSellingBalance";
            this.butGetDEXfixedSellingBalance.Size = new System.Drawing.Size(114, 23);
            this.butGetDEXfixedSellingBalance.TabIndex = 2;
            this.butGetDEXfixedSellingBalance.Text = "获取账户余额";
            this.butGetDEXfixedSellingBalance.UseVisualStyleBackColor = true;
            this.butGetDEXfixedSellingBalance.Click += new System.EventHandler(this.butGetDEXfixedSellingBalance_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.txtNNChash);
            this.tabPage7.Controls.Add(this.label2);
            this.tabPage7.Controls.Add(this.txtCGAShash);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(497, 456);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "设置";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "NNC合约HASH";
            // 
            // txtNNChash
            // 
            this.txtNNChash.Location = new System.Drawing.Point(141, 77);
            this.txtNNChash.Name = "txtNNChash";
            this.txtNNChash.Size = new System.Drawing.Size(256, 21);
            this.txtNNChash.TabIndex = 45;
            this.txtNNChash.Text = "fc732edee1efdf968c23c20a9628eaa5a6ccb934";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "CGAS合约HASH";
            // 
            // txtCGAShash
            // 
            this.txtCGAShash.Location = new System.Drawing.Point(141, 29);
            this.txtCGAShash.Name = "txtCGAShash";
            this.txtCGAShash.Size = new System.Drawing.Size(256, 21);
            this.txtCGAShash.TabIndex = 43;
            this.txtCGAShash.Text = "74f2dc36a68fdc4682034178eb2220729231db76";
            // 
            // labBlockCount
            // 
            this.labBlockCount.AutoSize = true;
            this.labBlockCount.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBlockCount.Location = new System.Drawing.Point(805, 33);
            this.labBlockCount.Name = "labBlockCount";
            this.labBlockCount.Size = new System.Drawing.Size(264, 38);
            this.labBlockCount.TabIndex = 44;
            this.labBlockCount.Text = "labBlockCount";
            // 
            // timerOneSecond
            // 
            this.timerOneSecond.Enabled = true;
            this.timerOneSecond.Interval = 1000;
            this.timerOneSecond.Tick += new System.EventHandler(this.timerOneSecond_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 44;
            this.label5.Text = "合约HASH";
            // 
            // txtNNS_DEX_fixedSellingHash
            // 
            this.txtNNS_DEX_fixedSellingHash.Location = new System.Drawing.Point(135, 18);
            this.txtNNS_DEX_fixedSellingHash.Name = "txtNNS_DEX_fixedSellingHash";
            this.txtNNS_DEX_fixedSellingHash.Size = new System.Drawing.Size(256, 21);
            this.txtNNS_DEX_fixedSellingHash.TabIndex = 43;
            this.txtNNS_DEX_fixedSellingHash.Text = "7a64879a21b80e96a8bc91e0f07adc49b8f3521e";
            // 
            // formNNS_SDK_CSarp_GUItest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 607);
            this.Controls.Add(this.txtInfoShow);
            this.Controls.Add(this.txtTXIDshow);
            this.Controls.Add(this.lbTX);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labBlockCount);
            this.Controls.Add(this.cmbnelApiUrl);
            this.Controls.Add(this.butResetDoAddr);
            this.Controls.Add(this.txtDoAddr);
            this.Controls.Add(this.txtWIF);
            this.Controls.Add(this.labPubKey);
            this.Controls.Add(this.labAddr);
            this.Controls.Add(this.txtDomain);
            this.Name = "formNNS_SDK_CSarp_GUItest";
            this.Text = "NNS_SDK_CSarp_GUItest";
            this.Load += new System.EventHandler(this.formNNS_SDK_CSarp_GUItest_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butResetDoAddr;
        private System.Windows.Forms.TextBox txtDoAddr;
        private System.Windows.Forms.TextBox txtWIF;
        private System.Windows.Forms.Label labPubKey;
        private System.Windows.Forms.Label labAddr;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.ComboBox cmbnelApiUrl;
        private System.Windows.Forms.TextBox txtInfoShow;
        private System.Windows.Forms.TextBox txtTXIDshow;
        private System.Windows.Forms.ListBox lbTX;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtSubDomainForResolve;
        private System.Windows.Forms.TextBox txtResolveAddr;
        private System.Windows.Forms.Button butSetResolverData;
        private System.Windows.Forms.Button butResolve;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button butOwnerSetResolver;
        private System.Windows.Forms.ComboBox cbResolver;
        private System.Windows.Forms.Button butOwnerSetRegister;
        private System.Windows.Forms.ComboBox cbRegister;
        private System.Windows.Forms.TextBox txtOwnerSetOwnerAddrTo;
        private System.Windows.Forms.Button butOwnerSetOwner;
        private System.Windows.Forms.Button butGetOwnerInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ProgressBar pbTimerForDay;
        private System.Windows.Forms.Label labTimeForDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butGetDomainUseState;
        private System.Windows.Forms.Button butDoRenewDomain;
        private System.Windows.Forms.Button butDoCollectDomain;
        private System.Windows.Forms.Button butDoBidSettlement;
        private System.Windows.Forms.Label labGetBalanceOfBid;
        private System.Windows.Forms.Button butGetBalanceOfBid;
        private System.Windows.Forms.TextBox txtDoBid;
        private System.Windows.Forms.Button butDoBid;
        private System.Windows.Forms.Button butGetAuctionStateByFullhash;
        private System.Windows.Forms.Button butStartAuction;
        private System.Windows.Forms.TextBox txtBlcokTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labGetCGASBanlance;
        private System.Windows.Forms.Button butGetCGASBanlance;
        private System.Windows.Forms.TextBox txtCGASout;
        private System.Windows.Forms.Button butCGASout;
        private System.Windows.Forms.Button butCGASin_2;
        private System.Windows.Forms.TextBox txtCGASin;
        private System.Windows.Forms.Button butCGASin_1;
        private System.Windows.Forms.Label labBanlance;
        private System.Windows.Forms.Button butGetBanlance;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtSubDomainOwnerAddr;
        private System.Windows.Forms.TextBox txtSubDomain;
        private System.Windows.Forms.Button butSetSubDomainOwner;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button butRevoke;
        private System.Windows.Forms.Button butGetCreditInfo;
        private System.Windows.Forms.Button butDoAuthenticate;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button butDoBuy;
        private System.Windows.Forms.Button butDiscontinue;
        private System.Windows.Forms.Button butGetFixedSellingInfo;
        private System.Windows.Forms.TextBox txtLaunch;
        private System.Windows.Forms.Button butLaunch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butNNCoutAll;
        private System.Windows.Forms.Label labGetNNCbalance;
        private System.Windows.Forms.Button butGetNNCbalance;
        private System.Windows.Forms.TextBox txtNNCout;
        private System.Windows.Forms.Button butNNCout;
        private System.Windows.Forms.Button butDoNNCinStep1;
        private System.Windows.Forms.TextBox txtDoNNCinStep0;
        private System.Windows.Forms.Button butDoNNCinStep0;
        private System.Windows.Forms.Label labGetDEXfixedSellingBalance;
        private System.Windows.Forms.Button butGetDEXfixedSellingBalance;
        private System.Windows.Forms.Label labBlockCount;
        private System.Windows.Forms.Label labSarChash;
        private System.Windows.Forms.TextBox txtNNSresolverHash;
        private System.Windows.Forms.Timer timerOneSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNNScenterHash;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNNChash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCGAShash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNNSRegisterSellhash;
        private System.Windows.Forms.TextBox txtMinuteOfDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNNS_DEX_fixedSellingHash;
    }
}

