namespace FinalProject.Maps;
public class BigTorusMap : BigMap
{

    public BigTorusMap(int sizeX, int sizeY) : base(sizeX, sizeY)
    {
        FNext = MoveRules.BigTorusNext;
        FNextDiagonal = MoveRules.BigTorusNextDiagonal;
    }

}
