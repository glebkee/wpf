using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var parts = new List<Part>
            {
                new Part() { Id = 1, Name = "Зеркало", Price = 10, SellDate = "10.01.2020", ReturnDate = "" },
                new Part() { Id = 2, Name = "Фара", Price = 25, SellDate = "15.07.2020", ReturnDate = "" },
                new Part() {Id = 3, Name = "Дверь", Price = 20, SellDate = "10.07.2020", ReturnDate = "" }

            };
            foreach (Part part in parts)
            {
                listView1.Items.Add(part);
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(textbox1.Text) || String.IsNullOrEmpty(textbox2.Text) || String.IsNullOrEmpty(textbox3.Text) || String.IsNullOrEmpty(textbox4.Text) || String.IsNullOrEmpty(textbox5.Text))
            {
                MessageBox.Show("Одно или несколько полей пусты!");
            }
            else if(char.IsNumber(Convert.ToChar(textbox1.Text)) && char.IsNumber(Convert.ToChar(textbox3.Text)))
            {
                object newpart = new Part() { Id = Convert.ToInt32(textbox1.Text), Name = textbox2.Text, Price = Convert.ToInt32(textbox3.Text), SellDate = textbox4.Text, ReturnDate = textbox5.Text };
                listView1.Items.Add(newpart);
                textbox1.Text = String.Empty;
                textbox2.Text = String.Empty;
                textbox3.Text = String.Empty;
                textbox4.Text = String.Empty;
                textbox5.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Поля Id и Price могут содержать только числа!");
            }
        }
        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string SellDate { get; set; }
        public string ReturnDate { get; set; }
        
    }
}
