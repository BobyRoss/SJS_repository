using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class read_input : MonoBehaviour
{
    private string input;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecieveInput(string s){
        input = s;
        Debug.Log(input);
    }
}
