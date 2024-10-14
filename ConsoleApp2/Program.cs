namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group gr1 = new Group("2ПК2");

            Student stud1 = new Student("root45", "jfhg7qi");
            Student stud2 = new Student("newuser", "kjhfd78");

            gr1.AddStudent(stud1);
            gr1.AddStudent(stud2);

            Subject biology = new Subject("Биология", 40);
            Subject mathematics = new Subject("Математика", 100);

            try
            {
                biology.AddTask("эукариоты");
                biology.AddTask("позвоночные");

                mathematics.AddTask("тригонометрия");
                mathematics.AddTask("комплексные числа");
            }
            catch( ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Random rand = new Random();
            foreach (Student student in gr1.Students) 
            {

                student.AddMark(biology, "эукариоты", rand.Next(2,6));
                student.AddMark(biology, "позвоночные", rand.Next(2, 6));

                student.AddMark(mathematics, "тригонометрия", rand.Next(2, 6));
                student.AddMark(mathematics, "комплексные числа", rand.Next(2, 6));
            }

            Console.WriteLine(gr1);
        }
    }
}
