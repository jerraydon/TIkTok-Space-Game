using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDog : MonoBehaviour {

    public Animator Anim { get; private set; }

    private void Awake() {
        Anim = GetComponentInChildren<Animator>();
    }

}
