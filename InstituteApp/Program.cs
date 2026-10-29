namespace InstituteApp;
class Program{
    static void Main(string[] args){
        Console.WriteLine("вОЛЖСКИЙ ФИЛИАЛ ВОЛГУ");
        Student student1 = new Student("Александр", "Дугин", 81, "ИСП-243");
        Student student2 = new Student("Фридрих", "Ницше", 51, "ИСП-241");
       
        Group group1 = new Group("ИСП-241", "РАЗРАБОТКА ПО");
        Group group2 = new Group("ИСП-243", "РАЗРАБОТКА СТАНКОВ");


        group1.AddStudent(student2);
        group2.AddStudent(student1);
        Console.WriteLine();

        group1.ShowAllStudents();
        group2.ShowAllStudents();

        group1.ShowCount();
        group2.ShowCount();



        
    }
}