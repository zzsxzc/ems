using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 把dataTime转为仅包含日期的字符串 格式2021-02-19,在excel中可以自动转为日期格式
 */

namespace ems2.Util
{
    public class Zdate
    {

        //返回日期字符串(2021-2-19)
        public static string GetDateString(DateTime date)
        {
            String y = date.Year.ToString();
            String m = date.Month.ToString();
            String d = date.Day.ToString();
            return y + "-" + m + "-" + d;
        }


        public static string GetDateString2(DateTime date)
        {
            string dateString = date.ToString();
            //2021/1/1
            //2021/11/11
            //2021/1/11
            //2021/11/1
            //未处理字符串总长度 17 18 19  对应的保留长度 8 9 10
            //先截取后面的时间信息，然后用-替换/
            int len = dateString.Length;
            if (len == 17)
            {
                dateString = dateString.Substring(0, 8);
                dateString = dateString.Replace("/", "-");
            }
            else if (len == 18)
            {
                dateString = dateString.Substring(0, 9);
                dateString = dateString.Replace("/", "-");
            }
            else
            {
                dateString = dateString.Substring(0, 10);
                dateString = dateString.Replace("/", "-");
            }

            return dateString;
        }
    }
}
