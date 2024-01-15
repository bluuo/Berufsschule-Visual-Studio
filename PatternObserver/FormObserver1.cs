using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PatternObserver;
using BusinessLogic;
namespace PatternObserver01
{
    public partial class FormObserver2 : Form, IObserver
    {
        private Model _model = null;
        private int _y = 0;
        private const int _fy = 3;
        public FormObserver2()
        {
            //InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            const int x1 = 120, y1 = 30, b = 30, ymax = 50;
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.Red), x1, _fy * ymax + y1 - _y, b, _y);
            base.OnPaint(e);
        }
        #region IObserver Member
        public void UpdateDisplay(Object obj)
        {
            _model = (Model)obj;
            _y = _model.Number * _fy;
            this.Refresh();
        }
        #endregion
    }
}