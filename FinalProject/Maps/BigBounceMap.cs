namespace FinalProject.Maps;
public class BigBounceMap : BigMap
{

    public BigBounceMap(int sizeX, int sizeY) : base(sizeX, sizeY)
    {
        FNext = MoveRules.BigBounceNext;
        FNextDiagonal = MoveRules.BigBounceNextDiagonal;
    }

}
