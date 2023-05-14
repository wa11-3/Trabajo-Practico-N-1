using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    protected string _name;

    protected void Attack() { }
}


public class Hero : Personaje
{
    void Special() { }
}

public class Enemy : Personaje
{
   public virtual void Special() { }
}

public class Jugador : Hero { }

public class Terrestre : Enemy
{
    public override void Special()
    {
        base.Special();
    }
}

public class Volador : Enemy
{
    public override void Special()
    {
        base.Special();
    }
}