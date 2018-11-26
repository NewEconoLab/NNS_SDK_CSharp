using NEL;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinNeo;

namespace NNS_SDK_CSarp_GUItest
{
    public partial class formNNS_SDK_CSarp_GUItest : Form
    {
        #region 通用代码
        string nelApiUrl;
        //string nelApiUrl = "https://api.nel.group/api/mainnet";

        neoHelper.neoAddress neoAddress;
        nelApiHelper nelApi;

        public formNNS_SDK_CSarp_GUItest()
        {
            InitializeComponent();
        }

        private void initData()
        {
            neoAddress = new neoHelper.neoAddress(txtWIF.Text);

            labPubKey.Text = neoAddress.addrPubKey;
            labAddr.Text = txtDoAddr.Text = neoAddress.addrStr;
            
            nelApiUrl = cmbnelApiUrl.Text;

            nelApi = new nelApiHelper(nelApiUrl);
        }

        private void formNNS_SDK_CSarp_GUItest_Load(object sender, EventArgs e)
        {
            cmbnelApiUrl.SelectedIndex = 0;
            initData();
        }
        private void cmbnelApiUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            initData();
        }
        private void txtPriKey_TextChanged(object sender, EventArgs e)
        {
            initData();
        }

        private void lbTX_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTXIDshow.Text = (string)lbTX.SelectedItem;
            txtInfoShow.Text = nelApi.getNotify((string)lbTX.SelectedItem).ToString();
        }

        private void timerOneSecond_Tick(object sender, EventArgs e)
        {
            long blockIndex = nelApi.getBlockCount();

            if (lbTX.Items.Count > 0)
            {
                if (blockIndex > long.Parse(labBlockCount.Text))
                {
                    lbTX.SetSelected(lbTX.Items.Count - 1, true);
                }
            }

            labBlockCount.Text = blockIndex.ToString();

            if (txtBlcokTime.Text != "")
            {
                System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
                DateTime start = startTime.AddSeconds(long.Parse(txtBlcokTime.Text));
                //每5分钟一天
                var days = (DateTime.Now - start).TotalMinutes / int.Parse(txtMinuteOfDay.Text);
                labTimeForDay.Text = (days).ToString();
                if ((int)days <= 5) { pbTimerForDay.Value = (int)days; }
                else { pbTimerForDay.Value = 5; }
            }
        }
        #endregion

        #region 业务代码-NNS域名中心
        private void butGetOwnerInfo_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_domainCenter nNS_domainCenter = new NNS_SDK_CSharp.NNS_domainCenter(neoAddress, txtNNScenterHash.Text, nelApiUrl);

            txtInfoShow.Text = nNS_domainCenter.getOwnerInfo(txtDomain.Text);
        }

        private void butOwnerSetOwner_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_domainCenter nNS_domainCenter = new NNS_SDK_CSharp.NNS_domainCenter(neoAddress, txtNNScenterHash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_domainCenter.doOwnerSetOwner(txtDoAddr.Text, txtDomain.Text, txtOwnerSetOwnerAddrTo.Text));
        }

        private void butOwnerSetRegister_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_domainCenter nNS_domainCenter = new NNS_SDK_CSharp.NNS_domainCenter(neoAddress, txtNNScenterHash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_domainCenter.doOwnerSetRegister(txtDoAddr.Text, txtDomain.Text, cbRegister.Text));
        }

        private void butOwnerSetResolver_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_domainCenter nNS_domainCenter = new NNS_SDK_CSharp.NNS_domainCenter(neoAddress, txtNNScenterHash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_domainCenter.doOwnerSetResolver(txtDoAddr.Text, txtDomain.Text, cbResolver.Text));
        }
        #endregion

        #region 业务代码-NNS拍卖注册器
        private void butGetCGASBanlance_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            labGetCGASBanlance.Text = nNS_Register_Sell.getCGASbanlance(txtCGAShash.Text, txtDoAddr.Text).ToString();
        }

        private void butGetBanlance_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            labBanlance.Text = nNS_Register_Sell.getBalanceOf(txtDoAddr.Text).ToString();
        }

        private void butCGASin_1_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Register_Sell.doCGASinStep0(txtCGAShash.Text, txtDoAddr.Text,decimal.Parse(txtCGASin.Text)));
        }

        private void butCGASin_2_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Register_Sell.doCGASinStep1((string)lbTX.SelectedItem).Replace("0x", ""));
        }

        private void butCGASout_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Register_Sell.doCGASout(txtDoAddr.Text,decimal.Parse(txtCGASout.Text)));
        }

        private void butStartAuction_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Register_Sell.doStartAuction(txtDoAddr.Text, txtDomain.Text.Split('.')[1], txtDomain.Text.Split('.')[0]));
        }

        private void butGetAuctionStateByFullhash_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            txtInfoShow.Text = nNS_Register_Sell.getAuctionStateByFullDomain(txtDomain.Text, int.Parse(txtMinuteOfDay.Text));
            txtBlcokTime.Text = nelApi.getBlockTimeStamp((long)JObject.Parse(txtInfoShow.Text)["startBlockSelling"]).ToString();
        }

        private void butDoBid_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Register_Sell.doBid(txtDoAddr.Text,txtDomain.Text,decimal.Parse(txtDoBid.Text)));
        }

        private void butDoBidSettlement_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Register_Sell.doBidSettlement(txtDoAddr.Text,txtDomain.Text));
        }

        private void butDoCollectDomain_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Register_Sell.doCollectDomain(txtDoAddr.Text, txtDomain.Text));
        }

        private void butDoRenewDomain_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Register_Sell.doRenewDomain(txtDoAddr.Text, txtDomain.Text.Split('.')[1], txtDomain.Text.Split('.')[0]));
        }

        private void butGetBalanceOfBid_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            labGetBalanceOfBid.Text = nNS_Register_Sell.getBalanceOfBid(txtDoAddr.Text, txtDomain.Text).ToString();
        }

        private void butGetDomainUseState_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_register_sell nNS_Register_Sell = new NNS_SDK_CSharp.NNS_register_sell(neoAddress, txtNNSRegisterSellhash.Text, nelApiUrl);

            txtInfoShow.Text = nNS_Register_Sell.getDomainUseState(txtDomain.Text);
        }

        #endregion

        #region 业务代码-NNS解析器
        private void butResolve_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_resolver nNS_Resolver = new NNS_SDK_CSharp.NNS_resolver(neoAddress,txtNNSresolverHash.Text,nelApiUrl);

            txtInfoShow.Text = nNS_Resolver.resolve(txtDomain.Text);
        }

        private void butSetResolverData_Click(object sender, EventArgs e)
        {
            NNS_SDK_CSharp.NNS_resolver nNS_Resolver = new NNS_SDK_CSharp.NNS_resolver(neoAddress, txtNNSresolverHash.Text, nelApiUrl);

            lbTX.Items.Add(nNS_Resolver.SetResolverData(txtDoAddr.Text, txtDomain.Text, txtSubDomainForResolve.Text, txtResolveAddr.Text));
        }





        #endregion


    }
}