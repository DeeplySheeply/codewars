class NbaExtrap
    {
        public static double NbaExtrap(double ppg, double mpg)
        {

            if (ppg == 0 || mpg == 0)
            {
                return 0;
            }

            double answer = (ppg / mpg) * 48;
            return Math.Round(answer, 1);
        }
    }
