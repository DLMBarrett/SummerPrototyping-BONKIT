using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwistIt : MonoBehaviour
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

    }

    private void OnMouseOver()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(.9716f, .8111f, .4345f, 1);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(.9716f, .7333f, .4345f, 1);
            gameObject.GetComponent<ParticleSystem>().Play();
            //CinemachineFunctions.Instance.ShakeCamera(2f);
        }
    }

    private void OnMouseExit()
    {
        //CinemachineFunctions.Instance.ShakeCamera(0f);
        gameObject.GetComponent<SpriteRenderer>().color = originalColor;
    }
}
