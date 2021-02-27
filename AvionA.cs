using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionA : MonoBehaviour
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
        //rotation
        Keyframe[] RotationY;
        RotationY = new Keyframe[5];
        RotationY[0] = new Keyframe(0f, 0f);
        RotationY[1] = new Keyframe(15f, 90f);
        RotationY[2] = new Keyframe(30f, 180f);
        RotationY[3] = new Keyframe(45f, 270f);
        RotationY[4] = new Keyframe(60f, 360f);
        curve3 = new AnimationCurve(RotationY);
        animationClip = new AnimationClip();
        // set animation clip to be legacy
        animationClip.legacy = true;
        animationClip.SetCurve("", typeof(Transform), "localEulerAngles.y", curve3);
        anim.AddClip(animationClip, "test");
        anim.Play("test");
    }
}
