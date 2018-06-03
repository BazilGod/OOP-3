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

namespace oop13
{

    #region Composite
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual string Search(string itemName)
        {
            return "";
        }
        public virtual string GetName()
        {
            return "";
        }

        public virtual string Print()
        {
            return name;
        }
    }

    class Box : Component
    {
        private List<Component> components = new List<Component>();

        public Box(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override string GetName()
        {
            return name;
        }

        public override string Search(string itemName)
        {
            string result = "";

            try
            {
                for (int i = 0; i < components.Count; i++)
                {
                    foreach(Item item in (components[i] as Box).components)
                    {
                        if (item.GetName() == itemName)
                        {
                            result = "item found";
                        }
                    }                    
                    if (components[i].GetName() == itemName)
                    {
                        result = "item found";
                    }
                }           
            }
            catch
            {

            }
            if(result == "")
            {
                result = "item not found";
            }

            return result;
        }

        public override string Print()
        {
            string message = "";
            message += name.ToUpper() + "\n";
            for (int i = 0; i < components.Count; i++)
            {
               message+=  "- " +  components[i].Print() + "\n";
            }
            return message;
        }
    }

    class Item: Component
    {
        public Item(string name)
                : base(name)
        { }

        public override string Print()
        {
            return name;
        }

        public override string GetName()
        {
            return name;
        }

    }
    #endregion

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Component Box = new Box("big box:");

        private void Composite_Button_Click(object sender, RoutedEventArgs e)
        {  

            Component smallBox = new Box("small box");
            Component Item1 = new Item("book");
            Component Item2 = new Item("mobile");

            smallBox.Add(Item1);
            smallBox.Add(Item2);

            Box.Add(smallBox);
            CompositeTxtbl.Items.Add(Box.Print());


            Box.Remove(Item1);

            Component newBox = new Box("Gift box");

            Component Item3 = new Item("Candy");
            Component Item4 = new Item("Letter");
            newBox.Add(Item3);
            newBox.Add(Item4);
            Box.Add(newBox);

            CompositeTxtbl.Items.Add(Box.Print());
        }

        private void Find_Button_Click(object sender, RoutedEventArgs e)
        {         
            CompositeTxtbl.Items.Add(Box.Search("Letter"));
        }

        private void Find2_Button_Click(object sender, RoutedEventArgs e)
        {
            CompositeTxtbl.Items.Add(Box.Search("Toy"));
        }
    }
}
