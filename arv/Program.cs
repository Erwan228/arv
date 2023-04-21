namespace arv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vanligList = new List<int>();
            MariesListe<int> minListe = new MariesListe<int>();

            vanligList.Add(1);
            minListe.AddTwo(1, 2);

            vanligList.ForEach(x => Console.WriteLine(x));
            minListe.ForEach(x => Console.WriteLine(x));
        }
    }
}