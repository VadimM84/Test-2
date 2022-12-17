Console.Write("Введите имя пользовотеля: ");
String username = Console.ReadLine();

if(username.ToLower() == "нелечка")
{
   Console.WriteLine("Ура, это же Нелечка к нам пришла!"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}