﻿using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour {

    public float NumberOfSecondsLasting;
    public float NumberOfSecondsRemaining;
    private PlayerAttack PlayerAttackScript;
    // Use this for initialization
    void Start () {
        PlayerAttackScript = GameObject.FindGameObjectWithTag(Tags.Player).GetComponent<PlayerAttack>();
    }
	
	// Update is called once per frame
	void Update () {
        NumberOfSecondsLasting += Time.deltaTime;
        if (NumberOfSecondsLasting >= NumberOfSecondsRemaining)
        {
            PlayerAttackScript.StopLightningAttack();
        }
    }
    
    public void Die()
    {
        Destroy(gameObject);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    var Enemy = collision.gameObject.GetComponent(typeof(Enemy));
    //    if (Enemy != null)
    //    {
    //        (Enemy as Enemy).Die();
    //    }       
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var Enemy = collision.gameObject.GetComponent(typeof(Enemy));
        if (Enemy != null)
        {
            (Enemy as Enemy).Die();
        }
    }
}

