namespace OpenGraphNet
{
    using System.Linq;
    using HtmlAgilityPack;

    /// <summary>
    /// Extension for OpenGraph
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Return a matched HtmlAttribute
        /// </summary>
        /// <param name="htmlAttributeCollection">HtmlAttributeCollection element</param>
        /// <param name="strings">string array</param>
        /// <returns>Returns HtmlAttribute</returns>
        public static HtmlAttribute ReturnMatchedKey(this HtmlAttributeCollection htmlAttributeCollection, string[] strings)
        {
            return htmlAttributeCollection.FirstOrDefault(hac => strings.Contains(hac.Name));
        }
    }
}