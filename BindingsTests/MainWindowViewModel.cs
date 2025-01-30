using MvvmHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingsTests
{
    internal class MainWindowViewModel : BindableBase
    {
        private string text1 = "Sample text";

        public string Text1
        {
            get => text1;
            set
            {
                text1 = value;
                OnPropertyChanged(nameof(Text1));
            }
        }
        private bool IsTrue { get; set; }

        private Person _person = new Person("Sample person");

        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }


        public MainWindowViewModel()
        {
            ClickCmd = new RelayCommand(OnClickCmd);
        }



        private void OnClickCmd()
        {
            IsTrue = !IsTrue;
            Text1 = IsTrue.ToString();
            Person.Name = IsTrue.ToString();
            Person.Address.Street = IsTrue.ToString();
            Person.Address.Street2 = IsTrue.ToString();
        }

        public RelayCommand ClickCmd { get; private set; }

    }
}
