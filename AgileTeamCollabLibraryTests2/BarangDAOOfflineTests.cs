using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileTeamCollabLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileTeamCollabLibrary.Tests
{
    [TestClass()]
    public class BarangDAOOfflineTests
    {

        BarangDAOOffline test = new BarangDAOOffline();

        //INSERT
        [TestMethod()]
        public void InsertTest()
        {
            Assert.AreEqual(1, test.Insert("P001", "Melon", 5000, (decimal)5.5));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertHargaMinus()
        {
            test.Insert("P001", "Melon", -5000, (decimal)5.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertPajakMinus()
        {
            test.Insert("P002", "Melon", 5000, (decimal)-5.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertPajakNol()
        {
            test.Insert("P003", "Melon", 5000, (decimal)0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertPajakLebih100()
        {
            test.Insert("P004", "Melon", 5000, (decimal)101.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertKodeKosong()
        {
            test.Insert("", "Melon", 5000, (decimal)10);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertNamaKosong()
        {
            test.Insert("P005", "", 5000, (decimal)10);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertKodeLebih4Karakter()
        {
            test.Insert("P0011", "Melon", 5000, (decimal)10);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertNamaLebih50Karakter()
        {
            test.Insert("P006", "Melonnmmnmnmnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnskgjsheehsaufhukeasfhafwahfwaufgaufihawfl;DPAEIFIAIUKFAJsfjshegiusefnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn", 5000, (decimal)5.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertKodeSama()
        {
            test.Insert("P001", "Melon", 5000, (decimal)10);
            test.Insert("P001", "Melon", 5000, (decimal)10);
        }

        //UPDATE
        [TestMethod()]
        public void UpdateTest()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            Assert.AreEqual(1,test.Update("P001", "Semangka", 10000, (decimal)5.5));

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUpdateHargaMinus()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Update("P001", "Semangka", -10000, (decimal)5.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUpdatePajakMinus()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Update("P001", "Semangka", 10000, (decimal)-5.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUpdatePajakNol()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Update("P001", "Semangka", 10000, (decimal)0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUpdatePajakLebih100()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Update("P001", "Semangka", 10000, (decimal)105);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUpdateKodeKosong()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Update("", "Semangka", 10000, (decimal)5.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUpdateNamaKosong()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Update("P001", "", 10000, (decimal)5.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUpdateKodeLebih4Karakter()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Update("P00123", "Semangka", 10000, (decimal)5.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUpdateNamaLebih50Karakter()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Update("P001", "Melonnmmnmnmnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnskgjsheehsaufhukeasfhafwahfwa" +
                "ufgaufihawfl;DPAEIFIAIUKFAJsfjshegiusefnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn", 5000, (decimal)5.5);
    
        }

        //GetDataBarang
        [TestMethod()]
        public void GetDataBarangByKodeTest()
        {
            Barang c = new Barang { Kode = "P001", Nama = "Melon", Harga = 5000, Pajak = (decimal)5.5 };
            test.Insert(c.Kode,c.Nama,c.Harga,c.Pajak);
            Assert.AreEqual(c.Kode, test.GetDataBarangByKode("P001").Kode);
            Assert.AreEqual(c.Harga, test.GetDataBarangByKode("P001").Harga);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetBarangByKodeKosong()
        {
            Barang c = new Barang { Kode = "P001", Nama = "Melon", Harga = 5000, Pajak = (decimal)5.5 };
            test.Insert(c.Kode, c.Nama, c.Harga, c.Pajak);
            Assert.AreEqual(c.Kode, test.GetDataBarangByKode("").Kode);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetBarangByKodeLebih4Karakter()
        {
            Barang c = new Barang { Kode = "P001", Nama = "Melon", Harga = 5000, Pajak = (decimal)5.5 };
            test.Insert(c.Kode, c.Nama, c.Harga, c.Pajak);
            Assert.AreEqual(c.Kode, test.GetDataBarangByKode("12345").Kode);
        }


        //DELETE
        [TestMethod()]
        public void DeleteTest()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            Assert.AreEqual(test.Delete("P001"), 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDeleteKodeKosong()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Delete("");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDeleteKodeLebih4Karakter()
        {
            test.Insert("P001", "Melon", 5000, (decimal)5.5);
            test.Delete("QWERTY");
        }
    }
}