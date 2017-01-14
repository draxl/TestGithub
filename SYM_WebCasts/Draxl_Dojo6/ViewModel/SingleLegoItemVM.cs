using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Draxl_Dojo6.ViewModel
{
    public class SingleLegoItemVM : ViewModelBase
    {


        public int AmountOfPieces { get; set; }
        public BitmapImage LegoSetImage { get; set; }
        public String AgeRecommendation { get; set; }
        public String LegoSetDescription { get; set; }

        public ObservableCollection <SingleLegoItemVM> CollectionOfLegos { get; set; }

        public SingleLegoItemVM(int amountOfPieces, BitmapImage legoSetImage, string ageRecommendation, string legoSetDescription)
        {
            AmountOfPieces = amountOfPieces;
            LegoSetImage = legoSetImage;
            AgeRecommendation = ageRecommendation;
            LegoSetDescription = legoSetDescription;
        }

      
    }
}
