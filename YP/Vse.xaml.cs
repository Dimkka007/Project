using System;
using System.Collections;
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

namespace YP
{
    /// <summary>
    /// Логика взаимодействия для Vse.xaml
    /// </summary>
    public partial class Vse : Page
    {
        public Vse()
        {
            InitializeComponent();
            Product.ItemsSource = YPEntities.GetContext().Product.ToList();
            
        }

        private void SortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if(SortBox.SelectedIndex == 0)
            {
                Product.ItemsSource = YPEntities.GetContext().Product.OrderBy(x => x.MinCostForAgent).ToList();
            }
            if (SortBox.SelectedIndex == 1)
            {
                Product.ItemsSource = YPEntities.GetContext().Product.OrderByDescending(x => x.MinCostForAgent).ToList();
            }
        }

        private void FiltBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductType productType = new ProductType();
            if (FiltBox.SelectedIndex == 0)
            {
                Product.ItemsSource = YPEntities.GetContext().ProductType.OfType<ProductType>().Where(r=>r.Title.Contains("Запаска")).ToList();
            }
            if (FiltBox.SelectedIndex == 1)
            {
                Product.ItemsSource = YPEntities.GetContext().Product.OrderBy(x => x.MinCostForAgent).ToList();
            }
            if (FiltBox.SelectedIndex == 2)
            {
                Product.ItemsSource = YPEntities.GetContext().Product.OrderBy(x => x.MinCostForAgent).ToList();
            }
            if (FiltBox.SelectedIndex == 3)
            {
                Product.ItemsSource = YPEntities.GetContext().Product.OrderBy(x => x.MinCostForAgent).ToList();
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
