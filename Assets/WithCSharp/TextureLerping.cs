using UnityEngine;
public class TextureLerping : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private Texture[] textures;

    public TimerSet t1;
    public int BlendingTime;
    
    private Renderer cubeRenderer;

    private Texture m1;
    private Texture m2;
    private Texture m3;

    private float timer = 0;
    
    
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        m1 = textures[0];
        m2 = textures[1];
        m3 = textures[2];
        cubeRenderer.material.mainTexture = m1;
        BlendingTime = t1.BlendingTime;
    }

    private void ChangeCubeTexture(Texture texture){
        cubeRenderer.material.mainTexture = texture;
    }


    // Update is called once per frame
     void Update()
    {
        timer += Time.deltaTime;
        if (timer < BlendingTime/2.0 && timer > BlendingTime*0.4)
        {
            ChangeCubeTexture(m2);
        }else if (timer >= BlendingTime/2.0)
        {
            ChangeCubeTexture(m3);
        }else
        {
            ChangeCubeTexture(m1);
        }
        if(timer >= BlendingTime){
            timer = 0;
        }
    }
}
