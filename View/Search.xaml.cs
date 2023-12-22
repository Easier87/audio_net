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
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;

namespace audio_net.View
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        
        private List<string> rows = null;
        private List<string> filteredList = null;

        string conString = "Data Source=RAZDOLBAI\\SQLEXPRESS;Initial Catalog=audiodb;Integrated security=true";

        public Search()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Sql = "select song_name from dbo.Song";
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            rows = new List<string>();

            string row = null;
            while (dr.Read())
            {
                row = dr[0].ToString();
                rows.Add(row);
            }

            string item = "";
            string sql = "select link from dbo.Song where song_name = '" + item + "'";
            cmd = new SqlCommand(Sql, con);
            dr.Close();
            
            dr = cmd.ExecuteReader();

            for(int i = 0; i < SongsList.Items.Count; i++)
            {
                item = SongsList.Items[i].ToString();
            }

            dr.Close();
            con.Close();

            RefreshList(rows);

            App.Current.Resources["song_name"] = rows;
            
        }

        

        private void RefreshList(List<string> list)
        {
            SongsList.Items.Clear();
            foreach (string item in list)
            {
                SongsList.Items.Add(new ListViewItem().Content=item);
            }
        }

        private void SearchBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            filteredList = rows.Where(x => x.ToLower().Contains(SearchBox.Text.ToLower())).ToList();
            RefreshList(filteredList);
        }

        private void SongsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.SongName.Text = SongsList.SelectedItem.ToString();
            mainWindow.ShowDialog();
        }
    }
}
