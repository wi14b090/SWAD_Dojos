using GalaSoft.MvvmLight;
using SWAD_Dojo3v3.Entities;
using System;
using System.Collections.ObjectModel;

namespace SWAD_Dojo3v3.ViewModel
{
    
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<SWPackage> listItems { get; set; }

        public ObservableCollection<Currency> listCurr { get; set; }

        public Currency selectedCurr { get; set; }

       
        
        public MainViewModel DataContext { get; private set; }

        

        public MainViewModel()
        {
            //InitializeComponent();
            this.DataContext = this;
            listItems = new ObservableCollection<SWPackage>();
            listCurr = new ObservableCollection<Currency>();
            createTestData();
        }

        public void createTestData()
        {
            listItems.Add(new SWPackage("Word","Officeware", 149.99,65.44,2));
            listItems.Add(new SWPackage("Excel", "Officeware", 169.99, 75.44, 15));
            listItems.Add(new SWPackage("Power Point", "Officeware", 189.99, 85.44, 33));

            Currency eur = new Currency("EUR", 1);

            listCurr.Add(eur);
            listCurr.Add(new Currency("USD", 1.08934));
            listCurr.Add(new Currency("GBP", 0.89073));
            listCurr.Add(new Currency("CAD", 1.44567));

            selectedCurr = eur;
        }

        public void calculateAfterCurrChange()
        {
            Currency c = listCurr[listCurr.IndexOf(selectedCurr)];

            foreach (var item in listItems)
            {
                item.salesPrice = item.salesPriceInEUR * c.oneUnitInEUR;
            }
        }
    }
}