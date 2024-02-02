using FoodDelivery.Models;
using Microsoft.AspNetCore.Components;
namespace FoodDelivery.Global;

public class AddedItems
{
    private int _currentAddedItems = 0;
    public event Action OnDataChanged;
    public List<Item> ItemList { get; set; } = new List<Item>();

    public int UpdateCurrentAddedItems
    {
        get => _currentAddedItems;
        set
        {
            _currentAddedItems = value;
            OnCountChanged?.Invoke(_currentAddedItems);
        }
    }
    public event Action<int> OnCountChanged;
}
