using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [Tooltip ("In ms^-1")][SerializeField] float xSpeed = 4f;
    [SerializeField] float XRange = 22f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float rawNewXPos = Mathf.Clamp(transform.localPosition.x + xOffset, -XRange, XRange);

        transform.localPosition = new Vector3(rawNewXPos, transform.localPosition.y, transform.localPosition.z);
        
    }
}
