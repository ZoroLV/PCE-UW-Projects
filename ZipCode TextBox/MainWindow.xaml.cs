<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZipCode_TextBox
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            submitButton.IsEnabled = false;
        }

        private void textChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";

            if ((!Regex.Match(textBox.Text, _usZipRegEx).Success) && (!Regex.Match(textBox.Text, _caZipRegEx).Success))
            {
                submitButton.IsEnabled = false;
            }
            else
                submitButton.IsEnabled = true;
            

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZipCode_TextBox
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            submitButton.IsEnabled = false;
        }

        private void textChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";

            if ((!Regex.Match(textBox.Text, _usZipRegEx).Success) && (!Regex.Match(textBox.Text, _caZipRegEx).Success))
            {
                submitButton.IsEnabled = false;
            }
            else
                submitButton.IsEnabled = true;
            

        }
    }
}
>>>>>>> a02dca0fec6044e282fd93be39d2a8b5fec46374
