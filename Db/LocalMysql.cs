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
                    //类型转换 空指针

                    Jjmain jjmain = new Jjmain();
                    jjmain.Id = dataReader[0]==null?-1:int.Parse(dataReader[0].ToString());
                    jjmain.Empcategory = dataReader[1] == null ? null : dataReader[1].ToString();
                    jjmain.Group = dataReader[2] == null ? null : dataReader[2].ToString();
                    jjmain.Empname = dataReader[3] == null ? null : dataReader[3].ToString();
                    //zzstag 就算数据库中为空，dataReader[4]也不为null
                    Boolean test = dataReader[4] == null ? true : false;
                    jjmain.Empid = dataReader[4] == null ? -1 : int.Parse(dataReader[4].ToString());
                    jjmain.Gxgz = dataReader[5] == null ? null : dataReader[5].ToString();
                    jjmain.Rygz = dataReader[6] == null ? null : dataReader[6].ToString();
                    jjmain.Gwmx = dataReader[7] == null ? null : dataReader[7].ToString();
                    jjmain.Btlcategory = dataReader[8] == null ? null : dataReader[8].ToString();
                    jjmain.Spdj = dataReader[9] == null ? -1 : double.Parse(dataReader[9].ToString());
                    jjmain.Xs = dataReader[10] == null ? -1 : double.Parse(dataReader[10].ToString());
                    jjmain.Sjjp = dataReader[11] == null ? -1 : double.Parse(dataReader[11].ToString());
                    jjmain.Cl = dataReader[12] == null ? -1 : double.Parse(dataReader[12].ToString());
                    jjmain.Rgz = dataReader[13] == null ? -1 : double.Parse(dataReader[13].ToString());
                    jjmain.Llgs = dataReader[14] == null ? -1 : double.Parse(dataReader[14].ToString());
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

    }
}
