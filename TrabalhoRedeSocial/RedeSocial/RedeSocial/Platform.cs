namespace RedeSocial
{
    public class Platform
    {
        public bool Home(User user)
        {
            bool logged = true;
            Console.Clear();
            Console.WriteLine($"Olá {user.Name}\nSeus dados:");
            Console.WriteLine($"Idade: {user.Age}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine(Convert.ToUInt64(user.DateBirth).ToString(@"Nascimento: 00\.00\.0000"));
            while (logged)
            {
                Console.WriteLine("\n1 - Pesquisar pessoas\n2 - Sair");
                string userInputChoice = Console.ReadLine();
                if (userInputChoice == "1")
                {
                    SearchPeople();
                }
                else if (userInputChoice == "2")
                {
                    Thread.Sleep(250);
                    Console.WriteLine("Saindo...");
                    return false;
                }
                else
                {
                    Console.WriteLine("Opção não disponível, tente novamente");
                }
            }
            return true;
        }
        public void SearchPeople()
        {
            Console.Write("Digite o nome: ");
            string userInputPeopleName = Console.ReadLine();
            Console.WriteLine($"{userInputPeopleName} encontrado\n1 - Enviar pedido de amizade\n2 - Enviar mensagem\n3 - Voltar");
            string userInputChoice = Console.ReadLine();
            if (userInputChoice == "1")
            {
                SendFriendRequest(userInputPeopleName);
            }
            else if (userInputChoice == "2")
            {
                SendMessage(userInputPeopleName);
            }
            else
            {
                Console.WriteLine("Opção indisponível, voltando para a home");
            }
        }
        public void SendMessage(string userInputPeopleName)
        {
            Console.WriteLine($"Digite a mensagem para {userInputPeopleName}");
            string userInputMessage = Console.ReadLine();
            Console.WriteLine("Enviado");
        }
        public void SendFriendRequest(string userInputPeopleName)
        {
            Console.WriteLine($"Clique ENTER para enviar pedido de amizade á {userInputPeopleName}");
            Console.ReadKey();
            Console.WriteLine("Pedido de amizade enviado");
        }
    }
}