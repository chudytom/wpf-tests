using MvvmHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingsTests
{
    internal class Address : BindableBase
    {
        private string _street;

        public Address(string street)
        {
            _street = street;
            _street2 = street;
        }

        public string Street
        {
            get { return _street; }
            set
            {
                _street = value;
                OnPropertyChanged(nameof(Street));
                // Result from test: When only Address implements INotifyPropertyChanged and the event is called on the nested property Person.Address.Street, it is enough and the UI gets updated
                // Tested when Person does not implement the interface
            }
        }


        private string _street2;
        public string Street2
        {
            get { return _street2; }
            set { SetProperty(ref _street2, value); }
            // Result from test: Same story as for Street. So basically the SetPropety wrapper works as expected
        }

    }
}
