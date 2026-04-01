using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject
{
    [SerializeField] private List<KitchenObjectsSO> validKitchenObjectSOList;
    private List<KitchenObjectsSO> kitchenObjectSOList;

    private void Awake()
    {
        kitchenObjectSOList = new List<KitchenObjectsSO>();
    }
    public bool TryAddIngredient(KitchenObjectsSO kitchenObjectsSO)
    {
        if (!validKitchenObjectSOList.Contains(kitchenObjectsSO))
        {
            //not a valid ingredient
            return false;
        }
        if (kitchenObjectSOList.Contains(kitchenObjectsSO))
        {
            //Already has this type
            return false;
        } else
        {
            kitchenObjectSOList.Add(kitchenObjectsSO);
            return true;
        }
    }
}
