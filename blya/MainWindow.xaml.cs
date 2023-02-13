using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
namespace blya
{
    public partial class MainWindow : Window
    {   
        double player = 0;  
        public MainWindow()
        {
            InitializeComponent();
        }
        private void strat_Click(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
            b10.IsEnabled = false;
            hz.Content = "ХОД ПИЛЮЛЬКИ";
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    player = 1;
                    hz.Content = "ХОД КРОКОДИЛА";
                    b1.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b1.IsEnabled = false;
                    break;
            }
            win();
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    player = 1;
                    hz.Content = "ХОД КРОКОДИЛА";
                    b2.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b2.IsEnabled = false;
                    break;
            }
            win();
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    player = 1;
                    hz.Content = "ХОД КРОКОДИЛА";
                    b3.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b3.IsEnabled = false;
                    break;
            }
            win();
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    hz.Content = "ХОД КРОКОДИЛА";
                    b4.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b4.IsEnabled = false;
                    break;
            }
            win();
        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    player = 1;
                    hz.Content = "ХОД КРОКОДИЛА";
                    b5.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b5.IsEnabled = false;
                    break;
            }
            win();
        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    player = 1;
                    hz.Content = "ХОД КРОКОДИЛА";
                    b6.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b6.IsEnabled = false;
                    break;
            }
            win();
        }
        private void b7_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    player = 1;
                    hz.Content = "ХОД КРОКОДИЛА";
                    b7.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b7.IsEnabled = false;
                    break;
            }
            win();
        }
        private void b8_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    player = 1;
                    hz.Content = "ХОД КРОКОДИЛА";
                    b8.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b8.IsEnabled = false;
                    break;
            }
            win();
        }
        private void b9_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💊");
                    
                    player = 1;
                    hz.Content = "ХОД КРОКОДИЛА";
                    b9.IsEnabled = false;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "💉");
                    player = 0;
                    hz.Content = "ХОД ПИЛЮЛЬКИ";
                    b9.IsEnabled = false;
                    break;
            }
            win();
        }
        void win()
        {
            if (b1.Content == b2.Content && b2.Content == b3.Content && b1.Content != null && b2.Content != null && b3.Content != null || b4.Content == b5.Content && b5.Content == b6.Content && b4.Content != null && b5.Content != null && b6.Content != null || b7.Content == b8.Content && b8.Content == b9.Content && b7.Content != null && b8.Content != null && b9.Content != null || b1.Content == b5.Content && b5.Content == b9.Content && b1.Content != null && b5.Content != null && b9.Content != null  ||
                b3.Content == b5.Content && b5.Content == b7.Content && b3.Content != null && b5.Content != null && b7.Content != null || b2.Content == b5.Content && b5.Content == b8.Content && b2.Content != null && b5.Content != null && b8.Content != null || b1.Content == b4.Content && b4.Content == b7.Content && b1.Content != null && b4.Content != null && b7.Content != null || b3.Content == b6.Content && b6.Content == b9.Content && b3.Content != null && b6.Content != null && b9.Content != null)
            {
                MessageBox.Show("выиграл");
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
                b5.IsEnabled = false;
                b6.IsEnabled = false;
                b7.IsEnabled = false;
                b8.IsEnabled = false;
                b9.IsEnabled = false;
            }
            //else
            //{
            //  MessageBox.Show("ничья");
            //}
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            b6.IsEnabled = false;
            b7.IsEnabled = false;
            b8.IsEnabled = false;
            b9.IsEnabled = false;
            b10.IsEnabled = true;
            hz.Content = "ХОД ПИЛЮЛЬКИ";
            b1.Content = null;
            b2.Content = null;
            b3.Content = null;
            b4.Content = null;
            b5.Content = null;
            b6.Content = null;
            b7.Content = null;
            b8.Content = null;
            b9.Content = null;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void KIBORG_Click(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
            b10.IsEnabled = false;
            hz.Content = "ХОД ПИЛЮЛЬКИ";
        }
        private void KIBORG_Click_1(object sender, RoutedEventArgs e, Random rand)
        {
            MessageBox.Show("АУУУУУУ НАПИСАНО ЧТО В БЕТЕ))))))");
            List<bat>
            Random rand = new Random();
            int random = rand.Next(1, 9);
            MessageBox.Show(rand);

        }
    } 
}
//PS Я ЗНАЮ ЧТО Я ДУРАК ПОТОМУ ЧТО Я МОГ ВСЕ ПРОПИСАТЬ В B1 И ПРИРОВНЯТЬ ВСЕ КНОПКИ К НЕМУ, НО ЧТО-ТО ПОШЛО НЕ ТАК
