namespace SharedLibrary
{
    public class Pair<T1, T2>
    {
        // Tuple-like class, but mutable
        public Pair(T1 t1, T2 t2)
        {
            Item1 = t1;
            Item2 = t2;
        }
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
    }
}
