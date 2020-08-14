
using UnityEngine;

public class ItemTypeComponent : MonoBehaviour
{
    [SerializeField]protected ItemType _itemType;
    // Start is called before the first frame update
    public ItemType Type
    {
        get
        {
            return _itemType;
        }
        set
        {
            _itemType = value;
        }
    }
    
}
