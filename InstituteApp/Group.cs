namespace InstituteApp {
    class Group {
        public string GroupName;
        public string Direction;
        public List<Student> Students;

        public Group(string groupName, string direction){
            GroupName = groupName;
            Direction = direction;
            Students = new List<Student>();
        }

        public void AddStudent(Student student){
            Students.Add(student);
            Console.WriteLine($"{student.FirstName} {student.LastName} ДОБАВЛЕН В {GroupName}");


        }

        public void ShowAllStudents(){
            Console.WriteLine($"студенты группы {GroupName}");
            Console.WriteLine($"направление {Direction}");

            for (int i = 0; i < Students.Count; i++){
                Console.Write($"{i+1}. ");
                Students[i].Introduce();
            }
        }

        public void ShowCount(){
            Console.WriteLine($"всего студентов в группе {GroupName}: {Students.Count}");
        }
    }
}