namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateProject
    /// </summary>
    public class UpdateProjectPayload : QueryableValue<UpdateProjectPayload>
    {
        public UpdateProjectPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The updated project.
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `project` will change from `Project!` to `Project`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public Project Project => this.CreateProperty(x => x.Project, Octokit.GraphQL.Model.Project.Create);

        internal static UpdateProjectPayload Create(Expression expression)
        {
            return new UpdateProjectPayload(expression);
        }
    }
}