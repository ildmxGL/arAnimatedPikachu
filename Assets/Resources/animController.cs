using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Default Take"))
            {
                anim.Play("begin");
            }
            else if (touch.phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("begin"))
            {
                anim.Play("begin");
            }
        }
        */
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Default Take"))
            {
                anim.Play("bow");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("begin"))
            {
                anim.Play("bow");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("bow"))
            {
                anim.Play("gauddung");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("gauddung"))
            {
                anim.Play("doridori");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("doridori"))
            {
                anim.Play("bow");
            }
        }
    }
}
