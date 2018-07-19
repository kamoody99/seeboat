using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FileReader
{
    /*
     *This main page just is a way to test to see that the FileParser class works. 
     * The main page creates a FileParser object and inputs 11 numbers. The MainPage() calls the FileToArray function and sets a label equal to that array.
     * The app will not actually display the array correctly 
     * Set a breakpoint on line 25 and then hover over DataInDoubleArray to see the items in the array.
     */
	public partial class MainPage : ContentPage
	{
        FileParser ObjToGetData = new FileParser("26,23.09,45.80,5,34,59,2,67.9,34.7,4.9,45.34");

        public MainPage()
		{
			InitializeComponent();
            double[] DataInDoubleArray = ObjToGetData.FileToArray();
            SensorDataLabel.Text = DataInDoubleArray.ToString();
            //System.Diagnostics.Debug.WriteLine("*********************************\n******************************************\n**********************************");
            //System.Diagnostics.Debug.WriteLine(DataInDoubleArray + "");
            //System.Diagnostics.Debug.WriteLine(DataInDoubleArray.ToString());
            //System.Diagnostics.Debug.WriteLine(DataInDoubleArray.ToList().ToString());
            //System.Diagnostics.Debug.WriteLine("*********************************\n******************************************\n**********************************");



        }



	}
}
