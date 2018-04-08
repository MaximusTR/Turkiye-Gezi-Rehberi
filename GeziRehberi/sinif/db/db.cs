using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace GeziRehberi.sinif.db
{
    class db
    {
        public static SQLiteConnection baglanti = new SQLiteConnection("Data Source=db/gezirehberi.db");
        public static string ToplamYer()
        {

            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select count(*) from pois";
            String run = cmd.ExecuteScalar().ToString();
            baglanti.Close();
            return run;


        }


        public static string ToplamKategori()
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select count(*) from categories";
            String run = cmd.ExecuteScalar().ToString();
            baglanti.Close();
            return run;
        }
        
        public static DataTable KategoriGetir()
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select * from categories";            
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }

        public static object YerlerGetir(int sec)
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            if(sec == 0)
            { 
            cmd.CommandText = "select id as ID,name as İSİM,intro as TÜR from pois";
            }
            else { 
            cmd.CommandText = "select id as ID,name as İSİM,intro as TÜR from pois where category_id=@sec";
            }
            cmd.Parameters.AddWithValue("@sec", sec);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();            
            da.Fill(dt);            
            baglanti.Close();
            return dt;            
        }


        public static DataTable DetayGetir(int id)
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select * from pois where id=@id";
            cmd.Parameters.AddWithValue("id",id);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }

        public static void favori(int id)
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select favorite from pois where id=@id";
            cmd.Parameters.AddWithValue("id",id);
            String run = cmd.ExecuteScalar().ToString();
            SQLiteCommand up = baglanti.CreateCommand();              
            if(run == "0")
            { 
                up.CommandText = "update pois set favorite=@durum where id=@id";
                up.Parameters.AddWithValue("@durum", 1);
                up.Parameters.AddWithValue("@id",id);
                up.ExecuteNonQuery();
            }
            else
            {
                up.CommandText = "update pois set favorite=@durum where id=@id";
                up.Parameters.AddWithValue("@durum", 0);
                up.Parameters.AddWithValue("@id", id);
                up.ExecuteNonQuery();
            }
            
            baglanti.Close();
        }

        public static object FavoriGetir()
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select id as ID,name as İSİM,intro as TÜR from pois where favorite=@favori";            
            cmd.Parameters.AddWithValue("@favori", 1);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();            
            da.Fill(dt);            
            baglanti.Close();
            return dt;            
        }



        public static String KategoriGetir(Int64 id)
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select name from categories where id=@id";
            cmd.Parameters.AddWithValue("@id",id);
            String veri = cmd.ExecuteScalar().ToString();            
            baglanti.Close();
            return veri;
        }

        public static object GezdigimYerler()
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select id as ID,name as İSİM,intro as TÜR from pois where gezdim=@id";
            cmd.Parameters.AddWithValue("@id", 1);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;           
        }

        public static void NotKaydet(int id,String not)
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "update pois set notlarim=@not where id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@not", not);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }


        public static void gezdim(int id)
        {
            baglanti.Open();
            SQLiteCommand cmd = baglanti.CreateCommand();
            cmd.CommandText = "select gezdim from pois where id=@id";
            cmd.Parameters.AddWithValue("id", id);
            String run = cmd.ExecuteScalar().ToString();
            SQLiteCommand up = baglanti.CreateCommand();
            if (run == "0")
            {
                up.CommandText = "update pois set gezdim=@durum where id=@id";
                up.Parameters.AddWithValue("@durum", 1);
                up.Parameters.AddWithValue("@id", id);
                up.ExecuteNonQuery();
            }
            else
            {
                up.CommandText = "update pois set gezdim=@durum where id=@id";
                up.Parameters.AddWithValue("@durum", 0);
                up.Parameters.AddWithValue("@id", id);
                up.ExecuteNonQuery();
            }

            baglanti.Close();
        }


    }
}
