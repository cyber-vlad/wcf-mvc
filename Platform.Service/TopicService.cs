namespace Platform.Service
{
    public class TopicService : IService
    {
        public string RegisterTopic(string topic)
        {
            return $"{topic} registered successfully";
        }
    }
}
