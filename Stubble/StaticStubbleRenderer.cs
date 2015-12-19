﻿// <copyright file="StaticStubbleRenderer.cs" company="Stubble Authors">
// Copyright (c) Stubble Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using Stubble.Core.Classes;

namespace Stubble.Core
{
    public class StaticStubbleRenderer
    {
        private static readonly Lazy<StubbleRenderer> Lazy = new Lazy<StubbleRenderer>(() => new StubbleRenderer());

        /// <summary>
        /// Returns the wrapped Stubble Instance that is Lazily Instantiated
        /// </summary>
        public static StubbleRenderer Instance { get { return Lazy.Value; } }

        /// <summary>
        /// Helper method for calling the Render method on the enclosed instance.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="view"></param>
        /// <returns>the template rendered with the given data</returns>
        public static string Render(string template, object view)
        {
            return Instance.Render(template, view);
        }

        /// <summary>
        /// Helper method for calling the Render method on the enclosed instance with the
        /// given render settings.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="view"></param>
        /// <param name="settings"></param>
        /// <returns>A mustache rendered string</returns>
        public static string Render(string template, object view, RenderSettings settings)
        {
            return Instance.Render(template, view, settings);
        }

        /// <summary>
        /// Helper method for calling the Render method on the enclosed instance.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="view"></param>
        /// <param name="partials"></param>
        /// <returns>the template rendered with the given data</returns>
        public static string Render(string template, object view, IDictionary<string, string> partials)
        {
            return Instance.Render(template, view, partials);
        }

        /// <summary>
        /// Helper method for calling the Render method on the enclosed instance with the
        /// given render settings
        /// </summary>
        /// <param name="template"></param>
        /// <param name="view"></param>
        /// <param name="partials"></param>
        /// <param name="settings"></param>
        /// <returns>the template rendered with the given data</returns>
        public static string Render(string template, object view, IDictionary<string, string> partials,
            RenderSettings settings)
        {
            return Instance.Render(template, view, partials, settings);
        }

        /// <summary>
        /// Helper method for calling the Parse method on the enclosed Instance
        /// </summary>
        /// <param name="template"></param>
        /// <returns>A list of ParserOutput tokens parsed from the template</returns>
        public static IList<ParserOutput> Parse(string template)
        {
            return (List<ParserOutput>)Instance.Parse(template);
        }

        /// <summary>
        /// Helper method for calling the Parse method on the enclosed Instance
        /// </summary>
        /// <param name="template"></param>
        /// <param name="tags"></param>
        /// <returns>A list of ParserOutput tokens parsed from the template</returns>
        public static IList<ParserOutput> Parse(string template, Tags tags)
        {
            return (List<ParserOutput>)Instance.Parse(template, tags);
        }

        /// <summary>
        /// Helper method for calling the Parse method on the enclosed Instance
        /// </summary>
        /// <param name="template"></param>
        /// <param name="tags"></param>
        /// <returns>A list of ParserOutput tokens parsed from the template</returns>
        public static IList<ParserOutput> Parse(string template, string tags)
        {
            return (List<ParserOutput>)Instance.Parse(template, tags);
        }

        /// <summary>
        /// Calls the Cache Template method on the enclosed Instance.
        ///
        /// This parses the template and adds it to the cache prior to use for speed.
        /// </summary>
        /// <param name="template"></param>
        public static void CacheTemplate(string template)
        {
            Instance.CacheTemplate(template);
        }

        /// <summary>
        /// Calls the Cache Template method on the enclosed Instance.
        ///
        /// This parses the template and adds it to the cache prior to use for speed.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="tags"></param>
        public static void CacheTemplate(string template, Tags tags)
        {
            Instance.CacheTemplate(template, tags);
        }

        /// <summary>
        /// Calls the Cache Template method on the enclosed Instance.
        ///
        /// This parses the template and adds it to the cache prior to use for speed.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="tags"></param>
        public static void CacheTemplate(string template, string tags)
        {
            Instance.CacheTemplate(template, tags);
        }

        /// <summary>
        /// Helper method for clearing the Template Cache on the enclosed Instance.
        /// </summary>
        public static void ClearCache()
        {
            Instance.ClearCache();
        }
    }
}
