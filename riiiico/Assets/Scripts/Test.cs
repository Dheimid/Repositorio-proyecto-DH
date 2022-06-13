using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Aquí van las variables.
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] SpriteRenderer monjaSprite;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update" + transform.position);
        //transform.rotation = Quaternion.Euler(0,0,(1 * Time.deltaTime) + transform.rotation.eulerAngles.z);

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            monjaSprite.flipX = false;

        }
        else if (Input.GetKeyDown(KeyCode.A))
        { 
           
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            monjaSprite.flipX = true;
        }

    } 
}
