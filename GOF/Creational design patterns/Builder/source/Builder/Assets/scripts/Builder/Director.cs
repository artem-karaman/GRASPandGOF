namespace Builder
{
    internal class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.PrepareRectTransform();
            builder.AddLayoutGroup();
            builder.AddContentSizeFitter();
        }
    }
}
