namespace RedeSocial
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DateBirth { get; set; }
        public bool Register()
        {
            Console.Write("Nome: ");
            Name = NameValidator(Console.ReadLine());
            Console.Write("Idade: ");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 18)
            {
                Console.WriteLine("Você não pode utilizar o MeetUp Inc");
                return false;
            }
            else
            {
                Console.Write("Email: ");
                Email = EmailValidator(Console.ReadLine());
                Console.Write("Senha: ");
                Password = PasswordValidator(Console.ReadLine());
                Console.Write("Data de Nascimento: ");
                DateBirth = DateBirthValidatorLetter(Console.ReadLine().ToUpper());
                Console.WriteLine("Cadastrado com sucesso");
                return true;
            }
        }
        public string NameValidator(string name)
        {
            while (name.Length < 5)
            {
                Console.WriteLine("Nome inválido");
                name = Console.ReadLine();
            }
            return name;
        }
        public string EmailValidator(string input)
        {
            bool emailOk = true;
            while (emailOk)
            {
                if (input.Contains("@") && input.Contains(".com"))
                {
                    emailOk = false;
                }
                else
                {
                    Console.WriteLine("Email inválido, tente novamente");
                    input = Console.ReadLine();
                }
            }
            return input;

        }
        public string PasswordValidator(string input)
        {
            bool passwordOk = true;
            while (passwordOk)
            {
                if (input.Length > 5)
                {
                    passwordOk = false;
                }
                else
                {
                    Console.WriteLine("Senha inválida, necessário ter 5 caracteres.Tente novamente");
                    input = Console.ReadLine();
                }
            }
            return input;
        }
        public string DateBirthValidatorLetter(string input)
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < abc.Length; i++)
            {
                char alfabeto = abc[i];
                if (input.Contains(alfabeto))
                {
                    i = 0; input = null;
                    Console.WriteLine("Não pode conter letras, tente novamente");
                    input = Console.ReadLine().ToUpper();
                    DateBirthValidatorSize(input);
                }
            }
            return input;
        }
        public string DateBirthValidatorSize(string input)
        {
            bool lenghtOk = true;
            while (lenghtOk)
            {
                if (input.Length < 8)
                {
                    input = null;
                    Console.WriteLine("Tamanho errado. Formato: 00/00/0000.Tente novamente");
                    input = Console.ReadLine().ToUpper();
                }
                else
                {
                    lenghtOk = false;
                }
            }
            return input;
        }
    }
}