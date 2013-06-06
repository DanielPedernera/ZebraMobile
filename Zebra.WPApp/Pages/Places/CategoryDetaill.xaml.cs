using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ZebrasLib.Classes;

namespace Zebra.WPApp.Pages.Places
{
    public partial class CategoryDetaill : PhoneApplicationPage
    {
        public CategoryDetaill()
        {
            InitializeComponent();
            this.Loaded += CategoriesPage_Loaded;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
             base.OnNavigatedTo(e);
             string cat = NavigationContext.QueryString["category"];
             txtCambiar.Title = cat;
        }
        

        private void CategoriesPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<Category> listCategories = new List<Category>();
            listCategories.Add(new Category { name = "Coffe"  });
            listCategories.Add(new Category { name = "Coffe1" });
            listCategories.Add(new Category { name = "Coffe2" });
            listCategories.Add(new Category { name = "Coffe3" });
            listCategories.Add(new Category { name = "Coffe4" });
            listCategories.Add(new Category { name = "Coffe5" });

            lstCategories.ItemsSource = listCategories;
        }
    }
}