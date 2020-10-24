﻿using GraphQL;
using GraphQL.Types;

namespace CoreNg.Graphql
{
    public class ApiSchema : Schema
    {
        public ApiSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ApiQuery>();
            Mutation = resolver.Resolve<ApiMutation>();
        }

    }
}
