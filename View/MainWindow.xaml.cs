
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data;
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
using Microsoft.Win32;

namespace audio_net
{

    public partial class MainWindow : Window
    {
        
        string filepath;
        string conString = "Data Source=RAZDOLBAI\\SQLEXPRESS;Initial Catalog=audiodb;Integrated security=true";

        MediaPlayer player = new MediaPlayer();
        
        public MainWindow()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            
            ArtistName.Text = SongName.Text;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Аудиофалы (*.mp3)|*.mp3";
            openFileDialog.Multiselect = false;

            bool? dialogOk = openFileDialog.ShowDialog();
            if (dialogOk == true)
            {
                filepath = openFileDialog.FileName;
                player.Open(new Uri(filepath));
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void Play_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
