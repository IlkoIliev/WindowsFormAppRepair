namespace Business
{
    public class Repair
    {
        private int n;
        public int N
        {
            get { return n; }
            set
            {
                if (value >= 0 && value < 101)
                {
                    n = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(N), "Дължината на страна от площадката трябва да е в интервала [1...100]");
                }
            }
        }

        private double w;
        public double W
        {
            get { return w; }
            set
            {
                if (value >= 0.0 && value <= 10.00)
                {
                    w = value;
                }
                else
                {
                    throw new Exception("Невалидна стойност");
                }
            }
        }

        private double l;
        public double L
        {
            get { return l; }
            set
            {
                if (value >= 0.0 && value <= 10.00)
                {
                    l = value;
                }
                else
                {
                    throw new Exception("Невалидна стойност");
                }
            }
        }

        private double m;
        public double M
        {
            get { return m; }
            set
            {
                if (value >= 0 && value < 11)
                {
                    m = value;
                }
                else
                {
                    throw new Exception("Невалидна стойност");
                }
            }
        }

        private double o;
        public double O
        {
            get { return o; }
            set
            {
                if (value >= 0 && value < 11)
                {
                    o = value;
                }
                else
                {
                    throw new Exception("Невалидна стойност");
                }
            }
        }

        public Repair(int N, double W, double L, double M, double O)
        {
            this.N = N;
            this.W = W;
            this.L = L;
            this.M = M;
            this.O = O;
        }

        public Repair() : this(0, 0, 0, 0, 0)
        {
            // Празно тяло
        }

        public string CalculateResponse()
        {
            double area = n * n;
            area -= m * o;
            double tilesCount = area / (w * l);
            double time = tilesCount * 0.2;
            return $"Необходими плочки {tilesCount}" + Environment.NewLine + $" Необходимо време {time}";
        }
    }
}
