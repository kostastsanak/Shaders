using UnityEngine;

public class ShaderCsharpTimer : MonoBehaviour
{
    public Material m1;
    public TimerSet t1;
    private float timer = 0;
    private void Update(){
        timer += Time.deltaTime;
        if(timer >= t1.BlendingTime){
            timer = 0;
        }
        float sendTime = timer/t1.BlendingTime;
        m1.SetFloat("_Blend",sendTime);
    }
}
