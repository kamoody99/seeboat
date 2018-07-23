using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PullFromCloudFeat
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            CloudPull dataPullDown = new CloudPull();
            System.Diagnostics.Debug.WriteLine("************************************/n***********************************/n******************************/n");
            System.Diagnostics.Debug.WriteLine("" + dataPullDown.DoesTableExist());
            System.Diagnostics.Debug.WriteLine("************************************/n***********************************/n******************************/n");
        }
    }
}
