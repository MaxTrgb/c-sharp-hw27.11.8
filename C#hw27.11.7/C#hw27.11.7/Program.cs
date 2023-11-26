namespace MySpace
{
    class Order
    {
        // Properties
        public int OrderNumber { get; set; }
        public double PurchaseAmount { get; set; }

        // Constructor
        public Order(int orderNumber, double purchaseAmount)
        {
            OrderNumber = orderNumber;
            PurchaseAmount = purchaseAmount;
        }

        // Method to display information about the order
        public virtual void DisplayOrderInfo()
        {
            Console.WriteLine($"Order Number: {OrderNumber}, Purchase Amount: ${PurchaseAmount:F2}");
        }
    }

    class OnlineOrder : Order
    {
        // Additional property for OnlineOrder
        public string ShippingAddress { get; set; }

        // Constructor
        public OnlineOrder(int orderNumber, double purchaseAmount, string shippingAddress) : base(orderNumber, purchaseAmount)
        {
            ShippingAddress = shippingAddress;
        }

        // Override the DisplayOrderInfo method
        public override void DisplayOrderInfo()
        {
            base.DisplayOrderInfo();
            Console.WriteLine($"Shipping Address: {ShippingAddress}");
        }
    }

    class InStoreOrder : Order
    {
        // Additional property for InStoreOrder
        public string StoreLocation { get; set; }

        // Constructor
        public InStoreOrder(int orderNumber, double purchaseAmount, string storeLocation) : base(orderNumber, purchaseAmount)
        {
            StoreLocation = storeLocation;
        }

        // Override the DisplayOrderInfo method
        public override void DisplayOrderInfo()
        {
            base.DisplayOrderInfo();
            Console.WriteLine($"Store Location: {StoreLocation}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Create objects of both classes
            List<Order> orders = new List<Order>
            {
                new OnlineOrder(1001, 75.99, "Truskavetska 2, Drohobych"),
                new InStoreOrder(2002, 50.50, "Shop ATB"),
                new OnlineOrder(3003, 120.75, "Stepana Banderu 234, Lviv"),
                new InStoreOrder(4004, 30.25, "Shop Foxtrot")
            };

            // Display information about each order
            Console.WriteLine("Order Information:");
            foreach (Order order in orders)
            {
                order.DisplayOrderInfo();
                Console.WriteLine(); 
            }
        }
    }
}
