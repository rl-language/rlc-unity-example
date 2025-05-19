using System;
using UnityEditor.UI;
using UnityEngine;

public class BoardSlot : MonoBehaviour
{
    public int x;
    public int y;

    private AnyGameAction action = null; 

    void Start() {
        GameMark var = new GameMark();
        var.x.assign(x);
        var.y.assign(y);
        action = new AnyGameAction();
        action.assign(var);
    }

    void Update()
    {
        Renderer renderer = GetComponent<Renderer>();
        long slot_value = Example.getState().board.slots[y * 3 + x].value;
        if (slot_value == 0)
        {
            renderer.material.color = Color.white;
        }
        if (slot_value == 1)
        {
            renderer.material.color = Color.red;
        }
        if (slot_value == 2)
        {
            renderer.material.color = Color.blue;
        }
    }


    void OnMouseDown()
    {
        Debug.Log("clicked");
        Example.applyAction(action);
    }
}
