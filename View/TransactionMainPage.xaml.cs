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
    /// Lógica de interacción para CustomerMainPage.xaml
    /// </summary>
    public partial class TransactionMainPage : Page
    {
        public TransactionMainPage()
        {
            DataContext = MainWindowViewModel.GetInstance();

            InitializeComponent();
            TransactionsSearchTextBox.Focus();
        }

        private void KeyUpNoSymbolsEvent(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = Formatter.RemoveInvalidCharacters(((TextBox)sender).Text, out bool status);
            if (status)
            {
                MainWindowViewModel.GetInstance().Code = "Símbolo inválido!";
            }
        }

        private void KeyUpNoSymbolsNoSpaceEvent(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = Formatter.RemoveInvalidCharacters(((TextBox)sender).Text, out var status);
            if (status)
            {
                MainWindowViewModel.GetInstance().Code = "Símbolo inválido!";
            }
            ((TextBox)sender).Text = Formatter.RemoveWhiteSpace(((TextBox)sender).Text, out status);
            if (status)
            {
                MainWindowViewModel.GetInstance().Code = "Espacio inválido!";
            }
        }
    }
}
