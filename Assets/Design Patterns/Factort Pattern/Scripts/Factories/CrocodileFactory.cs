using UnityEngine;

public class CrocodileFactory : Factory
{
  [SerializeField] private Crocodile crocodilePrefab;

  public override IAnimal CreateAnimal(Vector3 position)
  {
    GameObject crocodileInstance = Instantiate(crocodilePrefab.gameObject, position, Quaternion.identity);
    Crocodile newCrocodile = crocodileInstance.GetComponent<Crocodile>();

    newCrocodile.Initialize();
    newCrocodile.MakeSound();

    return newCrocodile;
  }
}
