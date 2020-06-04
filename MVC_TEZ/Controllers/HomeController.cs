using MVC_TEZ.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TEZ.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = "Data Source=C:/anaModul.db; Version=3;";//connection string
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string aranan) {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                if (aranan.ToString() != "") {
                    var sql = "SELECT * FROM genelTablo WHERE urunAdi LIKE '%" + aranan.ToString() + "%' ORDER BY LENGTH(urunAdi) ASC";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection)) {
                        var table = new DataTable();
                        adapter.Fill(table);
                        foreach (DataRow row in table.Rows) {
                            var category = new Models.Category();
                            category.marketAdi = (row["marketAdi"].ToString());
                            category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                            category.urunAdi = (row["urunAdi"].ToString());
                            category.fiyat = Double.Parse(row["fiyat"].ToString());
                            category.indirimYüzdesi = Int32.Parse(row["indirimYuzdesi"].ToString());
                            model.Add(category);
                        }
                    }
                }
                else {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        public ActionResult Meyve(string meyveara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi='Meyve' AND urunAdi LIKE '%" + meyveara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Sebze(string sebzeara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi='Sebze' AND urunAdi LIKE '%" + sebzeara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult KirmiziEt(string kirmizietara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE 'Kırmızı Et%' AND urunAdi LIKE '%" + kirmizietara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult BeyazEt(string beyazetara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE 'Beyaz Et%' AND urunAdi LIKE '%" + beyazetara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult EtSarküteri(string etsarküteriara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Şarküteri%' AND urunAdi LIKE '%" + etsarküteriara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult BalikDeniz(string balikdenizara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Balık%Deniz%' AND urunAdi LIKE '%" + balikdenizara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Mezeler(string mezeara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Mezeler%' AND urunAdi LIKE '%" + mezeara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Sut(string sutara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Süt%' AND urunAdi LIKE '%" + sutara.ToString() + "%' ORDER BY LENGTH(urunAdi) ASC";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Peynir(string peynirara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Peynir%' AND urunAdi LIKE '%" + peynirara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Yogurt(string yogurtara="")
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Yoğurt%' AND urunAdi LIKE '%" + yogurtara.ToString() + "%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        //Buradan Sonrası Yok
        public ActionResult TereyagMargarin()
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Tereyağ%Margarin%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Yumurta()
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Yumurta%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Zeytin()
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Zeytin%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Dondurma()
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Dondurma%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult SutluTatli()
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Kerema%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }
        public ActionResult Kahvaltilik()
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM genelTablo WHERE altKategoriAdi LIKE '%Kahvaltılık%'";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.fiyat = Double.Parse(row["fiyat"].ToString());
                        category.marketAdi = (row["marketAdi"].ToString());
                        category.altkategoriAdi = (row["altkategoriAdi"].ToString());
                        category.genelkategoriAdi = (row["genelkategoriAdi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }

        public ActionResult Sale()
        {
            var model = new List<Models.Category>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var sql = "SELECT * FROM indirimliUrunler WHERE indirimDurumu != 0";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Models.Category();
                        category.urunAdi = (row["urunAdi"].ToString());
                        category.yeniFiyat = Double.Parse(row["yeniFiyat"].ToString());
                        category.indirimYüzdesi = Int32.Parse(row["indirimYuzdesi"].ToString());
                        model.Add(category);
                    }
                }
            }
            return View(model);
        }

        public ActionResult Detay()
        {
            try
            {
                ViewBag.DataPoints = JsonConvert.SerializeObject(_db.Points.ToList(), _jsonSetting);

                return View();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return View("Error");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return View("Error");
            }
        }
        private DataBaseEntities _db = new DataBaseEntities();

        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
    }
}