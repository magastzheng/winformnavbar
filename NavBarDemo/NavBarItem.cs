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
    public partial class NavBarItem : UserControl
    {
        private NavNodeData _data;
        private NavBarContainer _owner;
        private Button _button;
        private TreeView _treeView;

        private int _barIndex;
        private NavBarItemState _barState = NavBarItemState.Expand;
        private string _title;
        private int _titleHeight = 20;
        private int _barSpace = 5;
        private int _barMargin = 5;
        private bool _isSelected = false;
        private Color _titleStartColor = Color.White;
        private Color _titleEndColor = Color.FromArgb(199, 211, 247);

        public int BarIndex
        {
            get { return _barIndex; }
            set { _barIndex = value; }
        }

        public NavBarItemState BarState
        {
            get { return _barState; }
            set 
            {
                _barState = value;
                SetBarState(value);
            }
        }

        private void SetBarState(NavBarItemState state)
        {
            if (state == NavBarItemState.Collapse)
            {
                this.Height = _button.Height;
            }
            else
            { 
                //TODO: calc the bar height
                _owner.SetExpandHeight();
            }
            _owner.SetLayout();
        }

        public NavNodeData Data 
        {
            get { return _data; }
            set { _data = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        public int TitleHeight
        {
            get { return _titleHeight; }
            set { _titleHeight = value; }
        }

        public int BarSpace
        {
            get { return _barSpace; }
            set { _barSpace = value; }
        }

        public int BarMargin
        {
            get { return _barMargin; }
            set { _barMargin = value; }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                Invalidate();
            }
        }

        public Color TitleStartColor
        {
            get { return _titleStartColor; }
            set { _titleStartColor = value; }
        }

        public Color TitleEndColor
        {
            get { return _titleEndColor; }
            set { _titleEndColor = value; }
        }

        public NavBarItem()
        {
            InitializeComponent();
            this._title = "NavBarItem";
            this.BackColor = Color.FromArgb(214, 233, 247);
            this._button.Click += new EventHandler(
                    delegate(object sender, EventArgs e)
                    {
                        IsSelected = true;
                        _owner.SelectedIndex = _barIndex;

                        if (_barState == NavBarItemState.Collapse)
                            BarState = NavBarItemState.Expand;
                        else
                            BarState = NavBarItemState.Collapse;

                    }
                );
        }

        public NavBarItem(NavBarContainer owner)
            : this()
        {
            _owner = owner;
        }

        public void SetTreeViewHeihgt()
        { 
            
        }

        public void AddTreeViewItem()
        {
            //TreeNode holder = new TreeNode();
            
            TreeNode root = new TreeNode();
            root.Text = "Root";
            root.Expand();

            TreeNode root2 = new TreeNode();
            root2.Text = "Root2";
            root2.Expand();


            TreeNode node1 = new TreeNode();
            node1.Text = "1";
            node1.Expand();

            TreeNode node2 = new TreeNode();
            node2.Text = "2";
            node2.Expand();

            root.Nodes.Add(node1);
            root.Nodes.Add(node2);

            TreeNode node3 = new TreeNode();
            node3.Text = "1";
            node3.Expand();

            TreeNode node4 = new TreeNode();
            node4.Text = "2";
            node4.Expand();

            root2.Nodes.Add(node3);
            root2.Nodes.Add(node4);

            //_treeView.Nodes.Add(holder);
            _treeView.Top = _button.Bottom + _barSpace;
            _treeView.Nodes.Add(root);
            _treeView.Nodes.Add(root2);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            IsSelected = true;
            _owner.SelectedIndex = _barIndex;
        }
    }
}
