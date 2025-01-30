using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingsTests
{
    internal class Person
    {
        public Person(string name)
        {
            _name = name;
        }

        private string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private Address _address = new Address("Sample street");
        public Address Address
		{
			get { return _address; }
			set { _address = value; }
		}

	}
}
