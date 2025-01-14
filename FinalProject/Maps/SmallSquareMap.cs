namespace FinalProject.Maps;
public class SmallSquareMap : SmallMap
{

    public SmallSquareMap(int size) : base(size, size)
    {
        FNext = MoveRules.WallNext;
        FNextDiagonal = MoveRules.WallNextDiagonal;
    }

}
