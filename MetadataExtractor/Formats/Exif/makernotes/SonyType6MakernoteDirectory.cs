#region License
//
// Copyright 2002-2015 Drew Noakes
// Ported from Java to C# by Yakov Danilov for Imazen LLC in 2014
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
// More information about this project is available at:
//
//    https://github.com/drewnoakes/metadata-extractor-dotnet
//    https://drewnoakes.com/code/exif/
//
#endregion

using System.Collections.Generic;

namespace MetadataExtractor.Formats.Exif.Makernotes
{
    /// <summary>Describes tags specific to Sony cameras that use the Sony Type 6 makernote tags.</summary>
    /// <author>Drew Noakes https://drewnoakes.com</author>
    public class SonyType6MakernoteDirectory : Directory
    {
        public const int TagMakernoteThumbOffset = 0x0513;
        public const int TagMakernoteThumbLength = 0x0514;
//      public const int TagUnknown1 = 0x0515;
        public const int TagMakernoteThumbVersion = 0x2000;

        private static readonly Dictionary<int?, string> _tagNameMap = new Dictionary<int?, string>
        {
            { TagMakernoteThumbOffset, "Makernote Thumb Offset" },
            { TagMakernoteThumbLength, "Makernote Thumb Length" },
            { TagMakernoteThumbVersion, "Makernote Thumb Version" }
        };

        public SonyType6MakernoteDirectory()
        {
            SetDescriptor(new SonyType6MakernoteDescriptor(this));
        }

        public override string Name
        {
            get { return "Sony Makernote"; }
        }

        protected override IReadOnlyDictionary<int?, string> GetTagNameMap()
        {
            return _tagNameMap;
        }
    }
}
