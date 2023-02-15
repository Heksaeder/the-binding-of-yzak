using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public AnimatorOverrideController anim;
    public AnimatorOverrideController animation_base;


    public void Changer_de_skin()
    {
        GetComponent<Animator>().runtimeAnimatorController = anim as RuntimeAnimatorController;
    }

    public void Retour_normal()
    {
        GetComponent<Animator>().runtimeAnimatorController = animation_base as RuntimeAnimatorController;
    }
}
