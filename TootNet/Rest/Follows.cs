﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Objects;

namespace TootNet.Rest
{
    public class Follows : ApiBase
    {
        internal Follows(Tokens e) : base(e) { }

        /// <summary>
        /// <para>Follow a remote user.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> uri ("username@domain" formatted string) (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the account object.</para>
        /// </returns>
        public Task<Account> PostAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Account>(MethodType.Post, "follows", Utils.ExpressionToDictionary(parameters));
        }

        /// <summary>
        /// <para>Follow a remote user.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> uri ("username@domain" formatted string) (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the account object.</para>
        /// </returns>
        public Task<Account> PostAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Account>(MethodType.Post, "follows", parameters);
        }
    }
}
