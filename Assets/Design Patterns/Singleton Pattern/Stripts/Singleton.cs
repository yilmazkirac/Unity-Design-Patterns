using UnityEngine;

public class Singleton : MonoBehaviour
{
   public static Singleton Instance;
   public string Text="Hello World";
   private void Awake()
   {
       if(Instance == null)
       {
           Instance = this;
           DontDestroyOnLoad(this.gameObject);
       }
       else
       {
           Destroy(this.gameObject);
       }
   }
}
