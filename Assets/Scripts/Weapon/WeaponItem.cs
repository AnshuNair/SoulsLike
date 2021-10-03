using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapon Item")]
public class WeaponItem : Item
{
    public GameObject modelPrefab;
    public bool isUnarmed;

    [Header("Weapon Idle Animations")]
    public string right_hand_idle;
    public string left_hand_idle;

    [Header("One Handed Right Attack Animations")]
    public string OH_Right_Light_Attack_1;
    public float oh_right_light_1_duration;
    public string OH_Right_Light_Attack_2;
    public float oh_right_light_2_duration;
    public string OH_Right_Heavy_Attack_1;
    public float oh_right_heavy_1_duration;

    [Header("One Handed Left Attack Animations")]
    public string OH_Left_Light_Attack_1;
    public float oh_left_light_1_duration;
    public string OH_Left_Light_Attack_2;
    public float oh_left_light_2_duration;
    public string OH_Left_Heavy_Attack_1;
    public float oh_left_heavy_1_duration;

    [Header("Stamina Costs")]
    public int baseStamina;
    public float lightAttackMultiplier;
    public float heavyAttackMultiplier;
}
