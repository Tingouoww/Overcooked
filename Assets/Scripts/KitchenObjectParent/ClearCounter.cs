using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    public override void Interact(Player player)
    {
        //桌上沒東西
        if (!HasKitchenObject())
        {
            //玩家有東西
            if (player.HasKitchenObject())
            {
                //放食材
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
        }
        //桌上有東西
        else
        {
            //玩家沒東西
            if (!player.HasKitchenObject())
            {
                //拿食材
                this.GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
