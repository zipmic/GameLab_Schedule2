using UnityEngine;

public class SliderCharaterEdit : MonoBehaviour
{
 
    [SerializeField] private SkinnedMeshRenderer SkinnedMeshRenderer;
    [SerializeField] int index;
    public void setslider(float value)
    {
        SkinnedMeshRenderer.SetBlendShapeWeight(index,value);
    }
   

       

}
