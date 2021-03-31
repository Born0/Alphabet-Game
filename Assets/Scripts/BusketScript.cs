using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusketScript : MonoBehaviour
{
    /*private readonly string[] words = {"apple","ball","cat", "doll", "egg", "fish" , "goat", "hen", "icecream" , "jet", "key", "lion" , "monkey", "necklace", "orange" , "pot", "queen", "rat", "star", "tree", "umbrella", "violin", "wagon", "xmas"
                                   ,"yak","zebra"};*/
    public List<string> words = new List<string>();

    private bool check=false;
    private string word;
    private int indexer=0;
    public List<GameObject> sourceObject = new List<GameObject>();
    private List<GameObject> destroyObject = new List<GameObject>();
    private GameObject currentObject;
    public static bool collideCheck = false;
   

    void Start()
    {
        check = false;
        currentObject = sourceObject[indexer];


    }

    
    void Update()
    {
        currentObject.SetActive(false);
        currentObject = sourceObject[indexer];
        currentObject.SetActive(true);
    }

    public void CheckWord()
    {
        Debug.Log("check="+ word);
        foreach(var item in words)
        {
            if(item==word)
            {
                check = true;
                indexer++;
            }
        }
        /*for(int i=0;i<wordObject.Capacity-1;i++)
        {
            wordObject[i].transform.position = placeHolder[i].transform.position;
        }*/

        Debug.Log(check);
        check = false;
        word = "";
        foreach (var item in destroyObject)
        {
            Destroy(item);
        }
    }

    public void Reset()
    {
        Debug.Log(destroyObject.Count);
       
        if (destroyObject.Count != 0)
        {
            if ( destroyObject.Count>=0)
            {
                Destroy(destroyObject[destroyObject.Count - 1]);
                destroyObject.RemoveAt(destroyObject.Count - 1);
                
            }
           
        }
       
        
        
    }
       




    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.tag);
        word += collision.gameObject.tag;
        destroyObject.Add(collision.gameObject);
        collideCheck = true;
    }
}
