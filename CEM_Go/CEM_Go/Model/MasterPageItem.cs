using System;

namespace Colimo.Model
{
    internal class MasterPageItem
    {
        public Type TargetType { get; internal set; }

        public string IconSource { get; set; }

        public string Title { get; internal set; }
    }
}