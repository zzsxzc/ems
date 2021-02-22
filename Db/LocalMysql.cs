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

        //计件分录(每人/日)
        public List<Jjmain> getJjmain()
        {
            List<Jjmain> Jjmains=new List<Jjmain>();

            MySqlConnection connect = new MySqlConnection(conStr);
            try
            {
                connect.Open();//建立连接，可能出现异常,使用try catch语句
                string query = "SELECT * FROM ems_jjmain;";  //sql查询语句
                MySqlCommand cmd = new MySqlCommand(query, connect);    //将查询语句放进该数据库容器中
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {
                    //类型转换 空指针

                    Jjmain jjmain = new Jjmain();
                    jjmain.Id = changeToInt(dataReader[0]);
                    jjmain.Empcategory = dataReader[1].ToString();
                    jjmain.Group = dataReader[2].ToString();
                    jjmain.Empname = dataReader[3].ToString();
                    jjmain.Empid = changeToInt(dataReader[4]);
                    jjmain.Gxgz = dataReader[5].ToString();
                    jjmain.Rygz = dataReader[6].ToString();
                    jjmain.Gwmx = dataReader[7].ToString();
                    jjmain.Btlcategory = dataReader[8].ToString();
                    jjmain.Spdj = changeToDouble(dataReader[9]);
                    jjmain.Xs = changeToDouble(dataReader[10]);
                    jjmain.Sjjp = changeToDouble(dataReader[11]);
                    jjmain.Cl = changeToDouble(dataReader[12]);
                    jjmain.Rgz = changeToDouble(dataReader[13]);
                    jjmain.Llgs = changeToDouble(dataReader[14]);
                    jjmain.Workdate = dataReader[15] == null ? null : dataReader[15].ToString();

                    Jjmains.Add(jjmain);
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

        //两个参数, 如果参数b tostring为"",a和b赋值-1
        private int changeToInt(Object o)
        {
            if(o.ToString().Equals(""))
            {
                return -1;
            }
            else
            {
                return int.Parse(o.ToString());
            }    
        }

        private double changeToDouble(Object o)
        {
            if (o.ToString().Equals(""))
            {
                return -1;
            }
            else
            {
                return double.Parse(o.ToString());
            }
        }

    }
}
