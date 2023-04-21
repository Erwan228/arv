namespace arv
{
    public class MariesListe<T> : List<T>
    {
        public void AddTwo(T itemOne, T itemTwo)
        {
            Add(itemOne);
            Add(itemTwo);
        }
    }
}
