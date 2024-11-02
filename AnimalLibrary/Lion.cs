namespace AnimalLibrary;

[CustomComment("Этот класс представляет льва.")]
public class Lion : Animal
{
    public Lion(string name, string country, bool hide, string whatAnimal)
        : base(name, country, hide, whatAnimal, eClassificationAnimal.Carnivores) { }

    public override eFavoriteFood GetFavouriteFood() => eFavoriteFood.Meat;

    public override void SayHello() => Console.WriteLine("Ррр!");
}
