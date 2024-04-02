using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RPG_G
{
    internal class Program
    {
        //Create\Drop table-------------------------------------------------------------------------------------------------------
        public static void cre_or_dr_t(int num) 
        {
            Console.WriteLine("\n1.Create table\n2.Drop table");
            Console.WriteLine("\nEnter number:");
            int num2=int.Parse(Console.ReadLine());
            SqlConnection mySqlConn = new SqlConnection("server=localhost\\SQLEXPRESS;database=RPG_GAME;Integrated Security=SSPI;");
            SqlCommand myComm = mySqlConn.CreateCommand();
            mySqlConn.Open();
            if (num2 == 1)
            {
                Console.WriteLine("Enter table name:");
                string tablename = Console.ReadLine();
                Console.WriteLine("Enter column name:");
                string colname = Console.ReadLine();
                Console.WriteLine("Enter column type:");
                string coltype = Console.ReadLine();
                Console.WriteLine("not null?");
                string nnull = Console.ReadLine();
                myComm.CommandText = "create table " + tablename + "(" + colname + " " + coltype + " " + nnull + ");";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe table has been created");
                Console.ReadKey();
            }  
            if(num2 == 2)
            {
                Console.WriteLine("Enter table name:");
                string tablename = Console.ReadLine();
                myComm.CommandText = "drop table " + tablename + "";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe table has been dropped");
                Console.ReadKey();
            }
        }

        //ALTER TABLE-------------------------------------------------------------------------------------------------------------

        public static void alter_t(int num)
        {
            Console.WriteLine("\n1.Add column\n2.Drop column\n3.Add constraint to column");
            Console.WriteLine("\nEnter number:");
            int num1=int.Parse(Console.ReadLine());
            SqlConnection mySqlConn = new SqlConnection("server=localhost\\SQLEXPRESS;database=RPG_GAME;Integrated Security=SSPI;");
            SqlCommand myComm = mySqlConn.CreateCommand();
            mySqlConn.Open();
            if (num1 == 1)
            {
                Console.WriteLine("Enter table name:");
                string tablename = Console.ReadLine();
                Console.WriteLine("Enter column name:");
                string colname = Console.ReadLine();
                Console.WriteLine("Enter column type:");
                string coltype = Console.ReadLine();
                Console.WriteLine("null?:");
                string nnull = Console.ReadLine();
                Console.WriteLine("primary key:");
                string pkey = Console.ReadLine();
                myComm.CommandText = "alter table " + tablename + " add " + colname + " " + coltype + " "+nnull+ " " + pkey + "";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe column has been added into table");
                Console.ReadKey();
            }
            if(num1 == 2)
            {
                Console.WriteLine("Enter table name:");
                string tablename = Console.ReadLine();
                Console.WriteLine("Enter column name:");
                string colname = Console.ReadLine();
                myComm.CommandText = "alter table " + tablename + " drop column " + colname + "" ;
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe column has been dropped from table");
                Console.ReadKey();
            }
            if( num1 == 3)
            {
                Console.WriteLine("Enter table name:");
                string tablename = Console.ReadLine();
                Console.WriteLine("Enter column name:");
                string coln1 = Console.ReadLine();
                Console.WriteLine("Enter column name:");
                string coln2 = Console.ReadLine();
                Console.WriteLine("Enter column name:");
                string coln3 = Console.ReadLine();
                Console.WriteLine("Enter pkey name:");
                string pkeyname = Console.ReadLine();
                myComm.CommandText = "alter table " + tablename + " add constraint "+pkeyname+" primary key ("+coln1+ "," + coln2 + "," + coln3 + ")";
                mySqlConn.Close();
                Console.WriteLine("\n\nThe primary key has been added");
                Console.ReadKey();
            }
            if (num1 == 4)
            {
                Console.WriteLine("Enter table name F:");
                string tnF = Console.ReadLine();
                Console.WriteLine("Enter column name F:");
                string colnF = Console.ReadLine();
                Console.WriteLine("Enter table name P:");
                string tnP = Console.ReadLine();
                Console.WriteLine("Enter column name:");
                string colnP = Console.ReadLine();
                myComm.CommandText = "alter table " + tnF + " add foreign key (" + colnF + ") references " + tnP + "(" + colnP + ")";
                mySqlConn.Close();
                Console.WriteLine("\n\nThe foreign key has been added");
                Console.ReadKey();
            }

            mySqlConn.Close();
        }

        //INSERT INTO TABLE-------------------------------------------------------------------------------------------------------

        public static void insert_r(int num)
        {
            Console.WriteLine("Enter table name:");
            string tablename = Console.ReadLine();
            SqlConnection mySqlConn = new SqlConnection("server=localhost\\SQLEXPRESS;database=RPG_GAME;Integrated Security=SSPI;");
            SqlCommand myComm = mySqlConn.CreateCommand();
            mySqlConn.Open();
            if (String.Equals(tablename, "Users"))
            {
                Console.WriteLine("Enter ID:");
                string ID = Console.ReadLine();
                Console.WriteLine("Enter e-mail:");
                string email = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string pass = Console.ReadLine();
                Console.WriteLine("Enter date of birth:");
                string DofB = Console.ReadLine();
                Console.WriteLine("Enter sex:");
                string sex = Console.ReadLine();
                Console.WriteLine("Enter state:");
                string state = Console.ReadLine();
                myComm.CommandText = "insert into " + tablename + " values('" + ID + "','" + email + "','" + pass + "','" + sex + "','" + DofB + "','" + state + "');";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe data has been added into table");
                Console.ReadKey();
            }

            if (String.Equals(tablename, "Purse"))
            {
                Console.WriteLine("Enter ID:");
                string ID = Console.ReadLine();
                Console.WriteLine("Enter date:");
                string date = Console.ReadLine();
                Console.WriteLine("Enter amount:");
                string amount = Console.ReadLine();
                Console.WriteLine("Enter date:");
                string item = Console.ReadLine();
                Console.WriteLine("Enter number of items:");
                string num_of_item = Console.ReadLine();
                myComm.CommandText = "insert into " + tablename + " values('" + ID + "','" + date + "','" + amount + "','" + item + "','" + num_of_item + "');";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe data has been added into table");
                Console.ReadKey();
            }
            if (String.Equals(tablename, "Inventory"))
            {
                Console.WriteLine("Enter nick name:");
                string n_name = Console.ReadLine();
                Console.WriteLine("Enter item:");
                string item = Console.ReadLine();
                Console.WriteLine("Enter number of items:");
                string num_of_item = Console.ReadLine();
                myComm.CommandText = "insert into " + tablename + " values('" + n_name + "','" + item + "','" + num_of_item + "');";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe data has been added into table");
                Console.ReadKey();
            }

            if (String.Equals(tablename, "Character"))
            {
                Console.WriteLine("Enter ID:");
                string ID = Console.ReadLine();
                Console.WriteLine("Enter LVL:");
                string lvl = Console.ReadLine();
                Console.WriteLine("Enter exp:");
                string exp = Console.ReadLine();
                Console.WriteLine("Enter sex:");
                string sex = Console.ReadLine();
                Console.WriteLine("Enter nick name:");
                string nick = Console.ReadLine();
                myComm.CommandText = "insert into " + tablename + " values('" + ID + "','" + lvl + "','" + exp + "','" + sex + "','" + nick + "');";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe data has been added into table");
                Console.ReadKey();
            }

            if (String.Equals(tablename, "Skills"))
            {
                Console.WriteLine("Enter nick name:");
                string nick = Console.ReadLine();
                Console.WriteLine("Enter LVL:");
                string lvl = Console.ReadLine();
                Console.WriteLine("Enter skill:");
                string skill = Console.ReadLine();
                myComm.CommandText = "insert into " + tablename + " values('" + nick + "','" + lvl + "','" + skill + "');";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe data has been added into table");
                Console.ReadKey();
            }


            mySqlConn.Close();
        }

        //SELECT-------------------------------------------------------------------------------------------------------------------

        static public void select_t(int num)
        {
            SqlConnection mySqlConn = new SqlConnection("server=localhost\\SQLEXPRESS;database=RPG_GAME;Integrated Security=SSPI;");
            SqlCommand myComm = mySqlConn.CreateCommand();
            mySqlConn.Open();
            Console.WriteLine("\n1.Select column where...\n2.Select + Inner Join");
            Console.WriteLine("Enter number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter table name:");
            string tablename = Console.ReadLine();
            //------------------------------------------------------------
            int c = 1, i = 0;
            if (num1 == 1)
            {
                Console.WriteLine("Enter columns:");
                string col = Console.ReadLine();
                while (i < col.Length)
                {
                    if (col[i] == ' ')
                        c++;
                    i++;
                }
                Console.WriteLine("Enter condition");
                string cond = Console.ReadLine();
                
                Console.WriteLine("\t" + col);
                i = 0;
                myComm.CommandText = "select " + col + " from " + tablename + " where " + cond + "";
                SqlDataReader mySqlDataReader = myComm.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    while (i < c)
                    {
                        Console.Write("   " + mySqlDataReader[i].ToString());
                        i++;
                    }
                    Console.WriteLine();
                    i = 0;
                }

                mySqlDataReader.Close();
            }
            if (num1 == 2)
            {
                Console.WriteLine("Enter table.column");
                string tabC = Console.ReadLine();
                Console.WriteLine("Enter table name 2:");
                string table2= Console.ReadLine();
                Console.WriteLine("Enter table.column=table2.column2");
                string tabC2=Console.ReadLine();
                c = 1;
                while (i < tabC.Length)
                {
                    if (tabC[i] == ' ')
                        c++;
                    i++;
                }
                Console.WriteLine("\t" + tabC);
                i = 0;
               
                myComm.CommandText = "select " +tabC+ " from " + tablename + " inner join "+table2+" on "+tabC2+""; 
                //table 1 ... join table 2 on tablename.columnname=tablename.columnname
                SqlDataReader mySqlDataReader = myComm.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    while (i < c)
                    {
                        Console.Write("     "+mySqlDataReader[i].ToString());
                        i++;
                    }
                    Console.WriteLine();
                    i = 0;
                }

                mySqlDataReader.Close();

            }
            
            mySqlConn.Close();
            Console.ReadKey();

        }
        
        //UPDATE-------------------------------------------------------------------------------------------------------------------
        static public void update_t(int num)
        {
            SqlConnection mySqlConn = new SqlConnection("server=localhost\\SQLEXPRESS;database=RPG_GAME;Integrated Security=SSPI;");
            SqlCommand myComm = mySqlConn.CreateCommand();
            mySqlConn.Open();
                Console.WriteLine("Enter table name:");
                string tablename = Console.ReadLine();
                Console.WriteLine("Enter column name:");
                string colname = Console.ReadLine();
                Console.WriteLine("value");
                string val = Console.ReadLine();
                Console.WriteLine("Enter condition:");
                string cond = Console.ReadLine();
                
                myComm.CommandText = "update " + tablename + " set "+colname+"="+val+" where "+cond+"";
                myComm.ExecuteNonQuery();
                mySqlConn.Close();
                Console.WriteLine("\n\nThe table has been updated");
                Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Main menu:\n1.Create table\n2.Alter table\n3.Insert into table\n4.Select\n5.Update\n6.Exit(-1)");
            Console.WriteLine("\nEnter number:");
            int num = int.Parse(Console.ReadLine());
            if(num>6)
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                switch (num)
                {
                    case 1:
                    cre_or_dr_t(num);
                        break;
                    case 2:
                    alter_t(num);
                        break;
                    case 3:
                    insert_r(num);
                        break;
                    case 4:
                    select_t(num);
                        break;
                    case 5:
                        update_t(num);
                        break;

                }

                Console.Clear();
                Console.WriteLine("Main menu:\n1.Create table\n2.Alter table\n3.Insert into table\n4.Select\n5.Update\n6.Exit(-1)");
                Console.WriteLine("\nEnter number:");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
