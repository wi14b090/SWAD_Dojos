using GalaSoft.MvvmLight;
using SWAD_Dojo3v3.Entities;
using System.Collections.ObjectModel;

namespace SWAD_Dojo3v3.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        ObservableCollection<Address> list { get; set; }
        public MainViewModel DataContext { get; private set; }

        public MainViewModel()
        {
            //InitializeComponent();
            this.DataContext = this;
            list = new ObservableCollection<Address>();
            createTestData();
        }

        public void createTestData()
        {
            list.Add(new Address("Max","Muster","Mustergasse 33","Musterhausen",1111));
            list.Add(new Address("Nina", "Niedlich", "Niedlichstrasse 44", "Niedlichen", 2222));
            list.Add(new Address("Oman", "Olafsen", "Olafgasse 55", "Olafingen", 3333));
        }
    }
}