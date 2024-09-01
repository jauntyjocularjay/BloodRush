using System.ComponentModel;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;
public class OverlayManager : MonoBehaviour
{
    public FXer agility;
    public FXer health;
    public FXer nulled;
    public FXer strength;
    public FXer wisdom;
    public FXer currentFX;
    public Image image;
    public Animator animator;
    public void Start()
    {
        currentFX = Select(FX.nulled);
        image.sprite = currentFX.GetSprite();
        animator.runtimeAnimatorController = currentFX.animatorController;
    }

    public FXer Select(FX fx)
    {
        if(fx == FX.agility)
        {
            return agility;
        } 
        else if(fx == FX.health) {
            return health;
        }
        else if(fx == FX.nulled) {
            return nulled;
        }
        else if(fx == FX.wisdom) {
            return wisdom;
        }
        else {
            throw new InvalidEnumArgumentException($"{fx} is not a valid enum value");
        }
    }
}

public enum FX
{
    agility,
    dexterity,
    health,
    nulled,
    wisdom
}


