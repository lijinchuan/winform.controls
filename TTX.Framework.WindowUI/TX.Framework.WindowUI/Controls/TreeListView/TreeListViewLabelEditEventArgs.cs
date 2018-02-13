﻿#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TX.Framework.WindowUI.Controls
{
    public delegate void TreeListViewLabelEditEventHandler(object sender, TreeListViewLabelEditEventArgs e);
    public delegate void TreeListViewBeforeLabelEditEventHandler(object sender, TreeListViewBeforeLabelEditEventArgs e);

    [Serializable]
    public class TreeListViewLabelEditEventArgs : CancelEventArgs
    {
        private TreeListViewItem _Item;
        internal int _columnIndex;
        private string _Label;

        public TreeListViewLabelEditEventArgs(TreeListViewItem item, int column, string label)
            : base()
        {
            _Item = item;
            _columnIndex = column;
            _Label = label;
        }

        public string Label
        {
            get { return _Label; }
        }

        public TreeListViewItem Item
        {
            get { return _Item; }
        }

        public int ColumnIndex
        {
            get { return _columnIndex; }
        }
    }

    [Serializable]
    public class TreeListViewBeforeLabelEditEventArgs : TreeListViewLabelEditEventArgs
    {
        private Control _Editor;

        public TreeListViewBeforeLabelEditEventArgs(TreeListViewItem item, int column, string label)
            : base(item, column, label)
        {
        }

        public new int ColumnIndex
        {
            get { return _columnIndex; }
            set { _columnIndex = value; }
        }

        public Control Editor
        {
            get { return _Editor; }
            set { _Editor = value; }
        }
    }
}
