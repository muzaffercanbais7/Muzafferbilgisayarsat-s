using Muzafferbilgisayarsatıs.veriler;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzafferbilgisayarsatıs.ayrıntılar
{
    public static class ayrıntı
    {
        public static bool MüşteriEkle(Musteri m)
        {
            try
            {
                int res = veri.MüşteriEkle(m);

                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                DataSet ds = veri.MüşteriGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriGüncelle(Musteri m)
        {
            try
            {
                int res = veri.MüşteriGüncelle(m);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static bool MüşteriSil(string id)
        {
            try
            {
                int res = veri.MüşteriSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static bool UrunEkle(Urun u)
        {
            try
            {
                int res = veri.UrunEkle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                DataSet ds = veri.UrunGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool UrunGüncelle(Urun u)
        {
            try
            {
                int res = veri.UrunGüncelle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool UrunSil(string id)
        {
            try
            {
                int res = veri.UrunSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SatisSil(string id)
        {
            try
            {
                int res = veri.SatisSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SatisEkle(Satis s)
        {
            try
            {
                int res = veri.SatisEkle(s);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
        internal static bool SatisGüncelle(Satis s)
        {
            try
            {
                int res = veri.SatisGüncelle(s);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static DataSet OdemeDetay()
        {
            try
            {
                DataSet ds = veri.OdemeDetay();

                return ds; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool OdemeEkle(Odeme o)
        {
            try
            {
                int res = veri.OdemeEkle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet SatisDetay()
        {
            try
            {
                DataSet ds = veri.SatisDeyat();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool OdemeGüncelle(Odeme o)
        {
            try
            {
                int res = veri.OdemeGüncelle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeSil(string id)
        {
            try
            {
                int res = veri.OdemeSil(id);

                return (res > 0); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
