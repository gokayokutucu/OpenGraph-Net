using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OpenGraphNet.Metadata
{
    public class MetadataList
    {
        private readonly StructuredMetadataDictionary _internalMetadata;
        private readonly StructuredMetadataDictionary _internalOpenGraphData;

        public MetadataList(StructuredMetadataDictionary internalMetadata,
            StructuredMetadataDictionary internalOpenGraphData)
        {
            _internalMetadata = internalMetadata;
            _internalOpenGraphData = internalOpenGraphData;
        }

        /// <summary>
        /// Gets the all metadata.
        /// </summary>
        /// <value>
        /// The all metadata data.
        /// </value>
        public IDictionary<string, IList<StructuredMetadata>> All => new ReadOnlyDictionary<string, IList<StructuredMetadata>>(_internalMetadata);

        /// <summary>
        /// Gets the opengraph metadata.
        /// </summary>
        /// <value>
        /// The opengraph metadata data.
        /// </value>
        public IDictionary<string, IList<StructuredMetadata>> OpenGraph => new ReadOnlyDictionary<string, IList<StructuredMetadata>>(_internalOpenGraphData);
    }
}