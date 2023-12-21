
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

namespace audio_net
{

    public partial class MainWindow : Window
    {
        public MediaPlayer player;

        string conString = "Data Source=RAZDOLBAI\\SQLEXPRESS;Initial Catalog=audiodb;Integrated security=true";

        public MainWindow()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Sql = "select song_name from dbo.Song";
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            List<string> rows = new List<string>();

            string row = null;
            while (dr.Read())
            {
                row = dr[0].ToString();
                rows.Add(row);
            }
            dr.Close();
            
            
        }
    
        

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Play_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
