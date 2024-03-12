string cestaSoubor = (@"C:\trideni\nesetrizene.txt");
string cestaSoubor2 = (@"C:\trideni\setrizeno.txt");
Random nahoda = new Random();
int[] vystupcisla = new int[100];


naplneniSeznamu();
cteniSouboru();
bubblesort(vystupcisla);
serazenyList();
zapisSouboru2();



void naplneniSeznamu()
{
    List<int> seznam = new List<int>();
    for (int i = 0; i < 100; i++)
    {
        seznam.Add(nahoda.Next(0, 999));
    }
    Console.WriteLine("Seznam naplněn .....");
    for (int i = 0; i < 100; i++)
    {
        if (i == 99)
        {
            Console.WriteLine("{0}", seznam[i]);
        }
        Console.Write("{0}, ", seznam[i]);
    }
    Console.WriteLine();
    //Zápis do souboru
    string vystup = String.Join(",", seznam);
    File.WriteAllText(cestaSoubor, vystup);
}

void cteniSouboru()
{
    Console.WriteLine("-------------------------------");
    string vstup = File.ReadAllText(cestaSoubor);
    string[] vystupp = new string[100];
    vystupp = vstup.Split(",");
 

    for (int i = 0; i < 100; i++)
    {
        vystupcisla[i] = Int32.Parse(vystupp[i]); 
    }
}



void bubblesort(int[] b)
{
    int delka = b.Length;
    bool vytrizeno = false;
    while (!vytrizeno)
    {
        vytrizeno = true;
        for (int i = 0; i < delka - 1; i++)
        {
            ;
            if (b[i] > b[i + 1])
            {
                int t = b[i];
                b[i] = b[i + 1];
                b[i + 1] = t;
                vytrizeno = false;
            }
        }
        delka -= 1;
    }
}

void serazenyList()
{
    Console.WriteLine("");
    Console.WriteLine("serazeny list:");
    for (int i = 0; i < vystupcisla.Length; i++)
    {
        Console.Write($"{vystupcisla[i]} ");
    }
}
 void zapisSouboru2()
{
    //Zápis setřízeného seznamu do druhého souboru
    string vystuptrid = Convert.ToString(String.Join(",", vystupcisla));
    File.WriteAllText(cestaSoubor2, vystuptrid);
}
