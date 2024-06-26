using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAwaken : EnemyStateBase
{
    public override void OnEnter()
    {
        Debug.Log("EnemyAwaken Enter");
        enemy.config.animationModel.WakeUp(model);
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        if (InIdleAnimation())
        {
            enemy.ChangeState<EnemyIdle>();
        }
    }
}
