namespace StudentManagementApp_WebForm.Models
{
    public class Student
    {
        public Student(string name, string email, string regNo, int deptId):this()
        {
            Name = name;
            Email = email;
            RegNo = regNo;
            DeptID = deptId;

        }

        public Student()
        {
            
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }
        public int DeptID { get; set; }
       
    }
}