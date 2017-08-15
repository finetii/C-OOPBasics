
namespace WildFarm
{
    abstract class Food
    {
        int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

    }
}
