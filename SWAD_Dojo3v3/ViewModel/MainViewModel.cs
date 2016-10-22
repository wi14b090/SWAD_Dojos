using GalaSoft.MvvmLight;
using SWAD_Dojo3v3.Entities;
using System;
using System.Collections.ObjectModel;

namespace SWAD_Dojo3v3.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<SWPackage> listItems { get; set; }

        public ObservableCollection<Currency> listCurr { get; set; }

        public String selectedCurr { get; set; }

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
            listItems.Add(new SWPackage("Word","Officeware",new decimal(149.99),new decimal(65.44),2));
            listItems.Add(new SWPackage("Excel", "Officeware", new decimal(169.99), new decimal(75.44), 15));
            listItems.Add(new SWPackage("Power Point", "Officeware", new decimal(189.99), new decimal(85.44), 33));

            listCurr.Add(new Currency("EUR",1));
            listCurr.Add(new Currency("USD", 1));
            listCurr.Add(new Currency("GBP", 1));
            listCurr.Add(new Currency("CAD", 1));

            selectedCurr = "EUR";
        }
    }
}