using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public TextMeshProUGUI timetext;
    public TextMeshProUGUI wintimeText;
    public GameObject gameoverbutton;
    public GameObject mainmenubutton;
    Rigidbody rb;
    public GameObject numberofstars;
    public GameObject numberofcuboids;
    public GameObject numberofhexgons;
    public GameObject numberofdiamonds;

    public float speed;
    public float jumpForce;
    public float airMultiplier = 0.5f; // Adjust this value to control air movement speed
    public int star = 0;
    public int cuboid = 0;
    public int hexgon = 0;
    public int diamond = 0;
    public TextMeshProUGUI starcount;
    public TextMeshProUGUI cuboidcount;
    public TextMeshProUGUI hexgoncount;
    public TextMeshProUGUI diamondcount;
    public TextMeshProUGUI winText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        starcount.text = ":  " + star;
        cuboidcount.text = ":  " + cuboid;
        hexgoncount.text = ":  " + hexgon;
        diamondcount.text = ":  " + diamond;
    }


    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        starcount.text = ":  " + star;
        cuboidcount.text = ":  " + cuboid;
        hexgoncount.text = ":  " + hexgon;
        diamondcount.text = ":  " + diamond;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool isActive = !gameoverbutton.activeSelf;
            gameoverbutton.SetActive(isActive);
            mainmenubutton.SetActive(isActive);
        }
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, Time.deltaTime * 5f); // Gradually reduce velocity to zero
        }
        else
        {
            // Multiply the force by airMultiplier when the ball is in the air
            float currentMultiplier = rb.velocity.y > 0 ? airMultiplier : 1f;
            rb.AddForce(movement * speed * currentMultiplier);
        }
    }

    void Jump()
    {
        if (Mathf.Abs(rb.velocity.y) < 0.01f) // Check if the ball is not already rising
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Star")
        {
            other.gameObject.SetActive(false);
            star = star + 1;
        }
        if (other.gameObject.tag == "Cuboid")
        {
            other.gameObject.SetActive(false);
            cuboid = cuboid + 1;
        }
        if (other.gameObject.tag == "Hexgon")
        {
            other.gameObject.SetActive(false);
            hexgon = hexgon + 1;
        }
        if (other.gameObject.tag == "Diamond")
        {
            other.gameObject.SetActive(false);
            diamond = diamond + 1;
        }

        int winstar = numberofstars.transform.childCount;
        int wincuboid = numberofcuboids.transform.childCount;
        int winhexgon = numberofhexgons.transform.childCount;
        int windiamond = numberofdiamonds.transform.childCount;


        if (star == winstar && cuboid == wincuboid && hexgon == winhexgon && diamond == windiamond)
        {
            winText.text = "You Win!!!";
            gameoverbutton.SetActive(true);
            mainmenubutton.SetActive(true);
            timetext.gameObject.SetActive(false);
            String timescore = timetext.text;
            string[] timeSegments = timescore.Split(':');
            string minutes = timeSegments[0].Trim();
            string seconds = timeSegments[1].Trim();
            wintimeText.text = "Your Score: " + minutes + ":" + seconds;
            wintimeText.gameObject.SetActive(true);

        }



    }
    public void teleport(Vector3 position)
    {
        transform.position = position;
        Physics.SyncTransforms();

    }
}