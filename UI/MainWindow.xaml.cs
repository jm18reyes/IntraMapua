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
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Design;
using System.Collections;
using BLL;


namespace IntraMAPua
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            LoginWindow open = new LoginWindow();
            open.Show();
            this.Close();
                        
        }

        /*LocationConverter locConverter = new LocationConverter();
        ArrayList smNames = new ArrayList();
        ArrayList coordinates = new ArrayList();*/

        
        
       
        /*
                private void btnCenter_Click(object sender, RoutedEventArgs e)
                {
                    Location origin = (Location)locConverter.ConvertFrom("14.5824, 120.9783");
                    double zoom = System.Convert.ToDouble(13);
            
                }

                private void cmboMall_GotFocus(object sender, RoutedEventArgs e)
                {
                    BusinessLogic SmFinder = new BusinessLogic();
                    SmFinder.ObtainSm(smNames, coordinates);
            
                    for(int i = 0; i < smNames.Count; i++)
                    {
                       // cmboMall.Items.Add(smNames[i]);
                    }
                }

                private void cmboMall_SelectionChanged(object sender, SelectionChangedEventArgs e)
                {
                    string[] lineSplit = new string[2];
                    double coordinate1,
                           coordinate2;
                    Location center = (Location)locConverter.ConvertFrom(coordinates[cmboMall.SelectedIndex]);
                    lineSplit = coordinates[cmboMall.SelectedIndex].ToString().Split(',');
                    coordinate1 = double.Parse(lineSplit[0]);
                    coordinate2 = double.Parse(lineSplit[1]);
                    double zoom = System.Convert.ToDouble(16);

                    Pushpin pushpin = new Pushpin();
                    TextBlock pushpinTag = new TextBlock(); // create a textblock
                    pushpinTag.Text = "SM"; // assign text to textblock
                    pushpin.Content = pushpinTag; // insert textblock into pushpin
                    MapLayer.SetPosition(pushpin, new Location(coordinate1, coordinate2));
                    MetroManila.Children.Add(pushpin);

                    MapLayer imageLayer = new MapLayer();

                    Image image = new Image();
                    image.Height = 150;
                    //Define the URI location of the image
                    BitmapImage myBitmapImage = new BitmapImage();
                    myBitmapImage.BeginInit();
                    myBitmapImage.UriSource = new Uri("http://upload.wikimedia.org/wikipedia/commons/d/d4/Golden_Gate_Bridge10.JPG");
                    // To save significant application memory, set the DecodePixelWidth or  
                    // DecodePixelHeight of the BitmapImage value of the image source to the desired 
                    // height or width of the rendered image. If you don't do this, the application will 
                    // cache the image as though it were rendered as its normal size rather then just 
                    // the size that is displayed.
                    // Note: In order to preserve aspect ratio, set DecodePixelWidth
                    // or DecodePixelHeight but not both.
                    //Define the image display properties
                    myBitmapImage.DecodePixelHeight = 150;
                    myBitmapImage.EndInit();
                    image.Source = myBitmapImage;
                    image.Opacity = 0.6;
                    image.Stretch = System.Windows.Media.Stretch.None;

                    //The map location to place the image at
                    Location location = new Location() { Latitude = coordinate1, Longitude = coordinate2 };
                    //Center the image around the location specified
                    PositionOrigin position = PositionOrigin.Center;

                    //Add the image to the defined map layer
                    imageLayer.AddChild(image, location, position);
                    //Add the image layer to the map
                    MetroManila.Children.Add(imageLayer);

                    // Setting map view
                    MetroManila.SetView(center, zoom);
                    MetroManila.Focus();
            }*/
    }
}
