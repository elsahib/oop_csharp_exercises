using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        String Eat();
        int AverageHeight();
        String Setting();
        void GoToSleep();
        void WakeUp();
        Boolean IsAsleep();

    }

    public class DomesticCat : ICat
    {
        public Boolean sleepStatus;
        public String Eat()
        {
            return "Purrrrrrr";
        }
        public Int32 AverageHeight()
        {
            return 23;
        }
        public String Setting()
        {
            return "domestic";
        }
        public void GoToSleep()
        {
            sleepStatus = true;
        }
        public void WakeUp()
        {
            sleepStatus = false;
        }

        public Boolean IsAsleep()
        {
            return sleepStatus;
        }
    }
    public class LionCat : ICat
    {
        public Boolean sleepStatus;
        public String Eat()
        {
            return "Roar!!!!";
        }
        public Int32 AverageHeight()
        {
            return 1100;
        }
        public String Setting()
        {
            return "wild";
        }
        public void GoToSleep()
        {
            sleepStatus = true;
        }
        public void WakeUp()
        {
            sleepStatus = false;
        }

        public Boolean IsAsleep()
        {
            return sleepStatus;
        }
    }
    public class CheetahCat : ICat
    {
        public Boolean sleepStatus;
        public String Eat()
        {
            return "Zzzzzzz";
        }
        public Int32 AverageHeight()
        {
            return 1100;
        }
        public String Setting()
        {
            return "wild";
        }
        public void GoToSleep()
        {
            sleepStatus = true;
        }
        public void WakeUp()
        {
            sleepStatus = false;
        }

        public Boolean IsAsleep()
        {
            return sleepStatus;
        }
    }
}
