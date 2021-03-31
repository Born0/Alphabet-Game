using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public Text welerrorText;
   

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
                welerrorText.text = "Well Done";
                break;
            }
            else
            {
                welerrorText.text = "Try Again";
                break;
            }
        }
        /*for(int i=0;i<wordObject.Capacity-1;i++)
        {
            wordObject[i].transform.position = placeHolder[i].transform.position;
        }*/

        //Debug.Log(check);
        check = false;
        word = "";
        StartCoroutine(WaitError(1));
        
        foreach (var item in destroyObject)
        {
            Destroy(item);
        }
    }

    private IEnumerator WaitError(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        welerrorText.text = "";
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

    public void ExitScreen()
    {
        Application.Quit();
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
}
