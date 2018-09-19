using Newtonsoft.Json;
using System;
using System.Collections;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;
using WinFormTest.Entity;

namespace WinFormTest
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private MeituanConfig config;
        private MeituanSiger signer;

        private readonly string APP_AUTH_TOKEN = "03609e18c54d6ba60ab91e06cd3831660652b0dfa2c5a41455eaef36b9bb8c93056edd98d89122a7d8917c6e7f0ce3da9c9ce183d6ebf9ec3840b521a4a17fa08e955df5255c190ec48f938209e7587c";
        private readonly string VERSION = "1";

        private readonly string CHECK_PRE_URL = "https://api-open-cater.meituan.com/tuangou/coupon/prepare";
        private readonly string CHECK_URL = "https://api-open-cater.meituan.com/tuangou/coupon/consume";
        private readonly string CHECK_CANCEL_URL = "https://api-open-cater.meituan.com/tuangou/coupon/cancel";

        private readonly string CANCEL_TYPE = "1";
        private readonly string E_ID = "001";
        private readonly string E_NAME = "门店一";
        private readonly string E_ORDER_ID = "0123456789";


        private void FrmStart_Load(object sender, EventArgs e)
        {
            signer = new MeituanSiger();
            config = new MeituanConfig();

            labToken.Text = "appAuthToken";
            labCharset.Text = "charset";
            labTimestamp.Text = "timestamp";
            labVersion.Text = "Version";
            labResult.Text = "";
            btnRefreshTimestamp.Text = "Refresh";
            btnCheckPre.Text = "CheckPre";
            btnCheck.Text = "Check";

            textBoxDeveloperId.Text = "100344";
            textBoxBusinessId.Text = "1";
            textBoxEPoiId.Text = Guid.NewGuid().ToString().ToUpper();

            PageInit();
        }

        private void FrmStart_Activated(object sender, EventArgs e)
        {
            textBoxCouponCode.Focus();
        }

        private void BtnRefreshTimestamp_Click(object sender, EventArgs e)
        {
            textBoxTimestamp.Text = GetTimestamp();
        }

        private void BtnCheckPre_Click(object sender, EventArgs e)
        {
            if (textBoxCouponCode.Text.Trim().Length != 12)
            {
                MessageBox.Show("请录入号码，且长度必须为12位");
                return;
            }

            string url = GetCheckPreUrl();
            string data = GetCheckPreData();
            HttpHelper httpHepler = new HttpHelper();
            string result = httpHepler.Post(url, data, 10 * 1000);
            Console.WriteLine(result);

            CheckPreDataHandler(result);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (textBoxCouponCode.Text.Trim().Length != 12)
            {
                MessageBox.Show("请录入号码，且长度必须为12位");
                return;
            }

            string url = GetCheckUrl();
            string data = GetCheckData();
            HttpHelper httpHepler = new HttpHelper();
            string result = httpHepler.Post(url, data, 10 * 1000);
            Console.WriteLine(result);

            CheckDataHandler(result);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (textBoxCouponCode.Text.Trim().Length != 12)
            {
                MessageBox.Show("请录入号码，且长度必须为12位");
                return;
            }

            string url = GetCancelUrl();
            string data = GetCancelData();
            HttpHelper httpHepler = new HttpHelper();
            string result = httpHepler.Post(url, data, 10 * 1000);
            Console.WriteLine(result);
            CancelDataHandler(result);
        }

        private void PageInit()
        {
            textBoxToken.Text = APP_AUTH_TOKEN;
            textBoxCharSet.Text = config.CharSet;
            textBoxVersion.Text = VERSION;
            textBoxCouponCode.Text = "";
            textBoxTimestamp.Text = GetTimestamp();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Test");

            string ts = GetTimestamp() + "000";

            Hashtable ht = new Hashtable
            {
                { "developerId", textBoxDeveloperId.Text.Trim() },
                { "businessId", textBoxBusinessId.Text.Trim() },
                { "ePoiId", textBoxEPoiId.Text.Trim() },
                { "ePoiName", textBoxEPoiName.Text.Trim() },
                { "timestamp",  ts}
            };
           
            string sign = signer.GetSign(ht);
            Console.WriteLine(sign);

            StringBuilder sb = new StringBuilder();
            sb.Append("https://open-erp.meituan.com/storemap?developerId=");
            sb.Append(textBoxDeveloperId.Text.Trim());
            sb.Append("&businessId=");
            sb.Append(textBoxBusinessId.Text.Trim());
            sb.Append("&ePoiId=");
            sb.Append(textBoxEPoiId.Text.Trim());
            sb.Append("&ePoiName=");
            sb.Append(HttpUtility.UrlEncode(textBoxEPoiName.Text.Trim()));
            sb.Append("&timestamp=");
            sb.Append(ts);
            sb.Append("&sign=");
            sb.Append(sign);

            textBoxLink.Text = sb.ToString();

            Console.WriteLine("------------------------------------------------------");
        }

        /// <summary>
        /// 计算当前时间戳
        /// </summary>
        /// <returns>当前的时间戳【单位是秒】</returns>        
        private string GetTimestamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0);
            string timestamp = Convert.ToString(Convert.ToInt64(ts.TotalSeconds));
            Console.WriteLine("timestamp - " + timestamp);
            return timestamp;
        }

        /// <summary>
        /// 生成验券准备URL
        /// </summary>
        /// <returns></returns>
        private string GetCheckPreUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(CHECK_PRE_URL);
            sb.Append("?");
            sb.Append("appAuthToken").Append("=").Append(APP_AUTH_TOKEN);
            sb.Append("&");
            sb.Append("charset").Append("=").Append(config.CharSet);
            sb.Append("&");
            sb.Append("timestamp").Append("=").Append(textBoxTimestamp.Text.Trim());
            sb.Append("&");
            sb.Append("version").Append("=").Append(VERSION);
            sb.Append("&");
            sb.Append("sign").Append("=").Append(GetCheckPreSign());

            string url = sb.ToString();
            Console.WriteLine("CheckPreUrl - " + url);
            return url;
        }

        /// <summary>
        /// 生成验券准备数据
        /// </summary>
        /// <returns></returns>
        private string GetCheckPreData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("couponCode");
            sb.Append("=");
            sb.Append(textBoxCouponCode.Text.Trim());
            string data = sb.ToString();
            Console.WriteLine(data);
            return data;
        }

        /// <summary>
        /// 生成验券准备sign
        /// </summary>
        /// <returns></returns>
        private string GetCheckPreSign()
        {
            Hashtable ht = new Hashtable
            {
                { "appAuthToken", APP_AUTH_TOKEN },
                { "charset", config.CharSet },
                { "timestamp", textBoxTimestamp.Text.Trim() },
                { "version", VERSION },
                { "couponCode", textBoxCouponCode.Text.Trim()}
            };

            string sign = signer.GetSign(ht);
            Console.WriteLine(sign);
            return sign;
        }

        /// <summary>
        /// 验券准备返回数据处理
        /// </summary>
        /// <param name="result"></param>
        private void CheckPreDataHandler(String result)
        {
            Clipboard.SetDataObject(result);
            labResult.Text = result;
            ResponseCheckPre obj = JsonConvert.DeserializeObject<ResponseCheckPre>(result);
            if (obj != null)
            {
                if (obj.Data != null)
                {
                    Console.WriteLine("Get Data");
                    Console.WriteLine(obj.Data.ToString());
                    MessageBox.Show(obj.Data.ToString());
                }
                else if (obj.Error != null)
                {
                    Console.WriteLine("Get Error");
                    Console.WriteLine(obj.Error.Code);
                    Console.WriteLine(obj.Error.Error_type);
                    Console.WriteLine(obj.Error.Message);
                    MessageBox.Show(obj.Error.Message);
                }
                else
                {
                    Console.WriteLine("Convert failed, but obj is not null");
                    MessageBox.Show("接口返回数据解析失败 - 1");
                }
            }
            else
            {
                Console.WriteLine("Convert failed");
                MessageBox.Show("接口返回数据解析失败 - 2");
            }
        }

        /// <summary>
        /// 生成执行验券URL
        /// </summary>
        /// <returns></returns>
        private string GetCheckUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(CHECK_URL);
            sb.Append("?");
            sb.Append("appAuthToken").Append("=").Append(APP_AUTH_TOKEN);
            sb.Append("&");
            sb.Append("charset").Append("=").Append(config.CharSet);
            sb.Append("&");
            sb.Append("timestamp").Append("=").Append(textBoxTimestamp.Text.Trim());
            sb.Append("&");
            sb.Append("version").Append("=").Append(VERSION);
            sb.Append("&");
            sb.Append("sign").Append("=").Append(GetCheckSign());

            string url = sb.ToString();
            Console.WriteLine("CheckUrl - " + url);
            return url;
        }

        /// <summary>
        /// 生成执行验券数据
        /// </summary>
        /// <returns></returns>
        private string GetCheckData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("couponCode").Append("=").Append(textBoxCouponCode.Text.Trim());
            sb.Append("&");
            sb.Append("count").Append("=").Append("1");
            sb.Append("&");
            sb.Append("eId").Append("=").Append(E_ID);
            sb.Append("&");
            sb.Append("eName").Append("=").Append(E_NAME);
            sb.Append("&");
            sb.Append("eOrderId").Append("=").Append(E_ORDER_ID);

            string data = sb.ToString();
            Console.WriteLine(data);
            return data;
        }

        /// <summary>
        /// 生成执行验券sign
        /// </summary>
        /// <returns></returns>
        private string GetCheckSign()
        {
            Hashtable ht = new Hashtable
            {
                { "appAuthToken", APP_AUTH_TOKEN },
                { "charset", config.CharSet },
                { "timestamp", textBoxTimestamp.Text.Trim() },
                { "version", VERSION },
                { "couponCode", textBoxCouponCode.Text.Trim()},
                { "count", "1"},
                { "eId", E_ID},
                { "eName", E_NAME},
                { "eOrderId", E_ORDER_ID}
            };

            string sign = signer.GetSign(ht);
            Console.WriteLine(sign);
            return sign;
        }

        /// <summary>
        /// 执行验券返回数据处理
        /// </summary>
        /// <param name="result"></param>
        private void CheckDataHandler(String result)
        {
            Clipboard.SetDataObject(result);
            labResult.Text = result;
            ResponseCheckPre obj = JsonConvert.DeserializeObject<ResponseCheckPre>(result);
            if (obj != null)
            {
                if (obj.Data != null)
                {
                    Console.WriteLine("Get Data");
                    Console.WriteLine(obj.Data.ToString());
                    MessageBox.Show(obj.Data.ToString());
                }
                else if (obj.Error != null)
                {
                    Console.WriteLine("Get Error");
                    Console.WriteLine(obj.Error.Code);
                    Console.WriteLine(obj.Error.Error_type);
                    Console.WriteLine(obj.Error.Message);
                    MessageBox.Show(obj.Error.Message);
                }
                else
                {
                    Console.WriteLine("Convert failed, but obj is not null");
                    MessageBox.Show("接口返回数据解析失败 - 1");
                }
            }
            else
            {
                Console.WriteLine("Convert failed");
                MessageBox.Show("接口返回数据解析失败 - 2");
            }
        }

        /// <summary>
        /// 生成撤销验券URL
        /// </summary>
        /// <returns></returns>
        private string GetCancelUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(CHECK_CANCEL_URL);
            sb.Append("?");
            sb.Append("appAuthToken").Append("=").Append(APP_AUTH_TOKEN);
            sb.Append("&");
            sb.Append("charset").Append("=").Append(config.CharSet);
            sb.Append("&");
            sb.Append("timestamp").Append("=").Append(textBoxTimestamp.Text.Trim());
            sb.Append("&");
            sb.Append("version").Append("=").Append(VERSION);
            sb.Append("&");
            sb.Append("sign").Append("=").Append(GetCancelSign());

            string url = sb.ToString();
            Console.WriteLine("CancelUrl - " + url);
            return url;
        }

        /// <summary>
        /// 生成撤销验券数据
        /// </summary>
        /// <returns></returns>
        private string GetCancelData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("couponCode").Append("=").Append(textBoxCouponCode.Text.Trim());
            sb.Append("&");
            sb.Append("type").Append("=").Append(CANCEL_TYPE);
            sb.Append("&");
            sb.Append("eId").Append("=").Append(E_ID);
            sb.Append("&");
            sb.Append("eName").Append("=").Append(E_NAME);

            string data = sb.ToString();
            Console.WriteLine(data);
            return data;
        }

        /// <summary>
        /// 生成撤销验券sign
        /// </summary>
        /// <returns></returns>
        private string GetCancelSign()
        {
            Hashtable ht = new Hashtable
            {
                { "appAuthToken", APP_AUTH_TOKEN },
                { "charset", config.CharSet },
                { "timestamp", textBoxTimestamp.Text.Trim() },
                { "version", VERSION },
                { "couponCode", textBoxCouponCode.Text.Trim()},
                { "type", CANCEL_TYPE},
                { "eId", E_ID},
                { "eName", E_NAME}
            };

            string sign = signer.GetSign(ht);
            Console.WriteLine(sign);
            return sign;
        }

        /// <summary>
        /// 撤销验券返回数据处理
        /// </summary>
        /// <param name="result"></param>
        private void CancelDataHandler(String result)
        {
            Clipboard.SetDataObject(result);
            labResult.Text = result;
            ResponseCheckPre obj = JsonConvert.DeserializeObject<ResponseCheckPre>(result);
            if (obj != null)
            {
                if (obj.Data != null)
                {
                    Console.WriteLine("Get Data");
                    Console.WriteLine(obj.Data.ToString());
                    MessageBox.Show(obj.Data.ToString());
                }
                else if (obj.Error != null)
                {
                    Console.WriteLine("Get Error");
                    Console.WriteLine(obj.Error.Code);
                    Console.WriteLine(obj.Error.Error_type);
                    Console.WriteLine(obj.Error.Message);
                    MessageBox.Show(obj.Error.Message);
                }
                else
                {
                    Console.WriteLine("Convert failed, but obj is not null");
                    MessageBox.Show("接口返回数据解析失败 - 1");
                }
            }
            else
            {
                Console.WriteLine("Convert failed");
                MessageBox.Show("接口返回数据解析失败 - 2");
            }
        }
    }

    
}