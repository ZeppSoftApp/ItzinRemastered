using System.Text;

namespace ItzinRemastered;

public class Calculation
    {
        private CoinDropResult[] drops;
        public Calculation()
        {
            
        }

        public void Calc()
        {
            drops = new CoinDropResult[6];
            Random rnd = new Random();

            // for (int i = 0; i < drops.Length; i++)
            for (int i = drops.Length -1; i >= 0; i--)
            {
                System.Console.Write(".");
                Thread.Sleep(3000);
                int res = rnd.Next(6, 10);
                drops[i] = new CoinDropResult(res);
               // Console.WriteLine(res);
            }

            System.Console.WriteLine();
        }

        //public void Show()
        //{
        //    int position = 6;
        //    foreach (var drop in drops)
        //    {
        //        Console.WriteLine(" {0}: {1}",position--,drop);
        //    }
        //}

        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            int position = 6;
            foreach (var drop in drops)
            {
                sb.Append(string.Format(" {0}: {1}", position--, drop));
                sb.Append(Environment.NewLine);
                // Console.WriteLine(" {0}: {1}", position--, drop);
            }

            return sb.ToString();
        }

        public void SimpleCalc()
        {
            if (drops != null && drops.Length > 0)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("Simple");

                foreach (var coinDropResult in drops)
                {
                    Console.WriteLine(coinDropResult);
                }
            }
        }


        public void RelativeCalc()
        {
            CoinDropResult[] relativeDrops = new CoinDropResult[6];

            for (int i = 0; i < drops.Length; i++)
            {
                if (drops[i].GetSeed() == 9)
                    relativeDrops[i] = new CoinDropResult(8);
                else if (drops[i].GetSeed() == 6)
                    relativeDrops[i] = new CoinDropResult(7);
                else
                    relativeDrops[i] = new CoinDropResult(drops[i].GetSeed());

            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Relative");

            foreach (var coinDropResult in relativeDrops)
            {
                Console.WriteLine(coinDropResult);
            }



        }

        public void ChangesCalc()
        {
            CoinDropResult[] changesDrops = new CoinDropResult[6];

            for (int i = 0; i < drops.Length; i++)
            {
                if (drops[i].GetSeed() == 9 || drops[i].GetSeed() == 6)
                    changesDrops[i] = new CoinDropResult(8);
                else
                    changesDrops[i] = new CoinDropResult(7);

            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Changes");

            foreach (var coinDropResult in changesDrops)
            {
                Console.WriteLine(coinDropResult);
            }
        }

        public void AntiCalc()
        {
            CoinDropResult[] antiDrops = new CoinDropResult[6];
            for (int i = 0; i < drops.Length; i++)
            {
                if (drops[i].GetSeed() == 9)
                    antiDrops[i] = new CoinDropResult(7);

                if (drops[i].GetSeed() == 6)
                    antiDrops[i] = new CoinDropResult(8);

                if (drops[i].GetSeed() == 8)
                    antiDrops[i] = new CoinDropResult(7);

                if (drops[i].GetSeed() == 7)
                    antiDrops[i] = new CoinDropResult(8);

           

            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Anti");

            foreach (var coinDropResult in antiDrops)
            {
                Console.WriteLine(coinDropResult);
            }

        }
    }
    class CoinDropResult
    {
        private int _seed;
        
        public CoinDropResult(int seed)
        {
            _seed = seed;
        }

        public int GetSeed()
        {
            return _seed;
        }

        public override string ToString()
        {
            String res = "";

            switch (_seed)
            {
                case 9:
                    res = "-0-";
                    break;
                case 6:
                    res = "-X-";
                    break;
                case 7:
                    res = "---";
                    break;
                case 8:
                    res = "- -";
                    break;
            }
            return res; 
        }
    }