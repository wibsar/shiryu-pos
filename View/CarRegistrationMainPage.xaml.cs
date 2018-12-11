﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Athena;

namespace Shiryu
{
    /// <summary>
    /// Lógica de interacción para Yonke.xaml
    /// </summary>
    public partial class CarRegistrationMainPage : Page
    {
        public CarRegistrationMainPage()
        {
            DataContext = CarRegistrationViewModel.GetInstance();
            InitializeComponent();
        }
    }
}
