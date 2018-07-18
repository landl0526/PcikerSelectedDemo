using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerSelectedChangedDemo
{
    public class SecondPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<string> ColorPicerData { set; get; }
        public List<string> AlphaBetData { set; get; }

        private string selectedItem { set; get; }
        public string SelectedItem
        {
            get => selectedItem;
            set
            {
                if (value != null)
                {
                    this.selectedItem = value;
                    this.onPropertyChanged(nameof(SelectedItem));
                }
            }
        }

        private string alphaBetSelectedItem { set; get; }
        public string AlphaBetSelectedItem
        {
            get => alphaBetSelectedItem;
            set
            {
                if (value != null)
                {
                    this.alphaBetSelectedItem = value;
                    this.onPropertyChanged(nameof(AlphaBetSelectedItem));
                }
            }
        }

        public ObservableCollection<string> ListOfDataItems { get; set; }
      = new ObservableCollection<string> { "alphabet", "colors" };

        private string selectedDataItem { set; get; }
        public string SelectedDataItem
        {
            get => selectedDataItem;
            set
            {
                selectedDataItem = value;
            }
        }

        public SecondPageViewModel()
        {
            ColorPicerData = new List<string> { "red", "orange", "yellow" };
            AlphaBetData = new List<string> { "a", "b", "c" };
        }
    }
}
