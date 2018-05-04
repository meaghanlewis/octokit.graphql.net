namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a Git commit.
    /// </summary>
    public class Commit : QueryableValue<Commit>
    {
        public Commit(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// An abbreviated version of the Git object ID
        /// </summary>
        public string AbbreviatedOid { get; }

        /// <summary>
        /// The number of additions in this commit.
        /// </summary>
        public int Additions { get; }

        /// <summary>
        /// Authorship details of the commit.
        /// </summary>
        public GitActor Author => this.CreateProperty(x => x.Author, Octokit.GraphQL.Model.GitActor.Create);

        /// <summary>
        /// Check if the committer and the author match.
        /// </summary>
        public bool AuthoredByCommitter { get; }

        /// <summary>
        /// The datetime when this commit was authored.
        /// </summary>
        public DateTimeOffset AuthoredDate { get; }

        /// <summary>
        /// Fetches `git blame` information.
        /// </summary>
        /// <param name="path">The file whose Git blame information you want.</param>
        public Blame Blame(Arg<string> path) => this.CreateMethodCall(x => x.Blame(path), Octokit.GraphQL.Model.Blame.Create);

        /// <summary>
        /// The number of changed files in this commit.
        /// </summary>
        public int ChangedFiles { get; }

        /// <summary>
        /// Comments made on the commit.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public CommitCommentConnection Comments(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null) => this.CreateMethodCall(x => x.Comments(first, after, last, before), Octokit.GraphQL.Model.CommitCommentConnection.Create);

        /// <summary>
        /// The HTTP path for this Git object
        /// </summary>
        public string CommitResourcePath { get; }

        /// <summary>
        /// The HTTP URL for this Git object
        /// </summary>
        public string CommitUrl { get; }

        /// <summary>
        /// The datetime when this commit was committed.
        /// </summary>
        public DateTimeOffset CommittedDate { get; }

        /// <summary>
        /// Check if commited via GitHub web UI.
        /// </summary>
        public bool CommittedViaWeb { get; }

        /// <summary>
        /// Committership details of the commit.
        /// </summary>
        public GitActor Committer => this.CreateProperty(x => x.Committer, Octokit.GraphQL.Model.GitActor.Create);

        /// <summary>
        /// The number of deletions in this commit.
        /// </summary>
        public int Deletions { get; }

        /// <summary>
        /// The linear commit history starting from (and including) this commit, in the same order as `git log`.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="path">If non-null, filters history to only show commits touching files under this path.</param>
        /// <param name="author">If non-null, filters history to only show commits with matching authorship.</param>
        /// <param name="since">Allows specifying a beginning time or date for fetching commits.</param>
        /// <param name="until">Allows specifying an ending time or date for fetching commits.</param>
        public CommitHistoryConnection History(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<string>? path = null, Arg<CommitAuthor>? author = null, Arg<string>? since = null, Arg<string>? until = null) => this.CreateMethodCall(x => x.History(first, after, last, before, path, author, since, until), Octokit.GraphQL.Model.CommitHistoryConnection.Create);

        public ID Id { get; }

        /// <summary>
        /// The Git commit message
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// The Git commit message body
        /// </summary>
        public string MessageBody { get; }

        /// <summary>
        /// The commit message body rendered to HTML.
        /// </summary>
        public string MessageBodyHTML { get; }

        /// <summary>
        /// The Git commit message headline
        /// </summary>
        public string MessageHeadline { get; }

        /// <summary>
        /// The commit message headline rendered to HTML.
        /// </summary>
        public string MessageHeadlineHTML { get; }

        /// <summary>
        /// The Git object ID
        /// </summary>
        public string Oid { get; }

        /// <summary>
        /// The parents of a commit.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public CommitConnection Parents(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null) => this.CreateMethodCall(x => x.Parents(first, after, last, before), Octokit.GraphQL.Model.CommitConnection.Create);

        /// <summary>
        /// The datetime when this commit was pushed.
        /// </summary>
        public DateTimeOffset? PushedDate { get; }

        /// <summary>
        /// The Repository this commit belongs to
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.GraphQL.Model.Repository.Create);

        /// <summary>
        /// The HTTP path for this commit
        /// </summary>
        public string ResourcePath { get; }

        /// <summary>
        /// Commit signing information, if present.
        /// </summary>
        public IGitSignature Signature => this.CreateProperty(x => x.Signature, Octokit.GraphQL.Model.Internal.StubIGitSignature.Create);

        /// <summary>
        /// Status information for this commit
        /// </summary>
        public Status Status => this.CreateProperty(x => x.Status, Octokit.GraphQL.Model.Status.Create);

        /// <summary>
        /// Returns a URL to download a tarball archive for a repository.
        /// Note: For private repositories, these links are temporary and expire after five minutes.
        /// </summary>
        public string TarballUrl { get; }

        /// <summary>
        /// Commit's root Tree
        /// </summary>
        public Tree Tree => this.CreateProperty(x => x.Tree, Octokit.GraphQL.Model.Tree.Create);

        /// <summary>
        /// The HTTP path for the tree of this commit
        /// </summary>
        public string TreeResourcePath { get; }

        /// <summary>
        /// The HTTP URL for the tree of this commit
        /// </summary>
        public string TreeUrl { get; }

        /// <summary>
        /// The HTTP URL for this commit
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Check if the viewer is able to change their subscription status for the repository.
        /// </summary>
        public bool ViewerCanSubscribe { get; }

        /// <summary>
        /// Identifies if the viewer is watching, not watching, or ignoring the subscribable entity.
        /// </summary>
        public SubscriptionState ViewerSubscription { get; }

        /// <summary>
        /// Returns a URL to download a zipball archive for a repository.
        /// Note: For private repositories, these links are temporary and expire after five minutes.
        /// </summary>
        public string ZipballUrl { get; }

        internal static Commit Create(Expression expression)
        {
            return new Commit(expression);
        }
    }
}