using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalMove = 0;
    public float verticalMove = 0;
    public float playerSpeed = 5f;
    public CharacterController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxis("Horizontal");
        horizontalMove = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
       player.Move(new Vector3(horizontalMove*-1, 0, verticalMove) * playerSpeed * Time.deltaTime);
    }
}
