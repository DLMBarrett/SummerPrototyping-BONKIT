using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwistIt : MonoBehaviour
{
    Color originalColor;
    public BopItAnimations bIA;
    bool enabled = true;

    // Start is called before the first frame update
    void Start()
    {
        originalColor = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && enabled)
        {
            bIA.enabled = false;
            enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.T) && !enabled)
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
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(.9716f, .8111f, .4345f, 1);
            if (Input.GetMouseButtonDown(0))
            {
                bIA.playTwistAnimation();
                gameObject.GetComponent<SpriteRenderer>().color = new Color(.9716f, .7333f, .4345f, 1);
                gameObject.GetComponent<ParticleSystem>().Play();
                Invoke("stopAnim", .8f);

                //CinemachineFunctions.Instance.ShakeCamera(2f);
            }
        }
    }

    private void OnMouseExit()
    {
        if (enabled)
        { 
            //CinemachineFunctions.Instance.ShakeCamera(0f);
            bIA.stopTwistAnimation();
            gameObject.GetComponent<SpriteRenderer>().color = originalColor;
        }
    }

    private void stopAnim()
    {
        bIA.stopTwistAnimation();
    }

}
