using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickSlotsUIHandler : MonoBehaviour
{
    public Image leftWeaponIcon;
    public Image rightWeaponIcon;

    public void UpdateWeaponSlotsUI(WeaponItem weapon, bool isLeft)
    {
        if (!isLeft)
        {
            if (weapon.itemIcon != null)
                rightWeaponIcon.sprite = weapon.itemIcon;
            else
                rightWeaponIcon.sprite = null;
        }
        else
        {
            if (weapon.itemIcon != null)
                leftWeaponIcon.sprite = weapon.itemIcon;
            else
                leftWeaponIcon.sprite = null;
        }
    }
}
