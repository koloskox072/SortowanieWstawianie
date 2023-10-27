namespace SortowanieWstawianie
{
    
    class sort
    {
        private const int N = 50;
        private int[] liczby = new int[N];
        private int poz = 0;
        public int x { set
            {
                if (poz < N)
                    liczby[poz++] = value;
            } 
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < N; i++)
                s+= (liczby[i].ToString()+" ");
            return s; 

        }
        public void sortuj()
        {
            int p, y;
            for (int i = 0;i < N; i++)
            {
                p = znajdzMax(i);
                y = liczby[p];
                for (int j = p; ;j--)
                    liczby[j] = liczby[j-1];
            }
        }
        private int znajdzMax(int p)
        {
            int max = liczby[p];
            int min = p;
            for (int i = p;i < N;i++)
                if (liczby[i] > max)
                {
                    max = liczby[i];
                    min = i;
                }
            return min;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 500;
            Random random = new Random();
            Console.WriteLine($"Podaj {N} liczb:");
            sort s = new sort();
            for(int i=0; i<N; i++)
            {
                //s.x = int.Parse(Console.ReadLine());
                s.x = random.Next(1,100);
            }
            Console.WriteLine(s);
        }
    }
}