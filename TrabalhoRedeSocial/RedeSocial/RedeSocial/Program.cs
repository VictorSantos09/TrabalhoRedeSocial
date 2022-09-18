using RedeSocial;

User user = new User();
MeetUp meetUp = new MeetUp();
Platform platform = new Platform();

Console.WriteLine("MeetUp Inc.");

bool userChoosing = true;

while (userChoosing)
{
    Console.WriteLine($"1 - Cadastrar\n2 - Login\n3 - Encerrar");
    string userFirstInput = Console.ReadLine();
    if (userFirstInput == "1")
    {
        if (user.Register() == false)
        {
            break;
        }
        else
        {
            continue;
        }
    }
    else if (userFirstInput == "2")
    {
        if (meetUp.Login(user) == false)
        {
            userChoosing = false;
        }
        else
        {
            if (platform.Home(user) == false)
            {
                userChoosing = false;
            }
        }
    }
    else if (userFirstInput == "3")
    {
        Console.Clear();
        Thread.Sleep(250);
        Console.WriteLine("Encerrando...");
        userChoosing = false;
    }
    else
    {
        Console.WriteLine("Opção não cadastrada, tente novamente");
    }
}