using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public string mouseXInputName, mouseYInputName;
    public float mouseSensitivity;
    public Transform playerBody;
    private float xAxisClamp;
    public GameObject Enemy;

    private int timer;
    private int timerx;

    private void Awake()
    {
        LookCursor();
        xAxisClamp = 0.0f;
        timer = 0;
        timerx = 1;
        InvokeRepeating("SpawnMan", 1, 5);
    }

    private void LookCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SpawnMan()
    {
        Instantiate(Enemy, new Vector3(Random.Range(5f, 15f), -1.47f, Random.Range(5f, 15f)), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotation();
       /* timer = timer + timerx;
        print(timer);*/

        
      /*  if (timer >= 500)
        {

            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            Instantiate(Enemy, new Vector3(Random.Range(5f, 15f), -1.47f, Random.Range(5f, 15f)), transform.rotation); 
            timer = 0;
            timer = 0;
        }*/

    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationValue(270.0f);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationValue(90.0f);
        }


        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
