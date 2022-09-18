﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossController : ItemController
{
    public void UseItem() {
        Debug.Log("use Cross");
        RaycastHit2D hit = Physics2D.Raycast(HeroController.instance.GetComponent<Rigidbody2D>().position + Vector2.up * 0.2f, HeroController.instance.lookDirection, 0.5f, LayerMask.GetMask("npc"));
        if (hit.collider != null && hit.collider.tag == "BlankBook")
        {
            NewDialogueTrigger dialogueTrigger = new NewDialogueTrigger();
            dialogueTrigger.dialoguePath = "Level1/useCross";
            UI_Inventory.instance.gameObject.SetActive(false);
            HeroController.instance.inventory_open = false;
            //HeroController.instance.dialogue_open = true;
            dialogueTrigger.TriggerDialogue();
        }
    }
}
