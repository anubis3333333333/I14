namespace InstituteApp;
class Program{
    static void Main(string[] args){
        Console.WriteLine("вОЛЖСКИЙ ФИЛИАЛ ВОЛГУ");
        Student student1 = new Student("Александр", "Дугин", 81, "ИСП-243");
        Student student2 = new Student("Фридрих", "Ницше", 51, "ИСП-2222");
       

        student1.Introduce();
        Console.WriteLine();

        student2.Introduce();
        Console.WriteLine();

        student1.Study();
        student2.Study();
    }
}