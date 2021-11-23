using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO.NET.LINQ
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        GeographyServerDataContext db;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Geography; Integrated Security = true;");
            comboBox1.Items.Add("All Continents");
            comboBox1.Items.Add("All Countries");
            comboBox1.Items.Add("All Capital Cities");
            comboBox1.Items.Add("Top 5 countries according to area");
            comboBox1.Items.Add("Top 5 countries according to population");
            comboBox1.Items.Add("Top 5 cities according to population");
            comboBox1.Items.Add("Top 3 continents according to area");
            comboBox1.Items.Add("Top 3 continents according to population");
            db = new GeographyServerDataContext();
        }

        private void creationbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string []queries = {"CREATE TABLE CONTINENTS(ID INT IDENTITY(1,1)  NOT NULL PRIMARY KEY, NAME NVARCHAR(50) NOT NULL)",
                            @"CREATE TABLE COUNTRIES(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,NAME NVARCHAR(50) NOT NULL,CONTINENTID INT NOT NULL FOREIGN KEY REFERENCES CONTINENTS (ID),AREA INT NOT NULL)",
                            @"CREATE TABLE CITIES(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,NAME NVARCHAR(50),COUNTRYID INT NOT NULL FOREIGN KEY REFERENCES COUNTRIES(ID),
                            POPULATION_ INT NOT NULL,CAPITAL BIT NOT NULL,)"};
           
            for (int i = 0; i < queries.Length; i++)
            {
                SqlCommand command = new SqlCommand(queries[i], connection);
                command.ExecuteNonQuery();
            }
           
      
            MessageBox.Show("DataBase is ready");
            connection.Close();
        }

        private void fillbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
        
            db.CONTINENTs.InsertOnSubmit(new CONTINENT() { NAME = "ASIA" });
            db.CONTINENTs.InsertOnSubmit(new CONTINENT() { NAME = "AFRICA" });
            db.CONTINENTs.InsertOnSubmit(new CONTINENT() { NAME = "NORTH AMERICA" });
            db.CONTINENTs.InsertOnSubmit(new CONTINENT() { NAME = "SOUTH AMERICA" });
            db.CONTINENTs.InsertOnSubmit(new CONTINENT() { NAME = "ANTARCTICA" });
            db.CONTINENTs.InsertOnSubmit(new CONTINENT() { NAME = "EUROPE" });

            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "CHINA", CONTINENTID = 1, AREA = 9596961 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "RUSSIA", CONTINENTID = 1, AREA = 17098242 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "TURKEY", CONTINENTID = 1, AREA = 783562 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "LIBYA", CONTINENTID = 2, AREA = 1759540 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "TUNUSIA", CONTINENTID = 2, AREA = 10486339 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "BARBADOS", CONTINENTID = 3, AREA =430 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "CANADA", CONTINENTID = 3, AREA = 9984670 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "ARGENTINA", CONTINENTID = 4, AREA = 2766890 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "BRAZIL", CONTINENTID = 4, AREA = 8514877 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "FRANCE", CONTINENTID = 6, AREA = 640679 });
            db.COUNTRies.InsertOnSubmit(new COUNTRy() { NAME = "NORWAY", CONTINENTID = 6, AREA = 385207 });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Guangzhou-Foshan", COUNTRYID =1, POPULATION_ = 20597000, CAPITAL = false });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Moscow", COUNTRYID = 2, POPULATION_ = 16170000, CAPITAL = true });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Istanbul", COUNTRYID = 3, POPULATION_ = 13287000, CAPITAL = true });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Buenos Aires", COUNTRYID = 8, POPULATION_ = 14122000, CAPITAL = true });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Paris", COUNTRYID = 10, POPULATION_ = 10858000, CAPITAL = true});
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Chengdu", COUNTRYID = 1, POPULATION_ = 10376000, CAPITAL = false });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "St. Petersburg", COUNTRYID = 2, POPULATION_ = 5126000, CAPITAL = false });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Tripoli", COUNTRYID = 4, POPULATION_ = 2220000, CAPITAL = false });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Tunis", COUNTRYID = 5, POPULATION_ = 638845, CAPITAL = true });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Jumayl", COUNTRYID = 4, POPULATION_ = 39344, CAPITAL = false});
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Toronto", COUNTRYID = 7, POPULATION_ = 20597000, CAPITAL = true});
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Ottawa", COUNTRYID = 1, POPULATION_ = 934243, CAPITAL = false });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Santa Fe", COUNTRYID = 8, POPULATION_ = 490171, CAPITAL = false });
            db.CITies.InsertOnSubmit(new CITy() { NAME = "Salvador", COUNTRYID = 9, POPULATION_ = 2900319, CAPITAL = false });
            db.SubmitChanges();
            connection.Close();

            MessageBox.Show("DataBase is ready");
        }

        private void runbutton_Click(object sender, EventArgs e)
        {
            string txt = comboBox1.SelectedItem.ToString();
            switch (txt)
            {
                case "All Continents":
                    datagrid.DataSource = db.CONTINENTs.OrderBy(x=>x.ID).Select(x => new { x.NAME });                     
                    break;
                case "All Countries":
                    datagrid.DataSource = db.COUNTRies.OrderBy(x => x.ID).Select(x => new { x.NAME });
                    break;
                case "All Capital Cities":
                    datagrid.DataSource = db.CITies.Where(x=>x.CAPITAL==true).Select(x => new { x.NAME });
                break;
                case "Top 5 countries according to area":
                    datagrid.DataSource = db.COUNTRies.Select(x=> new { x.NAME, x.AREA }).OrderByDescending(x => x.AREA).Take(5).Select(z=>new { z.NAME,z.AREA});
                    break;
                case "Top 5 countries according to population":
                    datagrid.DataSource = db.COUNTRies.OrderByDescending(x => x.CITies.Sum(y => y.POPULATION_)).Take(5).Select(z=>new { z.NAME,z.CITies });
                    break;
                case "Top 5 cities according to population":
                    datagrid.DataSource = db.CITies.OrderByDescending(x => x.POPULATION_).Take(3).Select(z=>new {z.NAME,z.POPULATION_ });
                    break;
                case "Top 3 continents according to area":
                    datagrid.DataSource = db.CONTINENTs.OrderByDescending(x => x.COUNTRies.Sum(y => y.AREA)).Take(3).Select(z=>new { z.NAME,z.COUNTRies });
                    break;
                case "Top 3 continents according to population":
                    datagrid.DataSource = db.CONTINENTs.OrderByDescending(x => x.COUNTRies.Sum(y => y.CITies.Sum(z => z.POPULATION_))).Take(3).Select(i => new { i.NAME}) ;
                    break;
                default:
                    break;
            }
        }

        private void datagrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int text = datagrid.SelectedCells[0].RowIndex+1;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "All Continents":
                    datagrid.DataSource = db.COUNTRies.Where(x => x.CONTINENTID == text).Select(y => new { y.NAME });
                    break;
                case "All Countries":
                    datagrid.DataSource = db.CITies.Where(x => x.COUNTRYID == text).Select(y => new { y.NAME });
                    break;
                default:
                    break;
            }
            
     
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString())
            {
                case "All Continents":
                    datagrid.DataSource = db.CONTINENTs.OrderBy(x => x.ID).Select(x => new { x.NAME });
                    break;
                case "All Countries":
                    datagrid.DataSource = db.COUNTRies.OrderBy(x => x.ID).Select(x => new { x.NAME });
                    break;
                default:
                    break;
            }
        }
    }
}
