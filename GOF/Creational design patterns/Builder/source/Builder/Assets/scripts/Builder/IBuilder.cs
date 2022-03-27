namespace Builder
{
    internal interface IBuilder
    {
        void PrepareRectTransform();
        void AddLayoutGroup();
        
        void AddContentSizeFitter();
        IScrollProduct GetResult();
    }
}
