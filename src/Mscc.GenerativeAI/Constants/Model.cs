﻿#if NET472_OR_GREATER || NETSTANDARD2_0
using System;
using System.Linq;
#endif

namespace Mscc.GenerativeAI
{
    /// <summary>
    /// Helper class to provide model names.
    /// Ref: https://cloud.google.com/vertex-ai/generative-ai/docs/learn/model-versioning#latest-version
    /// </summary>
    public static class Model
    {
        public const string GeminiPro = "gemini-pro";
        public const string Gemini10Pro = "gemini-1.0-pro";
        public const string Gemini10Pro001 = "gemini-1.0-pro-001";
        public const string Gemini10Pro002 = "gemini-1.0-pro-002";
        public const string Gemini10ProTuning = Gemini10Pro001;
        public const string GeminiProLatest = "gemini-1.0-pro-latest";
        public const string GeminiProVision = "gemini-pro-vision";
        public const string Gemini10ProVision = "gemini-1.0-pro-vision";
        public const string Gemini10ProVision001 = "gemini-1.0-pro-vision-001";
        public const string GeminiProVisionLatest = "gemini-1.0-pro-vision-latest";
        public const string GeminiUltra = "gemini-ultra";
        public const string GeminiUltraLatest = "gemini-1.0-ultra-latest";
        public const string Gemini15Pro = Gemini15ProLatest;
        // public const string Gemini15ProGfFc = "gemini-1.5-pro-gf-fc";
        public const string Gemini15ProPreview = "gemini-1.5-pro-preview-0409";
        public const string Gemini15ProLatest = "gemini-1.5-pro-latest";
        public const string BisonText001 = "text-bison-001";
        public const string BisonText002 = "text-bison-002";
        public const string BisonText = BisonText001;
        public const string BisonText32k002 = "text-bison-32k-002";
        public const string BisonText32k = BisonChat32k002;
        public const string UnicornText001 = "text-unicorn-001";
        public const string UnicornText = UnicornText001;
        public const string BisonChat001 = "chat-bison-001";
        public const string BisonChat002 = "chat-bison-002";
        public const string BisonChat = BisonChat001;
        public const string BisonChat32k002 = "chat-bison-32k-002";
        public const string BisonChat32k = BisonChat32k002;
        public const string CodeBisonChat001 = "codechat-bison-001";
        public const string CodeBisonChat002 = "codechat-bison-002";
        public const string CodeBisonChat = BisonChat002;
        public const string CodeBisonChat32k002 = "codechat-bison-32k-002";
        public const string CodeBisonChat32k = BisonChat32k002;
        public const string CodeGecko001 = "code-gecko-001";
        public const string CodeGecko002 = "code-gecko-002";
        public const string CodeGeckoLatest = "code-gecko@latest";
        public const string CodeGecko = CodeGeckoLatest;
        public const string GeckoEmbedding = "embedding-gecko-001";
        public const string Embedding = "embedding-001";
        public const string TextEmbedding004 = "text-embedding-004";
        public const string TextEmbedding = TextEmbedding004;
        public const string AttributedQuestionAnswering = "aqa";
        public const string ImageGeneration006 = "imagegeneration@006";
        public const string ImageGeneration005 = "imagegeneration@005";
        public const string ImageGeneration002 = "imagegeneration@002";
        public const string ImageGeneration = ImageGeneration006;
        public const string ImageText001 = "imagetext@001";
        public const string ImageText = ImageText001;
    }
}
