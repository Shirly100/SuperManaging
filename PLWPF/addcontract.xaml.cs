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
using System.Windows.Shapes;
using BL;
using BE;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for addcontract.xaml
    /// </summary>
    public partial class addcontract : Window
    {
        IBL bl;
        Contract temp_con;
        public addcontract()
        {
            bl = factoryBL.get_bl();
            InitializeComponent();
            temp_con = new Contract();
            id_EmployerComboBox.ItemsSource = bl.getMotherList();
            id_ChidComboBox.ItemsSource = bl.getChildListAlone();
            DataContext = temp_con;
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (((DateTime)started_WorkingDatePicker.SelectedDate) > ((DateTime)end_WorkingDatePicker.SelectedDate))
                {
                    started_WorkingDatePicker.BorderBrush = Brushes.Red;
                    end_WorkingDatePicker.BorderBrush = Brushes.Red;
                    throw new Exception("INCORRECT DATES");
                }

                else if ((started_WorkingDatePicker.SelectedDate) > (DateTime.Now))
                {
                    started_WorkingDatePicker.BorderBrush = Brushes.Red;
                    throw new Exception("INCORRECT DATE");
                }
                bl.addContract(temp_con);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void started_WorkingDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            temp_con.StartDate = ((DateTime)started_WorkingDatePicker.SelectedDate).ToLongDateString();
        }

        private void end_WorkingDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            temp_con.EndDate = ((DateTime)end_WorkingDatePicker.SelectedDate).ToLongDateString();
        }

        private void id_ChildComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            temp_con.ID_child = ((Child)id_ChidComboBox.SelectedItem).ID_child;
        }

        private void id_EmployeeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            temp_con.ID_nanny = ((Nanny)(id_EmployerComboBox.SelectedItem)).ID;
        
        }
    }
}
