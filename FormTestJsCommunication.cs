using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace ChromeTest
{
    public partial class FormTestJsCommunication : Form
    {
        ChromiumWebBrowser m_chromeBrowser = null;

        public FormTestJsCommunication()
        {
            InitializeComponent();
        }

        private void FormTestJsCommunication_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            m_chromeBrowser = new ChromiumWebBrowser("http://www.maps.google.com");

            panel1.Controls.Add(m_chromeBrowser);

        }

        private void FormTestJsCommunication_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
