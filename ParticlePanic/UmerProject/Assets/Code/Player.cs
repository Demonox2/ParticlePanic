using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float speed;
    public float jumpForce;
    private float moveInput;

    public GameObject projectile;
    private GameManager gm;
    public GameObject Collectable;

    private Rigidbody2D rb;

    int collectableCount = 0;
    public GameObject leftSpawner;
    public GameObject upSpawner;
    public GameObject downSpawner;

    bool grounded;
    bool djAvailable;

    bool getCollectableStatus = collectableSpawner.collectableSpawned;

    public Text countText;

    public AudioSource jumpSound;
    public AudioSource collectSound;
    public AudioSource dieSound;

    public GameObject model;


    //Unity Methods
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        SetCountText();
    }

    void Update() {
        if (grounded)
        {
            djAvailable = true;
        }
        Jump();
        Movement();
        SpawnerActivator();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile") || other.CompareTag("deathzone"))
        {
            DieTimer();
            dieSound.Play();

        }
        if (other.gameObject.CompareTag("Collectable"))
        {
            collectableCount++;
            collectSound.Play();
            SetCountText();
            Destroy(other.gameObject);
            collectableSpawner.collectableSpawned = false; 
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")){
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }

    void SpawnerActivator()
    {
        if(collectableCount >= 4)
        {
            leftSpawner.SetActive(true);
        }
        if (collectableCount >= 8)
        {
            upSpawner.SetActive(true);
        }
        if (collectableCount >= 12)
        {
            downSpawner.SetActive(true);
        }

    }

    //Methods
    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
        
    }

    void DieTimer()
    {
        DestroyObject(model);
        StartCoroutine(wait());

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        Die();
    }

    void Movement()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKeyDown(KeyCode.Space)))
        {
            if (grounded)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpSound.Play();
            }
            if(!grounded && djAvailable)
            {
                rb.velocity = Vector2.up * jumpForce;
                djAvailable = false;
                jumpSound.Play();
            }
        }
    }

    void SetCountText() {
        countText.text = "Neutrons: " + collectableCount.ToString();
    }


}
