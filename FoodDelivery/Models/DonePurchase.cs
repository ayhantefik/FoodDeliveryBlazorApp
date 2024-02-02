namespace FoodDelivery.Models;

public class DonePurchase : Item
{
    public int Id { get; set; }
    public string PurchaseCode { get; set; }
    public DateTime DatePurchase {  get; set; }
    public string CustomerName { get; set; }
    public string Status { get; set; }
    public string DeliveryAddress {  get; set; }
    public string? Driver {  get; set; }
}
