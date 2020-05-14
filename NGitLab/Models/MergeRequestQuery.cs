﻿using System;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    /// <summary>
    /// Allows to use more advanced gitlab queries for getting merge requests
    /// </summary>
    [DataContract]
    public class MergeRequestQuery
    {
        /// <summary>
        /// Return all merge requests or just those that are opened, closed, locked, or merged
        /// </summary>
        public MergeRequestState? State { get; set; }

        /// <summary>
        /// Return requests ordered by created_at or updated_at fields. Default is created_at
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Return requests sorted in asc or desc order. Default is desc
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// Return merge requests for a specific milestone
        /// </summary>
        public string Milestone { get; set; }

        /// <summary>
        /// If simple, returns the iid, URL, title, description, and basic state of merge request
        /// </summary>
        public string View { get; set; }

        /// <summary>
        /// Return merge requests matching a comma separated list of labels
        /// </summary>
        public string Labels { get; set; }

        /// <summary>
        /// Return merge requests created on or after the given time
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Return merge requests created on or before the given time
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Return merge requests updated on or after the given time
        /// </summary>
        public DateTime? UpdatedAfter { get; set; }

        /// <summary>
        /// Return merge requests updated on or before the given time
        /// </summary>
        public DateTime? UpdatedBefore { get; set; }

        /// <summary>
        /// Return merge requests for the given scope: created_by_me, assigned_to_me or all. Defaults to created_by_me
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Returns merge requests created by the given user id. Combine with scope=all or scope=assigned_to_me
        /// </summary>
        public int? AuthorId { get; set; }

        /// <summary>
        /// Returns merge requests assigned to the given user id
        /// </summary>
        public QueryAssigneeId AssigneeId { get; set; }

        /// <summary>
        /// Returns merge requests which have specified all the users with the given ids as individual approvers.
        /// None returns merge requests without approvers. Any returns merge requests with an approver.
        /// </summary>
        public int[] ApproverIds { get; set; }

        /// <summary>
        /// Return merge requests with the given source branch
        /// </summary>
        public string SourceBranch { get; set; }

        /// <summary>
        /// Return merge requests with the given target branch
        /// </summary>
        public string TargetBranch { get; set; }

        /// <summary>
        /// Search merge requests against their title and description
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// Specifies how many record per paging (Gitlab supports a maximum of 100 projects and defaults to 20).
        /// </summary>
        public int? PerPage { get; set; }
    }
}