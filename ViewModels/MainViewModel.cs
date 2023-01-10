using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace cursistToevoegen.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Cursist> Studenten { get; set; } = new ObservableCollection<Cursist>()
        {
            new Cursist("sdfg", "gfds"),
            new Cursist("xcvb", "bvc"),
            new Cursist("xcvb", "sdfb")
        };

        private string _test = "Hello World";

        public string Test

        {
            get { return _test; }
            set
            {
                _test = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }

        public void VoegStudentToe(string voornaam, string achternaam)
        {
            Studenten.Add(new Cursist(voornaam, achternaam));
            Test = "Goodbye World";
        }

        //InputNaam.Clear();
        //InputVoorNaam.Clear();
        //StudentLijst.ItemsSource = null;
        //StudentLijst.ItemsSource = studenten;
    }
}