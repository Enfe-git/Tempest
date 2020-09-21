using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartFirstLevel", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartFirstLevel() {
        SceneManager.LoadScene(1);
    }

}
