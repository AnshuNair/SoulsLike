using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : InteractableObject
{
    public WeaponItem weapon;
    public override void Interact(PlayerManager playerManager)
    {
        base.Interact(playerManager);
        PickUpItem(playerManager);
    }

    private void PickUpItem(PlayerManager playerManager)
    {
        PlayerInventory playerInventory = playerManager.GetComponent<PlayerInventory>();
        PlayerLocomotion playerLocomotion = playerManager.GetComponent<PlayerLocomotion>();
        AnimatorManager animatorManager = playerManager.GetComponent<AnimatorManager>();
        playerLocomotion.playerRigidbody.velocity = Vector3.zero;
        animatorManager.PlayTargetAnimation("pick_up_item", true, true);
        playerInventory.weaponsInventory.Add(weapon);
        Destroy(gameObject);
    }
}
