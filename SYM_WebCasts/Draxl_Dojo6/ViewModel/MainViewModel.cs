using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Draxl_Dojo6.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        public ObservableCollection<SingleLegoItemVM> LegoCollection { get; set; }
        public ObservableCollection<SingleLegoItemVM> ShoppingCart { get; set; }

        private SingleLegoItemVM currentlySelectedLego;

        public SingleLegoItemVM CurrentlySelectedLego
        {
            get { return currentlySelectedLego; }
            set { currentlySelectedLego = value; RaisePropertyChanged(); }
        }

        public void AddToCartButtonClick
        {

            set { ShoppingCart.Add(value); RaisePropertyChanged(); }
        }

        public MainViewModel()
        {

            //the variable was created above , the format is given as 
            LegoCollection = new ObservableCollection<SingleLegoItemVM>();
            DemoDataGenerator();

        }


        private void DemoDataGenerator()
        {
            SingleLegoItemVM FirstItemforCollection = new SingleLegoItemVM(250,new BitmapImage(new Uri("Images/crane.jpg", UriKind.Relative)), "3+", "Technic Crane");
            LegoCollection.Add(FirstItemforCollection);

            SingleLegoItemVM SecondItemforCollection = new SingleLegoItemVM(600, new BitmapImage(new Uri("Images/bagr.jpg", UriKind.Relative)), "3+", "Technic Bagr");
            LegoCollection.Add(SecondItemforCollection);

            SingleLegoItemVM ThirdItemforCollection = new SingleLegoItemVM(450, new BitmapImage(new Uri("Images/truck.jpg", UriKind.Relative)), "3+", "Technic Truck");
            LegoCollection.Add(ThirdItemforCollection);

        }

       
    }
}