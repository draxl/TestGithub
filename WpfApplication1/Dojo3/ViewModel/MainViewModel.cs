using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;

namespace Dojo3.ViewModel
{
    public class MainViewModel : BaseViewModel
    {



        public MainViewModel()
        {

            selectedCurrency = CodingDojo4DataLib.Converter.Currencies.EUR;
            stock = manager.CurrentStock.OnStock;

            foreach (var item in manager.CurrentStock.OnStock)
            {
                Items.Add(new StockEntryViewModel(item));
            }



        }

        public Array Currencies
        {
            get { return Enum.GetValues(typeof(Currencies)); }

        }

        public Currencies SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                selectedCurrency = value;
                OnPropertyChanged("SelectedCurrency");
                StartConversion();

            }
        }

        private List<StockEntry> stock;

        public static ObservableCollection<StockEntryViewModel> items = new ObservableCollection<StockEntryViewModel>();
        private CodingDojo4DataLib.Converter.Currencies selectedCurrency;



        public static ObservableCollection<StockEntryViewModel> Items
        {
            get { return items; }
            set
            {
                items = value;
            }

        }

        private SampleManager manager = new SampleManager();

        private void StartConversion()
        {

            foreach (var item in Items)
            {
                item.CalculateSalesPriceFromEuro(SelectedCurrency);
                item.CalculatePurchasePriceFromEuro(SelectedCurrency);
            }
        }
    }
}

