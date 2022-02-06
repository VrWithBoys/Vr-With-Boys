using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationToggle : MonoBehaviour
{
    public Animator anim;
    public Button clap;
    int ideal;

    
    // Start is called before the first frame update
    void Start()
    {
        ideal = Random.Range(1, 3);
        anim.SetInteger("anisel",ideal);
    }

    // Update is called once per frame
    void Update()
    {
        clap.onClick.AddListener(() => emote("Sitting Clap"));
        
    }
    void emote(string j)
{
    anim.Play(j);
}

}
