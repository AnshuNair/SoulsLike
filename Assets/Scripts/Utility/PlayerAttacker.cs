using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    private AnimatorManager animatorManager;
    private PlayerManager playerManager;
    private WeaponSlotManager weaponSlotManager;
    private InputManager inputManager;
    private PlayerStats playerStats;
    public string lastAttack;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        playerManager = GetComponent<PlayerManager>();
        weaponSlotManager = GetComponent<WeaponSlotManager>();
        inputManager = GetComponent<InputManager>();
        playerStats = GetComponent<PlayerStats>();
    }

    public void HandleWeaponCombo(WeaponItem weapon)
    {
        float staminaCost = Mathf.RoundToInt(weapon.baseStamina * weapon.lightAttackMultiplier);
        if (inputManager.comboFlag && playerStats.currentStamina >= staminaCost)
        {
            animatorManager.animator.SetBool("canDoCombo", false);
            weaponSlotManager.attackingWeapon = weapon;
            if (lastAttack == weapon.OH_Right_Light_Attack_1)
            {
                StopAllCoroutines();
                animatorManager.PlayTargetAnimation(weapon.OH_Right_Light_Attack_2, true, true);
                lastAttack = weapon.OH_Right_Light_Attack_2;
                weaponSlotManager.OpenRightHandDamageCollider();
                StartCoroutine(TurnOffColliderAfterAnimation(weapon.oh_right_light_2_duration, true));
            }
            else if (lastAttack == weapon.OH_Left_Light_Attack_1)
            {
                StopAllCoroutines();
                animatorManager.PlayTargetAnimation(weapon.OH_Left_Light_Attack_2, true, true);
                lastAttack = weapon.OH_Left_Light_Attack_2;
                weaponSlotManager.OpenLeftHandDamageCollider();
                StartCoroutine(TurnOffColliderAfterAnimation(weapon.oh_left_light_2_duration, false));
            }
        }
    }

    public void HandleRightLightAttack(WeaponItem weapon)
    {
        float staminaCost = Mathf.RoundToInt(weapon.baseStamina * weapon.lightAttackMultiplier);
        if (!playerManager.isInteracting && playerStats.currentStamina >= staminaCost)
        {
            weaponSlotManager.attackingWeapon = weapon;
            lastAttack = weapon.OH_Right_Light_Attack_1;
            animatorManager.PlayTargetAnimation(weapon.OH_Right_Light_Attack_1, true, true);
            StopAllCoroutines();
            weaponSlotManager.OpenRightHandDamageCollider();
            StartCoroutine(TurnOffColliderAfterAnimation(weapon.oh_right_light_1_duration, true));
        }
    }

    public void HandleRightHeavyAttack(WeaponItem weapon)
    {
        float staminaCost = Mathf.RoundToInt(weapon.baseStamina * weapon.heavyAttackMultiplier);
        if (!playerManager.isInteracting && playerStats.currentStamina >= staminaCost)
        {
            weaponSlotManager.attackingWeapon = weapon;
            lastAttack = weapon.OH_Right_Heavy_Attack_1;
            animatorManager.PlayTargetAnimation(weapon.OH_Right_Heavy_Attack_1, true, true);
            StopAllCoroutines();
            weaponSlotManager.OpenRightHandDamageCollider();
            StartCoroutine(TurnOffColliderAfterAnimation(weapon.oh_right_heavy_1_duration, true));
        }
    }

    public void HandleLeftLightAttack(WeaponItem weapon)
    {
        float staminaCost = Mathf.RoundToInt(weapon.baseStamina * weapon.lightAttackMultiplier);
        if (!playerManager.isInteracting && playerStats.currentStamina >= staminaCost)
        {
            weaponSlotManager.attackingWeapon = weapon;
            lastAttack = weapon.OH_Left_Light_Attack_1;
            animatorManager.PlayTargetAnimation(weapon.OH_Left_Light_Attack_1, true, true);
            StopAllCoroutines();
            weaponSlotManager.OpenLeftHandDamageCollider();
            StartCoroutine(TurnOffColliderAfterAnimation(weapon.oh_left_light_1_duration, false));
        }
    }

    public void HandleLeftHeavyAttack(WeaponItem weapon)
    {
        float staminaCost = Mathf.RoundToInt(weapon.baseStamina * weapon.heavyAttackMultiplier);
        if (!playerManager.isInteracting && playerStats.currentStamina >= staminaCost)
        {
            weaponSlotManager.attackingWeapon = weapon;
            lastAttack = weapon.OH_Left_Heavy_Attack_1;
            animatorManager.PlayTargetAnimation(weapon.OH_Left_Heavy_Attack_1, true, true);
            StopAllCoroutines();
            weaponSlotManager.OpenLeftHandDamageCollider();
            StartCoroutine(TurnOffColliderAfterAnimation(weapon.oh_left_heavy_1_duration, false));
        }
    }

    private IEnumerator TurnOffColliderAfterAnimation(float clipLength, bool rightHand)
    {
        yield return new WaitForSeconds(clipLength);
        if (rightHand)
            weaponSlotManager.CloseRightHandDamageCollider();
        else
            weaponSlotManager.CloseLeftHandDamageCollider();
    }
}
