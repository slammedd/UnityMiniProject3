using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private MenuController menuController;

    public float flapPower;
    public int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
        menuController = FindObjectOfType<MenuController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * flapPower, ForceMode.Impulse);
        }

        scoreText.text = score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(scoreText);
        menuController.finalScore = score;
        Destroy(gameObject);
    }
}
