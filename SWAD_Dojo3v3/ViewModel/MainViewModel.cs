using GalaSoft.MvvmLight;
using SWAD_Dojo3v3.Entities;
using System.Collections.ObjectModel;

namespace SWAD_Dojo3v3.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<SWPackage> list { get; set; }
        public MainViewModel DataContext { get; private set; }

        public MainViewModel()
        {
            //InitializeComponent();
            this.DataContext = this;
            list = new ObservableCollection<SWPackage>();
            createTestData();
        }

        public void createTestData()
        {
            list.Add(new SWPackage("Word","Officeware",new decimal(149.99),new decimal(65.44),2));
            list.Add(new SWPackage("Excel", "Officeware", new decimal(169.99), new decimal(75.44), 15));
            list.Add(new SWPackage("Power Point", "Officeware", new decimal(189.99), new decimal(85.44), 33));

        }
    }
}