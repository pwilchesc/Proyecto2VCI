using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMo : MonoBehaviour
{
    public Animation anim;
    AnimationClip animationClip;
    AnimationCurve curvex;
    AnimationCurve curvey;
    AnimationCurve curvez;
    AnimationCurve curverx;
    AnimationCurve curvery;
    AnimationCurve curverz;

    // Use this for initialization
    void Start()
    {
        Animation();
    }
    void Animation()
    {
        anim = GetComponent<Animation>();
        // define animation curve
        // AnimationCurve translateY = AnimationCurve.Linear(0.0f, 0.0f, 3f, 3.0f);
        Keyframe[] posx;
        posx = new Keyframe[9];
        posx[0] = new Keyframe(0f, -10f);
        posx[1] = new Keyframe(5f,-10f);
        posx[2] = new Keyframe(10f, -15f);
        posx[3] = new Keyframe(20f, -15f);
        posx[4] = new Keyframe(25f, -12f);
        posx[5] = new Keyframe(27f, -11f);
        posx[6] = new Keyframe(35f, -6f);
        posx[7] = new Keyframe(45f, -2f);
        posx[8] = new Keyframe(50f, 4f);
        posx[8] = new Keyframe(55f, 8f);
        curvex = new AnimationCurve(posx);
        Keyframe[] posy;
        posy = new Keyframe[7];
        posy[0] = new Keyframe(0f, 0f);
        posy[1] = new Keyframe(5f, 0f);
        posy[2] = new Keyframe(10f, 1f);
        posy[3] = new Keyframe(20f, 1f);
        posy[4] = new Keyframe(25f, 2f);
        posy[5] = new Keyframe(50f, 2f);
        posy[6] = new Keyframe(55f, 0f);
        curvey = new AnimationCurve(posy);
        Keyframe[] posz;
        posz = new Keyframe[8];
        posz[0] = new Keyframe(0f, -18f);
        posz[1] = new Keyframe(5f, -18f);
        posz[2] = new Keyframe(10f, -10f);
        posz[3] = new Keyframe(20f, -10f);
        posz[4] = new Keyframe(25f, -6f);
        posz[5] = new Keyframe(45f, 3f);
        posz[6] = new Keyframe(50f, 8f);
        posz[7] = new Keyframe(55f, 16f);
        curvez = new AnimationCurve(posz);
        //Rotation
        Keyframe[] Rotx;
        Rotx = new Keyframe[9];
        Rotx[0] = new Keyframe(0f, 0f);
        Rotx[1] = new Keyframe(5f,0f);
        Rotx[2] = new Keyframe(10f, 0f);
        Rotx[3] = new Keyframe(20f,0f);
        Rotx[4] = new Keyframe(25f, 10f);
        Rotx[5] = new Keyframe(35f, 10f);
        Rotx[6] = new Keyframe(45f, 20f);
        Rotx[7] = new Keyframe(50f, 20f);
        Rotx[8] = new Keyframe(55f, 0f);
        curverx = new AnimationCurve(Rotx);
        Keyframe[] Roty;
        Roty = new Keyframe[5];
        Roty[0] = new Keyframe(0f, 0f);
        Roty[1] = new Keyframe(5f, 0f);
        Roty[2] = new Keyframe(10f, 90f);
        Roty[3] = new Keyframe(50f, 90f);
        Roty[4] = new Keyframe(55f, 180f);
        curvery = new AnimationCurve(Roty);
        Keyframe[] Rotz;
        Rotz = new Keyframe[3];
        Rotz[0] = new Keyframe(0f, 0f);
        Rotz[1] = new Keyframe(5f, 0f);
        Rotz[2] = new Keyframe(10f, 0f);
        curverz = new AnimationCurve(Rotz);

        animationClip = new AnimationClip();
        // set animation clip to be legacy
        animationClip.legacy = true;
        animationClip.SetCurve("", typeof(Transform), "localPosition.x", curvex);
        animationClip.SetCurve("", typeof(Transform), "localPosition.y", curvey);
        animationClip.SetCurve("", typeof(Transform), "localPosition.z", curvez);
        animationClip.SetCurve("", typeof(Transform), "localEulerAngles.x", curverx);
        animationClip.SetCurve("", typeof(Transform), "localEulerAngles.y", curvery);
        animationClip.SetCurve("", typeof(Transform), "localEulerAngles.z", curverz);
        anim.AddClip(animationClip, "test");
        anim.Play("test");
    }
}
