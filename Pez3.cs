using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pez3 : MonoBehaviour
{
    public Animation anim;
    AnimationClip animationClip;
    AnimationCurve curve3;
    // Use this for initialization
    void Start()
    {
        Animation();
    }
    void Animation()
    {
        anim = GetComponent<Animation>();
        int t;
        //rotation
        Keyframe[] RotationY;
        RotationY = new Keyframe[60];
        for (int i = 0; i < 60; i++)
        {
            int Mod = i % 2;
            t = i+1;
            if (Mod == 0 )
            {
                RotationY[i] = new Keyframe((t), -10f);
            }
            else
            {
                RotationY[i] = new Keyframe((t), 10f);
            }
            
        }

        curve3 = new AnimationCurve(RotationY);
        animationClip = new AnimationClip();
        // set animation clip to be legacy
        animationClip.legacy = true;
        animationClip.SetCurve("", typeof(Transform), "localEulerAngles.z", curve3);
        anim.AddClip(animationClip, "test");
        anim.Play("test");
    }
}
