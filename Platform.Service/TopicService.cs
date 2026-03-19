namespace Platform.Service
{
    public class TopicService : IService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
