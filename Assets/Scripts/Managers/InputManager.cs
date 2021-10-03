using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControls;
    private PlayerLocomotion playerLocomotion;
    private AnimatorManager animatorManager;
    private PlayerAttacker playerAttacker;
    private PlayerInventory playerInventory;
    private PlayerManager playerManager;
    private PlayerStats playerStats;

    public Vector2 movementInput;
    public Vector2 cameraInput;

    public float cameraInputX;
    public float cameraInputY;

    public float moveAmount;
    public float verticalInput;
    public float horizontalInput;

    public bool space_Input;
    public bool lightAttackRight_Input;
    public bool heavyAttackRight_Input;
    public bool lightAttackLeft_Input;
    public bool heavyAttackLeft_Input;
    public bool upArrow_Input;
    public bool downArrow_Input;
    public bool leftArrow_Input;
    public bool rightArrow_Input;
    public bool q_Input;

    public bool comboFlag;
    public float rollInputTimer;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        playerAttacker = GetComponent<PlayerAttacker>();
        playerInventory = GetComponent<PlayerInventory>();
        playerManager = GetComponent<PlayerManager>();
        playerStats = GetComponent<PlayerStats>();
    }

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();
            playerControls.PlayerActions.Interact.performed += i => q_Input = true;
            playerControls.WeaponSelect.RightArrow.performed += i => rightArrow_Input = true;
            playerControls.WeaponSelect.LeftArrow.performed += i => leftArrow_Input = true;
            playerControls.PlayerActions.LightAttackLeft.performed += i => lightAttackLeft_Input = true;
            playerControls.PlayerActions.HeavyAttackLeft.performed += i => heavyAttackLeft_Input = true;
            playerControls.PlayerActions.LightAttackRight.performed += i => lightAttackRight_Input = true;
            playerControls.PlayerActions.HeavyAttackRight.performed += i => heavyAttackRight_Input = true;
        }

        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
        HandleRollInput();
        HandleRightAttackInput();
        HandleLeftAttackInput();
        HandleQuickSlotsInput();
        HandleInteractInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
        cameraInputX = cameraInput.x;
        cameraInputY = cameraInput.y;
        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
        animatorManager.UpdateAnimatorValues(0, moveAmount, playerLocomotion.isSprinting);
    }

    private void HandleRollInput()
    {
        space_Input = playerControls.PlayerActions.Roll.phase == UnityEngine.InputSystem.InputActionPhase.Started;

        if (space_Input)
        {
            rollInputTimer += Time.deltaTime;
        }
        else
        {
            if (rollInputTimer > 0 && rollInputTimer < 0.5f && playerStats.currentStamina >= 15f)
            {
                playerLocomotion.isSprinting = false;
                playerLocomotion.isRolling = true;
            }

            rollInputTimer = 0f;
        }
    }

    private void HandleRightAttackInput()
    {
        if (lightAttackRight_Input)
        {
            if (playerManager.canDoCombo)
            {
                comboFlag = true;
                playerAttacker.HandleWeaponCombo(playerInventory.rightWeapon);
                comboFlag = false;
            }
            else
            {
                playerAttacker.HandleRightLightAttack(playerInventory.rightWeapon);
            }
        }
        if (heavyAttackRight_Input)
        {
            playerAttacker.HandleRightHeavyAttack(playerInventory.rightWeapon);
        }
    }

    private void HandleLeftAttackInput()
    {
        

        if (lightAttackLeft_Input)
        {
            if (playerManager.canDoCombo)
            {
                comboFlag = true;
                playerAttacker.HandleWeaponCombo(playerInventory.leftWeapon);
                comboFlag = false;
            }
            else
            {
                playerAttacker.HandleLeftLightAttack(playerInventory.leftWeapon);
            }
        }
        if (heavyAttackLeft_Input)
        {
            playerAttacker.HandleLeftHeavyAttack(playerInventory.leftWeapon);
        }
    }

    private void HandleQuickSlotsInput()
    {
        
        if (rightArrow_Input)
        {
            playerInventory.ChangeRightWeapon();
        }
        else if (leftArrow_Input)
        {
            playerInventory.ChangeLeftWeapon();
        }
    }

    private void HandleInteractInput()
    {
        
    }
}
