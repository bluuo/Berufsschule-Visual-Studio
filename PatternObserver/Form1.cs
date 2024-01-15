using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using PatternObserver01;
/// Das Observer-Pattern - Variante 1 von 3
/// ---------------------------------------
/// Implementierung mit Interfaces und Callbacks
/// weitere Implementierungs-Varianten sind:
/// - 2.) Implementierung mit Delegates und Events
/// - 3.) Implementierung des Microsoft Event Pattern
namespace PatternObserver
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            //InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
        
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    checkBox_RegObserver1.Enabled = true;
        //    checkBox_RegObserver2.Enabled = true;
        //    button1.Enabled = false;
        //    // Alle benötigten Objekte instanziieren
        //    _model = new Model();
        //    _frmObserver1 = new FormObserver1();
        //    _frmObserver2 = new FormObserver2();
        //    // Und los geht's:
        //    _frmObserver1.Show();
        //    _frmObserver2.Show();
        //    _model.Start();
        //}
        //private void checkBox_RegObserver1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox_RegObserver1.Checked) _model.RegisterObserver(_frmObserver1);
        //    else _model.UnRegisterObserver(_frmObserver1);
        //}
        //private void checkBox_RegObserver2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox_RegObserver2.Checked) _model.RegisterObserver(_frmObserver2);
        //    else _model.UnRegisterObserver(_frmObserver2);
        //}
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    _model.UnRegisterObserver(_frmObserver1);
        //    _model.UnRegisterObserver(_frmObserver2);
        //    _model.Stop();
        //}
    }
}