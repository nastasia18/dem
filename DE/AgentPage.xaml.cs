using DE.AppData;
using System;
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
using System.Windows.Threading;

namespace DE
{
    /// <summary>
    /// Логика взаимодействия для AgentPage.xaml
    /// </summary>
    public partial class AgentPage : Page
    {
        public AgentPage()
        {
            InitializeComponent();

            var History = ConnectDB.conObj.Agent.ToList();
            ListAgent.ItemsSource = History;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
        }

        public void UpdateData(object sender, object e)
        {
            var History = ConnectDB.conObj.Agent.ToList();
            ListAgent.ItemsSource = History;
            ListAgent.ItemsSource = ConnectDB.conObj.Agent.Where(p => p.Name.StartsWith(SearchPanel.Text.ToLower()) || p.Phone.StartsWith(SearchPanel.Text) || p.Email.StartsWith(SearchPanel.Text)).ToList();
        }

        private void TypeSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
