using Harjoitus3;

bool jatketaan = true;
DateTime tuloAika;
DateTime lahtoAika;
DateTime aukiAika = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
DateTime kiinniAika = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 0, 0);
double hinta = -1;
do
{
    Console.Write("Anna tuloaika tt:mm: ");
    string annettu = Console.ReadLine();
    while (!DateTime.TryParse(annettu, out tuloAika) || tuloAika <= aukiAika)
    {
            Console.Write("Ei sallittu aika, yritä uudestaan: ");
            annettu = Console.ReadLine();
    }

    Console.Write("Anna lähtöaika tt:mm: ");
    annettu = Console.ReadLine();
    while (!DateTime.TryParse(annettu, out lahtoAika) && lahtoAika >= kiinniAika)
    {
        Console.Write("Ei sallittu aika, yritä uudestaan: ");
        annettu = Console.ReadLine();
    }

    TimeSpan parkkiAika = (lahtoAika - tuloAika);
    //TimeSpan pAika = parkkiAika;
    parkki parkki = new parkki(parkkiAika, hinta);
    hinta = parkki.pHinta;
    double parkkiHinta = hinta;
    double tHinta = -1;

    if (parkkiAika <= TimeSpan.FromHours(2.00))
        tHinta = 2;
    else if (parkkiAika < TimeSpan.FromHours(2.00) || parkkiAika <= TimeSpan.FromHours(5.00))
        tHinta = 1.75;
    else if (parkkiAika > TimeSpan.FromHours(5.00))
        tHinta = 1.5;

    hinta = parkkiAika.TotalHours * tHinta;

    Console.WriteLine("Olit parkissa {0} tuntia ja {1} minuuttia", parkkiAika.Hours, parkkiAika.Minutes);
    Console.WriteLine("Parkki maksoi {0} euroa", hinta);

} while (jatketaan);