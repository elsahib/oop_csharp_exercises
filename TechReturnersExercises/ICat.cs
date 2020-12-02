using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {   
        String Eat();
        Int32 AverageHeight();
        String Setting();
        Boolean IsAsleep();

    }

    public class DomesticCat : ICat
    {
    public static String Eat() {
        return "Purrrrrrr";
    }
       public static Int32 AverageHeight() {
        return 23;
    }
       public static String Setting() {
        return "domestic";
    }
       public static Boolean IsAsleep() {
        return ;
    }

}
    public class LionCat{
    public static Boolean Eat() {

    }
}
    public class CheetahCat{
    public static Boolean Eat() {

    }
}
}
