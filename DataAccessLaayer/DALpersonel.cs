using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLaayer
{
    public class DALpersonel
    {
        public static List<Personel> PersonelListesi()
        {
            List<Personel> degerler = new List<Personel>();//değerler isimli nesne türettik.
            SqlCommand komut1 = new SqlCommand("select * from TBL_PERSONEL", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                Personel pr = new Personel();
                pr.Id = int.Parse(dr["ID"].ToString());
                pr.Ad = dr["AD"].ToString();
                pr.Soyad = dr["SOYAD"].ToString();
                pr.Sehir = dr["SEHIR"].ToString();
                pr.Gorevi = dr["GOREV"].ToString();
                pr.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(pr);


            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEKle(Personel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBL_PERSONEL (AD,SOYAD,SEHIR,GOREV,MAAS) VALUES (@P1,@P2,@P3,@P4,@P5)", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Sehir);
            komut2.Parameters.AddWithValue("@p4", p.Gorevi);
            komut2.Parameters.AddWithValue("@p5", p.Maas);
           return komut2.ExecuteNonQuery();

        }
         
        public static int PersonelSil (Personel s)
        {
            SqlCommand komut2 = new SqlCommand("delete from TBL_PERSONEL where ID=@p1",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1",s.Id);
            return komut2.ExecuteNonQuery();

        }

        public static bool PersonelGuncelle(Personel g)
        {
            SqlCommand komut4 = new SqlCommand("update  TBL_PERSONEL  set AD=@P1,SOYAD=@P2,SEHIR=@P3,GOREV=@P4,MAAS=@P5 WHERE ID=@P6",Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1",g.Ad);
            komut4.Parameters.AddWithValue("@P2",g.Soyad);
            komut4.Parameters.AddWithValue("@P3", g.Sehir);
            komut4.Parameters.AddWithValue("@P4", g.Gorevi);
            komut4.Parameters.AddWithValue("@P5", g.Maas);
            komut4.Parameters.AddWithValue("@P6", g.Id);
            return komut4.ExecuteNonQuery()>0;



        }

    }
}
