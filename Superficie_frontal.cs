// See https://aka.ms/new-console-template for more information
namespace Superficie_frontal
{
    class Caja
    {
        public int Alto { get; set; }
        public int Largo { get; set; }

        public int SuperficieFrontal
        {
            get
            {
                return Alto * Largo;
            }
        }
    }
}
