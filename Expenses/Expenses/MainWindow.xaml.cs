using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Expenses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Expense> expenses;
        Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Expense e1 = new Expense() { Category = "Travel", Amount = 55.65m, ExpenseDate = new DateTime(2018, 5, 8) };
            Expense e2 = new Expense() { Category = "Entertainment", Amount = 99.55m, ExpenseDate = new DateTime(2019, 11, 16) };
            Expense e3 = new Expense() { Category = "Other", Amount = 19.21m, ExpenseDate = new DateTime(2019, 11,11) };


            expenses = new ObservableCollection<Expense>
            {
                e1,
                e2,
                e3
            };

            lbxExpenses.ItemsSource = null;
            lbxExpenses.ItemsSource = expenses;

            tblkTotal.Text = Expense.TotalExpenses.ToString();

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
          // Expense e1 = new Expense() { Category = "Travel", Amount = 22.50m, ExpenseDate = DateTime.Now };

            expenses.Add(GetRandomExpense());

            tblkTotal.Text = Expense.TotalExpenses.ToString();


            
        }

        private Expense GetRandomExpense()
        {
            string[] categories = new string[]{"Travel", "Entertainment", "Other"};
            int randnum = rng.Next(0, 3);
            string category = categories[randnum];

            randnum = rng.Next(1, 10001);
            decimal randAmount = (decimal)randnum / 100;

            randnum = rng.Next(0, 31);
            DateTime randDate = DateTime.Now.AddDays(-randnum);

            Expense e1 = new Expense(category,randAmount,randDate);

            return e1;

        }

        
    }
}
