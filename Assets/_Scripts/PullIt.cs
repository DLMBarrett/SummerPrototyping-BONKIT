using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PullIt : MonoBehaviour
{

    Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        originalColor = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        CinemachineFunctions.Instance.ShakeCamera(2f);
    }

    private void OnMouseOver()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(.5301f, .7222f, .9622f, 1);
    }

    private void OnMouseExit()
    {
        CinemachineFunctions.Instance.ShakeCamera(0f);
        gameObject.GetComponent<SpriteRenderer>().color = originalColor;
    }

}
