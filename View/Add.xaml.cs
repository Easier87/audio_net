using audio_net.ViewModel;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Text;
using System;
using System.Data.SqlClient;


namespace audio_net.View
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    /// 
    public partial class Add : Page
    {
        private Song _currentSong = new Song();

        string conString = "Data Source=RAZDOLBAI\\SQLEXPRESS;Initial Catalog=audiodb;Integrated security=true";

        public Add(Song selectedSong)
        {
            InitializeComponent();
            


            if(selectedSong != null)
            {
                _currentSong = selectedSong;
            }

            DataContext = _currentSong;

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string Sql = "select artist_name from dbo.Artist";
            
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Box.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        private void Select_File_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Аудиофайлы (*.mp3) | *.mp3";
            bool? dialogOk = ofd.ShowDialog();
            if (dialogOk == true)
            {
                DownIcon.Opacity = 0;
                FilePath.Text = ofd.FileName;
            }
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (Box.Text == "" || FilePath.Text=="")
            {
                if (FilePath.Text.Length == 0)
                    errors.AppendLine("Выберите песню");
                if (second_tb.Text.Length == 0)
                    errors.AppendLine("Укажите имя исполнителя");
                if (third_tb.Text.Length == 0)
                    errors.AppendLine("Укажите название песни");
            }

            if (errors.Length <= 0)
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string sql = null;
                SqlCommand cmd = new SqlCommand("select artist_name from dbo.Artist", con);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    if(second_tb.Text == dataReader[0].ToString())
                    {
                        sql = "INSERT INTO Song (link, song_name, artist_id) VALUES (@link, @song_name, @artist_id)";
                        break;
                    }
                }
                dataReader.Close();

                int Id = 1;

                if (sql == null)
                {
                    sql = "INSERT INTO Artist (artist_name) VALUES (@artist_name); INSERT INTO Song (link, song_name, artist_id) VALUES (@link, @song_name, @artist_id)";

                    cmd = new SqlCommand("select max(id) from dbo.Artist", con);
                    Id = (Int32)cmd.ExecuteScalar() + 1;
                }
                else
                {
                    cmd = new SqlCommand("select id from dbo.Artist WHERE artist_name = '" + second_tb.Text + "'", con);
                    Id = (Int32)cmd.ExecuteScalar();
                }

                
                SqlCommand main_cmd = new SqlCommand(sql, con);
                

                if(sql == "INSERT INTO Artist (artist_name) VALUES (@artist_name); INSERT INTO Song (link, song_name, artist_id) VALUES (@link, @song_name, @artist_id)")
                {
                    main_cmd.Parameters.AddWithValue("@artist_name", second_tb.Text);
                }                

                main_cmd.Parameters.AddWithValue("@link", FilePath.Text);
                main_cmd.Parameters.AddWithValue("@song_name", third_tb.Text);
                main_cmd.Parameters.AddWithValue("@artist_id", Id);

                int a = main_cmd.ExecuteNonQuery();
         
                MessageBox.Show(a.ToString());

                    //audiodbEntities.GetContext().Song.Add(_currentSong);

                //try
                //{
                //    audiodbEntities.GetContext().SaveChangesAsync();
                //    MessageBox.Show("Песня загружена!!!!!");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message.ToString());
                //}
            }

            else
            {
                MessageBox.Show(errors.ToString());
                return;
            }
        }
    }
}
