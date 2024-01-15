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
using System.Reflection.Emit;
namespace PatternObserver01
{
    public partial class FormObserver1 : Form, IObserver
    {
        private Model _model = null;
        public FormObserver1()
        {
            //InitializeComponent();
        }
        #region IObserver Member 
        public void UpdateDisplay(object obj)
        {
            _model = (Model)obj;
            this.Refresh();
            //label1.Text = _model.Number.ToString();
        }
        #endregion
    }
}
