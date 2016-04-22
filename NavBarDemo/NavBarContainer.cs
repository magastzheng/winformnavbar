using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavBarDemo
{
    public partial class NavBarContainer : UserControl
    {
        private NavBarItems _navBarItems;

        public NavBarItems Bars
        {
            get { return _navBarItems; }
        }

        public NavBarItem this[int index]
        {
            get 
            {
                if (index > -1)
                {
                    return this._navBarItems[index];
                }
                else
                {
                    return null;
                }
            }
        }

        private int _selectedIndex = -1;
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value;
                SelectBar(value);
            }
        }

        private int _barSpace = 1;
        public int BarSpace
        {
            get { return _barSpace; }
            set { _barSpace = value; }
        }

        private int _barMargin = 5;
        public int BarMargin
        {
            get { return _barMargin; }
            set { _barMargin = value; }
        }


        public NavBarContainer()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(112, 140, 225);
            this._navBarItems = new NavBarItems(this);
            this.AutoScroll = true;
        }

        private void NavBarContainer_Load(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private int ValidTop
        {
            get { return Top - Margin.Top - Padding.Top; }
        }

        private int ValidBottom
        {
            get { return Bottom - Margin.Bottom - Padding.Bottom; }
        }

        public void SetExpandHeight()
        {
            int height = this.Height;
            if (_selectedIndex >= 0 && _selectedIndex < this._navBarItems.Count)
            {
                if (_selectedIndex == 0)
                {
                    if (this._navBarItems.Count == 1)
                    {
                        height = this.ValidBottom - this._navBarItems[_selectedIndex].Top - this._barSpace;
                    }
                    else
                    {
                        height = this._navBarItems[_selectedIndex + 1].Top - this._navBarItems[_selectedIndex].Top - this._barSpace;
                    }
                }
                else if (_selectedIndex == this._navBarItems.Count - 1)
                {
                    this._navBarItems[_selectedIndex].Height = this.ValidBottom - this._navBarItems[_selectedIndex - 1].Bottom - this._barSpace;
                }
                else
                {
                    this._navBarItems[_selectedIndex].Height = this._navBarItems[_selectedIndex + 1].Top - this._navBarItems[_selectedIndex - 1].Bottom - this._barSpace;
                }

                this._navBarItems[_selectedIndex].Height = height;
            }
        }

        public void SetLayout()
        {
            //for (int i = 0; i < this._navBarItems.Count; i++)
            //{
            //    if (i == 0)
            //    {
            //        this._navBarItems[i].Top = 10;
            //    }
            //    else
            //    {
            //        this._navBarItems[i].Top = this._navBarItems[i - 1].Bottom + this._barSpace;
            //        this._navBarItems[i].BarIndex = i;
            //    }
            //}
            if(_selectedIndex >= 0 && _selectedIndex < this._navBarItems.Count)
            {
                for (int i = 1; i <= _selectedIndex; i++)
                {
                    this._navBarItems[i].Top = this._navBarItems[i - 1].Bottom + this._barSpace;
                    this._navBarItems[i].BarIndex = i;
                }

                for (int i = this._navBarItems.Count - 1; i > _selectedIndex; i--)
                {
                    if (i == this._navBarItems.Count - 1)
                    {
                        this._navBarItems[i].Top = this.ValidBottom - this._navBarItems[i].Height - this._barSpace;
                    }
                    else
                    {
                        this._navBarItems[i].Top = this._navBarItems[i + 1].Top - this._navBarItems[i].Height - this._barSpace;
                    }
                }
            }
        }

        public void SetLayout(NavBarItem item)
        {
            this.SuspendLayout();
            this.Controls.Add(item);
            if (_navBarItems.Count == 0)
            {
                item.Top = this.Top;
            }
            else
            {
                item.Top = this[_navBarItems.Count - 1].Bottom + _barSpace;
            }

            //other process
            this.ResumeLayout();
        }

        public NavBarItem AddBar()
        {
            _navBarItems.Add();
            return _navBarItems[_navBarItems.Count - 1];
        }

        public void RemoveBar(NavBarItem item)
        {
            int index = item.BarIndex;
            _navBarItems.Remove(item);
            Controls.Remove(item);
            SetLayout();
        }

        public void RemoveBarAt(int index)
        {
            Controls.Remove(_navBarItems[index]);
            _navBarItems.RemoveAt(index);
            SetLayout();
        }

        private void SelectBar(int index)
        {
            foreach (NavBarItem bar in _navBarItems)
            {
                if (bar.BarIndex == index)
                    continue;
                bar.IsSelected = false;
            }
        }
    }
}
