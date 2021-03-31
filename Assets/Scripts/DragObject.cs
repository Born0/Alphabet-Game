using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class DragObject : MonoBehaviour

{

    private Vector3 mOffset;
    public GameObject charA;
    public GameObject busket;

    private float mZCoord;

    public List<GameObject> placeHolder = new List<GameObject>();

    private Vector3 objectPosition;
    private Quaternion rotation;

    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(

            gameObject.transform.position).z;

        

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

        objectPosition = gameObject.transform.position;
        rotation = gameObject.transform.rotation;

    }



    private Vector3 GetMouseAsWorldPoint()

    {
       

        Vector3 mousePoint = Input.mousePosition;

       

        mousePoint.z = mZCoord;

       

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()

    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

    private void OnCollisionEnter(Collision collision)
    {
       // Debug.Log(collision.gameObject.tag);
    }

    private void OnMouseUp()
    {
        if(BusketScript.collideCheck)
        {
            Instantiate(gameObject, objectPosition, rotation);
        }
        else
        {
            gameObject.transform.position = objectPosition;
        }

        BusketScript.collideCheck = false;

    }
}