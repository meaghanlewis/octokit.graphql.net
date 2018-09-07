namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// An edge in a connection.
    /// </summary>
    public class IssueTimelineItemsEdge : QueryableValue<IssueTimelineItemsEdge>
    {
        public IssueTimelineItemsEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public IssueTimelineItems Node => this.CreateProperty(x => x.Node, Octokit.GraphQL.Model.IssueTimelineItems.Create);

        internal static IssueTimelineItemsEdge Create(Expression expression)
        {
            return new IssueTimelineItemsEdge(expression);
        }
    }
}