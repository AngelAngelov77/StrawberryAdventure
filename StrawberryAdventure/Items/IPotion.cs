namespace StrawberryAdventure
{
    public interface IPotion
    {
        int ImediateEffect { get; set; }

        void Use();
    }
}