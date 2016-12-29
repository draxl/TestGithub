using System;
using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;

namespace Dojo3.ViewModel
{
    public class StockEntryViewModel : BaseViewModel
    {

        private StockEntry stockEntry;

        private double salespriceInEuro;
        private double purchasepriceInEuro;

        public String Name
        {
            get { return stockEntry.SoftwarePackage.Name; }

            set
            {
                stockEntry.SoftwarePackage.Name = value;
                OnPropertyChanged("Name");
            }
        }


        public String Group
        {
            get { return stockEntry.SoftwarePackage.Category.Name; }

            set
            {
                stockEntry.SoftwarePackage.Category.Name = value;
                OnPropertyChanged("Name");
            }
        }


        public double SalesPrice
        {
            get { return stockEntry.SoftwarePackage.SalesPrice; }
            set
            {
                stockEntry.SoftwarePackage.SalesPrice = value;
                OnPropertyChanged("SalesPrice");
            }
        }



        public double PurchasePrice
        {
            get { return stockEntry.SoftwarePackage.PurchasePrice; }

            set
            {
                stockEntry.SoftwarePackage.PurchasePrice = value;
                OnPropertyChanged("PurchasePrice");
            }
        }


        public int OnStock
        {
            get { return stockEntry.Amount; }

            set
            {
                stockEntry.Amount = value;
                OnPropertyChanged("Name");
            }
        }

        public StockEntryViewModel(StockEntry entry)
        {
            stockEntry = entry;
            salespriceInEuro = entry.SoftwarePackage.SalesPrice;
            purchasepriceInEuro = entry.SoftwarePackage.PurchasePrice;
        }


        /* convert */
        public void CalculateSalesPriceFromEuro(Currencies currency)
        {
            this.SalesPrice = CurrencyConverter.ConvertFromEuroTo(currency, salespriceInEuro);

        }

        public void CalculatePurchasePriceFromEuro(Currencies currency)
        {

            this.PurchasePrice = CurrencyConverter.ConvertFromEuroTo(currency, purchasepriceInEuro);
        }

    }
}