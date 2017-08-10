using System;

namespace ExBuddy.Helpers
{
    using ff14bot.Objects;

    public static class NodeHelper
    {
        /// <summary>
        /// Returns true if the node is an ephemeral node
        /// </summary>
        public static bool IsEphemeral(this GatheringPointObject node)
        {
            return node.EnglishName.IndexOf("ephemeral", StringComparison.InvariantCultureIgnoreCase) >= 0;
        }

        /// <summary>
        /// Returns true if the node is concealed
        /// </summary>
        public static bool IsConcealed(this GatheringPointObject node)
        {
            return node.EnglishName.IndexOf("concealed", StringComparison.InvariantCultureIgnoreCase) >= 0;
        }

        /// <summary>
        /// Returns true if the node is unspoiled or legendary
        /// </summary>
        public static bool IsUnspoiled(this GatheringPointObject node)
        {
            // Temporary until we decide if legendary have any diff properties or if we should treat them the same.
            return node.EnglishName.IndexOf("unspoiled", StringComparison.InvariantCultureIgnoreCase) >= 0
                   || node.EnglishName.IndexOf("legendary", StringComparison.InvariantCultureIgnoreCase) >= 0;
        }
    }
}
