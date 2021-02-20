using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ems2.Models;
using MySql.Data.MySqlClient;
/**
 * 数据库操作都放在这里面
 */
namespace ems2.Db
{
    
    public class LocalMysql
    {
        //连接参数
        static string conStr = "server=127.0.0.1;port=3306;user=root;password=jtwmydtsgx@666; database=ems;CharSet=utf8;";//数据库的信息


        public List<Jjmain> getJjmain()
        {
            List<Jjmain> Jjmains=null;

            MySqlConnection connect = new MySqlConnection(conStr);
            try
            {
                connect.Open();//建立连接，可能出现异常,使用try catch语句
                string query = "SELECT * FROM ems_jjmain;";  //sql查询语句
                MySqlCommand cmd = new MySqlCommand(query, connect);    //将查询语句放进该数据库容器中
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {

                    Jjmain jjmain = new Jjmain();
                    jjmain.Id = int.Parse(dataReader[0].ToString());
                    jjmain.Empcategory = dataReader[1].ToString();
                    jjmain.Group = dataReader[2].ToString();
                    jjmain.Empname = dataReader[3].ToString();
                    jjmain.Empid = int.Parse(dataReader[4].ToString());
                    jjmain.gx = dataReader[1].ToString();
                    jjmain.Group = dataReader[2].ToString();
                    jjmain.Empname = dataReader[3].ToString();
                    jjmain.Empname = dataReader[3].ToString();

                    //
                    //Console.WriteLine(dataReader[0].ToString() + " " +
                    //                            dataReader[1].ToString() + " " +
                    //                            dataReader[2].ToString() + " " +
                    //                            dataReader[3].ToString() + " " +
                    //                            dataReader[4].ToString() + " " +
                    //                            dataReader[5].ToString() + " " +
                    //                            dataReader[6].ToString() + " " +
                    //                            dataReader[7].ToString() + " " +
                    //                            dataReader[8].ToString() + " " +
                    //                            dataReader[9].ToString() + " " +
                    //                            dataReader[10].ToString() + " " +
                    //                            dataReader[11].ToString() + " " +
                    //                            dataReader[12].ToString() + " " +
                    //                            dataReader[13].ToString() + " " +
                    //                            dataReader[14].ToString() + " " +
                    //                            dataReader[15].ToString()
                    //    );
                }
                //MessageBox.Show("恭喜，已经建立连接！");
                Console.ReadLine();
                return Jjmains;
            }
            catch (MySqlException exe)
            {
                return null;
            }
            finally
            {
                connect.Close();//关闭通道
            }
        }

    }
}
