using GraphQL;

namespace SchemaFirst
{

    public class PersonQuery
    {

        [GraphQLMetadata("employee")]
        public Person GetPerson()
        {
            return new Person { Id = "A101", Name = "Shiva Sai" };
        }

    }

}