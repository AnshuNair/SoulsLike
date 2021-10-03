using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlotManager : MonoBehaviour
{
    private WeaponHolderSlot leftHandSlot;
    private WeaponHolderSlot rightHandSlot;

    private DamageCollider leftHandDamageCollider;
    private DamageCollider rightHandDamageCollider;

    public WeaponItem attackingWeapon;

    private Animator animator;
    private QuickSlotsUIHandler quickSlotsUI;
    private PlayerStats playerStats;
    private PlayerAttacker playerAttacker;

    public string currentAttack = "";

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerStats = GetComponent<PlayerStats>();
        playerAttacker = GetComponent<PlayerAttacker>();
        quickSlotsUI = FindObjectOfType<QuickSlotsUIHandler>();
        WeaponHolderSlot[] weaponHolderSlots = GetComponentsInChildren<WeaponHolderSlot>();
        foreach (WeaponHolderSlot weaponSlot in weaponHolderSlots)
        {
            if (weaponSlot.isLeftHandSlot)
            {
                leftHandSlot = weaponSlot;
            }
            else if (weaponSlot.isRightHandSlot)
            {
                rightHandSlot = weaponSlot;
            }
        }

        LoadLeftWeaponDamageCollider();
        LoadRightWeaponDamageCollider();
    }

    public void LoadWeaponOnSlot(WeaponItem weaponItem, bool isLeft)
    {
        if (isLeft)
        {
            leftHandSlot.LoadWeaponModel(weaponItem);
            LoadLeftWeaponDamageCollider();
            #region Handle Left Weapon Idle Animations
            if (weaponItem != null)
            {
                animator.CrossFade(weaponItem.left_hand_idle, 0.2f);
            }
            else
            {
                animator.CrossFade("Left Arm Empty", 0.2f);
            }
            #endregion
        }
        else
        {
            rightHandSlot.LoadWeaponModel(weaponItem);
            LoadRightWeaponDamageCollider();
            #region Handle Right Weapon Idle Animations
            if (weaponItem != null)
            {
                animator.CrossFade(weaponItem.right_hand_idle, 0.2f);
            }
            else
            {
                animator.CrossFade("Right Arm Empty", 0.2f);
            }
            #endregion
        }

        quickSlotsUI.UpdateWeaponSlotsUI(weaponItem, isLeft);
    }

    #region Handle Weapon Collider

    private void LoadLeftWeaponDamageCollider()
    {
        leftHandDamageCollider = leftHandSlot.currentWeaponModel.GetComponentInChildren<DamageCollider>();
    }

    private void LoadRightWeaponDamageCollider()
    {
        rightHandDamageCollider = rightHandSlot.currentWeaponModel.GetComponentInChildren<DamageCollider>();
    }

    public void OpenRightHandDamageCollider()
    {
        rightHandDamageCollider.EnableDamageCollider();

        if (playerAttacker.lastAttack.ToLower().Contains("light"))
        {
            DrainStaminaLightAttack();
            currentAttack = "light";
        }
        else if (playerAttacker.lastAttack.ToLower().Contains("heavy"))
        {
            DrainStaminaHeavyAttack();
            rightHandDamageCollider.currentWeaponDamage *= 1.5f;
            currentAttack = "heavy";
        }
    }

    public void OpenLeftHandDamageCollider()
    {
        leftHandDamageCollider.EnableDamageCollider();

        if (playerAttacker.lastAttack.ToLower().Contains("light"))
        {
            DrainStaminaLightAttack();
            currentAttack = "light";
        }
        else if (playerAttacker.lastAttack.ToLower().Contains("heavy"))
        {
            DrainStaminaHeavyAttack();
            leftHandDamageCollider.currentWeaponDamage *= 1.5f;
            currentAttack = "heavy";
        }
    }

    public void CloseLeftHandDamageCollider()
    {
        leftHandDamageCollider.DisableDamageCollider();
        if (currentAttack == "heavy")
        {
            leftHandDamageCollider.currentWeaponDamage /= 1.5f;
        }
        currentAttack = "";
    }

    public void CloseRightHandDamageCollider()
    {
        rightHandDamageCollider.DisableDamageCollider();
        if (currentAttack == "heavy")
        {
            rightHandDamageCollider.currentWeaponDamage /= 1.5f;
        }
        currentAttack = "";
    }

    #endregion

    #region Handle Weapon Stamina Drainage
    public void DrainStaminaLightAttack()
    {
        playerStats.DrainStamina(Mathf.RoundToInt(attackingWeapon.baseStamina * attackingWeapon.lightAttackMultiplier));
    }

    public void DrainStaminaHeavyAttack()
    {
        playerStats.DrainStamina(Mathf.RoundToInt(attackingWeapon.baseStamina * attackingWeapon.heavyAttackMultiplier));
    }
    #endregion
}
