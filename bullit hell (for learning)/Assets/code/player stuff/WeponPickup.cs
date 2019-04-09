﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponPickup : MonoBehaviour {
    public GameObject player;
    public GameObject pickupwepon;
    public bool death=false;
    public bool grabable = false;
    // Use this for initialization
    void Start () {

    }
    
    // Update is called once per frame
    void Update () {
        player = GameObject.FindWithTag("Player");
        if (death)
        {
            Destroy(gameObject);
        }
        if (player != null)
        {
            grabable = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (grabable == true)
        {
            grabwepon();
            death = true;
        }
    }
    public void grabwepon()
    {
        player.GetComponent<hotbar>().wepons[player.GetComponent<hotbar>().topslot-1] = pickupwepon;
    }
}
