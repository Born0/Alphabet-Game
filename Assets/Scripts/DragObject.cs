using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class DragObject : MonoBehaviour

{

    private Vector3 mOffset;



    private float mZCoord;

    public List<GameObject> placeHolder = new List<GameObject>();



    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(

            gameObject.transform.position).z;

        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {
        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen

        mousePoint.z = mZCoord;

        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()

    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

    private void OnMouseUp()
    {
        if (gameObject.transform.position.z >= 8 && gameObject.transform.position.z <= 8.5)
        {
            gameObject.transform.position = placeHolder[0].transform.position;
        }
        else if(gameObject.transform.position.z >= 7 && gameObject.transform.position.z <= 8 )
        {
            gameObject.transform.position = placeHolder[1].transform.position;
        }
        else if (gameObject.transform.position.z >= 6.5 && gameObject.transform.position.z <= 7)
        {
            gameObject.transform.position = placeHolder[2].transform.position;
        }
        else if (gameObject.transform.position.z >= 6 && gameObject.transform.position.z <= 6.5)
        {
            gameObject.transform.position = placeHolder[3].transform.position;
        }
        else if (gameObject.transform.position.z >= 5 && gameObject.transform.position.z <=6 )
        {
            gameObject.transform.position = placeHolder[4].transform.position;
        }
        else if (gameObject.transform.position.z >= 4.5 && gameObject.transform.position.z <= 5)
        {
            gameObject.transform.position = placeHolder[5].transform.position;
        }
        else if (gameObject.transform.position.z >= 4 && gameObject.transform.position.z <= 4.5)
        {
            gameObject.transform.position = placeHolder[6].transform.position;
        }
        else if (gameObject.transform.position.z >= 3 && gameObject.transform.position.z <= 4)
        {
            gameObject.transform.position = placeHolder[7].transform.position;
        }
    }
}