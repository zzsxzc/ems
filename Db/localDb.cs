using ems2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ems2.Db
{
   public class localDb
   {
        public localDb()
        {
            Init();
        }

        private List<Student> Studentls;

        private void Init()
        {
            Studentls = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                Studentls.Add(new Student()
                {
                    Id = i,
                    //xctag 标记名
                    Name = $"Sample{i}"
                }) ;

            }
        }

        public List<Student> GetStudents()
        {
            return Studentls;
        }
        
        public void AddStudent(Student stu)
        {
            Studentls.Add(stu);
        }

        public void Delstudent(int id)
        {
            var model = Studentls.FirstOrDefault(t => t.Id == id);
            if(model!=null)
            {
                Studentls.Remove(model);
            }
        }

        //根据名字查找
        public List<Student> GetStudentsByName(string name)
        {
            return Studentls.Where(q => q.Name.Contains(name)).ToList();
        }
   }
}
