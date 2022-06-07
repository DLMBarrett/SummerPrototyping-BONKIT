using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PullIt : MonoBehaviour
{
    public BopItAnimations bIA;
    Color originalColor;
    bool enabled = true;

    // Start is called before the first frame update
    void Start()
    {
        originalColor = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && enabled)
        {
            bIA.enabled = false;
            enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.P) && !enabled)
        {
            bIA.enabled = true;
            enabled = true;
        }
    }

    private void OnMouseEnter()
    {
        
    }

    private void OnMouseOver()
    {
        if (enabled)
            gameObject.GetComponent<SpriteRenderer>().color = new Color(.5301f, .7222f, .9622f, 1);
        if (Input.GetMouseButtonDown(0) && enabled)
        {
            bIA.playPullAnimation();
            gameObject.GetComponent<SpriteRenderer>().color = new Color(.5301f, .6555f, .9622f, 1);
            gameObject.GetComponent<ParticleSystem>().Play();
            
            //CinemachineFunctions.Instance.ShakeCamera(2f);
        }
    }

    private void OnMouseExit()
    {
        //CinemachineFunctions.Instance.ShakeCamera(0f);
        if (enabled)
        {
            bIA.stopPullAnimation();
            gameObject.GetComponent<SpriteRenderer>().color = originalColor;
        }
    }

}
