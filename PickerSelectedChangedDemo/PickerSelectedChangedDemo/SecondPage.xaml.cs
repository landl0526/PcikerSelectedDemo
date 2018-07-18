using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickerSelectedChangedDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
        SecondPageViewModel viewModel;
		public SecondPage ()
		{
			InitializeComponent ();

            viewModel = new SecondPageViewModel();
            this.BindingContext = viewModel;

            ItemPickList.SetBinding(Picker.ItemsSourceProperty, new Binding { Path = "ColorPicerData" });
            ItemPickList.SetBinding(Picker.SelectedItemProperty, new Binding { Path = "SelectedItem" });
        }

        private void DataPickList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            if (picker.SelectedItem.Equals("alphabet"))
            {
                ItemPickList.SetBinding(Picker.ItemsSourceProperty, new Binding { Path = "AlphaBetData" });
                ItemPickList.SetBinding(Picker.SelectedItemProperty, new Binding { Path = "AlphaBetSelectedItem" });
            }
            else
            {
                ItemPickList.SetBinding(Picker.ItemsSourceProperty, new Binding { Path = "ColorPicerData" });
                ItemPickList.SetBinding(Picker.SelectedItemProperty, new Binding { Path = "SelectedItem" });
            }
        }
    }
}