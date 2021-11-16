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
            string[] queries = {@"INSERT INTO CONTINENTS(NAME) VALUES('ASIA')",
                                @"INSERT INTO CONTINENTS(NAME) VALUES('AFRICA')",
                                @"INSERT INTO CONTINENTS(NAME) VALUES('NORTH AMERICA')",
                                @"INSERT INTO CONTINENTS(NAME) VALUES('SOUTH AMERICA')",
                                @"INSERT INTO CONTINENTS(NAME) VALUES('ANTARCTICA')",
                                @"INSERT INTO CONTINENTS(NAME) VALUES('EUROPE')",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('CHINA',1,9596961)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('RUSSIA',1,17098242)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('TURKEY',1,783562)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('LIBYA',2,1759540)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('TUNUSIA',2,10486339)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('BARBADOS',3,430)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('CANADA',3,9984670)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('ARGENTINA',4,2766890)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('BRAZIL',4,8514877)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('FRANCE',6,640679)",
                                @"INSERT INTO COUNTRIES(NAME,CONTINENTID,AREA) VALUES ('NORWAY',6,385207)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Guangzhou-Foshan',1,20597000,1)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Moscow',2,16170000,0)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Istanbul',3,13287000,0)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Buenos Aires',8,14122000,0)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Paris',10,10858000,0)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Chengdu',1,10376000,1)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('St. Petersburg',2, 5126000,1)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Tripoli',4,2220000,0)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Jumayl',4,39344,1)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Tunis',5,638845,0)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Toronto',7,2731571,0)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Ottawa',7,934243,1)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Buenos Aires',8,13588171,0)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Santa Fe',8,490171,1)",
                                @"INSERT INTO CITIES (NAME,COUNTRYID,POPULATION_,CAPITAL) VALUES ('Salvador',9,2900319,1)" };
            for (int i = 0; i < queries.Length; i++)
            {
                SqlCommand command = new SqlCommand(queries[i], connection);
                command.ExecuteNonQuery();
            }


            MessageBox.Show("DataBase is ready");
            connection.Close();
        }
    }
}
