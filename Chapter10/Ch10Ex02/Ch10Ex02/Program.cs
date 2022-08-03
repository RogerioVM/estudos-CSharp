namespace Ch10Ex02
{
    public class ClassA
    {
        private int state = -1;
        public int State => state;
        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA myObject = new ClassA();
            Console.WriteLine($"myObject.State = {myObject.State}");
            ClassA.ClassB myOtherObject = new ClassA.ClassB();
            myOtherObject.SetPrivateState(myObject, 999);
            Console.WriteLine($"myObject.State = {myObject.State}");

            Profile profile = new Profile();
            profile.Mostrar();
            Console.ReadKey();
        }
    }

    class Profile
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Picture { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Digite o nome a ser inserido: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade a ser inserida: ");
            int idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome é {nome}");
            Console.WriteLine($"Sua idade é {idade}");

        }
    }
}