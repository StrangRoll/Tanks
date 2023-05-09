using Entities.Move;
using Entities.Move.MoveInputs;
using Entities.Weapon;
using UnityEngine;

public abstract class Tank : MonoBehaviour
{
    protected Weapon Weapon;
    protected IMoveType MoveType;
    protected IMoveInput MoveInput;

    protected float Speed;

    public abstract void Move();
    public abstract void Shoot();
}
