using GraphQL.Data;

namespace GraphQL.Types
{
    public class AddSpeakerPayload
    {
        public Speaker Speaker { get; }

        public AddSpeakerPayload(Speaker speaker)
        {
            Speaker = speaker;
        }
    }
}
