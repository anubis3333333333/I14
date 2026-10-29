namespace InstituteApp {
    class Student {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Group;

        public void Introduce(){
            Console.WriteLine($"Привет меня зовут {FirstName} {LastName}");
            Console.WriteLine($"Мне {Age} ЛЕТ");
        }
        
        public void Study(){
            Console.WriteLine($"{FirstName} изучает ООП");
        }
        
    }

}