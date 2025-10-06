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
using _9Pr_Kazakov.Classes;

namespace _9Pr_Kazakov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string img_Light = @"\Images\HeaveArmorDead.png";
        string img_Heave = @"\Images\LightArmorDead.png";

        private LightArmoredWarrior lightWarrior;
        private HeavyArmoredWarrior heavyWarrior;
        public MainWindow()
        {
            InitializeComponent();
            lightWarrior = new LightArmoredWarrior(100);
            heavyWarrior = new HeavyArmoredWarrior(100);
        }

        private void LightDamageButton_Click(object sender, RoutedEventArgs e)
        {
            lightWarrior.TakeDamage(10);
            UpdateUI();
        }

        private void HeavyDamageButton_Click(object sender, RoutedEventArgs e)
        {
            heavyWarrior.TakeDamage(10);
            UpdateUI();
        }

        private void UpdateLightWarriorUI()
        {
            LightHealthText.Text = lightWarrior.Health.ToString();
            string imagePath = lightWarrior.IsAlive
                ? "/Images/LightArmorAlive.png"
                : "/Images/LightArmorDead.png";
            LightWarriorImage.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
        }

        private void UpdateUI()
        {
            LightHealthText.Text = lightWarrior.Health.ToString();
            HeavyHealthText.Text = heavyWarrior.Health.ToString();

            // Обновляем картинки в зависимости от состояния
            string lightImagePath = lightWarrior.IsAlive
                ? @"C:\Users\student-a502\Desktop\9Pr_Kazakov\9Pr_Kazakov\Images\LightArmorAlive.png"
                : @"C:\Users\student-a502\Desktop\9Pr_Kazakov\9Pr_Kazakov\Images\LightArmorDead.png";

            string heavyImagePath = heavyWarrior.IsAlive
                ? @"C:\Users\student-a502\Desktop\9Pr_Kazakov\9Pr_Kazakov\Images\HeaveArmorAlive.png"
                : @"C:\Users\student-a502\Desktop\9Pr_Kazakov\9Pr_Kazakov\Images\HeaveArmorDead.png";

            LightWarriorImage.Source = new BitmapImage(new Uri(lightImagePath));
            HeavyWarriorImage.Source = new BitmapImage(new Uri(heavyImagePath));
        }
    }
}
