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

namespace _18day
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Hotel> CurrentHotels { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация данных напрямую в коде
            CurrentHotels = new List<Hotel>
            {
                new Hotel { id = 1, Name = "Grand Hotel", GameOfStars = 5, CountryName = "France", HotelImage = "image1.jpg" },
                new Hotel { id = 2, Name = "Seaside Resort", GameOfStars = 4, CountryName = "Spain", HotelImage = "image2.jpg" },
                new Hotel { id = 3, Name = "Mountain View", GameOfStars = 3, CountryName = "Switzerland", HotelImage = "image3.jpg" }
            };

            DataContext = this;
        }
        //комментарий
    }

}
