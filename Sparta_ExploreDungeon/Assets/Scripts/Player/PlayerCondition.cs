using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;

    Condition health { get { return uiCondition.health; } }
    private void Update()
    {
        
    }
    public void Heal(float amount)
    {
        health.Add(amount);
    }
    public void Damage(float amount)
    {
        health.Subtract(amount);
    }
}
