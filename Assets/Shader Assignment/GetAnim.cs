using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAnim : MonoBehaviour
{
    public AnimationManager anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<AnimationManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
