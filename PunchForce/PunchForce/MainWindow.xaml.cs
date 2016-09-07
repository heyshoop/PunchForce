using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;

namespace PunchForce
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String username = nameTextBox.Text.ToString();
            HttpClient httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:48.0) Gecko/20100101 Firefox/48.0");
            String loginUrl = "http://123.232.10.234:8083/servlet/com.sdjxd.pms.platform.serviceBreak.Invoke";
            List<KeyValuePair<String, String>> paramList = new List<KeyValuePair<String, String>>();
            paramList.Add(new KeyValuePair<string, string>("_c","com.sdjxd.pms.platform.organize.User"));
            paramList.Add(new KeyValuePair<string, string>("_m", "loginByEncode"));
            paramList.Add(new KeyValuePair<string, string>("_p0", "yL3P/tHg"));
            paramList.Add(new KeyValuePair<string, string>("_p1", "21218CCA77804D2BA1922C33E0151105"));
            HttpResponseMessage response = httpClient.PostAsync(new Uri(loginUrl), new FormUrlEncodedContent(paramList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
    }
}
