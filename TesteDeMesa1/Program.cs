using TestesDeMesa;

Author.BoasVindas();

int opcao = Menu.MenuTM01();

switch (opcao)
{
    case 0:
        Console.Clear();
        Console.WriteLine("Saindo...");
        Thread.Sleep(2000);
        break;

    case 1:
        TMESA01_01.TM01_01();
        break;

    case 2:
        TMESA01_02.TM01_02();
        break;

    case 3:
        TMESA01_03.TM01_03();
        break;
}
