namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateProjectCard
    /// </summary>
    public class UpdateProjectCardInput
    {
        public ID ProjectCardId { get; set; }

        public string Note { get; set; }

        public string ClientMutationId { get; set; }
    }
}