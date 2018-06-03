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

namespace OOP_Lab_26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClickCreate(object sender, RoutedEventArgs e)
        {
            Create newItem = new Create();

            if (newItem.ShowDialog() == true)
            {
                Figure Blue = new Figure(new BlueFigure());
                Figure Yellow = new Figure(new YellowFigure());

                if ("Синий круг" == newItem.FirureName)
                {
                    int g = -400;
                    for (int i = 0; i < newItem.FigureCount; i++)
                    {
                        Random random = new Random();
                        int randomNumber1 = random.Next(0, 100);
                        Ellipse ellipseNew = Blue.getCircle();
                        g = g + 100;
                        ellipseNew.Margin = new Thickness(-340, g, 0, 0);
                        Greed.Children.Add(ellipseNew);
                    }
                }
                if ("Жёлтый круг" == newItem.FirureName)
                {
                    int g = -400;
                    for (int i = 0; i < newItem.FigureCount; i++)
                    {
                        Random random = new Random();
                        int randomNumber1 = random.Next(0, 100);
                        Ellipse ellipseNew = Yellow.getCircle();
                        g = g + 100;
                        ellipseNew.Margin = new Thickness(-150, g, 0, 0);
                        Greed.Children.Add(ellipseNew);
                    }
                }
                if ("Синий квадрат" == newItem.FirureName)
                {
                    int g = -400;
                    for (int i = 1; i < newItem.FigureCount + 1; i++)
                    {
                        Random random = new Random();
                        int randomNumber1 = random.Next(0, 100);
                        Rectangle ellipseNew = Blue.getSquary();
                        g = g + 110;
                        ellipseNew.Margin = new Thickness(150, g, 0, 0);
                        Greed.Children.Add(ellipseNew);
                    }
                }
                if ("Жёлтый квадрат" == newItem.FirureName)
                {
                    int g = -400;
                    for (int i = 0; i < newItem.FigureCount; i++)
                    {
                        Random random = new Random();
                        int randomNumber1 = random.Next(0, 100);
                        Rectangle ellipseNew = Yellow.getSquary();
                        g = g + 110;
                        ellipseNew.Margin = new Thickness(340, g, 0, 0);
                        Greed.Children.Add(ellipseNew);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error open window");
            }

        }

        //Abstract factory
        abstract class Circle
        {
            public abstract Ellipse DrawCircle();
        }
        abstract class Square
        {
            public abstract Rectangle DrawSquary();
        }
        class BlueCircle : Circle
        {
            public override Ellipse DrawCircle()
            {
                Ellipse ellipseBlue = new Ellipse();
                ellipseBlue.Width = 50;
                ellipseBlue.Height = 50;
                ellipseBlue.Fill = Brushes.Blue;
                return ellipseBlue;
            }
        }
        class YellowCircle : Circle
        {
            public override Ellipse DrawCircle()
            {
                Ellipse ellipseYellow = new Ellipse();
                ellipseYellow.Width = 50;
                ellipseYellow.Height = 50;
                ellipseYellow.Fill = Brushes.Yellow;
                return ellipseYellow;
            }
        }
        class YellowSquare : Square
        {
            public override Rectangle DrawSquary()
            {
                Rectangle squareYellow = new Rectangle();
                squareYellow.Width = 50;
                squareYellow.Height = 50;
                squareYellow.Fill = Brushes.Yellow;
                return squareYellow;
            }
        }
        class BlueSquare : Square
        {
            public override Rectangle DrawSquary()
            {
                Rectangle squareBlue = new Rectangle();
                squareBlue.Width = 50;
                squareBlue.Height = 50;
                squareBlue.Fill = Brushes.Blue;
                return squareBlue;
            }
        }
        abstract class FigureFactory
        {
            public abstract Circle CreateCircle();
            public abstract Square CreateSquare();
        }
        class BlueFigure : FigureFactory
        {
            public override Circle CreateCircle()
            {
                return new BlueCircle();
            }

            public override Square CreateSquare()
            {
                return new BlueSquare();
            }

        }
        class YellowFigure : FigureFactory
        {
            public override Circle CreateCircle()
            {
                return new YellowCircle();
            }

            public override Square CreateSquare()
            {
                return new YellowSquare();
            }

        }

        class Figure
        {
            private Circle circle;
            private Square square;
            public Figure(FigureFactory factory)
            {
                circle = factory.CreateCircle();
                square = factory.CreateSquare();
            }
            public Ellipse getCircle()
            {
                return circle.DrawCircle();
            }
            public Rectangle getSquary()
            {
                return square.DrawSquary();
            }
        }
        //Protitype

        interface IFigure
        {
            IFigure Clone();
            String GetInfo();
        }

        class Rectangles : IFigure
        {
            int width;
            int height;
            public Rectangles(int w, int h)
            {
                width = w;
                height = h;
            }

            public IFigure Clone()
            {
                return new Rectangles(this.width, this.height);
            }
            public string GetInfo()
            {
                String s = System.String.Format("Прямоугольник длиной {0} и шириной {1}", height, width);
                return s;
            }
        }

        class Circles : IFigure
        {
            int radius;
            public Circles(int r)
            {
                radius = r;
            }

            public IFigure Clone()
            {
                return new Circles(this.radius);
            }
            public String GetInfo()
            {
                String s = System.String.Format("Круг радиусом {0}", radius);
                return s;
            }
        }

        private void ButtonClickClone(object sender, RoutedEventArgs e)
        {
            IFigure figure = new Rectangles(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            IFigure figures = new Circles(30);
            IFigure clonedFigures = figures.Clone();
            tb.Text = System.String.Format(" {0} \n {1} \n {2} \n {3}", figures.GetInfo(), clonedFigures.GetInfo(), figure.GetInfo(), clonedFigure.GetInfo());

        }
     
        //Bilder
        class Circletes
        {
            public string Color { get; set; }
            public Ellipse ellipse = new Ellipse();

        }
        class Squaretes
        {
            public string Color { get; set; }
            public Rectangle rectangle = new Rectangle();
        }

        class ComplexObject
        {
            public Circletes Circletes { get; set; }
            public Squaretes Squaretes { get; set; }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                if (Circletes != null)
                    sb.Append("Цвет круга: " + Circletes.Color + "\n");
                if (Squaretes != null)
                    sb.Append("Цвет прямоугольника: " + Squaretes.Color + " \n");
                return sb.ToString();
            }
        }
        abstract class ComplexObjectBilder {
            public ComplexObject ComplexObject { get; private set; }
            public void CreateComplexObject()
            {
                ComplexObject = new ComplexObject();
            }
            public abstract Ellipse SetCircletes();
            public abstract Rectangle SetSquaretes();
        }

        class Creater
        {
            public ComplexObject complexObject(ComplexObjectBilder complexObjectBilder)
            {
                complexObjectBilder.CreateComplexObject();
                complexObjectBilder.SetCircletes();
                complexObjectBilder.SetSquaretes();
 
                return complexObjectBilder.ComplexObject;
            }
        }

        class YellowComplexObjectBilder : ComplexObjectBilder
        {
            public override Ellipse SetCircletes()
            {
                Ellipse ellipseYellow = new Ellipse();
                ellipseYellow.Width = 150;
                ellipseYellow.Height = 150;
                ellipseYellow.Fill = Brushes.Yellow;
                this.ComplexObject.Circletes = new Circletes { Color = "Yellow" };
                this.ComplexObject.Circletes = new Circletes { ellipse = ellipseYellow};
                return ellipseYellow;
            }

            public override Rectangle SetSquaretes()
            {
                Rectangle squareYellow = new Rectangle();
                squareYellow.Width = 250;
                squareYellow.Height = 50;
                squareYellow.Fill = Brushes.Yellow;
                this.ComplexObject.Squaretes = new Squaretes { Color = "Yellow" };
                this.ComplexObject.Squaretes = new Squaretes { rectangle = squareYellow };
                return squareYellow;
            }
        }
        class BlueComplexObjectBilder : ComplexObjectBilder
        {
            public override Ellipse SetCircletes()
            {
                
                Ellipse ellipseBlue = new Ellipse();
                ellipseBlue.Width = 150;
                ellipseBlue.Height = 150;
                ellipseBlue.Fill = Brushes.Blue;
                this.ComplexObject.Circletes = new Circletes { Color = "Blue" };
                this.ComplexObject.Circletes = new Circletes { ellipse = ellipseBlue};
                return ellipseBlue;
            }

            public override Rectangle SetSquaretes()
            { 
                Rectangle squareBlue = new Rectangle();
                squareBlue.Width = 50;
                squareBlue.Height = 50;
                squareBlue.Fill = Brushes.Blue;
                this.ComplexObject.Squaretes = new Squaretes { Color = "Blue" };
                this.ComplexObject.Squaretes = new Squaretes { rectangle = squareBlue };
                return squareBlue;
            }
        }

        private void ButtonClickCreateComplexObject(object sender, RoutedEventArgs e)
        {
            Creater creater = new Creater();
            ComplexObjectBilder complexObjectBilder = new YellowComplexObjectBilder();
            ComplexObject grenComplexObject = creater.complexObject(complexObjectBilder);
            Greed.Children.Add(complexObjectBilder.SetCircletes());
            Greed.Children.Add(complexObjectBilder.SetSquaretes());
            String str = grenComplexObject.ToString();
       
            complexObjectBilder = new BlueComplexObjectBilder();
            ComplexObject BlueComplexObject = creater.complexObject(complexObjectBilder);
            Greed.Children.Add(complexObjectBilder.SetSquaretes());
        }
    }
}
