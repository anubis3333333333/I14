namespace InstituteApp {
    class Student {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Group;

        public Student(string firstName , string lastName , int age , string group ){
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Group = group;
        }

        public void Introduce(){
            Console.WriteLine($"Привет меня зовут {FirstName} {LastName}");
            Console.WriteLine($"Мне {Age} ЛЕТ");
        }
        
        public void Study(){
            Console.WriteLine($"{FirstName} изучает ООП");
        }
        
    }

}