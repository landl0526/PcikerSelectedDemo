using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerSelectedChangedDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //List<PickerViewModel> list = new List<PickerViewModel>();
            //for (int i=0; i<100; i++)
            //{
            //    PickerViewModel model = new PickerViewModel();
            //    List<string> stringList = new List<string>();
            //    for (int section=0; section<10; section++)
            //    {
            //        stringList.Add("section" + section + "  model" + i);
            //    };
            //    model.PickerData = stringList;
            //    list.Add(model);
            //}
            //MyListView.ItemsSource = list;
		}
	}
}
