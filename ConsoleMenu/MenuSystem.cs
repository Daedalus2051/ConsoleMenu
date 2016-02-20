using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class MenuSystem
    {
        private string _greeting;
        private string[] _menuItems;

        public string Greeting
        {
            get { return _greeting; }
            set { _greeting = value; }
        }
        public string[] MenuItems
        {
            get { return _menuItems; }
            set { _menuItems = value; }
        }

        public MenuSystem()
        {
        }
        public MenuSystem(string greeting, string[] menuItems)
        {
            _greeting = greeting;
            _menuItems = menuItems;
        }
    }
}
