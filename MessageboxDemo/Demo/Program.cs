using System.Windows;
using System;

namespace MessageboxDemo
{
    class Program
    {

        static void MessageboxIfDemo()
        {
            MessageBoxResult result;
            result = MessageBox.Show("Ja oder Nein?", "Frage",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question
                );

            if ( result == MessageBoxResult.Yes )
            {
                Console.WriteLine("JA");
            }
            else
            {
                Console.WriteLine("Nein oder Cancel");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            MessageboxIfDemo();
        }

    }
}
