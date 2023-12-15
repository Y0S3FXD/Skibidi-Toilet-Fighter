using UnityEngine;

public class Toilet : GameController
{
    public float MaxHealth = 100f;
    public float CurrentHealth;
    public bool IsPlayerOne = false;
    public Animator Anim;
    public Toilet Opponent;
    public HealthBar healthBar;
    public float moveSpeed = 50.25f;
    private Rigidbody rb;

    void Start()
    {
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    void Update()
    {
        HandleRotation();
        HandleActions();
    }

    private void HandleMovement()
    {
        float moveHorizontal = IsPlayerOne ? Input.GetAxis("Horizontal") : Input.GetAxis("Horizontal2");

        // Create movement vector for left/right movement by modifying the z-axis instead of the x-axis
        Vector3 movement = new Vector3(0.0f, 0.0f, moveHorizontal);

        // Apply the movement to the Rigidbody
        rb.MovePosition(rb.position + movement * moveSpeed);
    }

    private void HandleRotation()
    {

    }

    private void HandleActions()
    {
        if (IsPlayerOne)
        {
            if (Input.GetKeyDown(KeyCode.E)) PunchAnimation();
            // ... andre aktioner for Player One
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.M)) PunchAnimation();
            // ... andre aktioner for Player Two
        }
    }

    private void PunchAnimation()
    {
        Anim.SetTrigger("Punch");
    }

    private void HeadButtAnimation()
    {
        Anim.SetTrigger("Headbutt");
    }

    private void KickAnimation()
    {
        Anim.SetTrigger("Kick");
    }

    private void KissAnimation()
    {
        Anim.SetTrigger("Kiss");
    }

    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        healthBar.SetHealth(CurrentHealth);
    }
}
