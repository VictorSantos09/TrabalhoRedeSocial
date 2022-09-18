namespace RedeSocial
{
    public class MeetUp
    {
        public bool Login(User user)
        {
            bool userLoging = true; int contador = 5; int userTrys = 0;
            while (userLoging)
            {
                if (userTrys >= 5)
                {
                    Console.WriteLine($"{contador} tentativas restantes");
                    contador--;

                    if (userTrys == 10)
                    {
                        Console.WriteLine("Limite de tentativas atingido");
                        Console.WriteLine("Encerrando...");
                        return false;
                    }
                }
                if (EmailChecker(user, userTrys) == false)
                {
                    userTrys++;
                }
                else
                {
                    if (PasswordChecker(user, userTrys) == false)
                    {
                        userTrys++;
                    }
                    else
                    {
                        userLoging = false;
                    }
                }
            }
            return true;
        }
        public bool EmailChecker(User user, int userTrys)
        {
            Console.Write("Digite seu email: ");
            string userInputEmail = Console.ReadLine();
            if (userInputEmail != user.Email)
            {
                Console.WriteLine("Email não cadastrado, tente novamente");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool PasswordChecker(User user, int userTrys)
        {
            Console.Write("Senha: ");
            string userInputPassword = Console.ReadLine();
            if (userInputPassword != user.Password)
            {
                Console.WriteLine("Senha incorreta. Tente novamente");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}