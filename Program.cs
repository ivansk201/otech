List<string> maleNames = LoadNames("manname.txt");
List<string> femaleNames = LoadNames("femalename.txt");
List<string> maleSurnames = LoadNames("mansecondname.txt");
List<string> femaleSurnames = LoadNames("femalesecondname.txt");
List<string> malePatronymics = LoadNames("manmiddlename.txt");
List<string> femalePatronymics = LoadNames("femalemiddlename.txt");
try
{
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("Выберите какие ФИО вы хотите. Мужские или женские.");
Console.WriteLine("1 - Мужские ФИО");
Console.WriteLine("2 - Женские ФИО");
Console.WriteLine("----------------------------------------------------");
int chose1 = int.Parse(Console.ReadLine());


    if (chose1 != 1 && chose1 != 2)
    {
        Console.WriteLine("Некорректный выбор пола. Введите 1 или 2.");

    }
    else
    {
        Console.WriteLine("Введите, сколько ФИО вы хотите вывести: ");
        int chose2 = int.Parse(Console.ReadLine());

        Random rand = new Random();
        for (int i = 0; i < chose2; i++)
        {
            string randomFullName = "";
            if (chose1 == 1)
            {
                randomFullName = GenerateRandomFullName(maleNames, maleSurnames, malePatronymics);
            }
            else
            {
                randomFullName = GenerateRandomFullName(femaleNames, femaleSurnames, femalePatronymics);
            }

            Console.WriteLine($"{i + 1}: " + randomFullName);
        }
    }
}
catch
{
    Console.WriteLine("Некорректный выбор.");
}










static List<string> LoadNames(string fileName)
{
    List<string> names = new List<string>();
    using (StreamReader reader = new StreamReader(fileName))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            names.Add(line);
        }
    }
    return names;
}
static string GenerateRandomFullName(List<string> names, List<string> surnames, List<string> patronymics)
{
    Random rand = new Random();
    string randomName = names[rand.Next(names.Count)];
    string randomSurname = surnames[rand.Next(surnames.Count)];
    string randomPatronymic = patronymics[rand.Next(patronymics.Count)];

    return $"{randomSurname} {randomName} {randomPatronymic}";
}

    

