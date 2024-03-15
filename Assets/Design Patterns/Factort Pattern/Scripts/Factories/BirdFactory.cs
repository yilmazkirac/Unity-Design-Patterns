using UnityEngine;

public class BirdFactory : Factory
{
  [SerializeField] private Bird birdPrefab;

  public override IAnimal CreateAnimal(Vector3 position)
  {
    GameObject birdInstance = Instantiate(birdPrefab.gameObject, position, Quaternion.identity);
    Bird newBird = birdInstance.GetComponent<Bird>();

    newBird.Initialize();
    newBird.MakeSound();

    return newBird;
  }
}
