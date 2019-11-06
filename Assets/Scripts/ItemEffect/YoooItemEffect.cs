using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class YoooItemEffect : UsableItem.UsageEffect
{
    public int HealthAmount = 20;
    public override bool Use(CharacterData user)
    {
        if (user.Stats.CurrentHealth == 20)
        {
            return false;
        }
        else
        {
            user.Stats.ChangeHealth(HealthAmount);
            return true;
        }
    }
}
