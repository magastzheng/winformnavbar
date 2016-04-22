using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavBarDemo
{
    public class NavBarItems : List<NavBarItem>
    {
        private NavBarContainer _owner;
        public NavBarContainer Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public NavBarItems(NavBarContainer owner)
            : base()
        {
            _owner = owner;
        }

        public new void Add(NavBarItem item)
        {
            this._owner.SetLayout(item);
            base.Add(item);
            item.BarIndex = this.Count - 1;
            //
        }

        public void Add()
        {
            NavBarItem item = new NavBarItem(_owner);
            this.Add(item);
        }
    }
}
