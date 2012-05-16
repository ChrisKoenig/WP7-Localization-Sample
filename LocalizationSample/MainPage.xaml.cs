using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using LocalizationSample.Resources;
using Microsoft.Phone.Controls;

namespace LocalizationSample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void RunSoundFileButton_Click(object sender, EventArgs e)
        {
            MyMediaElement.Play();
        }
    }
}