using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace ChromiumBrowser
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser navegador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            navegador = new ChromiumWebBrowser("https://google.com.br");
            this.Controls.Add(navegador);
            navegador.Dock = DockStyle.Fill;
        }
    }
}
