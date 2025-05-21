namespace Markov_laba_2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string Adress { get; set; }
        public int RestaurantId { get; set; }
        public int CourierId { get; set; }
        public bool Status { get; set; }

    }
}
