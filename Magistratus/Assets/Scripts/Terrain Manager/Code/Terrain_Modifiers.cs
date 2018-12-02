﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain_Modifiers : MonoBehaviour {

    Vector3 curePatch;
    bool activeCure = false;
    int activeTimer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (activeCure) {
            activeTimer--;
            if (activeTimer == 0) {
                activeCure = false;
            }
        }
	}

    // Sets the centerpoint of the cure patch
    public void setCurePatch(Vector3 center) {
        curePatch = center;
        activeCure = true;
        activeTimer = 15;
    }

    // Returns true if the location sent is on cure terrain
    public bool isOnInfected(Vector3 location) {
        if (activeCure && (location.x < curePatch.x + 4 && location.x > curePatch.x - 4) && (location.z < curePatch.z + 4 && location.z > curePatch.z - 4)) {
            return true;
        }
        return false;
    }
}
