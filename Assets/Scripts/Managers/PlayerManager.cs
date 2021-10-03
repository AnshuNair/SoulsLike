using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Animator animator;
    private InputManager inputManager;
    private PlayerLocomotion playerLocomotion;
    private CameraManager cameraManager;
    private PlayerStats playerStats;
    private WeaponSlotManager weaponSlotManager;

    [Header("Player Interaction Flags")]
    public bool isInteracting;
    public bool isUsingRootMotion;
    public bool canDoCombo;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        cameraManager = FindObjectOfType<CameraManager>();
        playerStats = GetComponent<PlayerStats>();
        weaponSlotManager = GetComponent<WeaponSlotManager>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
        CheckForInteractableObject();
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }

    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();
        isUsingRootMotion = animator.GetBool("isUsingRootMotion");
        isInteracting = animator.GetBool("isInteracting");
        canDoCombo = animator.GetBool("canDoCombo");
        animator.SetBool("isGrounded", playerLocomotion.isGrounded);
        if (playerStats.currentStamina > 10f)
            playerLocomotion.isSprinting = inputManager.space_Input;

        inputManager.lightAttackRight_Input = false;
        inputManager.heavyAttackRight_Input = false;
        inputManager.lightAttackLeft_Input = false;
        inputManager.heavyAttackLeft_Input = false;
        inputManager.upArrow_Input = false;
        inputManager.downArrow_Input = false;
        inputManager.leftArrow_Input = false;
        inputManager.rightArrow_Input = false;
        inputManager.q_Input = false;

        if (!isInteracting && !playerLocomotion.isSprinting && playerStats.currentStamina < playerStats.maxStamina)
        {
            playerStats.currentStamina += Time.deltaTime * playerStats.staminaRechargeRate;
            playerStats.staminaBar.SetCurrentStamina(playerStats.currentStamina);
        }
        else if (playerLocomotion.isSprinting)
        {
            playerStats.currentStamina -= Time.deltaTime * 5f;
            playerStats.staminaBar.SetCurrentStamina(playerStats.currentStamina);
            if (playerStats.currentStamina <= 0f)
                playerLocomotion.isSprinting = false;
        }
    }

    public void CheckForInteractableObject()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position, 0.3f, transform.forward, out hit, 1f, cameraManager.collisionLayers))
        {
            if (hit.collider.CompareTag("Interactable"))
            {
                InteractableObject interactable = hit.collider.GetComponent<InteractableObject>();
                if (interactable != null)
                {
                    string interactableText = interactable.interactableText;

                    if (inputManager.q_Input)
                    {
                        hit.collider.GetComponent<InteractableObject>().Interact(this);
                    }
                }
            }
        }
    }
}
