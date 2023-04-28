using ZadaniaMikolausFrankiewiczowicz;

internal class Program
{
    private static void Main(string[] args)
    {
        //Zad 1 
            string tekst = "Ala ma kota";
            int klucz = 5;

            string zaszyfrowanyTekst = Szyfrowanie.ZaszyfrujCezar(tekst, klucz);
            Console.WriteLine("Zaszyfrowany tekst: " + zaszyfrowanyTekst);

            string odszyfrowanyTekst = Szyfrowanie.OdszyfrujCezar(zaszyfrowanyTekst, klucz);
        Console.WriteLine("Odszyfrowany tekst: " + odszyfrowanyTekst);

        Console.WriteLine(" ");
        Console.WriteLine("Zadanie 2 ");
        Console.WriteLine(" ");
        //Zad 2 
        Uzytkownik uzytkownik = new KonkretnyUzytkownik("Wiktor", "Pedałski");
    

        uzytkownik.PokazLogin();
        uzytkownik.PokazHaslo();


        uzytkownik.UkryjLogin();
        uzytkownik.UkryjHaslo();
    
        uzytkownik.ZmienLogin("witek", "wit_pedałski");
        uzytkownik.ZmienHaslo("niger123", "niger456");

        Console.WriteLine(" ");
        Console.WriteLine("Zadanie 3 ");
        Console.WriteLine(" ");
        //Zad 3 
        Student student = new Student("Wiktor", "Pedałski", 2022);
        Console.WriteLine(student);
        student.UkryjLogin();
        student.UkryjHaslo();

        Console.WriteLine(" ");
        Console.WriteLine("Zadanie 4");
        Console.WriteLine(" ");
        //Zad 4 
        Wydzial wydzial = new Wydzial();

        Student student1 = new Student("Jan", "Kowalski",  2020);
        wydzial.DodajStudenta(student1);

        Student student2 = new Student("Anna", "Nowak", 2021);
        wydzial.DodajStudenta(student2);

        wydzial.WypiszStudentow();

    }
}
