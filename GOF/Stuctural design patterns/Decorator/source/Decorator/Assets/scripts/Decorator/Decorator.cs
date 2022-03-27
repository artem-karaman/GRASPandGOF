using Unity.VectorGraphics;

public abstract class Decorator : ICell
{
    private ICell _cell;

    public Decorator(ICell cell)
    {
        _cell = cell;
    }

    public virtual SVGImage Show()
    {
        SVGImage image = null;

        if(_cell != null)
        {
            image = _cell.Show();
        }

        return image;
    }
}
