namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IPrint Acct = new Account(); // debug not available bc its defined as an IPrint var. Must be inside of the interface or you cannot reference the data. 
                                        // if IPrint was changed to be defined as an Account var, debug would work

            Acct.Print("ABC");
            Acct.Debug();
        }
    }
    public interface IPrint
    {
        void Print(string str);
    }
    public class Account : IPrint
    {
        public void Print(string str)
        {

        }

        public void Debug()
        {

        }
    }
}
