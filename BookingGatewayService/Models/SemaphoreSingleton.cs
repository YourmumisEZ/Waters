using BookingGatewayRepository;

namespace BookingGatewayService.Models
{
    public class Singleton
    {
        private bool isBlocked;

        private int getBookingCounter;

        private Singleton()
        {
            isBlocked = false;
            getBookingCounter = 0;
        }


        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public static void BlockSemaphore()
        {
            instance.isBlocked = true;
        }

        public static void ReleaseSemaphore()
        {
            instance.isBlocked = false;
        }

        public static bool IsBookingBlocked()
        {
            return instance.isBlocked;
        }

        public static void IncreaseGetStatusCounter()
        {
            instance.getBookingCounter++;
        }

        public static void DecreaseGetStatusCounter()
        {
            instance.getBookingCounter--;
        }

        public static int GetGetStatusCounter()
        {
            return instance.getBookingCounter;
        }
    }
}
