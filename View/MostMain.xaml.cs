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

namespace audio_net.View
{
    /// <summary>
    /// Логика взаимодействия для MostMain.xaml
    /// </summary>
    public partial class MostMain : Page
    {
        string conString = "Data Source=RAZDOLBAI\\SQLEXPRESS;Initial Catalog=audiodb;Integrated security=true";
        public MostMain()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Sql = "select song_name from dbo.Song";
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SongsList.Items.Add(dr[0].ToString());
            }
            dr.Close();
            
        }
    }
}
