using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.PageModels.PageFactory;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;

namespace NUnit_Auto_2022.Tests
{
    //[Parallelizable(ParallelScope.Children)]
    class AuthTest : BaseTest
    {

        string url = FrameworkConstants.GetUrl();

        // not recommended 
        private static IEnumerable<TestCaseData> GetCredentialsData()
        {
            yield return new TestCaseData("user1", "pass1");
            yield return new TestCaseData("user2", "pass2");
            yield return new TestCaseData("user3", "pass3");
            yield return new TestCaseData("user4", "pass4");
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestData\\credentials.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (index > 0)
                    {
                        yield return new TestCaseData(values[0], values[1]);
                    }
                    index++;
                }
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv2()
        {
            foreach (var values in Utils.GetGenericData("TestData\\credentials.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv3()
        {
            var csvData = Utils.GetDataTableFromCsv("TestData\\credentials.csv");
            for (int i = 0; i < csvData.Rows.Count; i++)
            {
                yield return new TestCaseData(csvData.Rows[i].ItemArray);
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataExcel()
        {
            var excelData = Utils.GetDataTableFromExcel("TestData\\credentials.xlsx");
            for (int i = 1; i < excelData.Rows.Count; i++)
            {
                yield return new TestCaseData(excelData.Rows[i].ItemArray);
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataJson()
        {
            var credentials = Utils.JsonRead<DataModels.Credentials>("TestData\\credentials.json");
            yield return new TestCaseData(credentials.Username, credentials.Password);
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataModels.Credentials));
            foreach (var file in Utils.GetAllFilesInFolderExt("TestData\\", "*.xml"))
            {
                Console.WriteLine("Testing with file: " + file);
                using (Stream reader = new FileStream(file, FileMode.Open))
                {
                    var credentials = (DataModels.Credentials)serializer.Deserialize(reader);
                    yield return new TestCaseData(credentials.Username, credentials.Password);
                }
            }

        }

        private static IEnumerable<TestCaseData> GetCredentialsDb()
        {

            // connecting to DB 
            using (MySqlConnection con = new MySqlConnection(FrameworkConstants.decryptedCon))
            {
                //opening connection
                con.Open();
                // prepare to run the query in the DB
                string query = "select username, password from test.credentialsAG;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                //run the query in the db and get the data row by row
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return new TestCaseData(reader["username"].ToString(), reader["password"].ToString());
                    }
                }

            }

        }

        private static IEnumerable<TestCaseData> GetCredentialsDbEf()
        {
            /*            DataModels.DbConnString connString = Utils.JsonRead<DataModels.DbConnString>("appsettings.json");
                        string conDetails = Utils.Decrypt(connString.ConnectionStrings.DefaultConnection, "btauto2022");*/
            //Map the DB table to EF model
            using (var context = new Other.CredentialsDbContext(FrameworkConstants.decryptedCon))
            {
                var credentials = context.credentialsCG;
                foreach (var cred in credentials)
                {
                    yield return new TestCaseData(cred.Username, cred.Password);
                }
            }
        }

        // Test auth with Page Object model
        [Category("AuthWithDb")]
        [Category("Smoke")]
        [Test, TestCaseSource("GetCredentialsDb"), Order(1)]
        public void BasicAuth(string username, string password)
        {
            _driver.Navigate().GoToUrl(url + "login");
            // This is beacuse we have 2 classes named LoginPage one on POM other on PageFactory
            // In real life framework you will have just one type of desigm pattern (POM/PF)
            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(_driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username, password);
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
        }

        private static string[] GetUsername = new string[]
        {
            "user1", "user2", "user3", "user4"
        };

        private static string[] GetPassword = new string[]
        {
            "pass1", "pass2", "pass3", "pass4"
        };

        // Test auth with Page factory
        [Category("AuthPageFactory")]
        [Test, Order(2), Category("Smoke")]
        //[Parallelizable(ParallelScope.Self)]
        public void BasicAuthPf([ValueSource("GetUsername")] string username, [ValueSource("GetPassword")] string password)
        {
            _driver.Navigate().GoToUrl(url + "login");
            PageModels.PageFactory.LoginPage lp = new PageModels.PageFactory.LoginPage(_driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username, password);
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
        }


    }
}