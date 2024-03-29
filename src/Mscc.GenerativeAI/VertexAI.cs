﻿#if NET472_OR_GREATER || NETSTANDARD2_0
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
#endif

namespace Mscc.GenerativeAI
{
    /// <summary>
    /// Entry point to access Gemini API running in Vertex AI.
    /// </summary>
    public sealed class VertexAI : IGenerativeAI
    {
        private readonly string? _projectId;
        private readonly string _region = "us-central1";
        private GenerativeModel? _generativeModel;

        /// <summary>
        /// Default constructor attempts to read <c>.env</c> file and environment variables.
        /// Sets default values, if available.
        /// </summary>
        /// <remarks>The following environment variables are used:
        /// <list type="table">
        /// <item><term>GOOGLE_PROJECT_ID</term>
        /// <description>Identifier of the Google Cloud project.</description></item>
        /// <item><term>GOOGLE_REGION</term>
        /// <description>Identifier of the Google Cloud region to use (default: "us-central1").</description></item>
        /// </list>
        /// </remarks>
        private VertexAI()
        {
            GenerativeAIExtensions.ReadDotEnv();

            _projectId = Environment.GetEnvironmentVariable("GOOGLE_PROJECT_ID");
            _region = Environment.GetEnvironmentVariable("GOOGLE_REGION") ?? _region;
        }
        
        /// <summary>
        /// Initialize access to Vertex AI Gemini API.
        /// </summary>
        /// <param name="projectId">Identifier of the Google Cloud project.</param>
        /// <param name="region">Region to use (default: "us-central1").</param>
        /// <exception cref="ArgumentNullException">Thrown when projectId is null.</exception>
        public VertexAI(string projectId, string? region = null) : this()
        {
            _projectId ??= projectId ?? throw new ArgumentNullException(nameof(projectId));
            _region = region ?? _region;
        }

        /// <summary>
        /// Create a generative model on Vertex AI to use.
        /// </summary>
        /// <param name="model">Model to use (default: "gemini-1.0-pro")</param>
        /// <param name="generationConfig">Optional. Configuration options for model generation and outputs.</param>
        /// <param name="safetySettings">Optional. A list of unique SafetySetting instances for blocking unsafe content.</param>
        /// <exception cref="ArgumentNullException">Thrown when projectId or region is null.</exception>
        /// <returns>Generative model instance.</returns>
        public GenerativeModel GenerativeModel(string model = Model.Gemini10Pro,
            GenerationConfig? generationConfig = null,
            List<SafetySetting>? safetySettings = null)
        {
            if (_projectId is null) throw new ArgumentNullException("projectId");
            if (_region is null) throw new ArgumentNullException("region");

            _generativeModel = new GenerativeModel(_projectId, _region, model, generationConfig, safetySettings);
            return _generativeModel;
        }
    }
}
