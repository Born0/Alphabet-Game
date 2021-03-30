using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusketScript : MonoBehaviour
{
    public List<string> words = new List<string>();
    private bool check = false;
    private string word = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckWord()
    {
        foreach(string item in words)
        {
            if(item==word)
            {
                check = true;
                break;
            }
        }
        Debug.Log(check);
        check = false;
        word = "";
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);

        word+=collision.gameObject.tag;
    }
}
