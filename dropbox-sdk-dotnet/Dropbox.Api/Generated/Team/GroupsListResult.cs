// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The groups list result object</para>
    /// </summary>
    public class GroupsListResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupsListResult> Encoder = new GroupsListResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupsListResult> Decoder = new GroupsListResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsListResult" />
        /// class.</para>
        /// </summary>
        /// <param name="groups">The groups</param>
        /// <param name="cursor">Pass the cursor into <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.GroupsListContinueAsync" /> to obtain
        /// the additional groups.</param>
        /// <param name="hasMore">Is true if there are additional groups that have not been
        /// returned yet. An additional call to <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.GroupsListContinueAsync" /> can
        /// retrieve them.</param>
        public GroupsListResult(col.IEnumerable<global::Dropbox.Api.TeamCommon.GroupSummary> groups,
                                string cursor,
                                bool hasMore)
        {
            var groupsList = enc.Util.ToList(groups);

            if (groups == null)
            {
                throw new sys.ArgumentNullException("groups");
            }

            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.Groups = groupsList;
            this.Cursor = cursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsListResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupsListResult()
        {
        }

        /// <summary>
        /// <para>Gets the groups of the groups list result</para>
        /// </summary>
        public col.IList<global::Dropbox.Api.TeamCommon.GroupSummary> Groups { get; protected set; }

        /// <summary>
        /// <para>Pass the cursor into <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.GroupsListContinueAsync" /> to obtain
        /// the additional groups.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        /// <summary>
        /// <para>Is true if there are additional groups that have not been returned yet. An
        /// additional call to <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.GroupsListContinueAsync" /> can
        /// retrieve them.</para>
        /// </summary>
        public bool HasMore { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupsListResult" />.</para>
        /// </summary>
        private class GroupsListResultEncoder : enc.StructEncoder<GroupsListResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupsListResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("groups", value.Groups, writer, global::Dropbox.Api.TeamCommon.GroupSummary.Encoder);
                WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
                WriteProperty("has_more", value.HasMore, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupsListResult" />.</para>
        /// </summary>
        private class GroupsListResultDecoder : enc.StructDecoder<GroupsListResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupsListResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupsListResult Create()
            {
                return new GroupsListResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupsListResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "groups":
                        value.Groups = ReadList<global::Dropbox.Api.TeamCommon.GroupSummary>(reader, global::Dropbox.Api.TeamCommon.GroupSummary.Decoder);
                        break;
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "has_more":
                        value.HasMore = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
