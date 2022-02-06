namespace NewCSharpConcepts
{
    public class MethodOverloading
    {
        public double methodProduct(double InitValue)
        {
            return InitValue*5;
        }

        //Overload by number of parameters
        public double methodProduct(double initValue, double timesValue)
        {
            return initValue*timesValue;
        }

        //Overload by type pf parameters
        public double methodProduct(double initValue, int intTimesValue)
        {
            return initValue*intTimesValue;
        }
    }
}