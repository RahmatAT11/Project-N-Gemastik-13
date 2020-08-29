using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;

    private Vector3 movement;
    private float horizontalMovement;
    private float verticalMovement;
    private ItemInformation itemCheckInfo;

    public bool checkInfo;
    // Start is called before the first frame update
    void Start()
    {
        itemCheckInfo = GameObject.Find("Item").GetComponent<ItemInformation>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.E) && checkInfo)
        {
            Debug.Log(itemCheckInfo.itemType);
            Debug.Log(itemCheckInfo.ethnicOrigin);
            Debug.Log(itemCheckInfo.itemDescription);
        }
    }

    void FixedUpdate()
    {
        movement = new Vector3(horizontalMovement, 0, verticalMovement);

        transform.Translate(movement * Time.deltaTime * moveSpeed, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickupItem"))
        {
            checkInfo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PickupItem"))
        {
            checkInfo = false;
        }
    }
}
