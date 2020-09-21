using System.Collections;
using UnityEngine;

public class heroController : MonoBehaviour
{

    public Animator anim;

    public KeyCode attack1;
    public KeyCode letgo1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attack1))
            anim.SetTrigger("HeroAttack");
        if (Input.GetKeyDown(letgo1))
            anim.SetTrigger("HeroLetGo");
    }
    public void Letgo()
    {
        if (Input.GetKeyDown(letgo1))
            anim.SetTrigger("HeroLetGo");
    }
}
