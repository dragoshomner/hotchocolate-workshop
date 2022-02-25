using GraphQL.Data;
using GraphQL.Extensions;
using GraphQL.Types;

namespace GraphQL.Graphql.Types
{
    public class Mutation
    {
        [UseApplicationDbContext]
        public async Task<AddSpeakerPayload> AddSpeakerAsync(
            AddSpeakerInput input,
            [Service] ApplicationDbContext context)
        {
            var speaker = new Speaker
            {
                Name = input.Name,
                Bio = input.Bio,
                Website = input.Website
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        } 
    }
}
