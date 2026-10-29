namespace InstituteApp;
class Program{
    static void Main(string[] args){
        Console.WriteLine("вОЛЖСКИЙ ФИЛИАЛ ВОЛГУ");

        Student student1 = new Student();
        student1.FirstName = "Александр";
        student1.LastName = "Дугин";
        student1.Age = 67;
        student1.Group = "ИСП-243";

        student1.Introduce();
        Console.WriteLine();

        Student student2 = new Student();
        student2.FirstName = "Фридрих";
        student2.LastName = "Ницше";
        student2.Age = 41;
        student2.Group = "ИСП-555";

        student2.Introduce();
        Console.WriteLine();

        student1.Study();
        student2.Study();
    }
}