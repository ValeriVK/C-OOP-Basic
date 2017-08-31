namespace WildFarm.Models
{
  public abstract class Food
    {
        public Food(int quantity)
        {
            this.Quantiy = quantity;
        }
        public int Quantiy { get; set; }
    }
}
