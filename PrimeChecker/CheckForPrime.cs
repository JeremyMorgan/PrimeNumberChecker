namespace PrimeChecker
{
    public class CheckForPrime
    {
        public static bool IsNumberPrime(int inputNmbr)
        {
            if (inputNmbr == 0 || inputNmbr == 1){
                return false;
            }

            for (int i = 2; i < inputNmbr; i++){
                if (inputNmbr % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
