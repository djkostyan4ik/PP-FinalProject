namespace FinalProject.Maps;
public class SmallTorusMap : SmallMap
{

    public SmallTorusMap(int sizeX, int sizeY) : base(sizeX, sizeY)
    {
        FNext = MoveRules.SmallTorusNext;
        FNextDiagonal = MoveRules.SmallTorusNextDiagonal;
    }

}
