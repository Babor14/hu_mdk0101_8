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

namespace hu_mdk0101_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<double> numbers = new List<double> { -3.5, -2.0, 4.0, -1.5, 2.5, 6.0 };

            LinkedList<double> linkedList = new LinkedList<double>(numbers);

            LinkedListNode<double> currentNode = linkedList.First;
            LinkedListNode<double> previousNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value > 0)
                {
                    if (previousNode != null)
                    {
                        linkedList.Remove(previousNode);
                        break;
                    }
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            foreach (double number in linkedList)
            {
                listBox.Items.Add(number);
            }
        }
    }
}
