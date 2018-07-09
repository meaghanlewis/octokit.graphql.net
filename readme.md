# Octokit.GraphQL

**Note**: This software is currently beta. There are few things left, and there might be bugs - be warned!

Octokit.GraphQL gives you access to the GitHub GraphQL API from .NET. It exposes the GitHub GraphQL API as a strongly-typed LINQ-like API, aiming to follow the GraphQL query syntax as closely as possible, which giving the benefits of strong typing in your favorite .NET language.

## Documentation

You can find our documentation [here](docs/readme.md).

## Usage Example

```csharp
using Octokit.GraphQL;
using Octokit.GraphQL.Core;
using static Octokit.GraphQL.Variable;

var connection = new Connection("https://api.github.com/graphql", YOUR_OAUTH_TOKEN); 

var query = new Query()
    .RepositoryOwner(Var("owner"))
    .Repository(Var("name"))
    .Select(repo => new
    {
        repo.Id,
        repo.Name,
        repo.Owner.Login,
        repo.IsFork,
        repo.IsPrivate,
    });

var compiledQuery = query.Compile();

var vars = new Dictionary<string, object>
{
    { "owner", "octokit" },
    { "name", "octokit.graphql.net" },
};

var result =  await Connection.Run(compiledQuery, vars);

Console.WriteLine(result.Owner + " & " + result.Name + " Rocks!");
```
